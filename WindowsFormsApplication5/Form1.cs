using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15; // Кол‐во строк

            dataGridView1.ColumnCount = 15; // Кол‐во столбцов
            int[,] a = new int[15, 15]; // Инициализируем массив
            int i, j;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i, j] = rand.Next(-100, 100);
            // Выводим матрицу в dataGridView1
            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    dataGridView1.Rows[i].Cells[j].Value =
                    a[i, j].ToString();
            // Поиск максимального элемента
            // на  диагонали
            int m = a[0, 0];
            int imax = 0;
            for (i = 0; i < 15; i++)
                if (a[i, i] > m)
                {
                    m = a[i, i];
                    imax = i;
                   
                }
            dataGridView1.Rows[imax].Cells[imax].Style.BackColor = Color.Green;
            textBox2.Text = Convert.ToString(m);
            textBox3.Text = Convert.ToString(imax+1);
             textBox1.Text = "";
            // выводим результат
            for (j = 0; j < 15; j++)
                textBox1.Text += Convert.ToString(a[imax, j]) + "  ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
