namespace ProjectOOP_NataliaHerrera
{
    partial class IP_Validator
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
            this.textBox_day = new System.Windows.Forms.TextBox();
            this.label_day = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIPv4 = new System.Windows.Forms.TextBox();
            this.textBoxIPv6 = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReadnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_day
            // 
            this.textBox_day.Location = new System.Drawing.Point(152, 23);
            this.textBox_day.Name = "textBox_day";
            this.textBox_day.ReadOnly = true;
            this.textBox_day.Size = new System.Drawing.Size(100, 20);
            this.textBox_day.TabIndex = 0;
            // 
            // label_day
            // 
            this.label_day.AutoSize = true;
            this.label_day.Location = new System.Drawing.Point(100, 27);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(37, 13);
            this.label_day.TabIndex = 1;
            this.label_day.Text = "Today";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter IP v4 Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter IP v6 Address:";
            // 
            // textBoxIPv4
            // 
            this.textBoxIPv4.Location = new System.Drawing.Point(152, 62);
            this.textBoxIPv4.Name = "textBoxIPv4";
            this.textBoxIPv4.Size = new System.Drawing.Size(138, 20);
            this.textBoxIPv4.TabIndex = 4;
            // 
            // textBoxIPv6
            // 
            this.textBoxIPv6.Location = new System.Drawing.Point(152, 93);
            this.textBoxIPv6.Name = "textBoxIPv6";
            this.textBoxIPv6.Size = new System.Drawing.Size(138, 20);
            this.textBoxIPv6.TabIndex = 5;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(25, 154);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "&Validate IP";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(130, 133);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReadnDisplay
            // 
            this.btnReadnDisplay.Location = new System.Drawing.Point(112, 183);
            this.btnReadnDisplay.Name = "btnReadnDisplay";
            this.btnReadnDisplay.Size = new System.Drawing.Size(111, 23);
            this.btnReadnDisplay.TabIndex = 8;
            this.btnReadnDisplay.Text = "Read and &Display";
            this.btnReadnDisplay.UseVisualStyleBackColor = true;
            this.btnReadnDisplay.Click += new System.EventHandler(this.btnReadnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(230, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // IP_Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(335, 229);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadnDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.textBoxIPv6);
            this.Controls.Add(this.textBoxIPv4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_day);
            this.Controls.Add(this.textBox_day);
            this.Name = "IP_Validator";
            this.Text = "IP Validator  Natalia Herrera";
            this.Load += new System.EventHandler(this.IP_Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_day;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIPv4;
        private System.Windows.Forms.TextBox textBoxIPv6;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReadnDisplay;
        private System.Windows.Forms.Button btnExit;
    }
}