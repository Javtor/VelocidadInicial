using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velocidad_Inicial.model;
using static System.Windows.Forms.ListView;

namespace Velocidad_Inicial
{
    public partial class Form1 : Form
    {

        private Analysis analysis;

        public Form1()
        {
            InitializeComponent();
            analysis = new Analysis();
            UpdateInfo();
        }

        private void LoadList()
        {
            List<Register> registers = analysis.registers;
            regListView.Items.Clear();
            foreach (Register register in registers)
            {
                ListViewItem lvi = new ListViewItem(register.Time.ToString("0.000", CultureInfo.InvariantCulture));
                lvi.SubItems.Add(register.Angle.ToString("0.000", CultureInfo.InvariantCulture));
                lvi.SubItems.Add(register.Distance.ToString("0.000", CultureInfo.InvariantCulture));
                regListView.Items.Add(lvi);
            }
            
        }

        private void UpdateAverages()
        {
            avDistLabel.Text = "" + analysis.CalculateAverage(Analysis.DISTANCE).ToString("0.000", CultureInfo.InvariantCulture);
            avAngLabel.Text = "" + analysis.CalculateAverage(Analysis.ANGLE).ToString("0.000", CultureInfo.InvariantCulture);
            avTimeLabel.Text = "" + analysis.CalculateAverage(Analysis.TIME).ToString("0.000", CultureInfo.InvariantCulture);
        }

        private void UpdateInfo()
        {
            LoadList();
            UpdateAverages();
            Calculations();
        }

        private void Calculations()
        {
            double v1 = analysis.AverageVo(Analysis.METHOD_1);
            double u1 = analysis.CalculateAverageUncertainty(Analysis.METHOD_1);
            double s1 = v1 - u1;
            double e1 = v1 + u1;
            V1Label.Text = v1.ToString("0.000", CultureInfo.InvariantCulture)
                +" +/- "+ u1.ToString("0.000", CultureInfo.InvariantCulture)
                + " ["+s1.ToString("0.000", CultureInfo.InvariantCulture) + ", "+e1.ToString("0.000", CultureInfo.InvariantCulture) + "]";

            double v2 = analysis.AverageVo(Analysis.METHOD_2);
            double u2 = analysis.CalculateAverageUncertainty(Analysis.METHOD_2);
            double s2 = v2 - u2;
            double e2 = v2 + u2;
            V2Label.Text = v2.ToString("0.000", CultureInfo.InvariantCulture)
                + " +/- " + u2.ToString("0.000", CultureInfo.InvariantCulture)
                + " [" + s2.ToString("0.000", CultureInfo.InvariantCulture) + ", " + e2.ToString("0.000", CultureInfo.InvariantCulture) + "]";

            IntersectionLabel.Text = FindIntersection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            analysis.ReadCsv(tbURL.Text, CBHeader.Checked);
            UpdateInfo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            analysis.AddRegister(Convert.ToDouble(tbTime.Text), Convert.ToDouble(tbAngle.Text), Convert.ToDouble(tbDistance.Text));
            tbTime.Clear(); tbAngle.Clear(); tbDistance.Clear();
            UpdateInfo();
        }

        private void Clearbt_Click(object sender, EventArgs e)
        {
            analysis.ClearRegisters();
            UpdateInfo();
        }

        private void Deletebt_Click(object sender, EventArgs e)
        {
            SelectedIndexCollection indices = regListView.SelectedIndices;
            for(int i = indices.Count-1; i >= 0; i--)
            {
                int index = indices[i];
                delete(index);
            }
            UpdateInfo();
            //Form2 check = new Form2(this);
            //check.ShowDialog();
        }
        public void delete(int index)
        {
            analysis.DeleteRegister(index);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("V1 promedio es:" + analysis.AverageVo(1).ToString("0.000", CultureInfo.InvariantCulture) + " y la incertidumbre es +/-" + analysis.CalculateAverageUncertainty(1).ToString("0.000", CultureInfo.InvariantCulture) +
    ". Y V2 es: " + analysis.AverageVo(2).ToString("0.000", CultureInfo.InvariantCulture) + " y la incertidumbre es +/-" + analysis.CalculateAverageUncertainty(2).ToString("0.000", CultureInfo.InvariantCulture));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("V1 promedio es:" + analysis.AverageVo(1).ToString("0.000", CultureInfo.InvariantCulture));
        }

        private void btCalc2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V2 promedio es:" + analysis.AverageVo(2).ToString("0.000", CultureInfo.InvariantCulture));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private string FindIntersection()
        {
            Double[] intersection = analysis.FindIntersection();
            String inter = "";
            inter += intersection[0].ToString("0.000", CultureInfo.InvariantCulture) + ", ";
            inter += intersection[1].ToString("0.000", CultureInfo.InvariantCulture);

            string message = "No hay interseccion";
            if (intersection[0] <= intersection[1]) message = "[" + inter + "]";
            return message;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
