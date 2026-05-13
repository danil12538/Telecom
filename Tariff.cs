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

        public static ModelEF.Model1 model = new ModelEF.Model1();
        List<Tariffs> tar = model.Tariffs.ToList();
        int t = 0;
        private void Start()
        {
            model.Tariffs.Load();
            comboBox1.DataSource = model.Tariffs.ToList();
            listBox2.DataSource = model.Tariffs.ToList();
            nameComboBox.DataSource = model.Tariffs.ToList();
        }

        private void Loading()
        {
            Fill(tar[t]);


        }
        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void Fill(Tariffs tariff)
        {
            NametextBox.Text = tariff.Name;
            FeetextBox.Text = tariff.MonthlyFee.ToString();
            SpeedtextBox.Text = tariff.SpeedMbps.ToString();
            ActivetextBox.Text = tariff.IsActive.ToString();
            DestextBox.Text = tariff.Description;
        }

        private void Tariff_Load(object sender, EventArgs e)
        {

            Start();
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }
    



        }
    }

