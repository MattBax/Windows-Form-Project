using System;

namespace OrderSummary
{
    partial class OrderForm
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
            this.view = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oidBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.oid = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.Desktop;
            this.view.ForeColor = System.Drawing.SystemColors.Control;
            this.view.Location = new System.Drawing.Point(46, 230);
            this.view.Margin = new System.Windows.Forms.Padding(2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(96, 58);
            this.view.TabIndex = 0;
            this.view.Text = "View Data";
            this.view.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.btn_View);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.ForestGreen;
            this.add.Location = new System.Drawing.Point(188, 230);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(89, 58);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.btn_Add);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.SandyBrown;
            this.edit.Location = new System.Drawing.Point(313, 230);
            this.edit.Margin = new System.Windows.Forms.Padding(2);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(93, 58);
            this.edit.TabIndex = 2;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.btn_Edit);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(445, 230);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 58);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.btn_Delete);
            // 
            // average
            // 
            this.average.BackColor = System.Drawing.SystemColors.Highlight;
            this.average.Location = new System.Drawing.Point(572, 233);
            this.average.Margin = new System.Windows.Forms.Padding(2);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(96, 55);
            this.average.TabIndex = 4;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = false;
            this.average.Click += new System.EventHandler(this.btn_Average);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 327);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(665, 298);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.view_Data);
            // 
            // oidBox
            // 
            this.oidBox.Location = new System.Drawing.Point(204, 52);
            this.oidBox.Margin = new System.Windows.Forms.Padding(2);
            this.oidBox.Name = "oidBox";
            this.oidBox.Size = new System.Drawing.Size(91, 26);
            this.oidBox.TabIndex = 6;
            this.oidBox.TextChanged += new System.EventHandler(this.oidBox_TextChanged);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(534, 52);
            this.priceBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(156, 26);
            this.priceBox.TabIndex = 7;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(204, 134);
            this.cBox.Margin = new System.Windows.Forms.Padding(2);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(91, 26);
            this.cBox.TabIndex = 8;
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(534, 134);
            this.Tbox.Margin = new System.Windows.Forms.Padding(2);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(156, 26);
            this.Tbox.TabIndex = 9;
            // 
            // oid
            // 
            this.oid.AutoSize = true;
            this.oid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oid.Location = new System.Drawing.Point(64, 55);
            this.oid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oid.Name = "oid";
            this.oid.Size = new System.Drawing.Size(78, 20);
            this.oid.TabIndex = 10;
            this.oid.Text = "Order ID";
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.Location = new System.Drawing.Point(67, 134);
            this.cid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(110, 20);
            this.cid.TabIndex = 11;
            this.cid.Text = "Customer ID";
            this.cid.Click += new System.EventHandler(this.cid_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(431, 55);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(49, 20);
            this.price.TabIndex = 12;
            this.price.Text = "Price";
            // 
            // terms
            // 
            this.terms.AutoSize = true;
            this.terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms.Location = new System.Drawing.Point(431, 138);
            this.terms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(100, 20);
            this.terms.TabIndex = 13;
            this.terms.Text = "Description";
            // 
            // Total
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.Location = new System.Drawing.Point(703, 230);
            this.button1.Name = "total";
            this.button1.Size = new System.Drawing.Size(95, 58);
            this.button1.TabIndex = 14;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Total);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(829, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.price);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.oid);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.oidBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.average);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.view);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox oidBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.Label oid;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label terms;
        private System.Windows.Forms.Button button1;
    }
}

