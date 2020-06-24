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
    public partial class AddFileForm : Form
    {
        /// <summary>
        ///  Создаваемый файл
        /// </summary>
        public File File;

        /// <summary>
        /// Форма создания новой записи
        /// </summary>
        public AddFileForm()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                File = new File
                {
                    Catalog = catalogBox.Text,
                    Name = nameBox.Text,
                    CreationDate = Convert.ToDateTime(creationDateBox.Text),
                    SectorCount = Convert.ToInt32(sectorCountBox.Text),
                    Deleted = deleteBox.Checked,
                    ReadOnly = readonlyBox.Checked,
                    Hidden = hideBox.Checked,
                    IsBySystem = systemBox.Checked
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Неверный формат входных данных", "Ошибка");
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
