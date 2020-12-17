﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_13;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }
        //Начальные значения при первой загрузке программы
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
            ColumnRows.Open();
            table.ColumnCount = ColumnRows.Col;
            table.RowCount = ColumnRows.Row;
            m.Value = ColumnRows.Row;
            n.Value = ColumnRows.Col;
        }
        //кол-во строк
        private void kolvostr_ValueChanged(object sender, EventArgs e)
        {
            table.RowCount = Convert.ToInt32(m.Value);
            rez1.Clear();
            rez2.Clear();
        }
        //кол-во столбов
        private void kolvostolb_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(n.Value);
            rez1.Clear();
            rez2.Clear();
        }
        
        //Заполнить
        private void button2_Click(object sender, EventArgs e)
        {
            Table.ZpMas(table);
        }
        //Очистить
        private void button3_Click(object sender, EventArgs e)
        {
            Table.ClearMas(table,rez1,rez2);          
        }
        //Рассчитать
        private void button1_Click(object sender, EventArgs e)
        {
            Table.Summ(table,zn,rez1,rez2);
        }

        private void zn_ValueChanged(object sender, EventArgs e)
        {
            zn.Maximum = Convert.ToInt32(n.Value);
            rez1.Clear();
            rez2.Clear();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работы №13\n" +
                "Платов Андрей ИСП-31\n" +
                "Дана матрица размера M * N и целое число K (1 < K < N). Найти сумму и произведение элементов K - го столбца данной матрицы.");
        }
        //выход
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.OpenFile(table);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table.SaveFile(table);
        }

        private void rez1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
        }

        private void rez2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
        }
        
        //размер и ячейка
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        int p1 = Convert.ToInt32(m.Value);
        int p2 = Convert.ToInt32(n.Value);
        statusStrip1.Items[0].Text = "Размер-" + p1.ToString() + "x" + p2.ToString();
        int x = table.CurrentCell.RowIndex + 1;
        int y = table.CurrentCell.ColumnIndex + 1;
        statusStrip1.Items[1].Text = "Ячейка-" + x.ToString() + "," + y.ToString();
        }
        //при закрытии
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ColumnRows.Save();
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nastroiki form3 = new Nastroiki();
            form3.ShowDialog();       
            table.ColumnCount = ColumnRows.Col;
            table.RowCount = ColumnRows.Row;
        }
    }
}
