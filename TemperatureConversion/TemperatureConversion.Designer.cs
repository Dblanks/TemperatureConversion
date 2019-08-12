namespace TemperatureConversion
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
            this.lblTemperature = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFahren = new System.Windows.Forms.RadioButton();
            this.rdCelsius = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(27, 37);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(98, 13);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Enter Temperature:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(90, 88);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFahren);
            this.groupBox1.Controls.Add(this.rdCelsius);
            this.groupBox1.Location = new System.Drawing.Point(93, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Conversion";
            // 
            // rdFahren
            // 
            this.rdFahren.AutoSize = true;
            this.rdFahren.Checked = true;
            this.rdFahren.Location = new System.Drawing.Point(15, 55);
            this.rdFahren.Name = "rdFahren";
            this.rdFahren.Size = new System.Drawing.Size(87, 17);
            this.rdFahren.TabIndex = 1;
            this.rdFahren.TabStop = true;
            this.rdFahren.Text = "to Fahrenheit";
            this.rdFahren.UseVisualStyleBackColor = true;
            // 
            // rdCelsius
            // 
            this.rdCelsius.AutoSize = true;
            this.rdCelsius.Location = new System.Drawing.Point(15, 19);
            this.rdCelsius.Name = "rdCelsius";
            this.rdCelsius.Size = new System.Drawing.Size(70, 17);
            this.rdCelsius.TabIndex = 0;
            this.rdCelsius.TabStop = true;
            this.rdCelsius.Text = "to Celsius";
            this.rdCelsius.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(197, 276);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(1, -1);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(489, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temperature conversion application to convert between Celsius and Fahrenheit.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTemperature);
            this.Name = "Form1";
            this.Text = "Temperature Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFahren;
        private System.Windows.Forms.RadioButton rdCelsius;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label label1;
    }
}

