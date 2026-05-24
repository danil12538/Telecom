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
using System.IO;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Telecom
{
    public partial class Subscription: Form
    {
        public Subscription()
        {
            InitializeComponent();
        }
        Model1 database = new Model1();
        private void Subscription_Load(object sender, EventArgs e)
        {
            StartLoadData();
        }
        private void StartLoadData()
        {
            database.Subscriptions.Load();
            subscriptionsBindingSource.DataSource = database.Subscriptions.Local.ToBindingList();
        }

        private void SaveData()
        {
            try
            {
                Validate();
                subscriptionsBindingSource.EndEdit();
                subscriptionsBindingSource.ResetBindings(true);
                database.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartLoadData();
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Visible = false;
            form.Show();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
        private void subscriptionsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
