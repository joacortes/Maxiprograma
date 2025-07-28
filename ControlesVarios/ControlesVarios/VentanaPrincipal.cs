using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesVarios
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            // Meto un comentario para subir a github como cambio
            InitializeComponent();
        }

       

        private void tspiPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya tenes abierta una ventana");
                    return;
                }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
