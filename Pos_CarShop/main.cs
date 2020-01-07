using MongoDB.Driver;
using Pos_CarShop.Models;
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
        public readonly IMongoCollection<ProductModel> _GetDatabaseservice;
        public main()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Shop_db");

            _GetDatabaseservice = database.GetCollection<ProductModel>("product");
        }

        private void main_Load(object sender, EventArgs e)
        {
            welcome1.Visible = true;
            addproduct1.Visible = false;

            var cartData = _GetDatabaseservice.Find(it => true).ToList();

            CartGridView.DataSource = cartData;

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
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            sparePartsBox.Visible = true;
            eletroBox.Visible = true;
            enginsBox.Visible = true;
            fixBox.Visible = true;
            powerUnitBox.Visible = true;
            suspensionBox.Visible = true;
            tiresWheelsBox.Visible = true;

            bannerPic.Visible = false;
            dataGridView.Visible = false;
            welcome1.Visible = false;
            addproduct1.Visible = false;
        }

        private void welcomeBtn_Click(object sender, EventArgs e)
        {
            sparePartsBox.Visible = false;
            eletroBox.Visible = false;
            enginsBox.Visible = false;
            fixBox.Visible = false;
            powerUnitBox.Visible = false;
            suspensionBox.Visible = false;
            tiresWheelsBox.Visible = false;

            label12.Visible = false;
            SearchBox.Visible = false;
            SearchButton.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            bannerPic.Visible = true;
            dataGridView.Visible = false;
            welcome1.Visible = true;
            addproduct1.Visible = false;
        }

        private void addProductbutton_Click(object sender, EventArgs e)
        {
            sparePartsBox.Visible = false;
            eletroBox.Visible = false;
            enginsBox.Visible = false;
            fixBox.Visible = false;
            powerUnitBox.Visible = false;
            suspensionBox.Visible = false;
            tiresWheelsBox.Visible = false;

            label12.Visible = false;
            SearchBox.Visible = false;
            SearchButton.Visible = false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            welcome1.Visible = false;
            addproduct1.Visible = true;

            dataGridView.Visible = false;

            bannerPic.Visible = true;

            
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string strKeyword = SearchBox.Text;

            var ds = _GetDatabaseservice.Find(it =>
            it.productType.Contains(strKeyword) ||
            it.productName.Contains(strKeyword) ||
            it.brand.Contains(strKeyword)).ToList();

            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            dataGridView.DataSource = ds;
        }

        private void sparePartsBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ของแต่ง")).ToList();
            if (data == null)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ของแต่ง ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void eletroBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ระบบไฟ")).ToList();
            if (data == null)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ระบบไฟ ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void enginsBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("เครื่องยนต์")).ToList();
            if (data == null)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท เครื่องยนต์ ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
            
        }

        private void fixBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("อุปกรณซ่อมบำรุง")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท อุปกรณซ่อมบำรุง ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void powerUnitBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ชุดขับเคลื่อน")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ชุดขับเคลื่อน ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void suspensionBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ช่วงล่าง")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ช่วงล่าง ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void tiresWheelsBox_Click(object sender, EventArgs e)
        {
            welcome1.Visible = false;
            addproduct1.Visible = false;

            label12.Visible = true;
            SearchBox.Visible = true;
            SearchButton.Visible = true;

            dataGridView.Visible = true;
            var data = _GetDatabaseservice.Find(it => it.productType.Contains("ล้อ / ยางรถ")).ToList();
            if (data.Count <= 0)
            {
                MessageBox.Show("ไม่มีสินค้าประเภท ล้อ / ยางรถ ในระบบ กรุณาเพิ่มสินค้า", "ไม่พบข้อมูลสินค้า", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView.DataSource = data;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
