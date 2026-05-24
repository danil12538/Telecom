using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.IO;
using Telecom.ModelEF;

namespace Telecom
{
    public partial class Client: Form
    {
        public Client()
        {
            InitializeComponent();
        }
        public static Model1 DB = new Model1();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientAdd form = new ClientAdd();
            this.Visible = false;
            form.Show();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientsBindingSource.DataSource = DB.Clients.ToList();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Выберите запись для удаления!");
                return;
            }

            if (dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Нельзя удалить новую строку!");
                return;
            }

            Clients CurrentClient = dataGridView1.CurrentRow.DataBoundItem as Clients;

            if (CurrentClient == null)
            {
                MessageBox.Show("Не удалось получить данные записи!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите удалить клиента: {CurrentClient.FullName}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DB.Clients.Remove(CurrentClient);
                    DB.SaveChanges();
                    clientsBindingSource.DataSource = DB.Clients.ToList();
                    clientsBindingSource.ResetBindings(false);
                    MessageBox.Show("Запись удалена!");
                }
                catch (Exception ex)
                {
                    // Показываем внутреннее исключение
                    string errorMessage = "Ошибка при удалении: " + ex.Message;
                    if (ex.InnerException != null)
                    {
                        errorMessage += "\n\nДетали: " + ex.InnerException.Message;
                    }
                    MessageBox.Show(errorMessage);
                }
            }

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Visible = false;
            form.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }


    }
}
