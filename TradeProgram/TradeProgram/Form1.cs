using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeProgram
{
    
    public partial class Form1 : Form
    {
        HistoricalDataInfo s;
        public Form1()
        {
            InitializeComponent();
            s = new HistoricalDataInfo();

            textBox1.Text = s.force.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
