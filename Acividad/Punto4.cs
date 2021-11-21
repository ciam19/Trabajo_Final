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
    public partial class Punto4 : Form
    {
        public Punto4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new pruebaEntities())
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                var resultado = db.fruta.Where(p => p.id == codigo).ToList();
                if (resultado.Count() == 0)
                {
                    MessageBox.Show("No se encontró un producto");
                    textBox1.Text = "";
                    return;
                }
                var filtrado = resultado.FirstOrDefault();
                textBox2.Text = filtrado.Precio;
                richTextBox1.Text = filtrado.Descripcion;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new pruebaEntities())
            {
                int dato = Convert.ToInt32(textBox1.Text);
                var data = db.fruta.Where(p => p.id == dato).First();
                data.Precio = textBox2.Text;
                data.Descripcion = richTextBox1.Text;
                db.SaveChanges();
                ClearForm();
                MessageBox.Show("Se actualizó el producto");
            }
        }

        public void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }
    }
}
