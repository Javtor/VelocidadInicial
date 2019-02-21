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
            analysis.ReadCsv(tbURL.Text, CBHeader.Checked);
            LoadList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            analysis.AddRegister(Convert.ToDouble(tbTime.Text), Convert.ToDouble(tbAngle.Text), Convert.ToDouble(tbDistance.Text));
            LoadList();
        }

        private void Clearbt_Click(object sender, EventArgs e)
        {
            analysis.ClearRegisters();
            LoadList();
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            Form2 check = new Form2(this);
            check.ShowDialog();
        }
        public void delete(int index)
        {
            analysis.DeleteRegister(index-1);
            LoadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btCalc2_Click(object sender, EventArgs e)
        {

        }
    }
}
