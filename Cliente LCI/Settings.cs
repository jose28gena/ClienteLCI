using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente_LCI
{
    public partial class Settings : Form
    {
        public static bool guardado;
        public Settings()
        {
            InitializeComponent();
            guardado = false;
            textBoxIP.Text = Properties.Settings.Default.IP;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxIP.Text == "")
            {
                MessageBox.Show("La dirección IP del servidor no debe de estar en blanco, para obtenerla puede consultar el servidor y presionar el botón 'Obtener IP'");
            }
            
            else
            {
                Properties.Settings.Default.IP = textBoxIP.Text;
                Properties.Settings.Default.Save();
                guardado = true;
                Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            if (textBoxIP.Text == "")
            {
                MessageBox.Show("La dirección IP del servidor no debe de estar en blanco, para obtenerla puede consultar el servidor y presionar el botón 'Obtener IP'");
            }
            else
            {
                Close();
            }
        }
    }
}
