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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventory_Management_Entities ent = new Inventory_Management_Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            var stores = from store in ent.Stores
                         select store.store_name;

            foreach (var store in stores)
            {
                stores_list.Items.Add(store);
            }

        }

        private void stores_SelectedIndexChanged(object sender, EventArgs e)
        {
            items_list.Items.Clear();

            var store_items = from item in ent.Items
                              join store_item in ent.Store_Item on item.item_id equals store_item.item_id
                              join store in ent.Stores on store_item.store_id equals store.store_id
                              where store.store_name == stores_list.SelectedItem.ToString()
                              select item.item_name;

            foreach (var item in store_items)
            {
                items_list.Items.Add(item);
            }
            
        }

        private void add_store_btn_Click(object sender, EventArgs e)
        {
            AddStoreDialog addStoreDialog = new AddStoreDialog();
            addStoreDialog.ShowDialog();

            if(addStoreDialog.DialogResult == DialogResult.OK)
            {
                var storeName = (from store in ent.Stores
                                where store.store_name == addStoreDialog.StoreName
                                select store.store_name).First();

                    stores_list.Items.Add(storeName);
            }
        }

        private void edit_store_btn_Click(object sender, EventArgs e)
        {
            EditStoreDialog editStoreDialog = new EditStoreDialog();
            editStoreDialog.ShowDialog();


        }

        private void del_store_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var store = (from s in ent.Stores
                             where s.store_name == stores_list.SelectedItem.ToString()
                             select s).First();

                var confirmDelete = MessageBox.Show("Are you sure you want to delete this store ?", null, MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    ent.Stores.Remove(store);
                    ent.SaveChanges();
                    stores_list.Items.Remove(store.store_name);
                    MessageBox.Show("Successfully deleted");
                    
                }
            }

            catch
            {
                //MessageBox.Show("Error");
            }

            

            
        }
    }
}
