using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFinanceiro
{
    public partial class Form1 : Form
    {

        private DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        public Form1()
        {
            InitializeComponent();
            AcceptButton = buttonCalcular;
            textBoxJuros.Text = "0";
            textBoxVenda.Text = "0";
            textBoxFinanciado.Text = "0";
            textBoxSinal.Text = "0";
            textBoxJuros180.Text = "900";
            textBoxJuros150.Text = "800";
            textBoxJuros120.Text = "700";
            textBoxJuros90.Text = "600";
            textBoxJuros60.Text = "520";
            textBoxVenda.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxSinal.TextChanged += new EventHandler(textBox_TextChanged);
            comboBoxJuros.SelectedIndex = 0;
            //ativa cor de linhas alternadas
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCalculo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSinal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        }

        private void textBoxJuros_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
            Campos();
        }

        private void textBoxJuros_Click(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            b.SelectionStart = b.Text.Length;
        }

        private void textBoxVenda_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
            Campos();
        }

        private void textBoxVenda_Click(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            b.SelectionStart = b.Text.Length;
        }

        private void textBoxSinal_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);

            if (textBoxParcela1.Text == "0")
                textBoxParcela1.Text = "1";
        }

        private void textBoxFinanciado_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.MoedaFormat(sender);
        }

        private void textBoxSinal_Click(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            b.SelectionStart = b.Text.Length;
        }

        private void textBoxFinanciado_Click(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            b.SelectionStart = b.Text.Length;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox b = (TextBox)sender;
            textBoxFinanciado.Text = (Convert.ToDecimal(textBoxVenda.Text) - Convert.ToDecimal(textBoxSinal.Text)).ToString();
        }

        private void textBoxParcela1_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.NumericTexto(sender);
            if (!string.IsNullOrEmpty(textBoxParcela1.Text))
                dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(Convert.ToInt32(textBoxParcela1.Text));
        }

        private void textBoxParcela2_TextChanged(object sender, EventArgs e)
        {
            FormTextoFormat.NumericTexto(sender);
            Campos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(Convert.ToInt32(textBoxParcela1.Text));
        }

        private void dataGridViewCalculo_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCalculo.Rows[e.RowIndex].Cells[0].Value = string.Format("{0:000}", e.RowIndex + 1);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            dataGridViewCalculo.Rows.Clear();
            //capital inicial
            double c = Convert.ToDouble(textBoxFinanciado.Text);
            double iD = 0;
            if (comboBoxJuros.SelectedIndex == 0)
                iD = ConverterJuros(Convert.ToDouble(textBoxJuros.Text));
            else
                iD = Convert.ToDouble(textBoxJuros.Text) / 100;

            //tempo do financiamento ou seja parcelas
            double t = Convert.ToDouble(textBoxParcela2.Text);
            double j = Math.Pow((iD + 1), t);

            //montante = calculo de amortização TabelaPrice
            double m = c * ((j * iD) / (j - 1));
            double devedor = c;

            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1);
            TimeSpan span = d2 - d1;
            int mes = (span.Days / 30) - 1;

            if (mes < 0)
                mes = 0;

            for (int i = 0; i < t; i++)
            {
                double am = m - devedor * iD;
                double ju = devedor * iD;
                double saldo = devedor - (am + ju);

                string[] parc = new string[6];
                parc[0] = "";
                parc[1] = dateTimePicker2.Value.AddMonths(i).ToShortDateString();
                parc[2] = CalcularJuros(c, Convert.ToDouble(textBoxJuros.Text), Convert.ToInt32(textBoxParcela2.Text), mes).ToString("C2");
                parc[3] = am.ToString("C2");
                parc[4] = ju.ToString("C2");
                parc[5] = saldo < 0 ? 0.ToString("C2") : saldo.ToString("C2");

                devedor -= am;
                dataGridViewCalculo.Rows.Add(parc);
                dataGridViewCalculo.ClearSelection();
            }

            textBox180.Text = CalcularJuros(c, Convert.ToDouble(textBoxJuros180.Text), 180, mes).ToString("C2");
            textBox150.Text = CalcularJuros(c, Convert.ToDouble(textBoxJuros150.Text), 150, mes).ToString("C2");
            textBox120.Text = CalcularJuros(c, Convert.ToDouble(textBoxJuros120.Text), 120, mes).ToString("C2");
            textBox90.Text = CalcularJuros(c, Convert.ToDouble(textBoxJuros90.Text), 90, mes).ToString("C2");
            textBox60.Text = CalcularJuros(c, Convert.ToDouble(textBoxJuros60.Text), 60, mes).ToString("C2");

            dataGridViewSinal.Rows.Clear();
            if (Convert.ToDecimal(textBoxSinal.Text) > 0)
            {
                for (int i = 0; i < Convert.ToInt32(textBoxParcela1.Text); i++)
                {
                    string[] sinal = new string[3];
                    sinal[0] = "";
                    sinal[1] = dateTimePicker1.Value.AddMonths(i).ToShortDateString();
                    sinal[2] = (Convert.ToDecimal(textBoxSinal.Text) / Convert.ToInt32(textBoxParcela1.Text)).ToString("C2");

                    dataGridViewSinal.Rows.Add(sinal);
                    dataGridViewSinal.ClearSelection();
                }
            }
        }

        private double CalcularJuros(double capital, double juros, int parc, int mes)
        {
            double j = ConverterJuros(juros);
            double c = capital * ((Math.Pow((j + 1), parc) * j) / (Math.Pow((j + 1), parc) - 1));

            return c * Math.Pow((j + 1), mes);
        }

        private double ConverterJuros(double j)
        {
            //converter juros anual em mensal
            double d = j / 100;
            double p = 1 / 12D;
            return Math.Pow((d + 1), p) - 1;
        }

        private void textBoxParcela1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxParcela1.Text))
                textBoxParcela1.Text = "1";
        }

        private void textBoxParcela2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxParcela2.Text))
                textBoxParcela2.Text = "1";
        }

        private void Campos()
        {
            buttonCalcular.Enabled = false;
            if (string.IsNullOrEmpty(textBoxFinanciado.Text) || Convert.ToDouble(textBoxFinanciado.Text) == 0)
                return;
            if (string.IsNullOrEmpty(textBoxJuros.Text) || Convert.ToDouble(textBoxJuros.Text) == 0)
                return;
            if (string.IsNullOrEmpty(textBoxParcela2.Text) || Convert.ToDouble(textBoxParcela2.Text) == 0)
                return;

            buttonCalcular.Enabled = true;
        }

        private void dataGridViewSinal_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSinal.Rows[e.RowIndex].Cells[0].Value = string.Format("{0:000}", e.RowIndex + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dateTimePicker2.Value = DateTime.Now.AddMonths(1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1);

            if (d2.CompareTo(d1) < 0)
                dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(Convert.ToInt32(textBoxParcela1.Text));
        }
    }
}
