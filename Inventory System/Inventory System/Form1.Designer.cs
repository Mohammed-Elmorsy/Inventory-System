namespace Inventory_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stores_items = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.del_item_btn = new System.Windows.Forms.Button();
            this.edit_item_btn = new System.Windows.Forms.Button();
            this.add_item_btn = new System.Windows.Forms.Button();
            this.del_store_btn = new System.Windows.Forms.Button();
            this.edit_store_btn = new System.Windows.Forms.Button();
            this.add_store_btn = new System.Windows.Forms.Button();
            this.items_list = new System.Windows.Forms.ListBox();
            this.stores_list = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_store_details = new System.Windows.Forms.Button();
            this.btn_item_details = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.stores_items.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stores_items);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // stores_items
            // 
            this.stores_items.Controls.Add(this.btn_item_details);
            this.stores_items.Controls.Add(this.btn_store_details);
            this.stores_items.Controls.Add(this.label3);
            this.stores_items.Controls.Add(this.label2);
            this.stores_items.Controls.Add(this.label1);
            this.stores_items.Controls.Add(this.del_item_btn);
            this.stores_items.Controls.Add(this.edit_item_btn);
            this.stores_items.Controls.Add(this.add_item_btn);
            this.stores_items.Controls.Add(this.del_store_btn);
            this.stores_items.Controls.Add(this.edit_store_btn);
            this.stores_items.Controls.Add(this.add_store_btn);
            this.stores_items.Controls.Add(this.items_list);
            this.stores_items.Controls.Add(this.stores_list);
            this.stores_items.Location = new System.Drawing.Point(4, 22);
            this.stores_items.Name = "stores_items";
            this.stores_items.Padding = new System.Windows.Forms.Padding(3);
            this.stores_items.Size = new System.Drawing.Size(974, 496);
            this.stores_items.TabIndex = 0;
            this.stores_items.Text = "Stores & Items";
            this.stores_items.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tranfer Items ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Items List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Stores List";
            // 
            // del_item_btn
            // 
            this.del_item_btn.Location = new System.Drawing.Point(500, 379);
            this.del_item_btn.Name = "del_item_btn";
            this.del_item_btn.Size = new System.Drawing.Size(75, 23);
            this.del_item_btn.TabIndex = 7;
            this.del_item_btn.Text = "Delete Item";
            this.del_item_btn.UseVisualStyleBackColor = true;
            // 
            // edit_item_btn
            // 
            this.edit_item_btn.Location = new System.Drawing.Point(414, 379);
            this.edit_item_btn.Name = "edit_item_btn";
            this.edit_item_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_item_btn.TabIndex = 6;
            this.edit_item_btn.Text = "Edit Item";
            this.edit_item_btn.UseVisualStyleBackColor = true;
            // 
            // add_item_btn
            // 
            this.add_item_btn.Location = new System.Drawing.Point(326, 379);
            this.add_item_btn.Name = "add_item_btn";
            this.add_item_btn.Size = new System.Drawing.Size(75, 23);
            this.add_item_btn.TabIndex = 5;
            this.add_item_btn.Text = "Add Item";
            this.add_item_btn.UseVisualStyleBackColor = true;
            // 
            // del_store_btn
            // 
            this.del_store_btn.Location = new System.Drawing.Point(196, 379);
            this.del_store_btn.Name = "del_store_btn";
            this.del_store_btn.Size = new System.Drawing.Size(75, 23);
            this.del_store_btn.TabIndex = 4;
            this.del_store_btn.Text = "Delete Store";
            this.del_store_btn.UseVisualStyleBackColor = true;
            this.del_store_btn.Click += new System.EventHandler(this.del_store_btn_Click);
            // 
            // edit_store_btn
            // 
            this.edit_store_btn.Location = new System.Drawing.Point(110, 379);
            this.edit_store_btn.Name = "edit_store_btn";
            this.edit_store_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_store_btn.TabIndex = 3;
            this.edit_store_btn.Text = "Edit Store";
            this.edit_store_btn.UseVisualStyleBackColor = true;
            this.edit_store_btn.Click += new System.EventHandler(this.edit_store_btn_Click);
            // 
            // add_store_btn
            // 
            this.add_store_btn.Location = new System.Drawing.Point(22, 379);
            this.add_store_btn.Name = "add_store_btn";
            this.add_store_btn.Size = new System.Drawing.Size(75, 23);
            this.add_store_btn.TabIndex = 2;
            this.add_store_btn.Text = "Add Store";
            this.add_store_btn.UseVisualStyleBackColor = true;
            this.add_store_btn.Click += new System.EventHandler(this.add_store_btn_Click);
            // 
            // items_list
            // 
            this.items_list.FormattingEnabled = true;
            this.items_list.Location = new System.Drawing.Point(328, 44);
            this.items_list.Name = "items_list";
            this.items_list.Size = new System.Drawing.Size(246, 316);
            this.items_list.TabIndex = 1;
            // 
            // stores_list
            // 
            this.stores_list.FormattingEnabled = true;
            this.stores_list.Location = new System.Drawing.Point(22, 44);
            this.stores_list.Name = "stores_list";
            this.stores_list.Size = new System.Drawing.Size(249, 316);
            this.stores_list.TabIndex = 0;
            this.stores_list.SelectedIndexChanged += new System.EventHandler(this.stores_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendors & Receiving Permissions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(934, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_store_details
            // 
            this.btn_store_details.Location = new System.Drawing.Point(110, 419);
            this.btn_store_details.Name = "btn_store_details";
            this.btn_store_details.Size = new System.Drawing.Size(75, 23);
            this.btn_store_details.TabIndex = 11;
            this.btn_store_details.Text = "Store Details";
            this.btn_store_details.UseVisualStyleBackColor = true;
            // 
            // btn_item_details
            // 
            this.btn_item_details.Location = new System.Drawing.Point(414, 419);
            this.btn_item_details.Name = "btn_item_details";
            this.btn_item_details.Size = new System.Drawing.Size(75, 23);
            this.btn_item_details.TabIndex = 12;
            this.btn_item_details.Text = "Item Details";
            this.btn_item_details.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.stores_items.ResumeLayout(false);
            this.stores_items.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stores_items;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_item_btn;
        private System.Windows.Forms.Button edit_item_btn;
        private System.Windows.Forms.Button add_item_btn;
        private System.Windows.Forms.Button del_store_btn;
        private System.Windows.Forms.Button edit_store_btn;
        private System.Windows.Forms.Button add_store_btn;
        private System.Windows.Forms.ListBox items_list;
        private System.Windows.Forms.ListBox stores_list;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_item_details;
        private System.Windows.Forms.Button btn_store_details;
        //public string StoreName
        //{
        //    get
        //    {
        //        return stores_list.SelectedItem.ToString();
        //    }
        //    set
        //    { }
        //}
        //public Form1 form1
        //{
        //    get
        //    {
        //        return this;
        //    }
        //    set
        //    { }
        //}
    }
}

