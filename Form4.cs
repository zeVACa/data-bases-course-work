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
    public partial class Form4 : Form
    {
        DataTable mass;
        public Form4(ref DataTable mass)
        {
            InitializeComponent();
            this.mass = mass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            try
            {
                File.Delete($"{name}.xml");
                MessageBox.Show("Файл удален");
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
