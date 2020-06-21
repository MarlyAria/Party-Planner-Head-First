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
            this.DisplayCostLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyDinnerBox = new System.Windows.Forms.CheckBox();
            this.numberDinner = new System.Windows.Forms.NumericUpDown();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.tabPageBirthday = new System.Windows.Forms.TabPage();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.cakeLabel = new System.Windows.Forms.Label();
            this.DisplayBirthdayCostLabel = new System.Windows.Forms.Label();
            this.BirthdayCost = new System.Windows.Forms.Label();
            this.fancyBirthdayBox = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberDinner)).BeginInit();
            this.tabPageBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageBirthday);
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
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Controls.Add(this.fancyDinnerBox);
            this.tabPage1.Controls.Add(this.numberDinner);
            this.tabPage1.Controls.Add(this.PeopleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(19, 103);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(124, 21);
            this.healthyBox.TabIndex = 9;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healtyBox_CheckedChanged);
            // 
            // fancyDinnerBox
            // 
            this.fancyDinnerBox.AutoSize = true;
            this.fancyDinnerBox.Checked = true;
            this.fancyDinnerBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDinnerBox.Location = new System.Drawing.Point(19, 76);
            this.fancyDinnerBox.Name = "fancyDinnerBox";
            this.fancyDinnerBox.Size = new System.Drawing.Size(148, 21);
            this.fancyDinnerBox.TabIndex = 8;
            this.fancyDinnerBox.Text = "Fancy Decorations";
            this.fancyDinnerBox.UseVisualStyleBackColor = true;
            this.fancyDinnerBox.CheckedChanged += new System.EventHandler(this.fancyDinnerBox_CheckedChanged);
            // 
            // numberDinner
            // 
            this.numberDinner.Location = new System.Drawing.Point(69, 48);
            this.numberDinner.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberDinner.Name = "numberDinner";
            this.numberDinner.Size = new System.Drawing.Size(120, 22);
            this.numberDinner.TabIndex = 7;
            this.numberDinner.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberDinner.ValueChanged += new System.EventHandler(this.numberDinner_ValueChanged);
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
            // tabPageBirthday
            // 
            this.tabPageBirthday.Controls.Add(this.cakeWriting);
            this.tabPageBirthday.Controls.Add(this.tooLongLabel);
            this.tabPageBirthday.Controls.Add(this.cakeLabel);
            this.tabPageBirthday.Controls.Add(this.DisplayBirthdayCostLabel);
            this.tabPageBirthday.Controls.Add(this.BirthdayCost);
            this.tabPageBirthday.Controls.Add(this.fancyBirthdayBox);
            this.tabPageBirthday.Controls.Add(this.numberBirthday);
            this.tabPageBirthday.Controls.Add(this.BirthdayLabel);
            this.tabPageBirthday.Location = new System.Drawing.Point(4, 25);
            this.tabPageBirthday.Name = "tabPageBirthday";
            this.tabPageBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBirthday.Size = new System.Drawing.Size(212, 195);
            this.tabPageBirthday.TabIndex = 1;
            this.tabPageBirthday.Text = "Birthday Party";
            this.tabPageBirthday.UseVisualStyleBackColor = true;
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(19, 131);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.ShortcutsEnabled = false;
            this.cakeWriting.Size = new System.Drawing.Size(175, 22);
            this.cakeWriting.TabIndex = 16;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
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
            // cakeLabel
            // 
            this.cakeLabel.AutoSize = true;
            this.cakeLabel.Location = new System.Drawing.Point(17, 102);
            this.cakeLabel.Name = "cakeLabel";
            this.cakeLabel.Size = new System.Drawing.Size(88, 17);
            this.cakeLabel.TabIndex = 14;
            this.cakeLabel.Text = "Cake Writing";
            // 
            // DisplayBirthdayCostLabel
            // 
            this.DisplayBirthdayCostLabel.AutoSize = true;
            this.DisplayBirthdayCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayBirthdayCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBirthdayCostLabel.Location = new System.Drawing.Point(69, 156);
            this.DisplayBirthdayCostLabel.Name = "DisplayBirthdayCostLabel";
            this.DisplayBirthdayCostLabel.Size = new System.Drawing.Size(98, 19);
            this.DisplayBirthdayCostLabel.TabIndex = 13;
            this.DisplayBirthdayCostLabel.Text = "Display cost";
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
            // fancyBirthdayBox
            // 
            this.fancyBirthdayBox.AutoSize = true;
            this.fancyBirthdayBox.Checked = true;
            this.fancyBirthdayBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthdayBox.Location = new System.Drawing.Point(19, 78);
            this.fancyBirthdayBox.Name = "fancyBirthdayBox";
            this.fancyBirthdayBox.Size = new System.Drawing.Size(148, 21);
            this.fancyBirthdayBox.TabIndex = 11;
            this.fancyBirthdayBox.Text = "Fancy Decorations";
            this.fancyBirthdayBox.UseVisualStyleBackColor = true;
            this.fancyBirthdayBox.CheckedChanged += new System.EventHandler(this.fancyBirthdayBox_CheckedChanged);
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
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.numberDinner)).EndInit();
            this.tabPageBirthday.ResumeLayout(false);
            this.tabPageBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DisplayCostLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyDinnerBox;
        private System.Windows.Forms.NumericUpDown numberDinner;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.TabPage tabPageBirthday;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label cakeLabel;
        private System.Windows.Forms.Label DisplayBirthdayCostLabel;
        private System.Windows.Forms.Label BirthdayCost;
        private System.Windows.Forms.CheckBox fancyBirthdayBox;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label BirthdayLabel;
    }
}

