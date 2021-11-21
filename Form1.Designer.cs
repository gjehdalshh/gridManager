
namespace gridManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_login = new System.Windows.Forms.Button();
            this.user_logout = new System.Windows.Forms.Button();
            this.pig_food = new System.Windows.Forms.Button();
            this.Sundae_food = new System.Windows.Forms.Button();
            this.mint_food = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.TextBox();
            this.user_pw = new System.Windows.Forms.TextBox();
            this.login_info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserSaleBtn = new System.Windows.Forms.Button();
            this.menuSaleDayBtn = new System.Windows.Forms.Button();
            this.menuSaleMonthBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(43, 51);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 15);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // user_login
            // 
            this.user_login.Location = new System.Drawing.Point(343, 46);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(75, 26);
            this.user_login.TabIndex = 4;
            this.user_login.Text = "로그인";
            this.user_login.UseVisualStyleBackColor = true;
            this.user_login.Click += new System.EventHandler(this.user_login_Click);
            // 
            // user_logout
            // 
            this.user_logout.Location = new System.Drawing.Point(695, 40);
            this.user_logout.Name = "user_logout";
            this.user_logout.Size = new System.Drawing.Size(75, 29);
            this.user_logout.TabIndex = 5;
            this.user_logout.Text = "로그아웃";
            this.user_logout.UseVisualStyleBackColor = true;
            this.user_logout.Click += new System.EventHandler(this.user_logout_Click);
            // 
            // pig_food
            // 
            this.pig_food.Location = new System.Drawing.Point(27, 94);
            this.pig_food.Name = "pig_food";
            this.pig_food.Size = new System.Drawing.Size(108, 46);
            this.pig_food.TabIndex = 7;
            this.pig_food.Text = "돼지국밥";
            this.pig_food.UseVisualStyleBackColor = true;
            this.pig_food.Click += new System.EventHandler(this.pig_food_Click);
            // 
            // Sundae_food
            // 
            this.Sundae_food.Location = new System.Drawing.Point(239, 94);
            this.Sundae_food.Name = "Sundae_food";
            this.Sundae_food.Size = new System.Drawing.Size(125, 46);
            this.Sundae_food.TabIndex = 8;
            this.Sundae_food.Text = "순대국밥";
            this.Sundae_food.UseVisualStyleBackColor = true;
            this.Sundae_food.Click += new System.EventHandler(this.Sundae_food_Click);
            // 
            // mint_food
            // 
            this.mint_food.Location = new System.Drawing.Point(475, 94);
            this.mint_food.Name = "mint_food";
            this.mint_food.Size = new System.Drawing.Size(113, 46);
            this.mint_food.TabIndex = 9;
            this.mint_food.Text = "민트국밥";
            this.mint_food.UseVisualStyleBackColor = true;
            this.mint_food.Click += new System.EventHandler(this.mint_food_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(621, 172);
            this.dataGridView1.TabIndex = 10;
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(69, 47);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(100, 25);
            this.user_id.TabIndex = 12;
            // 
            // user_pw
            // 
            this.user_pw.Location = new System.Drawing.Point(228, 47);
            this.user_pw.Name = "user_pw";
            this.user_pw.Size = new System.Drawing.Size(100, 25);
            this.user_pw.TabIndex = 13;
            // 
            // login_info
            // 
            this.login_info.AutoSize = true;
            this.login_info.Location = new System.Drawing.Point(526, 47);
            this.login_info.Name = "login_info";
            this.login_info.Size = new System.Drawing.Size(0, 15);
            this.login_info.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.mint_food);
            this.groupBox1.Controls.Add(this.Sundae_food);
            this.groupBox1.Controls.Add(this.pig_food);
            this.groupBox1.Location = new System.Drawing.Point(54, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 163);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "캐셔용 화면";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(54, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 228);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "관리자용 화면";
            // 
            // UserSaleBtn
            // 
            this.UserSaleBtn.Location = new System.Drawing.Point(178, 252);
            this.UserSaleBtn.Name = "UserSaleBtn";
            this.UserSaleBtn.Size = new System.Drawing.Size(127, 40);
            this.UserSaleBtn.TabIndex = 17;
            this.UserSaleBtn.Text = "유저별 판매";
            this.UserSaleBtn.UseVisualStyleBackColor = true;
            this.UserSaleBtn.Click += new System.EventHandler(this.UserSaleBtn_Click);
            // 
            // menuSaleDayBtn
            // 
            this.menuSaleDayBtn.Location = new System.Drawing.Point(343, 252);
            this.menuSaleDayBtn.Name = "menuSaleDayBtn";
            this.menuSaleDayBtn.Size = new System.Drawing.Size(131, 40);
            this.menuSaleDayBtn.TabIndex = 18;
            this.menuSaleDayBtn.Text = "메뉴별 일간 판매";
            this.menuSaleDayBtn.UseVisualStyleBackColor = true;
            this.menuSaleDayBtn.Click += new System.EventHandler(this.menuSaleDayBtn_Click);
            // 
            // menuSaleMonthBtn
            // 
            this.menuSaleMonthBtn.Location = new System.Drawing.Point(519, 252);
            this.menuSaleMonthBtn.Name = "menuSaleMonthBtn";
            this.menuSaleMonthBtn.Size = new System.Drawing.Size(130, 40);
            this.menuSaleMonthBtn.TabIndex = 19;
            this.menuSaleMonthBtn.Text = "메뉴별 월간 판매";
            this.menuSaleMonthBtn.UseVisualStyleBackColor = true;
            this.menuSaleMonthBtn.Click += new System.EventHandler(this.menuSaleMonthBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 555);
            this.Controls.Add(this.menuSaleMonthBtn);
            this.Controls.Add(this.menuSaleDayBtn);
            this.Controls.Add(this.UserSaleBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.login_info);
            this.Controls.Add(this.user_pw);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.user_logout);
            this.Controls.Add(this.user_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button user_login;
        private System.Windows.Forms.Button user_logout;
        private System.Windows.Forms.Button pig_food;
        private System.Windows.Forms.Button Sundae_food;
        private System.Windows.Forms.Button mint_food;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox user_pw;
        private System.Windows.Forms.Label login_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UserSaleBtn;
        private System.Windows.Forms.Button menuSaleDayBtn;
        private System.Windows.Forms.Button menuSaleMonthBtn;
    }
}

