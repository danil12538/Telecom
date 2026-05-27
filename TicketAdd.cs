using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telecom.ModelEF;

namespace Telecom
{
    public partial class TicketAdd: Form
    {
        public TicketAdd()
        {
            InitializeComponent();
        }
        Model1 database = new Model1();
        private List<Tickets> vsTicket = Client.DB.Tickets.ToList();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Ticket form = new Ticket();
            this.Visible = false;
            form.Show();
        }

        private void TicketAdd_Load(object sender, EventArgs e)
        {
            List<string> Status = new List<string>();
            foreach (Tickets TB in vsTicket)
                Status.Add(TB.Status);
            Status = Status.Distinct().ToList();
            comboBoxStatus.DataSource = Status;
            List<string> Priority = new List<string>();
            foreach (Tickets TB in vsTicket)
                Priority.Add(TB.Priority);
            Priority = Priority.Distinct().ToList();
            comboBoxPriority.DataSource = Priority;
            clientsBindingSource.DataSource = database.Clients.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (comboBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите статус из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxStatus.Focus();
                return;
            }
            if (comboBoxPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите приоритет из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxPriority.Focus();
                return;
            }
            if (comboBoxID.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите ID клиента из списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxID.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxSubject.Text))
            {
                MessageBox.Show("Введите тему", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSubject.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDes.Text))
            {
                MessageBox.Show("Заполните описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDes.Focus();
                return;
            }
            Tickets NCTicket = new Tickets();

            NCTicket.Subject = textBoxSubject.Text;
            NCTicket.Description = textBoxDes.Text;
            NCTicket.Priority = comboBoxPriority.Text;
            NCTicket.ClientID =Convert.ToInt32(comboBoxID.Text);
            NCTicket.Status = comboBoxStatus.Text;
            NCTicket.CreatedAt = Convert.ToDateTime(dateTimePicker.Text);

            try
            {
                Ticket.database.Tickets.Add(NCTicket);
                Ticket.database.SaveChanges();
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
            Ticket form = new Ticket();
            form.Visible = true;
            this.Close();
        }
    }
}
