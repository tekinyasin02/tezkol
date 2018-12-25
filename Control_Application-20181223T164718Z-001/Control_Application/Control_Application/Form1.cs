using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Control_Application
{
    public partial class Form1 : Form
    {
  

        public Form1()
        {

            KeyPreview = true;
            InitializeComponent();
            getAvilablePorts();
        }
        void getAvilablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void trackBarServo_0_Scroll(object sender, EventArgs e)
        {
            int servoAci = trackBarServo_0.Value;

            if (serialPort1.IsOpen)
            {
                labelServoAci_0.Text = "Açı: " + servoAci.ToString();
                veriGonder(0, servoAci);

            }

        }

        private void trackBarServo_1_Scroll(object sender, EventArgs e)
        {
            int servoAci = trackBarServo_1.Value;

            if (serialPort1.IsOpen)
            {
                labelServoAci_1.Text = "Açı: " + servoAci.ToString();
                veriGonder(1, servoAci);

            }

        }

        private void trackBarServo_2_Scroll(object sender, EventArgs e)
        {
            int servoAci = trackBarServo_2.Value;

            if (serialPort1.IsOpen)
            {
                labelServoAci_2.Text = "Açı: " + servoAci.ToString();
                veriGonder(2, servoAci);

            }

        }

        private void trackBarServo_3_Scroll(object sender, EventArgs e)
        {
            int servoAci = trackBarServo_3.Value;

            if (serialPort1.IsOpen)
            {
                labelServoAci_3.Text = "Açı: " + servoAci.ToString();
                veriGonder(3, servoAci);

            }

        }

        private void veriGonder(int channel, int pos)
        {
            string message = channel.ToString() + ':' + pos.ToString() + '*';

            try
            {
                serialPort1.Write(message);

            }
            catch
            {

            }

        }

        private void sifirla()
        {
            int[] sifirAci = { 90 ,90,60,75};

            trackBarServo_0.Value = sifirAci[0];
            trackBarServo_1.Value = sifirAci[1];
            trackBarServo_2.Value = sifirAci[2];
            trackBarServo_3.Value = sifirAci[3];

            labelServoAci_0.Text = "Açı: " + sifirAci[0].ToString();
            labelServoAci_1.Text = "Açı: " + sifirAci[1].ToString();
            labelServoAci_2.Text = "Açı: " + sifirAci[2].ToString();
            labelServoAci_3.Text = "Açı: " + sifirAci[3].ToString();

            for (int channel = 0; channel < 4; channel++)
            {
                veriGonder(channel, sifirAci[channel]);

            }

        }

        private void buttonResetServos_Click(object sender, EventArgs e)
        {
            sifirla();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sifirla();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelServoPos_3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                sifirla();
            }
            catch
            {
                serialPort1.Close();
                MessageBox.Show("Bağlantı Hatası");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (trackBarServo_0.Value != 0)
                {
                    trackBarServo_0.Value = trackBarServo_0.Value-1;
                  
                }
                int servoAci = trackBarServo_0.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_0.Text = "Açı: " + servoAci.ToString();
                    veriGonder(0, servoAci);

                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (trackBarServo_0.Value != 180)
                {
                    trackBarServo_0.Value = trackBarServo_0.Value + 1;

                }
                int servoAci = trackBarServo_0.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_0.Text = "Açı: " + servoAci.ToString();
                    veriGonder(0, servoAci);

                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (trackBarServo_2.Value != 140)
                {
                    trackBarServo_2.Value = trackBarServo_2.Value + 1;

                }
                int servoAci = trackBarServo_2.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_2.Text = "Açı: " + servoAci.ToString();
                    veriGonder(2, servoAci);

                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (trackBarServo_2.Value != 60)
                {
                    trackBarServo_2.Value = trackBarServo_2.Value - 1;

                }
                int servoAci = trackBarServo_2.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_2.Text = "Açı: " + servoAci.ToString();
                    veriGonder(2, servoAci);

                }
            }
            if (e.KeyCode == Keys.Q)
            {
                if (trackBarServo_1.Value != 90)
                {
                    trackBarServo_1.Value = trackBarServo_1.Value - 1;

                }
                int servoAci = trackBarServo_1.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_1.Text = "Açı: " + servoAci.ToString();
                    veriGonder(1, servoAci);

                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (trackBarServo_1.Value != 180)
                {
                    trackBarServo_1.Value = trackBarServo_1.Value + 1;

                }
                int servoAci = trackBarServo_1.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_1.Text = "Açı: " + servoAci.ToString();
                    veriGonder(1, servoAci);

                }
            }
            if (e.KeyCode == Keys.O)
            {
                if (trackBarServo_3.Value != 75)
                {
                    trackBarServo_3.Value = trackBarServo_3.Value - 1;

                }
                int servoAci = trackBarServo_3.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoAci_3.Text = "Açı: " + servoAci.ToString();
                    veriGonder(3, servoAci);

                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (trackBarServo_3.Value != 180)
                {
                    trackBarServo_3.Value = trackBarServo_3.Value + 1;

                }
                int servoAci = trackBarServo_3.Value;
                if (serialPort1.IsOpen)
                
                    labelServoAci_3.Text = "Açı: " + servoAci.ToString();
                    veriGonder(3, servoAci);

                }
            }
        }
    }


