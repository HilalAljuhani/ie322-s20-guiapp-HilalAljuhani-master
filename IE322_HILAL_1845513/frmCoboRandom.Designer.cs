namespace lesson_1
{
    partial class frmCoboRandom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRandom1 = new System.Windows.Forms.ComboBox();
            this.RadioLess1 = new System.Windows.Forms.RadioButton();
            this.RadioGreater1 = new System.Windows.Forms.RadioButton();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.BtnGenerate1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.RadioGreater2 = new System.Windows.Forms.RadioButton();
            this.RadioLess2 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRandom1);
            this.groupBox1.Controls.Add(this.RadioLess1);
            this.groupBox1.Controls.Add(this.RadioGreater1);
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.BtnGenerate1);
            this.groupBox1.Location = new System.Drawing.Point(98, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03_AAf19";
            // 
            // cmbRandom1
            // 
            this.cmbRandom1.FormattingEnabled = true;
            this.cmbRandom1.Location = new System.Drawing.Point(6, 37);
            this.cmbRandom1.Name = "cmbRandom1";
            this.cmbRandom1.Size = new System.Drawing.Size(121, 21);
            this.cmbRandom1.TabIndex = 8;
            this.cmbRandom1.SelectedIndexChanged += new System.EventHandler(this.cmbRandom1_SelectedIndexChanged);
            // 
            // RadioLess1
            // 
            this.RadioLess1.AutoSize = true;
            this.RadioLess1.Location = new System.Drawing.Point(157, 82);
            this.RadioLess1.Name = "RadioLess1";
            this.RadioLess1.Size = new System.Drawing.Size(92, 17);
            this.RadioLess1.TabIndex = 7;
            this.RadioLess1.TabStop = true;
            this.RadioLess1.Text = "Less than 500";
            this.RadioLess1.UseVisualStyleBackColor = true;
            this.RadioLess1.CheckedChanged += new System.EventHandler(this.RadioLess1_CheckedChanged);
            // 
            // RadioGreater1
            // 
            this.RadioGreater1.AutoSize = true;
            this.RadioGreater1.Location = new System.Drawing.Point(157, 123);
            this.RadioGreater1.Name = "RadioGreater1";
            this.RadioGreater1.Size = new System.Drawing.Size(108, 17);
            this.RadioGreater1.TabIndex = 6;
            this.RadioGreater1.TabStop = true;
            this.RadioGreater1.Text = "Greater than 500";
            this.RadioGreater1.UseVisualStyleBackColor = true;
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(157, 181);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(75, 23);
            this.BtnReset1.TabIndex = 4;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            this.BtnReset1.Click += new System.EventHandler(this.BtnReset1_Click);
            // 
            // BtnGenerate1
            // 
            this.BtnGenerate1.Location = new System.Drawing.Point(157, 35);
            this.BtnGenerate1.Name = "BtnGenerate1";
            this.BtnGenerate1.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate1.TabIndex = 0;
            this.BtnGenerate1.Text = "Genarate";
            this.BtnGenerate1.UseVisualStyleBackColor = true;
            this.BtnGenerate1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Controls.Add(this.RadioGreater2);
            this.groupBox2.Controls.Add(this.RadioLess2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Location = new System.Drawing.Point(452, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03_EAf19";
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(6, 35);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(121, 21);
            this.cmbRandom2.TabIndex = 9;
            this.cmbRandom2.SelectedIndexChanged += new System.EventHandler(this.cmbRandom2_SelectedIndexChanged);
            // 
            // RadioGreater2
            // 
            this.RadioGreater2.AutoSize = true;
            this.RadioGreater2.Location = new System.Drawing.Point(157, 123);
            this.RadioGreater2.Name = "RadioGreater2";
            this.RadioGreater2.Size = new System.Drawing.Size(108, 17);
            this.RadioGreater2.TabIndex = 8;
            this.RadioGreater2.TabStop = true;
            this.RadioGreater2.Text = "Greater than 500";
            this.RadioGreater2.UseVisualStyleBackColor = true;
            // 
            // RadioLess2
            // 
            this.RadioLess2.AutoSize = true;
            this.RadioLess2.Location = new System.Drawing.Point(157, 82);
            this.RadioLess2.Name = "RadioLess2";
            this.RadioLess2.Size = new System.Drawing.Size(92, 17);
            this.RadioLess2.TabIndex = 9;
            this.RadioLess2.TabStop = true;
            this.RadioLess2.Text = "Less than 500";
            this.RadioLess2.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.Location = new System.Drawing.Point(157, 35);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate2.TabIndex = 3;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = true;
            this.BtnGenerate2.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(157, 181);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(75, 23);
            this.BtnReset2.TabIndex = 2;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Count:";
            // 
            // frmCoboRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCoboRandom";
            this.Text = "frmCoboRandom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRandom1;
        private System.Windows.Forms.RadioButton RadioLess1;
        private System.Windows.Forms.RadioButton RadioGreater1;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.Button BtnGenerate1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.RadioButton RadioGreater2;
        private System.Windows.Forms.RadioButton RadioLess2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}