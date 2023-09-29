namespace GMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.vm_button = new System.Windows.Forms.Button();
            this.billing_button = new System.Windows.Forms.Button();
            this.inventory_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garage Managment System";
            // 
            // vm_button
            // 
            this.vm_button.BackColor = System.Drawing.SystemColors.Info;
            this.vm_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vm_button.Location = new System.Drawing.Point(125, 192);
            this.vm_button.Name = "vm_button";
            this.vm_button.Size = new System.Drawing.Size(372, 117);
            this.vm_button.TabIndex = 2;
            this.vm_button.Text = "Vehical Managment";
            this.vm_button.UseVisualStyleBackColor = false;
            this.vm_button.Click += new System.EventHandler(this.vm_button_Click);
            // 
            // billing_button
            // 
            this.billing_button.BackColor = System.Drawing.SystemColors.Info;
            this.billing_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing_button.Location = new System.Drawing.Point(125, 361);
            this.billing_button.Name = "billing_button";
            this.billing_button.Size = new System.Drawing.Size(372, 117);
            this.billing_button.TabIndex = 3;
            this.billing_button.Text = "Billing";
            this.billing_button.UseVisualStyleBackColor = false;
            this.billing_button.Click += new System.EventHandler(this.billing_button_Click);
            // 
            // inventory_button
            // 
            this.inventory_button.BackColor = System.Drawing.SystemColors.Info;
            this.inventory_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_button.Location = new System.Drawing.Point(616, 192);
            this.inventory_button.Name = "inventory_button";
            this.inventory_button.Size = new System.Drawing.Size(372, 117);
            this.inventory_button.TabIndex = 4;
            this.inventory_button.Text = "Inventory";
            this.inventory_button.UseVisualStyleBackColor = false;
            this.inventory_button.Click += new System.EventHandler(this.inventory_button_Click);
            // 
            // history_button
            // 
            this.history_button.BackColor = System.Drawing.SystemColors.Info;
            this.history_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.Location = new System.Drawing.Point(616, 361);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(372, 117);
            this.history_button.TabIndex = 5;
            this.history_button.Text = "History";
            this.history_button.UseVisualStyleBackColor = false;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMS.Properties.Resources.GMS;
            this.pictureBox1.Location = new System.Drawing.Point(211, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 547);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.inventory_button);
            this.Controls.Add(this.billing_button);
            this.Controls.Add(this.vm_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vm_button;
        private System.Windows.Forms.Button billing_button;
        private System.Windows.Forms.Button inventory_button;
        private System.Windows.Forms.Button history_button;
    }
}

