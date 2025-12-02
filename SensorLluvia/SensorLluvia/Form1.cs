using System;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;

namespace SensorLluvia

{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isBlinking;
        private SoundPlayer soundPlayer;
        private bool conexionActiva = false;

        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM8", 9600); // Configurado en COM4
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            timer1.Interval = 1500; // Intervalo de parpadeo en milisegundos
            timer1.Tick += new EventHandler(this.timer1_Tick);
            
            // Usar un sonido del sistema si no existe el archivo
            try
            {
                soundPlayer = new SoundPlayer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el sonido: " + ex.Message);
            }
        }

        private void botonComenzar_Click(object sender, EventArgs e)
        {
            if (!conexionActiva)
            {
                try
                {
                    serialPort.Open();
                    conexionActiva = true;
                    botonComenzar.Text = "DETENER";
                    botonComenzar.BackColor = System.Drawing.Color.Orange;
                    labelEstado.Text = "Sensor Status: Conectado";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir puerto: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    serialPort.Close();
                    conexionActiva = false;
                    botonComenzar.Text = "Comenzar";
                    botonComenzar.BackColor = System.Drawing.Color.Green;
                    labelEstado.Text = "Sensor Status: Desconectado";

                    // Detener efectos
                    if (isBlinking)
                    {
                        timer1.Stop();
                        if (soundPlayer != null)
                            soundPlayer.Stop();
                        pictureBox1.BackColor = System.Drawing.Color.Gray;
                        isBlinking = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cerrar puerto: " + ex.Message);
                }
            }
        }

        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                this.Invoke(new Action(() => {
                    string valor = data.Trim();
                    if (valor == "0" || valor == "1")
                    {
                        labelEstado.Text = "Sensor Status: " + (valor == "0" ? "Water Detected" : "No Water");

                        if (valor == "0") // Agua detectada
                        {
                            if (!isBlinking)
                            {
                                timer1.Start();
                                // Intentar reproducir sonido del sistema
                                SystemSounds.Exclamation.Play();
                                pictureBox1.BackColor = System.Drawing.Color.Red;
                                isBlinking = true;
                            }
                        }
                        else // No hay agua
                        {
                            if (isBlinking)
                            {
                                timer1.Stop();
                                if (soundPlayer != null)
                                    soundPlayer.Stop();
                                pictureBox1.BackColor = System.Drawing.Color.Green;
                                isBlinking = false;
                            }
                        }
                    }
                }));
            }
            catch (Exception )
            {
                // Manejar error de lectura
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Efecto de parpadeo cuando se detecta agua
            pictureBox1.BackColor = pictureBox1.BackColor == System.Drawing.Color.Gray ?
                                  System.Drawing.Color.Red : System.Drawing.Color.Gray;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            Application.Exit();
        }

        protected void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código de carga si es necesario
        }
    }
}