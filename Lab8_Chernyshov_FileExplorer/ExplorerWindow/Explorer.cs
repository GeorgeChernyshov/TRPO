using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExplorerWindow
{
    class Explorer
    {
        /// <summary>
        /// Окно проводника
        /// </summary>
        private ExplorerWindow _window;

        /// <summary>
        /// Файлы
        /// </summary>
        private IEnumerable<File> _files;

        /// <summary>
        /// Параметры поиска
        /// </summary>
        private dynamic _searchParameters;

        /// <summary>
        /// Нахождение файла поиском
        /// </summary>
        /// <param name="file">Файл</param>
        /// <returns>true, если файл подходит под условия поиска</returns>
        private bool IsFoundBySearch(File file)
        {
            if (_searchParameters.Catalog != ""
                && !file.Catalog?.ToLower()
                    ?.Contains(_searchParameters.Catalog.ToLower())
                )
                return false;

            if (_searchParameters.CreationDate != ""
                && !file.CreationDate.ToString("dd.MM.yyyy hh:mm")
                    ?.Contains(_searchParameters.CreationDate)
                )
                return false;

            if (_searchParameters.Deleted != CheckState.Indeterminate
                && file.Deleted != (_searchParameters.Deleted == CheckState.Checked))
                return false;

            return true;
        }

        /// <summary>
        /// Проводник
        /// </summary>
        /// <param name="xmlFile">Считываемый файл</param>
        public Explorer(string xmlFile)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _window = new ExplorerWindow();
            _window.OnUpdate += () => Update();
            _window.OnAddRequest += file => AddFile(file);
            _window.OnDeleteRequest += files => DeleteFiles(files);
            try
            {
                _files = XElement.Load(xmlFile)
                .Elements("File")
                .Select(d => new File
                {
                    Catalog = d.Element("Catalog").Value,
                    Name = d.Element("Name").Value,
                    Exstension = d.Element("Exstension").Value,
                    CreationDate = Convert.ToDateTime(d.Element("CreationDate").Value),
                    Deleted = Convert.ToBoolean(d.Element("Deleted").Value),
                    SectorCount = Convert.ToInt32(d.Element("SectorCount").Value),
                    ReadOnly = Convert.ToBoolean(d.Attribute("ReadOnly").Value),
                    Hidden = Convert.ToBoolean(d.Attribute("Hidden").Value),
                    IsBySystem = Convert.ToBoolean(d.Attribute("IsBySystem").Value)
                })
                .ToList();
            }
            catch(FileNotFoundException)
            {
                _window.ShowErrorMessage("Искомый файл не найден");
            }
            catch(Exception)
            {
                Open();
                _window.ShowErrorMessage("Неверный формат файла");
            }
        }

        /// <summary>
        /// Запуск работы проводника
        /// </summary>
        public void Open()
        {
            _window.UpdateDataGrid(_files);
            Application.Run(_window);
        }

        /// <summary>
        /// Обновление отображаемых данных
        /// </summary>
        public void Update()
        {
            _searchParameters = _window.SearchParameters;
            _window.UpdateDataGrid(_files.Where(IsFoundBySearch));
        }

        /// <summary>
        /// Добавление файла
        /// </summary>
        /// <param name="file">Файл</param>
        public void AddFile(File file)
        {
            try
            {
                if (_files.Any(f =>
                     f.Catalog == file.Catalog &&
                     f.Name == file.Name))
                    throw new FileAlreadyExistsException();
                ((List<File>)_files).Add(file);
                Update();
            }
            catch(FileAlreadyExistsException)
            {
                _window.ShowErrorMessage("Данный файл уже существует в системе");
            }
        } 

        /// <summary>
        /// Удаление файлов
        /// </summary>
        /// <param name="toDelete">Файлы, предоставленные к удалению</param>
        public void DeleteFiles(IEnumerable<File> toDelete)
        {
            _files.Where(file =>
                 toDelete.Any(d =>
                        d.Catalog == file.Catalog
                     && d.Name == file.Name)
                )
                .AsParallel()
                .ForAll(file => file.Deleted = true);

            Update();
        }
    }
}
