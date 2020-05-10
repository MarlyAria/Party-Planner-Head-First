namespace WindowsFormsApp2
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DisplayCostLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.healtyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.NumberOfPeopleNUD = new System.Windows.Forms.NumericUpDown();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.DisplayBirthdayCost = new System.Windows.Forms.Label();
            this.BirthdayCost = new System.Windows.Forms.Label();
            this.cakeLabel = new System.Windows.Forms.Label();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 224);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DisplayCostLabel);
            this.tabPage1.Controls.Add(this.CostLabel);
            this.tabPage1.Controls.Add(this.healtyBox);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.NumberOfPeopleNUD);
            this.tabPage1.Controls.Add(this.PeopleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(187, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.cakeLabel);
            this.tabPage2.Controls.Add(this.DisplayBirthdayCost);
            this.tabPage2.Controls.Add(this.BirthdayCost);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.BirthdayLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(212, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DisplayCostLabel
            // 
            this.DisplayCostLabel.AutoSize = true;
            this.DisplayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCostLabel.Location = new System.Drawing.Point(69, 140);
            this.DisplayCostLabel.Name = "DisplayCostLabel";
            this.DisplayCostLabel.Size = new System.Drawing.Size(98, 19);
            this.DisplayCostLabel.TabIndex = 11;
            this.DisplayCostLabel.Text = "Display cost";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(17, 142);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 17);
            this.CostLabel.TabIndex = 10;
            this.CostLabel.Text = "Cost";
            // 
            // HealtyCheckBox
            // 
            this.healtyBox.AutoSize = true;
            this.healtyBox.Location = new System.Drawing.Point(19, 103);
            this.healtyBox.Name = "HealtyCheckBox";
            this.healtyBox.Size = new System.Drawing.Size(124, 21);
            this.healtyBox.TabIndex = 9;
            this.healtyBox.Text = "Healthy Option";
            this.healtyBox.UseVisualStyleBackColor = true;
            this.healtyBox.CheckedChanged += new System.EventHandler(this.HealtyCheckBox_CheckedChanged);
            // 
            // DecoCheckBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(19, 76);
            this.fancyBox.Name = "DecoCheckBox";
            this.fancyBox.Size = new System.Drawing.Size(148, 21);
            this.fancyBox.TabIndex = 8;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // NumberOfPeopleNUD
            // 
            this.NumberOfPeopleNUD.Location = new System.Drawing.Point(19, 48);
            this.NumberOfPeopleNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumberOfPeopleNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfPeopleNUD.Name = "NumberOfPeopleNUD";
            this.NumberOfPeopleNUD.Size = new System.Drawing.Size(120, 22);
            this.NumberOfPeopleNUD.TabIndex = 7;
            this.NumberOfPeopleNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumberOfPeopleNUD.ValueChanged += new System.EventHandler(this.NumberOfPeopleNUD_ValueChanged);
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(17, 17);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(122, 17);
            this.PeopleLabel.TabIndex = 6;
            this.PeopleLabel.Text = "Number of People";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(19, 78);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(148, 21);
            this.fancyBirthday.TabIndex = 11;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(19, 50);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 22);
            this.numberBirthday.TabIndex = 10;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Location = new System.Drawing.Point(17, 19);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(122, 17);
            this.BirthdayLabel.TabIndex = 9;
            this.BirthdayLabel.Text = "Number of People";
            // 
            // DisplayBirthdayCost
            // 
            this.DisplayBirthdayCost.AutoSize = true;
            this.DisplayBirthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayBirthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBirthdayCost.Location = new System.Drawing.Point(69, 156);
            this.DisplayBirthdayCost.Name = "DisplayBirthdayCost";
            this.DisplayBirthdayCost.Size = new System.Drawing.Size(98, 19);
            this.DisplayBirthdayCost.TabIndex = 13;
            this.DisplayBirthdayCost.Text = "Display cost";
            // 
            // BirthdayCost
            // 
            this.BirthdayCost.AutoSize = true;
            this.BirthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayCost.Location = new System.Drawing.Point(17, 156);
            this.BirthdayCost.Name = "BirthdayCost";
            this.BirthdayCost.Size = new System.Drawing.Size(40, 17);
            this.BirthdayCost.TabIndex = 12;
            this.BirthdayCost.Text = "Cost";
            // 
            // cakeLabel
            // 
            this.cakeLabel.AutoSize = true;
            this.cakeLabel.Location = new System.Drawing.Point(17, 102);
            this.cakeLabel.Name = "cakeLabel";
            this.cakeLabel.Size = new System.Drawing.Size(88, 17);
            this.cakeLabel.TabIndex = 14;
            this.cakeLabel.Text = "Cake Writing";
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(112, 102);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(83, 17);
            this.tooLongLabel.TabIndex = 15;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(19, 131);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.ShortcutsEnabled = false;
            this.cakeWriting.Size = new System.Drawing.Size(175, 22);
            this.cakeWriting.TabIndex = 16;
            this.cakeWriting.Text = "Happy Birthday";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 226);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfPeopleNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DisplayCostLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.CheckBox healtyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.NumericUpDown NumberOfPeopleNUD;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label cakeLabel;
        private System.Windows.Forms.Label DisplayBirthdayCost;
        private System.Windows.Forms.Label BirthdayCost;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label BirthdayLabel;
    }
}

