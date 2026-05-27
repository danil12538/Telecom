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

namespace Telecom
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Tariffbutton_Click(object sender, EventArgs e)
        {
            Tariff form = new Tariff();
            this.Visible = false;
            form.Show();
        }

        private void Clientbutton_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            this.Visible = false;
            form.Show();
        }

        private void Ticketbutton_Click(object sender, EventArgs e)
        {
            Ticket form = new Ticket();
            this.Visible = false;
            form.Show();
        }

        private void Subbutton_Click(object sender, EventArgs e)
        {
            Subscription form = new Subscription();
            this.Visible = false;
            form.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
