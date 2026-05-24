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

namespace Telecom
{
    public partial class Ticket: Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        Model1 database = new Model1();

        List<Ticket> tickets = new List<Ticket>();

        private void Ticket_Load(object sender, EventArgs e)
        {
            ticketsBindingSource.DataSource = database.Tickets.ToList();
            loadStartData();
            LoadDataCombo();
        }

        private void loadStartData()
        {

            ticketsBindingSource.DataSource = tickets;
        }

        private void LoadDataCombo()
        {

            comboBox1.Items.Clear();


            var statuses = database.Tickets
                .Select(t => t.Status)
                .Distinct()
                .OrderBy(s => s)
                .ToList();


            comboBox1.Items.Add("Все");

            foreach (var status in statuses)
            {
                comboBox1.Items.Add(status);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
           
            string selectedStatus = comboBox1.SelectedItem.ToString();

            if (selectedStatus == "Все" || string.IsNullOrEmpty(selectedStatus))
            {
                ticketsBindingSource.DataSource = database.Tickets.ToList();
            }
            else
            {
                var filtered = database.Tickets
                    .Where(t => t.Status == selectedStatus)
                    .ToList();

                ticketsBindingSource.DataSource = filtered;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Visible = false;
            form.Show();
        }
    }
}
