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
    public partial class Punto3 : Form
    {
        public Punto3()
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
                richTextBox1.Text = filtrado.Nombre + "--" + filtrado.Descripcion + "--" + filtrado.fecha+"--"+filtrado.Precio;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new pruebaEntities())
            {
                int codigo = Convert.ToInt32(textBox1.Text);
                var data = db.fruta.Where(p => p.id == codigo).First();
                db.fruta.Remove(data);
                db.SaveChanges();
                MessageBox.Show("Se eliminó el producto");
                clearForm();
            }
        }

        public void clearForm()
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
        }
    }
}
