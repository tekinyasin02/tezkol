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
            int servoPos = trackBarServo_0.Value;

            if (serialPort1.IsOpen)
            {
                labelServoPos_0.Text = "Açı: " + servoPos.ToString();
                SendServoInfo(0, servoPos);

            }

        }

        private void trackBarServo_1_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_1.Value;

            if (serialPort1.IsOpen)
            {
                labelServoPos_1.Text = "Açı: " + servoPos.ToString();
                SendServoInfo(1, servoPos);

            }

        }

        private void trackBarServo_2_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_2.Value;

            if (serialPort1.IsOpen)
            {
                labelServoPos_2.Text = "Açı: " + servoPos.ToString();
                SendServoInfo(2, servoPos);

            }

        }

        private void trackBarServo_3_Scroll(object sender, EventArgs e)
        {
            int servoPos = trackBarServo_3.Value;

            if (serialPort1.IsOpen)
            {
                labelServoPos_3.Text = "Açı: " + servoPos.ToString();
                SendServoInfo(3, servoPos);

            }

        }

        private void SendServoInfo(int channel, int pos)
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

        private void ResetServos()
        {
            int[] centrePosition = { 90 ,90,60,75};

            trackBarServo_0.Value = centrePosition[0];
            trackBarServo_1.Value = centrePosition[1];
            trackBarServo_2.Value = centrePosition[2];
            trackBarServo_3.Value = centrePosition[3];

            labelServoPos_0.Text = "Açı: " + centrePosition[0].ToString();
            labelServoPos_1.Text = "Açı: " + centrePosition[1].ToString();
            labelServoPos_2.Text = "Açı: " + centrePosition[2].ToString();
            labelServoPos_3.Text = "Açı: " + centrePosition[3].ToString();

            for (int channel = 0; channel < 4; channel++)
            {
                SendServoInfo(channel, centrePosition[channel]);

            }

        }

        private void buttonResetServos_Click(object sender, EventArgs e)
        {
            ResetServos();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetServos();

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
                ResetServos();
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
                int servoPos = trackBarServo_0.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_0.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(0, servoPos);

                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (trackBarServo_0.Value != 180)
                {
                    trackBarServo_0.Value = trackBarServo_0.Value + 1;

                }
                int servoPos = trackBarServo_0.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_0.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(0, servoPos);

                }
            }
            if (e.KeyCode == Keys.W)
            {
                if (trackBarServo_2.Value != 140)
                {
                    trackBarServo_2.Value = trackBarServo_2.Value + 1;

                }
                int servoPos = trackBarServo_2.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_2.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(2, servoPos);

                }
            }
            if (e.KeyCode == Keys.S)
            {
                if (trackBarServo_2.Value != 60)
                {
                    trackBarServo_2.Value = trackBarServo_2.Value - 1;

                }
                int servoPos = trackBarServo_2.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_2.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(2, servoPos);

                }
            }
            if (e.KeyCode == Keys.Q)
            {
                if (trackBarServo_1.Value != 90)
                {
                    trackBarServo_1.Value = trackBarServo_1.Value - 1;

                }
                int servoPos = trackBarServo_1.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_1.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(1, servoPos);

                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (trackBarServo_1.Value != 180)
                {
                    trackBarServo_1.Value = trackBarServo_1.Value + 1;

                }
                int servoPos = trackBarServo_1.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_1.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(1, servoPos);

                }
            }
            if (e.KeyCode == Keys.O)
            {
                if (trackBarServo_3.Value != 75)
                {
                    trackBarServo_3.Value = trackBarServo_3.Value - 1;

                }
                int servoPos = trackBarServo_3.Value;
                if (serialPort1.IsOpen)
                {
                    labelServoPos_3.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(3, servoPos);

                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (trackBarServo_3.Value != 180)
                {
                    trackBarServo_3.Value = trackBarServo_3.Value + 1;

                }
                int servoPos = trackBarServo_3.Value;
                if (serialPort1.IsOpen)
                
                    labelServoPos_3.Text = "Açı: " + servoPos.ToString();
                    SendServoInfo(3, servoPos);

                }
            }
        }
    }


