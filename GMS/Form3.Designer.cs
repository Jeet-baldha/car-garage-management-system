namespace GMS
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantity_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pname_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnumber_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.price_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dsGrid = new System.Windows.Forms.DataGridView();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.lblPartNum = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parts Information  --------------------------------------";
            // 
            // quantity_text
            // 
            this.quantity_text.Location = new System.Drawing.Point(243, 237);
            this.quantity_text.Name = "quantity_text";
            this.quantity_text.Size = new System.Drawing.Size(158, 22);
            this.quantity_text.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Quantity  :";
            // 
            // pname_text
            // 
            this.pname_text.Location = new System.Drawing.Point(243, 193);
            this.pname_text.Name = "pname_text";
            this.pname_text.Size = new System.Drawing.Size(158, 22);
            this.pname_text.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Part Name  :";
            // 
            // pnumber_text
            // 
            this.pnumber_text.Location = new System.Drawing.Point(243, 150);
            this.pnumber_text.Name = "pnumber_text";
            this.pnumber_text.Size = new System.Drawing.Size(158, 22);
            this.pnumber_text.TabIndex = 17;
            this.pnumber_text.MouseLeave += new System.EventHandler(this.pnumber_text_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Part Number  :";
            // 
            // price_text
            // 
            this.price_text.Location = new System.Drawing.Point(243, 283);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(158, 22);
            this.price_text.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Price  :";
            // 
            // dsGrid
            // 
            this.dsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsGrid.Location = new System.Drawing.Point(31, 426);
            this.dsGrid.Name = "dsGrid";
            this.dsGrid.RowHeadersWidth = 51;
            this.dsGrid.RowTemplate.Height = 24;
            this.dsGrid.Size = new System.Drawing.Size(600, 236);
            this.dsGrid.TabIndex = 24;
            this.dsGrid.UseWaitCursor = true;
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.Info;
            this.delete_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(481, 347);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(142, 50);
            this.delete_button.TabIndex = 27;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.Info;
            this.update_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(284, 347);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(142, 50);
            this.update_button.TabIndex = 26;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.Info;
            this.add_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(83, 347);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(142, 50);
            this.add_button.TabIndex = 25;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // lblPartNum
            // 
            this.lblPartNum.AutoSize = true;
            this.lblPartNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPartNum.ForeColor = System.Drawing.Color.Red;
            this.lblPartNum.Location = new System.Drawing.Point(240, 174);
            this.lblPartNum.Name = "lblPartNum";
            this.lblPartNum.Size = new System.Drawing.Size(162, 16);
            this.lblPartNum.TabIndex = 28;
            this.lblPartNum.Text = "Please Enter Part Number";
            this.lblPartNum.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.Red;
            this.lblQuantity.Location = new System.Drawing.Point(241, 262);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(135, 16);
            this.lblQuantity.TabIndex = 29;
            this.lblQuantity.Text = "Please Enter Quantity";
            this.lblQuantity.Visible = false;
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.BackColor = System.Drawing.Color.Transparent;
            this.lblPartName.ForeColor = System.Drawing.Color.Red;
            this.lblPartName.Location = new System.Drawing.Point(240, 219);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(151, 16);
            this.lblPartName.TabIndex = 30;
            this.lblPartName.Text = "Please Enter Part Name";
            this.lblPartName.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(241, 308);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(118, 16);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Please Enter Price";
            this.lblPrice.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 688);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPartNum);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dsGrid);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity_text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pname_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnumber_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantity_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pname_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pnumber_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dsGrid;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label lblPartNum;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblPrice;
    }
}