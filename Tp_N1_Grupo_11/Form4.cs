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
    public partial class Ejercicio3 : Form
    {
        FormPrincipal formPrincipal;
        public Ejercicio3(FormPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            Habilitacion();
        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrincipal.Show();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            rbFemenino.Checked = true;
            rbCasado.Checked = true;
        }

        private void Habilitacion()
        {
            if (clbOficio.CheckedItems.Count > 0)
            {
                btnMostrar.Enabled = true;
            }
            else
            {
                btnMostrar.Enabled = false;
            }
        }

        private void clbOficio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Habilitacion();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        
    }
}

