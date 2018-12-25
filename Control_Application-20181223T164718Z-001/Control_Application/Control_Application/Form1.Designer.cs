namespace RobotKolKontrol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelServoAci_0 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarServo_0 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelServoAci_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarServo_1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelServoAci_2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarServo_2 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelServoAci_3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trackBarServo_3 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonResetServos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_0)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot Kol Kontrol";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelServoAci_0);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trackBarServo_0);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 155);
            this.panel1.TabIndex = 1;
            // 
            // labelServoAci_0
            // 
            this.labelServoAci_0.AutoSize = true;
            this.labelServoAci_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoAci_0.Location = new System.Drawing.Point(320, 107);
            this.labelServoAci_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServoAci_0.Name = "labelServoAci_0";
            this.labelServoAci_0.Size = new System.Drawing.Size(60, 31);
            this.labelServoAci_0.TabIndex = 4;
            this.labelServoAci_0.Text = "Açı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(688, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "180";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "0";
            // 
            // trackBarServo_0
            // 
            this.trackBarServo_0.Location = new System.Drawing.Point(69, 48);
            this.trackBarServo_0.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarServo_0.Maximum = 180;
            this.trackBarServo_0.Name = "trackBarServo_0";
            this.trackBarServo_0.Size = new System.Drawing.Size(623, 56);
            this.trackBarServo_0.TabIndex = 1;
            this.trackBarServo_0.Scroll += new System.EventHandler(this.trackBarServo_0_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sol-Sağ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelServoAci_1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.trackBarServo_1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(13, 246);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 155);
            this.panel2.TabIndex = 2;
            // 
            // labelServoAci_1
            // 
            this.labelServoAci_1.AutoSize = true;
            this.labelServoAci_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoAci_1.Location = new System.Drawing.Point(320, 107);
            this.labelServoAci_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServoAci_1.Name = "labelServoAci_1";
            this.labelServoAci_1.Size = new System.Drawing.Size(60, 31);
            this.labelServoAci_1.TabIndex = 4;
            this.labelServoAci_1.Text = "Açı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(688, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "180";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "90";
            // 
            // trackBarServo_1
            // 
            this.trackBarServo_1.Location = new System.Drawing.Point(69, 48);
            this.trackBarServo_1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarServo_1.Maximum = 180;
            this.trackBarServo_1.Minimum = 90;
            this.trackBarServo_1.Name = "trackBarServo_1";
            this.trackBarServo_1.Size = new System.Drawing.Size(623, 56);
            this.trackBarServo_1.TabIndex = 1;
            this.trackBarServo_1.Value = 90;
            this.trackBarServo_1.Scroll += new System.EventHandler(this.trackBarServo_1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Aşağı-Yukarı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.labelServoAci_2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.trackBarServo_2);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(13, 409);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 155);
            this.panel3.TabIndex = 3;
            // 
            // labelServoAci_2
            // 
            this.labelServoAci_2.AutoSize = true;
            this.labelServoAci_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoAci_2.Location = new System.Drawing.Point(320, 107);
            this.labelServoAci_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServoAci_2.Name = "labelServoAci_2";
            this.labelServoAci_2.Size = new System.Drawing.Size(60, 31);
            this.labelServoAci_2.TabIndex = 4;
            this.labelServoAci_2.Text = "Açı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(688, 48);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 31);
            this.label11.TabIndex = 3;
            this.label11.Text = "140";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "60";
            // 
            // trackBarServo_2
            // 
            this.trackBarServo_2.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarServo_2.Location = new System.Drawing.Point(69, 48);
            this.trackBarServo_2.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarServo_2.Maximum = 140;
            this.trackBarServo_2.Minimum = 60;
            this.trackBarServo_2.Name = "trackBarServo_2";
            this.trackBarServo_2.Size = new System.Drawing.Size(623, 56);
            this.trackBarServo_2.TabIndex = 1;
            this.trackBarServo_2.Value = 60;
            this.trackBarServo_2.Scroll += new System.EventHandler(this.trackBarServo_2_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(292, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 31);
            this.label13.TabIndex = 0;
            this.label13.Text = "Geri-İleri";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.labelServoAci_3);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.trackBarServo_3);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(13, 572);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 155);
            this.panel4.TabIndex = 4;
            // 
            // labelServoAci_3
            // 
            this.labelServoAci_3.AutoSize = true;
            this.labelServoAci_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServoAci_3.Location = new System.Drawing.Point(320, 107);
            this.labelServoAci_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServoAci_3.Name = "labelServoAci_3";
            this.labelServoAci_3.Size = new System.Drawing.Size(60, 31);
            this.labelServoAci_3.TabIndex = 4;
            this.labelServoAci_3.Text = "Açı:";
            this.labelServoAci_3.Click += new System.EventHandler(this.labelServoPos_3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(688, 48);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 31);
            this.label15.TabIndex = 3;
            this.label15.Text = "180";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 48);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 31);
            this.label16.TabIndex = 2;
            this.label16.Text = "75";
            // 
            // trackBarServo_3
            // 
            this.trackBarServo_3.Location = new System.Drawing.Point(69, 48);
            this.trackBarServo_3.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarServo_3.Maximum = 180;
            this.trackBarServo_3.Minimum = 75;
            this.trackBarServo_3.Name = "trackBarServo_3";
            this.trackBarServo_3.Size = new System.Drawing.Size(623, 56);
            this.trackBarServo_3.TabIndex = 1;
            this.trackBarServo_3.Value = 75;
            this.trackBarServo_3.Scroll += new System.EventHandler(this.trackBarServo_3_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(285, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 31);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tut-Bırak";
            // 
            // buttonResetServos
            // 
            this.buttonResetServos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetServos.Location = new System.Drawing.Point(305, 735);
            this.buttonResetServos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResetServos.Name = "buttonResetServos";
            this.buttonResetServos.Size = new System.Drawing.Size(181, 50);
            this.buttonResetServos.TabIndex = 5;
            this.buttonResetServos.Text = "Sıfırla";
            this.buttonResetServos.UseVisualStyleBackColor = true;
            this.buttonResetServos.Click += new System.EventHandler(this.buttonResetServos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "BAĞLAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 12);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(238, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bağlantı Yok!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(801, 793);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonResetServos);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Kol Kontrol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_0)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarServo_0;
        private System.Windows.Forms.Label labelServoAci_0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelServoAci_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarServo_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelServoAci_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarServo_2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelServoAci_3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trackBarServo_3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonResetServos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Label label3;
    }
}

