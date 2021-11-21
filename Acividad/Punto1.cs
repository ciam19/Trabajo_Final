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
    public partial class Punto1 : Form
    {
        public Punto1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new pruebaEntities())
            {
                fruta fruta = new fruta();
                fruta.Nombre = textBox1.Text;
                fruta.Descripcion = richTextBox1.Text;
                fruta.Precio = textBox3.Text;
                fruta.fecha = Convert.ToDateTime(dateTimePicker1.Text);
                db.fruta.Add(fruta);
                db.SaveChanges();
                clearForm();
                MessageBox.Show("Se creó el producto");
            }
        }

        public void clearForm()
        {
            DateTime today = DateTime.Today;
            textBox1.Text = "";
            richTextBox1.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = today.ToString();
        }
    }
}
