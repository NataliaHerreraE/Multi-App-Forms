namespace ProjectOOP_NataliaHerrera
{
    partial class Lotto649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto649));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnL649ReadDisplay = new System.Windows.Forms.Button();
            this.btnL649Generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 248);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(43, 223);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 221);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnL649ReadDisplay
            // 
            this.btnL649ReadDisplay.Location = new System.Drawing.Point(12, 437);
            this.btnL649ReadDisplay.Name = "btnL649ReadDisplay";
            this.btnL649ReadDisplay.Size = new System.Drawing.Size(111, 63);
            this.btnL649ReadDisplay.TabIndex = 8;
            this.btnL649ReadDisplay.Text = "&Read and\r\nDisplay the\r\nText File";
            this.btnL649ReadDisplay.UseVisualStyleBackColor = true;
            this.btnL649ReadDisplay.Click += new System.EventHandler(this.btnL649ReadDisplay_Click);
            // 
            // btnL649Generate
            // 
            this.btnL649Generate.Location = new System.Drawing.Point(12, 248);
            this.btnL649Generate.Name = "btnL649Generate";
            this.btnL649Generate.Size = new System.Drawing.Size(111, 79);
            this.btnL649Generate.TabIndex = 7;
            this.btnL649Generate.Text = "Generate\r\n6 + 1 unique\r\nnumbers\r\nout of 49";
            this.btnL649Generate.UseVisualStyleBackColor = true;
            this.btnL649Generate.Click += new System.EventHandler(this.btnL649Generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "The winning numbers are:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(460, 519);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnL649ReadDisplay);
            this.Controls.Add(this.btnL649Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lotto649";
            this.Text = "Lotto649 Natalia Herrera";
            this.Load += new System.EventHandler(this.Lotto649_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnL649ReadDisplay;
        private System.Windows.Forms.Button btnL649Generate;
        private System.Windows.Forms.Label label2;
    }
}