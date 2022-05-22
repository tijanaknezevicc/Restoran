namespace Restoran
{
    partial class NovaRezervacija
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTermin = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBrojGostiju = new System.Windows.Forms.ComboBox();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(584, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 16);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "User";
            // 
            // labelTermin
            // 
            this.labelTermin.AutoSize = true;
            this.labelTermin.Location = new System.Drawing.Point(68, 105);
            this.labelTermin.Name = "labelTermin";
            this.labelTermin.Size = new System.Drawing.Size(141, 16);
            this.labelTermin.TabIndex = 4;
            this.labelTermin.Text = "Izaberite zeljeni termin:";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(68, 160);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(76, 16);
            this.labelBroj.TabIndex = 5;
            this.labelBroj.Text = "Broj gostiju:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(237, 100);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(193, 22);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2022, 5, 22, 21, 55, 23, 0);
            // 
            // comboBoxBrojGostiju
            // 
            this.comboBoxBrojGostiju.FormattingEnabled = true;
            this.comboBoxBrojGostiju.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxBrojGostiju.Location = new System.Drawing.Point(237, 152);
            this.comboBoxBrojGostiju.Name = "comboBoxBrojGostiju";
            this.comboBoxBrojGostiju.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBrojGostiju.TabIndex = 7;
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(323, 261);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.buttonPotvrdi.TabIndex = 9;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // NovaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 350);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.comboBoxBrojGostiju);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelBroj);
            this.Controls.Add(this.labelTermin);
            this.Controls.Add(this.labelUser);
            this.Name = "NovaRezervacija";
            this.Text = "NovaRezervacija";
            this.Load += new System.EventHandler(this.NovaRezervacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelTermin;
        private System.Windows.Forms.Label labelBroj;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxBrojGostiju;
        private System.Windows.Forms.Button buttonPotvrdi;
    }
}