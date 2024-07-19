namespace ProjectOOP_NataliaHerrera
{
    partial class LottoMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LottoMax));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLMaxGenerate = new System.Windows.Forms.Button();
            this.btnLMaxReadDsiaply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "The winning numbers are:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLMaxGenerate
            // 
            this.btnLMaxGenerate.Location = new System.Drawing.Point(12, 248);
            this.btnLMaxGenerate.Name = "btnLMaxGenerate";
            this.btnLMaxGenerate.Size = new System.Drawing.Size(111, 79);
            this.btnLMaxGenerate.TabIndex = 1;
            this.btnLMaxGenerate.Text = "Generate\r\n7 + 1 unique\r\nnumbers\r\nout of 50";
            this.btnLMaxGenerate.UseVisualStyleBackColor = true;
            this.btnLMaxGenerate.Click += new System.EventHandler(this.btnLMaxGenerate_Click);
            // 
            // btnLMaxReadDsiaply
            // 
            this.btnLMaxReadDsiaply.Location = new System.Drawing.Point(12, 437);
            this.btnLMaxReadDsiaply.Name = "btnLMaxReadDsiaply";
            this.btnLMaxReadDsiaply.Size = new System.Drawing.Size(111, 63);
            this.btnLMaxReadDsiaply.TabIndex = 2;
            this.btnLMaxReadDsiaply.Text = "&Read and\r\nDisplay the\r\nText File";
            this.btnLMaxReadDsiaply.UseVisualStyleBackColor = true;
            this.btnLMaxReadDsiaply.Click += new System.EventHandler(this.btnLMaxReadDsiaply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 223);
            this.textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 221);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(460, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLMaxReadDsiaply);
            this.Controls.Add(this.btnLMaxGenerate);
            this.Controls.Add(this.label1);
            this.Name = "LottoMax";
            this.Text = "LottoMax Natalia Herrera";
            this.Load += new System.EventHandler(this.LottoMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLMaxGenerate;
        private System.Windows.Forms.Button btnLMaxReadDsiaply;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}