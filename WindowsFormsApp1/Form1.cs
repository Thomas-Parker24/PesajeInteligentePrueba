using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Testing(object sender, EventArgs e)
        {
            MessageBox.Show("Alerta", "¿Funciona?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
        }
    }
}
