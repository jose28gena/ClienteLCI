using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Cliente_LCI
{
    public partial class Form1 : Form
    {
        public static TcpClient Cliente = new TcpClient();
        public static String Recibido = "";
        public string IP;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerServidor_Tick(object sender, EventArgs e)
        {
            IP = Properties.Settings.Default.IP;
            try
            {
                Actualizar("."); 
                if (Cliente.Connected == false)
                {
                    Actualizar("0");
                    inOut.Enviar(Cliente, "SS");

                   
                }
                if (Cliente != null && Cliente.Connected == false)
                {
                    Actualizar("0");
                    inOut.Enviar(Cliente, "SS");

                    Cliente.Close();
                    Cliente = new TcpClient();
                    Cliente.Connect(IPAddress.Parse(IP), 4000);
                    label2.Text = "Conectando con el servicio..."+IP;
                }
                else
                {
                    if (Cliente.Available > 0)
                    {
                        Recibido = inOut.Recibir(Cliente);
                        label2.Text = Recibido;
                        //MessageBox.Show("Estado y Recibido: " + lblEstado.Text);
                        Cliente.Close();
                        Cliente = new TcpClient();
                        timerServidor.Enabled = false;
                        timerCliente.Enabled = true;
                        botonCIP.Enabled = false;
                    }
                }
            }
            catch (SocketException) { label2.Text = "Error de conexión... Es probable que la IP del servidor sea incorrecta o el \r\nservidor este apagado.";
            timerServidor.Enabled = true;
            timerCliente.Enabled = false;/*Cliente = new TcpClient();*/
            }
        }

        private void timerCliente_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Cliente != null && Cliente.Connected == false)
                {
                    inOut.Enviar(Cliente, "SS");

                    Cliente.Close();
                    Cliente = new TcpClient();
                    Cliente.Connect(IPAddress.Parse(IP), Convert.ToInt32(Recibido));
                    label2.Text = Cliente.Client.RemoteEndPoint.ToString();
                    inOut.Enviar(Cliente, "NN;" + Properties.Settings.Default.noombre);
                    //MessageBox.Show("Estado: " + lblEstado.Text);
                }
                else
                {
                    if (Cliente.Available > 0)
                    {
                        Recibido = inOut.Recibir(Cliente);
                        //MessageBox.Show("Recibido: " + Recibido);
                        if (Recibido == "BB")
                        {
                            //Bloquear();
                            Actualizar(Recibido);
                        }
                        else if (Recibido.StartsWith("DD"))
                        {
                            //Desbloquear();
                            Actualizar(Recibido);
                        }
                        else if (Recibido == "SS")
                        {
                            Actualizar(Recibido);
                            Cliente.Close();
                            Cliente = new TcpClient();
                            timerServidor.Enabled = true;
                            timerCliente.Enabled = false;
                        }
                        
                        else
                        {
                            inOut.Enviar(Cliente, Recibido);
                            Actualizar(Recibido);
                        }
                    }
                }
            }
            catch (Exception )
            {
                label2.Text = "Error de conexion 1"; 
                timerServidor.Enabled = true;
                timerCliente.Enabled = false ;
               //Cliente = new TcpClient();
            }
        }

        public void Actualizar(string r)
        {
            textBox1.Text += r;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.noombre == ""||Properties.Settings.Default.IP=="")
            {
                crear();
            }
            else
            {
                label2.Text = "Conectando con el servidor..."+IP;
                timerServidor.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cliente.Connected == true)
            {
                inOut.Enviar(Cliente, "SS");
                //Desbloquear();
                Cliente.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inOut.Enviar(Cliente, "admin;¿Qué pedo?");
            //MessageBox.Show("Mensaje a mandar: MM" + Properties.Settings.Default.noombre.Substring(0, 1) + ";recepcion");
            //inOut.Enviar(Cliente, "MM" + Properties.Settings.Default.noombre.Substring(0, 1) + ";recepcion");
            inOut.Enviar(Cliente, "MM" + "bloquear" + ";A2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inOut.Enviar(Cliente, "BB" + "A");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inOut.Enviar(Cliente, "DD" + "A");
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonCIP_Click(object sender, EventArgs e)
        {
            crear();
        }

        private void crear()
        {
            Settings f = new Settings();
            f.ShowDialog();
            if (Settings.guardado)
            {
                label2.Text = "Conectando con el servidor..."+IP;
                timerServidor.Enabled = true;
            }
        }

        private void botonCNombre_Click(object sender, EventArgs e)
        {
            CambiarNombre f = new CambiarNombre();
            f.ShowDialog();
            if (!botonCIP.Enabled && CambiarNombre.cambiado)
            {
                inOut.Enviar(Cliente, "NN;"+Properties.Settings.Default.noombre);
            }
        }
    }
}
