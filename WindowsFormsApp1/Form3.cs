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
    public partial class Nastroiki : Form
    {
        public Nastroiki()
        {
            InitializeComponent();
        }

        private void Nastroiki_Load(object sender, EventArgs e)
        {
            rows.Value = ColumnRows.Row;
            column.Value = ColumnRows.Col;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColumnRows.Row = Convert.ToInt32(rows.Value);
            ColumnRows.Col = Convert.ToInt32(column.Value);
            Close();
        }
    }
}
