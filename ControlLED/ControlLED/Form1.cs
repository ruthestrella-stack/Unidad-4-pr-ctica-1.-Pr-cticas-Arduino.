using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ControlLED
{
    public partial class Form1 : Form
    {
        private SerialPort Arduino;

        public Form1()
        {
            InitializeComponent();

            // CONFIGURACIÓN ARDUINO - CAMBIA "COM3" SI ES NECESARIO
            Arduino = new SerialPort("COM3", 9600);
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Arduino.IsOpen)
                    Arduino.Open();

                Arduino.Write("F");
                MessageBox.Show("LED APAGADO - Comando F enviado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nConecta el Arduino y verifica el puerto COM");
            }
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Arduino.IsOpen)
                    Arduino.Open();

                Arduino.Write("E");
                MessageBox.Show("LED ENCENDIDO - Comando E enviado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nConecta el Arduino y verifica el puerto COM");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino != null && Arduino.IsOpen)
            {
                Arduino.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}