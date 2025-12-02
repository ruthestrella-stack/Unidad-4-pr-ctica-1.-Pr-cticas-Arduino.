using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace HyT
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool puertoCerrado = false;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.PortName = "COM8"; // Cambiado a COM4 como solicitaste
            serialPort.BaudRate = 9600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoCerrado == false)
            {
                conectar();
            }
            else
            {
                noConectado();
            }
        }

        private void conectar()
        {
            try
            {
                puertoCerrado = true;
                serialPort.Open();
                botonConectar.Text = "DESCONECTAR";
                botonConectar.BackColor = Color.Black;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void noConectado()
        {
            try
            {
                puertoCerrado = false;
                serialPort.Close();
                botonConectar.Text = "CONECTAR";
                botonConectar.BackColor = Color.Blue;
                listBox1.Items.Clear();
                temperaturalabel.Text = "TEMPERATURA °C";
                humedadLabel.Text = "HUMEDAD %";
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new MethodInvoker(delegate
            {
                string[] values = data.Split('\t');
                if (values.Length >= 2)
                {
                    // Buscar la temperatura y humedad en los datos recibidos
                    string temperatura = "";
                    string humedad = "";

                    foreach (string value in values)
                    {
                        if (value.Contains("Temperatura:") || value.Contains("*C"))
                        {
                            temperatura = value.Replace("Temperatura:", "").Replace("*C", "").Trim();
                        }
                        else if (value.Contains("Humedad:") || value.Contains("%"))
                        {
                            humedad = value.Replace("Humedad:", "").Replace("%", "").Trim();
                        }
                    }

                    // Si no encontramos con los separadores, intentamos otro método
                    if (string.IsNullOrEmpty(temperatura) || string.IsNullOrEmpty(humedad))
                    {
                        // Buscar números en el string
                        System.Text.RegularExpressions.MatchCollection matches =
                            System.Text.RegularExpressions.Regex.Matches(data, @"\d+\.\d+");

                        if (matches.Count >= 2)
                        {
                            humedad = matches[0].Value;
                            temperatura = matches[1].Value;
                        }
                    }

                    if (!string.IsNullOrEmpty(temperatura) && !string.IsNullOrEmpty(humedad))
                    {
                        temperaturalabel.Text = $"Temperatura: {temperatura} °C";
                        humedadLabel.Text = $"Humedad: {humedad} %";
                        listBox1.Items.Add($"{temperatura} °C    {humedad} %");

                        // Mantener solo las últimas 20 lecturas
                        if (listBox1.Items.Count > 20)
                        {
                            listBox1.Items.RemoveAt(0);
                        }
                    }
                }
            }));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Método vacío necesario para el evento
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código de carga del formulario si es necesario
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Cerrar el puerto serial antes de salir
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            Application.Exit();
        }
    }
}