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
    public partial class FrmPila : Form
    {
        //Se crea la pila
        Stack<int> Pila = new Stack<int>();
        public FrmPila()
        {
            InitializeComponent();
        }

        private void FrmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbElemento.Text))
            {
                MessageBox.Show("Debe ingresar un número");
                return;
            }

            int elemento= Convert.ToInt32(tbElemento.Text);
            //Agrega el elemento que ingresa el usuario a la pila
            Pila.Push(elemento);
            MessageBox.Show("Elemento agregado a la pila");
            tbElemento.Clear();
            tbElemento.Focus();
            ActualizarVista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Count == 0)
            {
                MessageBox.Show("La pila está vacía");
                return;
            }
            //Elimina el ultimo elemento ingresado
            Pila.Pop();
            MessageBox.Show("Elemento eliminado de la pila");
            ActualizarVista();
        }

        //Se crea para actualizar la vista de la pila
        private void ActualizarVista()
        {
            //Se muestra la pila en el label, se usa Reverse para mostrar el orden correcto
            lblPila.Text = string.Join(" |", Pila.Reverse());
        }

        private void btnPrimerElemento_Click(object sender, EventArgs e)
        {
            //Pila.Peek() permite ver el primer elemento de la pila sin eliminarlo
            MessageBox.Show("El primer elemento de la pila es: " + Pila.Peek());
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            //Elimina todos los elementos de la pila
            Pila.Clear();
            ActualizarVista();
        }
    }
}
