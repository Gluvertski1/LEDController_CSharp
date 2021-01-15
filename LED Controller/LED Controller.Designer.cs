namespace WindowsFormsApplication1
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
            this.Quit = new System.Windows.Forms.Button();
            this.led1 = new System.Windows.Forms.CheckBox();
            this.led2 = new System.Windows.Forms.CheckBox();
            this.led4 = new System.Windows.Forms.CheckBox();
            this.led3 = new System.Windows.Forms.CheckBox();
            this.led8 = new System.Windows.Forms.CheckBox();
            this.led7 = new System.Windows.Forms.CheckBox();
            this.led6 = new System.Windows.Forms.CheckBox();
            this.led5 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DigPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(374, 274);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(144, 76);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // led1
            // 
            this.led1.AutoSize = true;
            this.led1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led1.Location = new System.Drawing.Point(55, 49);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(69, 24);
            this.led1.TabIndex = 1;
            this.led1.Text = "LED1";
            this.led1.UseVisualStyleBackColor = true;
            this.led1.CheckedChanged += new System.EventHandler(this.led1_CheckedChanged);
            // 
            // led2
            // 
            this.led2.AutoSize = true;
            this.led2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led2.Location = new System.Drawing.Point(55, 79);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(69, 24);
            this.led2.TabIndex = 2;
            this.led2.Text = "LED2";
            this.led2.UseVisualStyleBackColor = true;
            this.led2.CheckedChanged += new System.EventHandler(this.led2_CheckedChanged);
            // 
            // led4
            // 
            this.led4.AutoSize = true;
            this.led4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led4.Location = new System.Drawing.Point(55, 139);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(69, 24);
            this.led4.TabIndex = 4;
            this.led4.Text = "LED4";
            this.led4.UseVisualStyleBackColor = true;
            this.led4.CheckedChanged += new System.EventHandler(this.led4_CheckedChanged);
            this.led4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.led4_MouseClick);
            // 
            // led3
            // 
            this.led3.AutoSize = true;
            this.led3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led3.Location = new System.Drawing.Point(55, 109);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(69, 24);
            this.led3.TabIndex = 3;
            this.led3.Text = "LED3";
            this.led3.UseVisualStyleBackColor = true;
            this.led3.CheckedChanged += new System.EventHandler(this.led3_CheckedChanged);
            // 
            // led8
            // 
            this.led8.AutoSize = true;
            this.led8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led8.Location = new System.Drawing.Point(55, 259);
            this.led8.Name = "led8";
            this.led8.Size = new System.Drawing.Size(69, 24);
            this.led8.TabIndex = 8;
            this.led8.Text = "LED8";
            this.led8.UseVisualStyleBackColor = true;
            this.led8.CheckedChanged += new System.EventHandler(this.led8_CheckedChanged);
            // 
            // led7
            // 
            this.led7.AutoSize = true;
            this.led7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led7.Location = new System.Drawing.Point(55, 229);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(69, 24);
            this.led7.TabIndex = 7;
            this.led7.Text = "LED7";
            this.led7.UseVisualStyleBackColor = true;
            this.led7.CheckedChanged += new System.EventHandler(this.led7_CheckedChanged);
            // 
            // led6
            // 
            this.led6.AutoSize = true;
            this.led6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led6.Location = new System.Drawing.Point(55, 199);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(69, 24);
            this.led6.TabIndex = 6;
            this.led6.Text = "LED6";
            this.led6.UseVisualStyleBackColor = true;
            this.led6.CheckedChanged += new System.EventHandler(this.led6_CheckedChanged);
            // 
            // led5
            // 
            this.led5.AutoSize = true;
            this.led5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.led5.Location = new System.Drawing.Point(55, 169);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(69, 24);
            this.led5.TabIndex = 5;
            this.led5.Text = "LED5";
            this.led5.UseVisualStyleBackColor = true;
            this.led5.CheckedChanged += new System.EventHandler(this.led5_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(312, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Dev1/Port0";
            // 
            // DigPort
            // 
            this.DigPort.AutoSize = true;
            this.DigPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigPort.Location = new System.Drawing.Point(311, 45);
            this.DigPort.Name = "DigPort";
            this.DigPort.Size = new System.Drawing.Size(66, 20);
            this.DigPort.TabIndex = 11;
            this.DigPort.Text = "Dig Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DigPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.led8);
            this.Controls.Add(this.led7);
            this.Controls.Add(this.led6);
            this.Controls.Add(this.led5);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.Quit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LED Controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.CheckBox led1;
        private System.Windows.Forms.CheckBox led2;
        private System.Windows.Forms.CheckBox led4;
        private System.Windows.Forms.CheckBox led3;
        private System.Windows.Forms.CheckBox led8;
        private System.Windows.Forms.CheckBox led7;
        private System.Windows.Forms.CheckBox led6;
        private System.Windows.Forms.CheckBox led5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DigPort;
        private System.Windows.Forms.Label label1;
    }
}

