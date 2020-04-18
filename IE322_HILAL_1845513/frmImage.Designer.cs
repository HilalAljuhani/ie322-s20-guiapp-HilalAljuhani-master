namespace IE322_HILAL_1845513
{
    partial class frmImage
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
            this.Btnback = new System.Windows.Forms.Button();
            this.Btnload = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btnback
            // 
            this.Btnback.Location = new System.Drawing.Point(443, 271);
            this.Btnback.Name = "Btnback";
            this.Btnback.Size = new System.Drawing.Size(75, 23);
            this.Btnback.TabIndex = 0;
            this.Btnback.Text = "Back";
            this.Btnback.UseVisualStyleBackColor = true;
            this.Btnback.Click += new System.EventHandler(this.Btnback_Click);
            // 
            // Btnload
            // 
            this.Btnload.Location = new System.Drawing.Point(66, 34);
            this.Btnload.Name = "Btnload";
            this.Btnload.Size = new System.Drawing.Size(81, 92);
            this.Btnload.TabIndex = 1;
            this.Btnload.Text = "Load Image";
            this.Btnload.UseVisualStyleBackColor = true;
            this.Btnload.Click += new System.EventHandler(this.Btnload_Click);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(363, 62);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(190, 153);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.Btnload);
            this.Controls.Add(this.Btnback);
            this.Name = "frmImage";
            this.Text = "frmImage";
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnback;
        private System.Windows.Forms.Button Btnload;
        private System.Windows.Forms.PictureBox pic1;
    }
}