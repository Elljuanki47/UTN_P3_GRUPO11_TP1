using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_N1_Grupo_11
{
    public partial class Ejercicio2 : Form
    {
        FormPrincipal formPrincipal;
        public Ejercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            ValidarAceptar();
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void ValidarAceptar()
        {
            bool tieneNombre = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool tieneApellido = !string.IsNullOrWhiteSpace(txtApellido.Text);

            string persona = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();
            bool personaRepetida = ExistePersona(persona);

            btnAgregar.Enabled = tieneNombre && tieneApellido && !personaRepetida;
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else if (ExistePersona(txtNombre.Text.Trim() + " " + txtApellido.Text.Trim()))
            {
                tb.BackColor = Color.LightCoral;
            }
            else if (tb.Text.Length >= 25)
            {
                MessageBox.Show("Llegaste al limite maximo de 50 caracteres.");
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidarAceptar();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LstElementos.Items.Add(txtNombre.Text.Trim() + " " + txtApellido.Text.Trim());
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (LstElementos.SelectedIndex != -1)
            {
                LstElementos.Items.RemoveAt(LstElementos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un item para borrar" , "Atencion");
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else if (ExistePersona(txtNombre.Text.Trim() + " " + txtApellido.Text.Trim()))
            {
                tb.BackColor = Color.LightCoral;
            }
            else if (tb.Text.Length >= 25)
            {
                MessageBox.Show("Llegaste al limite maximo de 50 caracteres.");
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidarAceptar();
        }

        private bool ExistePersona(string persona)
        {
            foreach (var item in LstElementos.Items)
            {
                if (item.ToString().Equals(persona, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
