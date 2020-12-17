using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Войти
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123") Close();
            else
            {
                MessageBox.Show("Пароль неверный");
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        //Отмена
        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Close();     
        }
    }
}
