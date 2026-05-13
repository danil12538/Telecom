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
        List<Ticket> TicketChange = new List<Ticket>();
        List<string> TicketProp = new List<string>();
        private void Ticket_Load(object sender, EventArgs e)
        {
            ticketsBindingSource.DataSource = database.Tickets.ToList();
            loadStartData();
            LoadDataCombo();
        }

        private void loadStartData()
        {
            // ticketsBindingSource.DataSource = TicketChange;
            //tickets = database.Tickets.ToList();
            ticketsBindingSource.DataSource = tickets;
        }

        private void LoadDataCombo()
        {
            // Очищаем ComboBox
            comboBox1.Items.Clear();

            // Получаем все уникальные статусы из базы
            var statuses = database.Tickets
                .Select(t => t.Status)
                .Distinct()
                .OrderBy(s => s)
                .ToList();

            // Добавляем пункт "Все"
            comboBox1.Items.Add("Все");

            // Добавляем все статусы
            foreach (var status in statuses)
            {
                comboBox1.Items.Add(status);
            }

            // Выбираем "Все" по умолчанию
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            // Получаем выбранное значение из ComboBox
            string selectedStatus = comboBox1.SelectedItem.ToString();

            // Если выбрано "Все" — показываем всё
            if (selectedStatus == "Все" || string.IsNullOrEmpty(selectedStatus))
            {
                ticketsBindingSource.DataSource = database.Tickets.ToList();
            }
            else
            {
                // Фильтруем по статусу
                var filtered = database.Tickets
                    .Where(t => t.Status == selectedStatus)
                    .ToList();

                ticketsBindingSource.DataSource = filtered;
            }
        }

    }
}
