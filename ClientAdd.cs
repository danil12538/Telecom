using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Telecom.ModelEF;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Validation;
using System.Net;

namespace Telecom
{
    public partial class ClientAdd: Form
    {
        public ClientAdd()
        {
            InitializeComponent();
        }
        private List<Clients> vsClient = Client.DB.Clients.ToList();
        private void ClientAdd_Load(object sender, EventArgs e)
        {
            List<string> Status = new List<string>();
            foreach (Clients TB in vsClient)
                Status.Add(TB.Status);
            Status = Status.Distinct().ToList();
            comboBoxStatus.DataSource = Status;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            this.Visible = false;
            form.Show();
        }

        private void BalancetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BalancetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',')
                    e.Handled = true;
            
        }
        private int IDplus()
        {
            int max = 0;
            foreach (Clients TB in vsClient)
                if (max < TB.ClientID) max = TB.ClientID;
            return ++max;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Clients NClient = new Clients();

            NClient.ClientID = IDplus();
            NClient.FullName = NametextBox.Text;
            NClient.Email = MailtextBox.Text;
            NClient.Address = AddresstextBox.Text;
            NClient.Phone = PhonetextBox.Text;
            NClient.Balance = Convert.ToDecimal(BalancetextBox.Text);
            // NClient.CreatedAt = Convert.ToDateTime(DatetextBox.Text);
            NClient.CreatedAt = Convert.ToDateTime(dateTimePicker.Text);
            NClient.Status = comboBoxStatus.Text;

            try
            {
                Client.DB.Clients.Add(NClient);
                Client.DB.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;

                if (ex.InnerException != null)
                {
                    message += "\n\nВнутренняя ошибка:\n" + ex.InnerException.Message;

                    if (ex.InnerException.InnerException != null)
                    {
                        message += "\n\nДетали:\n" + ex.InnerException.InnerException.Message;
                    }
                }

                MessageBox.Show(message);
                return;
            }

            MessageBox.Show("Данные успешно добавлены!");
            Client form = new Client();
            form.Visible = true;
            this.Close();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
