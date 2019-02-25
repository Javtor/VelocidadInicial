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
            LoadList();
        }

        private void LoadList()
        {
            List<Register> registers = analysis.registers;
            regListView.Items.Clear();
            foreach (Register register in registers)
            {
                ListViewItem lvi = new ListViewItem(register.Time + "");
                lvi.SubItems.Add(register.Angle + "");
                lvi.SubItems.Add(register.Distance + "");
                regListView.Items.Add(lvi);
            }
            avDistLabel.Text = "" + analysis.CalculateAverage(Analysis.DISTANCE);
            avAngLabel.Text = "" + analysis.CalculateAverage(Analysis.ANGLE);
            avTimeLabel.Text = "" + analysis.CalculateAverage(Analysis.TIME);
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
            tbTime.Clear(); tbAngle.Clear(); tbDistance.Clear();
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
            analysis.DeleteRegister(index - 1);
            LoadList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("V1 promedio es:" + analysis.AverageVo(1) + " y la incertidumbre es +/-" + analysis.CalculateAverageUncertainty(1) +
    ". Y V2 es: " + analysis.AverageVo(2) + " y la incertidumbre es +/-" + analysis.CalculateAverageUncertainty(2));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("V1 promedio es:" + analysis.AverageVo(1));
        }

        private void btCalc2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V2 promedio es:" + analysis.AverageVo(2));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Double[] intersection = analysis.FindIntersection();
            String inter = "";

            for (int i = 0; i < intersection.Length && intersection != null; i++)
            {
                if (i % 2 == 0)
                {
                    inter += intersection[i] + " - ";
                }
                else
                {
                    inter += intersection[i];
                }
            }
            string message = "No hay interseccion entre los dos intervalos";
            if (intersection[0] <= intersection[1]) message = "El intervalo de interseccon es de :[" + inter + "]";
            MessageBox.Show(message);
        }

        private void tbURL_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Buscar Csv",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            dynamic result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbURL.Text = openFileDialog1.FileName;
            }
        }
    }
}
