namespace Pos_CarShop
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addProductbutton = new System.Windows.Forms.Button();
            this.welcomeBtn = new System.Windows.Forms.Button();
            this.GotoProductTypeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.calProductPrice = new System.Windows.Forms.Button();
            this.addproduct1 = new Pos_CarShop.UserController.Addproduct();
            this.welcome1 = new Pos_CarShop.Welcome();
            this.productType1 = new Pos_CarShop.productType();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.addProductbutton);
            this.groupBox1.Controls.Add(this.welcomeBtn);
            this.groupBox1.Controls.Add(this.GotoProductTypeBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 543);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button6.Location = new System.Drawing.Point(6, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 49);
            this.button6.TabIndex = 15;
            this.button6.Text = "สรุปการขายรายเดือน";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button5.Location = new System.Drawing.Point(6, 251);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 49);
            this.button5.TabIndex = 14;
            this.button5.Text = "สรุปการขายรายวัน";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.Location = new System.Drawing.Point(6, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "เช็คสินค้าใน Stock";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // addProductbutton
            // 
            this.addProductbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.addProductbutton.Location = new System.Drawing.Point(6, 141);
            this.addProductbutton.Name = "addProductbutton";
            this.addProductbutton.Size = new System.Drawing.Size(188, 49);
            this.addProductbutton.TabIndex = 2;
            this.addProductbutton.Text = "เพิ่มสินค้า";
            this.addProductbutton.UseVisualStyleBackColor = true;
            this.addProductbutton.Click += new System.EventHandler(this.addProductbutton_Click);
            // 
            // welcomeBtn
            // 
            this.welcomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.welcomeBtn.Location = new System.Drawing.Point(6, 31);
            this.welcomeBtn.Name = "welcomeBtn";
            this.welcomeBtn.Size = new System.Drawing.Size(188, 49);
            this.welcomeBtn.TabIndex = 1;
            this.welcomeBtn.Text = "หน้าต้อนรับ";
            this.welcomeBtn.UseVisualStyleBackColor = true;
            this.welcomeBtn.Click += new System.EventHandler(this.welcomeBtn_Click);
            // 
            // GotoProductTypeBtn
            // 
            this.GotoProductTypeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.GotoProductTypeBtn.Location = new System.Drawing.Point(6, 86);
            this.GotoProductTypeBtn.Name = "GotoProductTypeBtn";
            this.GotoProductTypeBtn.Size = new System.Drawing.Size(188, 49);
            this.GotoProductTypeBtn.TabIndex = 0;
            this.GotoProductTypeBtn.Text = "ซื้อขาย";
            this.GotoProductTypeBtn.UseVisualStyleBackColor = true;
            this.GotoProductTypeBtn.Click += new System.EventHandler(this.GotoProductTypeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(1014, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "วันเวลา";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(18, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(35, 16);
            this.date.TabIndex = 1;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.time.Location = new System.Drawing.Point(52, 31);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(59, 25);
            this.time.TabIndex = 0;
            this.time.Text = "Time";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.addproduct1);
            this.panel1.Controls.Add(this.welcome1);
            this.panel1.Controls.Add(this.productType1);
            this.panel1.Location = new System.Drawing.Point(218, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 530);
            this.panel1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(962, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 132);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ยอดรวม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "บาท";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "1000.00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox4.Location = new System.Drawing.Point(962, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 298);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "รายการสินค้า";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "ราคา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "สินค้า";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Items.AddRange(new object[] {
            "150",
            "250",
            "100",
            "170"});
            this.listBox2.Location = new System.Drawing.Point(211, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(70, 238);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "ผ้าเบรก",
            "น้ำมันเครื่อง",
            "สเอตร์หน้า",
            "สเตอร์หลัง"});
            this.listBox1.Location = new System.Drawing.Point(6, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 238);
            this.listBox1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.clearBtn.Location = new System.Drawing.Point(962, 562);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(138, 50);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "ยกเลิก";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // calProductPrice
            // 
            this.calProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.calProductPrice.Location = new System.Drawing.Point(1112, 562);
            this.calProductPrice.Name = "calProductPrice";
            this.calProductPrice.Size = new System.Drawing.Size(138, 50);
            this.calProductPrice.TabIndex = 21;
            this.calProductPrice.Text = "ชำระเงิน";
            this.calProductPrice.UseVisualStyleBackColor = true;
            // 
            // addproduct1
            // 
            this.addproduct1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addproduct1.Location = new System.Drawing.Point(3, 0);
            this.addproduct1.Name = "addproduct1";
            this.addproduct1.Size = new System.Drawing.Size(732, 527);
            this.addproduct1.TabIndex = 2;
            this.addproduct1.Visible = false;
            // 
            // welcome1
            // 
            this.welcome1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome1.Location = new System.Drawing.Point(58, 18);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(657, 465);
            this.welcome1.TabIndex = 1;
            // 
            // productType1
            // 
            this.productType1.Location = new System.Drawing.Point(58, 73);
            this.productType1.Name = "productType1";
            this.productType1.Size = new System.Drawing.Size(637, 425);
            this.productType1.TabIndex = 0;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 661);
            this.Controls.Add(this.calProductPrice);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "main";
            this.Text = "Pos CarShop v1";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addProductbutton;
        private System.Windows.Forms.Button welcomeBtn;
        private System.Windows.Forms.Button GotoProductTypeBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private productType productType1;
        private Welcome welcome1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calProductPrice;
        private UserController.Addproduct addproduct1;
    }
}

