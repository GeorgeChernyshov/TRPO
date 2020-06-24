using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplorerWindow
{
    public partial class ExplorerWindow : Form
    {
        /// <summary>
        /// Событие, происходящее при обновлении
        /// </summary>
        public event Action OnUpdate;

        /// <summary>
        /// Событие, происходящее по запросу удаления
        /// </summary>
        public event Action<IEnumerable<File>> OnDeleteRequest;

        /// <summary>
        /// Событие, происходящее по запросу добавления
        /// </summary>
        public event Action<File> OnAddRequest;

        /// <summary>
        /// Параметры поиска
        /// </summary>
        public dynamic SearchParameters
        {
            get
            {
                return new
                {
                    Catalog = catalogSearchBox.Text,
                    CreationDate = creationDateBox.Text,
                    Deleted = deleteBox.CheckState
                };
            }
        }

        /// <summary>
        /// GUI проводника
        /// </summary>
        public ExplorerWindow()
        {
            InitializeComponent();
            source = new BindingSource();
            filesDG.DataSource = source;
        }

        /// <summary>
        /// Обновление датагрида
        /// </summary>
        /// <param name="files">Отображаемые файлы</param>
        public void UpdateDataGrid(IEnumerable<File> files) => source.DataSource = files;

        /// <summary>
        /// Отображение сообщения об ошибке
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        public void ShowErrorMessage(string message) => MessageBox.Show(message, "Ошибка");

        private void catalogSearchBox_TextChanged(object sender, EventArgs e) => OnUpdate.Invoke();
        private void creationDateBox_TextChanged(object sender, EventArgs e) => OnUpdate.Invoke();
        private void deleteBox_CheckStateChanged(object sender, EventArgs e) => OnUpdate.Invoke();
        private void addButton_Click(object sender, EventArgs e)
        {
            var addFileForm = new AddFileForm();
            if (addFileForm.ShowDialog() == DialogResult.OK)
                OnAddRequest.Invoke(addFileForm.File);
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var files = filesDG.SelectedRows
                .Cast<DataGridViewRow>()
                .Select(row => new File
                {
                    Catalog = row.Cells[0].Value.ToString(),
                    Name = row.Cells[1].Value.ToString()
                });

            OnDeleteRequest.Invoke(files);
        }
    }
}
