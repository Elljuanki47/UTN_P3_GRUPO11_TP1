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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblIntegrante3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
