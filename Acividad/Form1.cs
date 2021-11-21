using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punto1 punto1 = new Punto1();
            punto1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Punto2 punto1 = new Punto2();
            punto1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Punto3 punto1 = new Punto3();
            punto1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Punto4 punto1 = new Punto4();
            punto1.Show();
        }
    }
}
