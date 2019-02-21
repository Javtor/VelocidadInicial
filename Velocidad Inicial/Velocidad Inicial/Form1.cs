using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velocidad_Inicial.model;

namespace Velocidad_Inicial
{
    public partial class Form1 : Form
    {

        private Analysis analysis;

        public Form1()
        {
            InitializeComponent();
            analysis = new Analysis();
        }

        private void LoadList()
        {
            List<Register> registers = analysis.registers;
            regListView.Items.Clear();
            foreach(Register register in registers)
            {
                ListViewItem lvi = new ListViewItem(register.Time+"");
                lvi.SubItems.Add(register.Angle + "");
                lvi.SubItems.Add(register.Distance + "");
                regListView.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
