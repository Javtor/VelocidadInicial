using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocidad_Inicial
{
    public partial class Form2 : Form
    {
        private Form1 main;
        public Form2(Form1 f)
        {
            InitializeComponent();
            main = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.delete(Convert.ToInt32(textBox1.Text));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
