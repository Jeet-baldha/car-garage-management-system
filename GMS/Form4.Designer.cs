namespace GMS
{
    partial class Form4
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
            this.cnumber_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.addpart_button = new System.Windows.Forms.Button();
            this.savebill_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgBill = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.partquan_text = new System.Windows.Forms.TextBox();
            this.servicecharge_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addbill_button = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCN = new System.Windows.Forms.Label();
            this.entery_date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Billing";
            // 
            // cnumber_text
            // 
            this.cnumber_text.Location = new System.Drawing.Point(221, 173);
            this.cnumber_text.Name = "cnumber_text";
            this.cnumber_text.Size = new System.Drawing.Size(158, 22);
            this.cnumber_text.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Car Number  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "Car Information  -----------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Date  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 41);
            this.label2.TabIndex = 20;
            this.label2.Text = "Service Details  -----------------------------------------";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(44, 300);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(406, 363);
            this.dg.TabIndex = 21;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 34);
            this.label3.TabIndex = 22;
            this.label3.Text = "Parts Details";
            // 
            // addpart_button
            // 
            this.addpart_button.BackColor = System.Drawing.SystemColors.Info;
            this.addpart_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpart_button.Location = new System.Drawing.Point(129, 679);
            this.addpart_button.Name = "addpart_button";
            this.addpart_button.Size = new System.Drawing.Size(236, 37);
            this.addpart_button.TabIndex = 26;
            this.addpart_button.Text = "Add Parts";
            this.addpart_button.UseVisualStyleBackColor = false;
            this.addpart_button.Click += new System.EventHandler(this.addpart_button_Click);
            // 
            // savebill_button
            // 
            this.savebill_button.BackColor = System.Drawing.SystemColors.Info;
            this.savebill_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebill_button.Location = new System.Drawing.Point(822, 744);
            this.savebill_button.Name = "savebill_button";
            this.savebill_button.Size = new System.Drawing.Size(236, 37);
            this.savebill_button.TabIndex = 29;
            this.savebill_button.Text = "Save Bill";
            this.savebill_button.UseVisualStyleBackColor = false;
            this.savebill_button.Click += new System.EventHandler(this.savebill_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(894, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Billing Details";
            // 
            // dgBill
            // 
            this.dgBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBill.Location = new System.Drawing.Point(737, 300);
            this.dgBill.Name = "dgBill";
            this.dgBill.RowHeadersWidth = 51;
            this.dgBill.RowTemplate.Height = 24;
            this.dgBill.Size = new System.Drawing.Size(406, 363);
            this.dgBill.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Parts Quantity";
            // 
            // partquan_text
            // 
            this.partquan_text.Location = new System.Drawing.Point(514, 353);
            this.partquan_text.Name = "partquan_text";
            this.partquan_text.Size = new System.Drawing.Size(158, 22);
            this.partquan_text.TabIndex = 31;
            // 
            // servicecharge_text
            // 
            this.servicecharge_text.Location = new System.Drawing.Point(517, 561);
            this.servicecharge_text.Name = "servicecharge_text";
            this.servicecharge_text.Size = new System.Drawing.Size(158, 22);
            this.servicecharge_text.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Service Charge";
            // 
            // addbill_button
            // 
            this.addbill_button.BackColor = System.Drawing.SystemColors.Info;
            this.addbill_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbill_button.Location = new System.Drawing.Point(478, 621);
            this.addbill_button.Name = "addbill_button";
            this.addbill_button.Size = new System.Drawing.Size(236, 37);
            this.addbill_button.TabIndex = 36;
            this.addbill_button.Text = "Add in Bill";
            this.addbill_button.UseVisualStyleBackColor = false;
            this.addbill_button.Click += new System.EventHandler(this.addbill_button_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(985, 688);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 22);
            this.txtTotal.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(892, 688);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 22);
            this.label11.TabIndex = 37;
            this.label11.Text = "Total  :";
            // 
            // lblCN
            // 
            this.lblCN.AutoSize = true;
            this.lblCN.BackColor = System.Drawing.Color.Transparent;
            this.lblCN.ForeColor = System.Drawing.Color.Red;
            this.lblCN.Location = new System.Drawing.Point(218, 198);
            this.lblCN.Name = "lblCN";
            this.lblCN.Size = new System.Drawing.Size(153, 16);
            this.lblCN.TabIndex = 39;
            this.lblCN.Text = "Please enter car number";
            this.lblCN.Visible = false;
            // 
            // entery_date
            // 
            this.entery_date.Location = new System.Drawing.Point(517, 173);
            this.entery_date.Name = "entery_date";
            this.entery_date.Size = new System.Drawing.Size(120, 22);
            this.entery_date.TabIndex = 40;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1192, 802);
            this.Controls.Add(this.entery_date);
            this.Controls.Add(this.lblCN);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.addbill_button);
            this.Controls.Add(this.servicecharge_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.partquan_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.savebill_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgBill);
            this.Controls.Add(this.addpart_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cnumber_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cnumber_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addpart_button;
        private System.Windows.Forms.Button savebill_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox partquan_text;
        private System.Windows.Forms.TextBox servicecharge_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addbill_button;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCN;
        private System.Windows.Forms.TextBox entery_date;
    }
}