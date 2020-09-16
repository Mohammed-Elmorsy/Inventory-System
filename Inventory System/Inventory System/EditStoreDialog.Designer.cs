namespace Inventory_System
{
    partial class EditStoreDialog
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
            this.ASD_cancel_btn = new System.Windows.Forms.Button();
            this.ESD_edit_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mgr_name = new System.Windows.Forms.TextBox();
            this.txt_mgr_address = new System.Windows.Forms.TextBox();
            this.txt_mgr_id = new System.Windows.Forms.TextBox();
            this.txt_store_address = new System.Windows.Forms.TextBox();
            this.txt_store_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ASD_cancel_btn
            // 
            this.ASD_cancel_btn.Location = new System.Drawing.Point(243, 283);
            this.ASD_cancel_btn.Name = "ASD_cancel_btn";
            this.ASD_cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.ASD_cancel_btn.TabIndex = 25;
            this.ASD_cancel_btn.Text = "Cancel";
            this.ASD_cancel_btn.UseVisualStyleBackColor = true;
            this.ASD_cancel_btn.Click += new System.EventHandler(this.ASD_cancel_btn_Click);
            // 
            // ESD_edit_btn
            // 
            this.ESD_edit_btn.Location = new System.Drawing.Point(51, 283);
            this.ESD_edit_btn.Name = "ESD_edit_btn";
            this.ESD_edit_btn.Size = new System.Drawing.Size(75, 23);
            this.ESD_edit_btn.TabIndex = 24;
            this.ESD_edit_btn.Text = "Edit Store";
            this.ESD_edit_btn.UseVisualStyleBackColor = true;
            this.ESD_edit_btn.Click += new System.EventHandler(this.ESD_edit_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Edit Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Manager Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Manager Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Manager ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // txt_mgr_name
            // 
            this.txt_mgr_name.Location = new System.Drawing.Point(131, 181);
            this.txt_mgr_name.Name = "txt_mgr_name";
            this.txt_mgr_name.Size = new System.Drawing.Size(167, 20);
            this.txt_mgr_name.TabIndex = 17;
            // 
            // txt_mgr_address
            // 
            this.txt_mgr_address.Location = new System.Drawing.Point(131, 221);
            this.txt_mgr_address.Name = "txt_mgr_address";
            this.txt_mgr_address.Size = new System.Drawing.Size(167, 20);
            this.txt_mgr_address.TabIndex = 16;
            // 
            // txt_mgr_id
            // 
            this.txt_mgr_id.Location = new System.Drawing.Point(131, 142);
            this.txt_mgr_id.Name = "txt_mgr_id";
            this.txt_mgr_id.Size = new System.Drawing.Size(167, 20);
            this.txt_mgr_id.TabIndex = 15;
            // 
            // txt_store_address
            // 
            this.txt_store_address.Location = new System.Drawing.Point(131, 102);
            this.txt_store_address.Name = "txt_store_address";
            this.txt_store_address.Size = new System.Drawing.Size(167, 20);
            this.txt_store_address.TabIndex = 14;
            // 
            // txt_store_name
            // 
            this.txt_store_name.Location = new System.Drawing.Point(131, 62);
            this.txt_store_name.Name = "txt_store_name";
            this.txt_store_name.Size = new System.Drawing.Size(167, 20);
            this.txt_store_name.TabIndex = 13;
            // 
            // EditStoreDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 326);
            this.Controls.Add(this.ASD_cancel_btn);
            this.Controls.Add(this.ESD_edit_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mgr_name);
            this.Controls.Add(this.txt_mgr_address);
            this.Controls.Add(this.txt_mgr_id);
            this.Controls.Add(this.txt_store_address);
            this.Controls.Add(this.txt_store_name);
            this.Name = "EditStoreDialog";
            this.Text = "EditStoreDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ASD_cancel_btn;
        private System.Windows.Forms.Button ESD_edit_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mgr_name;
        private System.Windows.Forms.TextBox txt_mgr_address;
        private System.Windows.Forms.TextBox txt_mgr_id;
        private System.Windows.Forms.TextBox txt_store_address;
        private System.Windows.Forms.TextBox txt_store_name;
    }
}