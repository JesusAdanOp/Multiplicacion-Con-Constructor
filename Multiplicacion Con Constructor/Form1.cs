using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicacion_Con_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            clmult mult = new clmult(int.Parse(txtV1.Text), int.Parse(txtV2.Text));
            txtResult.Text = mult.multiplicacion().ToString();
        }
    }
}
