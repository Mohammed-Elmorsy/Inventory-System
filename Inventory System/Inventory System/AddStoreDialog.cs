using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddStoreDialog : Form
    {
        public AddStoreDialog()
        {
            InitializeComponent();
        }

        Inventory_Management_Entities ent = new Inventory_Management_Entities();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ASD_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int mgr_id = int.Parse(txt_mgr_id.Text);

                Store new_store = new Store()
                {
                    store_name = txt_store_name.Text,
                    store_address = txt_store_address.Text,
                    manager_id = mgr_id,
                    manager_name = txt_mgr_name.Text,
                    manager_address = txt_mgr_address.Text
                };

                ent.Stores.Add(new_store);
                ent.SaveChanges();
                MessageBox.Show("Successfully Added");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ASD_cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
