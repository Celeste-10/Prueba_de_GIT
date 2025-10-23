using Prueba_de_GIT.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            //Cuando el usuario hace click en el boton de pila, se abre el formulario de pila
            FrmPila frmPila = new FrmPila();
            frmPila.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCola_Click(object sender, EventArgs e)
        {
            //Cuando el usuario hace click en el boton de cola, se abre el formulario de cola
            FrmCola frmCola = new FrmCola();
            frmCola.ShowDialog();
        }
    }
}
