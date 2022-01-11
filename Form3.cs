using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_BD
{
    public partial class Form3 : Form
    {
        DataTable mass;
        public Form3(ref DataTable mass)
        {
            InitializeComponent();
            this.mass = mass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            try
            {
                if (name == "")
                    throw new Exception("exc");
                mass.WriteXml($"{name}.xml");
                MessageBox.Show("Файл сохранен");
            }
            catch
            {
                MessageBox.Show("Недопустивое имя", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
