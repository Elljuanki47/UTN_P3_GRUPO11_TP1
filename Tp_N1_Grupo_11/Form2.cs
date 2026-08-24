using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tp_N1_Grupo_11
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
            ValidarAceptar();
        }
        private bool ExisteNombre(string nombre)
        {
            foreach (var item in Box1.Items)
            {
                if (item.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void ValidarAceptar()
        {
            bool tieneNombre = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool mismonombre = ExisteNombre(txtNombre.Text);
            btnAceptar.Enabled = tieneNombre && !mismonombre;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else if (ExisteNombre(tb.Text))
            {
                tb.BackColor = Color.Red;
            }
            else if (tb.Text.Length == 50)
            {
                MessageBox.Show("Llegaste al límite máximo de 50 caracteres.");
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidarAceptar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Box1.Items.Add(txtNombre.Text);
            txtNombre.Clear();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
        private void btnMoverUno_Click(object sender, EventArgs e)
        {
            if (Box1.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un nombre para mover.");
                return;
            }

            string nombre = Box1.SelectedItem.ToString();

            if(Box1.SelectedItem != null)
            {
                lstSeleccionados.Items.Add(nombre);
                Box1.Items.Remove(nombre);
            }
            
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            if (Box1.Items.Count == 0)
            {
                MessageBox.Show("No hay nombres para mover.");
                return;
            }

            while (Box1.Items.Count > 0)
            {
                lstSeleccionados.Items.Add(Box1.Items[0]);
                Box1.Items.RemoveAt(0);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
