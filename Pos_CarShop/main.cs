using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_CarShop
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            productType1.Visible = false;
            
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void GotoProductTypeBtn_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            productType1.Visible = true;
        }

        private void welcomeBtn_Click(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            productType1.Visible = false;
        }

        
    }
}
