using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telecom.ModelEF;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace Telecom
{
    public partial class Tariff : Form
    {
        public Tariff()
        {
            InitializeComponent();
        }

        Model1 database = new Model1();
        public class TariffItem
        {
                public int Id { get; set; }
                public string Name { get; set; }
                public decimal Price { get; set; }
                public bool IsActive { get; set; }

            public override string ToString()
            {
                string status = IsActive ? "" : " (архив)";
                return $"{Name} — {Price} руб.{status}";
            }
        }
        private void Tariff_Load(object sender, EventArgs e)
        {
            var tariffs = database.Tariffs
                .OrderBy(t => t.Name)
                .ToList();

            listBox1.Items.Clear();

            foreach (var tariff in tariffs)
            {

                listBox1.Items.Add(new TariffItem
                {
                    Id = tariff.TariffID,
                    Name = tariff.Name,
                    Price = tariff.MonthlyFee,
                    IsActive = (bool)tariff.IsActive
                });
            }


            if (listBox1.Items.Count > 0)
                listBox1.SelectedIndex = 0;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is TariffItem selectedItem)
            {
                int selectedId = selectedItem.Id;

                var tariff = database.Tariffs.Find(selectedId);

                NametextBox.Text = tariff.Name;
                FeetextBox.Text = tariff.MonthlyFee.ToString();
                SpeedtextBox.Text = tariff.SpeedMbps.ToString();
                ActivetextBox.Text = tariff.IsActive.ToString();
                DestextBox.Text = tariff.Description;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Visible = false;
            form.Show();
        }


        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

