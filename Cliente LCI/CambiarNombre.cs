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
    public partial class CambiarNombre : Form
    {
        public static bool cambiado;
        public CambiarNombre()
        {
            InitializeComponent();
            cambiado = false;
            textBoxNombre.Text = Properties.Settings.Default.noombre;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("La referencia del equipo no debe de estar en blanco, debe de tener un nombre parecido a los ejemplos que se muestran.");
            }
            else
            {
                Properties.Settings.Default.noombre = textBoxNombre.Text;
                Properties.Settings.Default.Save();
                cambiado = true;
                Close();
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("La referencia del equipo no debe de estar en blanco, debe de tener un nombre parecido a los ejemplos que se muestran.");
            }
            else
            {
                Close();
            }
        }
    }
}
