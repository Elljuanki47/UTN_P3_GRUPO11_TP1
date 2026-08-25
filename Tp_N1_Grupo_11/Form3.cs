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
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void ValidarAceptar()
        {
            bool tieneTexto = !string.IsNullOrWhiteSpace(txtNombre.Text);
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            //FALTA LA VALIDACION DE SI EXISTE EN LA LISTBOX
            else if (tb.Text.Length >= 50)
            {
                MessageBox.Show("Llegaste al limite maximo de 50 caracteres.");
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            ValidarAceptar();
        }
    }
}
