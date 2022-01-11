using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_BD
{
    public partial class Form5 : Form
    {
        DataTable mass;
        public Form5(ref DataTable mass)
        {
            InitializeComponent();
            this.mass = mass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            try
            {
                mass.ReadXml($"{name}.xml");
                MessageBox.Show("Файл загружен");
            }
            catch
            {
                MessageBox.Show("Файл не найден", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
