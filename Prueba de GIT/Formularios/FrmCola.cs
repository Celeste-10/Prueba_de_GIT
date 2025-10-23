using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_de_GIT.Formularios
{
    public partial class FrmCola : Form
    {
        //Se crea la cola
        Queue<int> cola = new Queue<int>();
        public FrmCola()
        {
            InitializeComponent();
        }

        private void FrmCola_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int elemento= Convert.ToInt32(tbElemento.Text);
            //Agrega el elemento que ingresa el usuario a la cola
            cola.Enqueue(elemento);
            MessageBox.Show("Elemento agregado a la cola");
            tbElemento.Clear();
            tbElemento.Focus();
            ActualizarVista();
        }

        //Se crea para actualizar la vista de la cola en el label
        private void ActualizarVista()
        {
            lblElemento.Text = string.Join(" |", cola);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Elimina el primer elemento ingresado en la cola
            cola.Dequeue();
            MessageBox.Show("Elemento eliminado de la cola");
            ActualizarVista();
        }

        private void btnPrimerElemento_Click(object sender, EventArgs e)
        {
            //Cola.Peek() permite ver el primer elemento de la cola sin eliminarlo
            MessageBox.Show("El primer elemento de la cola es: " + cola.Peek());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Muestra la cantidad de elementos en la cola
            MessageBox.Show("La cantidad de elementos en la cola es: " + cola.Count);
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            //Vacía la cola
            cola.Clear();
            ActualizarVista();
        }
    }
            
}
