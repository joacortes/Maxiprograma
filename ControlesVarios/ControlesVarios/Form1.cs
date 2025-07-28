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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            string nombre = txtBanda.Text;
            string fechaCreacion = dtpCreacion.Value.ToString();
            
            string gusto;

            if (rbRock.Checked)
                gusto = "Por lo que veo te gusta el rock";
            else if (rbCumbia.Checked)
                gusto = "Sos un vigilante, te gusta la cumbia";
            else
                gusto = "Bueno, por lo menos no elegiste cumbia";
            
            MessageBox.Show($"Has ingresado la banda {nombre}, la cual fue fundada el día {fechaCreacion}\n{gusto}");
        }
    }
}
