using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArrayLab9
{
    public partial class Form1 : Form
    {
        private int[,] A;
        private int n, m;
        private readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            n = (int)nudN.Value;
            m = (int)nudM.Value;
            A = new int[n, m];

            dgvA.ColumnCount = m;
            dgvA.RowCount = n;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i, j] = rnd.Next(-20, 21);
                    dgvA.Rows[i].Cells[j].Value = A[i, j];
                    dgvA.Columns[j].Width = 45;
                }
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (A == null)
            {
                MessageBox.Show("Сначала заполните матрицу");
                return;
            }

            var B = new List<int>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                        B.Add(A[i, j]);
                }
            }

            lstB.Items.Clear();
            foreach (var v in B)
                lstB.Items.Add(v);

            if (B.Count == 0)
            {
                lblStat.Text = "Массив пуст";
                return;
            }

            int sum = B.Sum();
            int min = B.Min();
            int max = B.Max();
            double avg = B.Average();

            lblStat.Text = $"Длина: {B.Count}  Сумма: {sum}  Min: {min}  Max: {max}  Среднее: {avg:F2}";
        }
    }
}