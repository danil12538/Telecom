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
            if (DB.Clients.ToList().Count == 0)
            {
                MessageBox.Show("Данные отсутствуют!");
                return;
            }

            Clients CurrentClient = DB.Clients.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show(
                $"Вы действительно хотите удалить объект с ID = {CurrentClient.ClientID}",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DB.Clients.Remove(CurrentClient);
                    DB.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    clientsBindingSource.DataSource = DB.Clients.ToList();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
