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
    public partial class Punto2 : Form
    {
        public Punto2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Punto2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new pruebaEntities())
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                var resultado = db.fruta.Where(p => p.id == codigo).ToList();
                if (resultado.Count() ==0)
                {
                    MessageBox.Show("No se encontró un producto");
                    textBox1.Text = ""; 
                    return;
                }
                var filtrado = resultado.FirstOrDefault();
                textBox2.Text = filtrado.Nombre;
                richTextBox1.Text = filtrado.Descripcion;
                textBox4.Text ="$"+ filtrado.Precio;

            }
        }
    }
}
