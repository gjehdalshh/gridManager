
namespace gridManager
{
    partial class menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.menu_name = new System.Windows.Forms.TextBox();
            this.menu_price = new System.Windows.Forms.TextBox();
            this.insertMenuBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nowMenuName = new System.Windows.Forms.TextBox();
            this.changeMenuName = new System.Windows.Forms.TextBox();
            this.changeMenuBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeMenuPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureInsertBtn = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.imgPathText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "신규 메뉴 추가";
            // 
            // menu_name
            // 
            this.menu_name.Location = new System.Drawing.Point(55, 166);
            this.menu_name.Name = "menu_name";
            this.menu_name.Size = new System.Drawing.Size(153, 25);
            this.menu_name.TabIndex = 1;
            // 
            // menu_price
            // 
            this.menu_price.Location = new System.Drawing.Point(55, 206);
            this.menu_price.Name = "menu_price";
            this.menu_price.Size = new System.Drawing.Size(153, 25);
            this.menu_price.TabIndex = 2;
            // 
            // insertMenuBtn
            // 
            this.insertMenuBtn.Location = new System.Drawing.Point(55, 255);
            this.insertMenuBtn.Name = "insertMenuBtn";
            this.insertMenuBtn.Size = new System.Drawing.Size(153, 32);
            this.insertMenuBtn.TabIndex = 3;
            this.insertMenuBtn.Text = "메뉴 추가";
            this.insertMenuBtn.UseVisualStyleBackColor = true;
            this.insertMenuBtn.Click += new System.EventHandler(this.insertMenuBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "기존 메뉴 변경";
            // 
            // nowMenuName
            // 
            this.nowMenuName.Location = new System.Drawing.Point(355, 166);
            this.nowMenuName.Name = "nowMenuName";
            this.nowMenuName.Size = new System.Drawing.Size(145, 25);
            this.nowMenuName.TabIndex = 5;
            // 
            // changeMenuName
            // 
            this.changeMenuName.Location = new System.Drawing.Point(355, 213);
            this.changeMenuName.Name = "changeMenuName";
            this.changeMenuName.Size = new System.Drawing.Size(145, 25);
            this.changeMenuName.TabIndex = 6;
            // 
            // changeMenuBtn
            // 
            this.changeMenuBtn.Location = new System.Drawing.Point(355, 306);
            this.changeMenuBtn.Name = "changeMenuBtn";
            this.changeMenuBtn.Size = new System.Drawing.Size(145, 32);
            this.changeMenuBtn.TabIndex = 7;
            this.changeMenuBtn.Text = "메뉴 변경";
            this.changeMenuBtn.UseVisualStyleBackColor = true;
            this.changeMenuBtn.Click += new System.EventHandler(this.changeMenuBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "가격";
            // 
            // changeMenuPrice
            // 
            this.changeMenuPrice.Location = new System.Drawing.Point(355, 254);
            this.changeMenuPrice.Name = "changeMenuPrice";
            this.changeMenuPrice.Size = new System.Drawing.Size(145, 25);
            this.changeMenuPrice.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "현재 음식 이름";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "바꿀 음식 이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "가격";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "이미지 등록";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(591, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 91);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureInsertBtn
            // 
            this.pictureInsertBtn.Location = new System.Drawing.Point(591, 311);
            this.pictureInsertBtn.Name = "pictureInsertBtn";
            this.pictureInsertBtn.Size = new System.Drawing.Size(123, 23);
            this.pictureInsertBtn.TabIndex = 16;
            this.pictureInsertBtn.Text = "이미지 등록";
            this.pictureInsertBtn.UseVisualStyleBackColor = true;
            this.pictureInsertBtn.Click += new System.EventHandler(this.pictureInsertBtn_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // imgPathText
            // 
            this.imgPathText.Location = new System.Drawing.Point(591, 280);
            this.imgPathText.Name = "imgPathText";
            this.imgPathText.Size = new System.Drawing.Size(123, 25);
            this.imgPathText.TabIndex = 17;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgPathText);
            this.Controls.Add(this.pictureInsertBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.changeMenuPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changeMenuBtn);
            this.Controls.Add(this.changeMenuName);
            this.Controls.Add(this.nowMenuName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertMenuBtn);
            this.Controls.Add(this.menu_price);
            this.Controls.Add(this.menu_name);
            this.Controls.Add(this.label1);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox menu_name;
        private System.Windows.Forms.TextBox menu_price;
        private System.Windows.Forms.Button insertMenuBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nowMenuName;
        private System.Windows.Forms.TextBox changeMenuName;
        private System.Windows.Forms.Button changeMenuBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox changeMenuPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pictureInsertBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox imgPathText;
    }
}