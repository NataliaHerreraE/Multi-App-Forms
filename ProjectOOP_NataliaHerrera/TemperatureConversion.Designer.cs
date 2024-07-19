namespace ProjectOOP_NataliaHerrera
{
    partial class TemperatureConversion
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
            this.radioCtoF = new System.Windows.Forms.RadioButton();
            this.radioFtoC = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.textTemp1 = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.textTemp2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioCtoF
            // 
            this.radioCtoF.AutoSize = true;
            this.radioCtoF.Location = new System.Drawing.Point(111, 38);
            this.radioCtoF.Name = "radioCtoF";
            this.radioCtoF.Size = new System.Drawing.Size(76, 17);
            this.radioCtoF.TabIndex = 0;
            this.radioCtoF.TabStop = true;
            this.radioCtoF.Text = "from C to F";
            this.radioCtoF.UseVisualStyleBackColor = true;
            this.radioCtoF.CheckedChanged += new System.EventHandler(this.radioCtoF_CheckedChanged);
            // 
            // radioFtoC
            // 
            this.radioFtoC.AutoSize = true;
            this.radioFtoC.Location = new System.Drawing.Point(111, 65);
            this.radioFtoC.Name = "radioFtoC";
            this.radioFtoC.Size = new System.Drawing.Size(76, 17);
            this.radioFtoC.TabIndex = 1;
            this.radioFtoC.TabStop = true;
            this.radioFtoC.Text = "from F to C";
            this.radioFtoC.UseVisualStyleBackColor = true;
            this.radioFtoC.CheckedChanged += new System.EventHandler(this.radioFtoC_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(190, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textTemp1
            // 
            this.textTemp1.Location = new System.Drawing.Point(30, 107);
            this.textTemp1.Name = "textTemp1";
            this.textTemp1.Size = new System.Drawing.Size(100, 20);
            this.textTemp1.TabIndex = 11;
            this.textTemp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(30, 188);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.Size = new System.Drawing.Size(233, 67);
            this.textBoxMessage.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "to";
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput2.Location = new System.Drawing.Point(204, 134);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(18, 18);
            this.labelInput2.TabIndex = 15;
            this.labelInput2.Text = "F";
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput1.Location = new System.Drawing.Point(70, 134);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(20, 18);
            this.labelInput1.TabIndex = 16;
            this.labelInput1.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Message:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(32, 276);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 18;
            this.btnConvert.TabStop = false;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(111, 276);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 19;
            this.btnReadFile.TabStop = false;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // textTemp2
            // 
            this.textTemp2.Location = new System.Drawing.Point(163, 107);
            this.textTemp2.Name = "textTemp2";
            this.textTemp2.ReadOnly = true;
            this.textTemp2.Size = new System.Drawing.Size(100, 20);
            this.textTemp2.TabIndex = 20;
            this.textTemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TemperatureConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(294, 318);
            this.Controls.Add(this.textTemp2);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelInput1);
            this.Controls.Add(this.labelInput2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textTemp1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.radioFtoC);
            this.Controls.Add(this.radioCtoF);
            this.Name = "TemperatureConversion";
            this.Text = "Temperature Conversion Natalia Herrera";
            this.Load += new System.EventHandler(this.TemperatureConversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCtoF;
        private System.Windows.Forms.RadioButton radioFtoC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textTemp1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox textTemp2;
    }
}