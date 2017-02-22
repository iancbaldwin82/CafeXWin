using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeXLogic;

namespace CafeXWin
{
    public partial class CafeXWin : Form
    {
        public CafeXWin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var items = new List<CafeMenuItem>() { new CafeMenuItem() { Name = "Cola", IsHot = false, Price = 0.50 },
                                           new CafeMenuItem() { Name = "Coffee", IsHot = true, Price = 1.00 },
                                           new CafeMenuItem() { Name = "Cheese Sandwich", IsHot = false, Price = 2.00 },
                                           new CafeMenuItem() { Name = "Steak Sandwich", IsHot = true, Price = 4.50 }
                                         };
            dataGridView1.DataSource = items;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Name != "Selected")
                {
                    col.ReadOnly = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var items = (List<CafeMenuItem>)dataGridView1.DataSource;
            txtResult.Text = CafeXHelper.Calculate(items).ToString("0.00");
        }

    }
}
