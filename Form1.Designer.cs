
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
            this.user_logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.login_info = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UserSaleBtn = new System.Windows.Forms.Button();
            this.menuSaleDayBtn = new System.Windows.Forms.Button();
            this.menuSaleMonthBtn = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.userLogRecord = new System.Windows.Forms.Button();
            this.menuManagement = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.orderSelectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderSelectText = new System.Windows.Forms.TextBox();
            this.selectCencelBtn = new System.Windows.Forms.Button();
            this.menuChangePrint = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // user_logout
            // 
            this.user_logout.Location = new System.Drawing.Point(1028, 19);
            this.user_logout.Name = "user_logout";
            this.user_logout.Size = new System.Drawing.Size(75, 38);
            this.user_logout.TabIndex = 5;
            this.user_logout.Text = "로그아웃";
            this.user_logout.UseVisualStyleBackColor = true;
            this.user_logout.Click += new System.EventHandler(this.admin_logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(503, 172);
            this.dataGridView1.TabIndex = 10;
            // 
            // login_info
            // 
            this.login_info.AutoSize = true;
            this.login_info.Location = new System.Drawing.Point(526, 47);
            this.login_info.Name = "login_info";
            this.login_info.Size = new System.Drawing.Size(0, 15);
            this.login_info.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(54, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1049, 228);
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
            this.menuSaleMonthBtn.Size = new System.Drawing.Size(157, 40);
            this.menuSaleMonthBtn.TabIndex = 19;
            this.menuSaleMonthBtn.Text = "메뉴별 월간 판매";
            this.menuSaleMonthBtn.UseVisualStyleBackColor = true;
            this.menuSaleMonthBtn.Click += new System.EventHandler(this.menuSaleMonthBtn_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // userLogRecord
            // 
            this.userLogRecord.Location = new System.Drawing.Point(178, 184);
            this.userLogRecord.Name = "userLogRecord";
            this.userLogRecord.Size = new System.Drawing.Size(127, 41);
            this.userLogRecord.TabIndex = 20;
            this.userLogRecord.Text = "유저 로그 기록";
            this.userLogRecord.UseVisualStyleBackColor = true;
            this.userLogRecord.Click += new System.EventHandler(this.userLogRecord_Click);
            // 
            // menuManagement
            // 
            this.menuManagement.Location = new System.Drawing.Point(343, 184);
            this.menuManagement.Name = "menuManagement";
            this.menuManagement.Size = new System.Drawing.Size(131, 41);
            this.menuManagement.TabIndex = 23;
            this.menuManagement.Text = "메뉴관리";
            this.menuManagement.UseVisualStyleBackColor = true;
            this.menuManagement.Click += new System.EventHandler(this.menuManagement_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1028, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "뒤로가기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderSelectBtn
            // 
            this.orderSelectBtn.Location = new System.Drawing.Point(812, 21);
            this.orderSelectBtn.Name = "orderSelectBtn";
            this.orderSelectBtn.Size = new System.Drawing.Size(86, 41);
            this.orderSelectBtn.TabIndex = 25;
            this.orderSelectBtn.Text = "검색";
            this.orderSelectBtn.UseVisualStyleBackColor = true;
            this.orderSelectBtn.Click += new System.EventHandler(this.orderSelectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "주문 / 결제 내역 검색";
            // 
            // orderSelectText
            // 
            this.orderSelectText.Location = new System.Drawing.Point(618, 47);
            this.orderSelectText.Name = "orderSelectText";
            this.orderSelectText.Size = new System.Drawing.Size(150, 25);
            this.orderSelectText.TabIndex = 27;
            // 
            // selectCencelBtn
            // 
            this.selectCencelBtn.Location = new System.Drawing.Point(519, 184);
            this.selectCencelBtn.Name = "selectCencelBtn";
            this.selectCencelBtn.Size = new System.Drawing.Size(157, 41);
            this.selectCencelBtn.TabIndex = 28;
            this.selectCencelBtn.Text = "주문 취소 내역";
            this.selectCencelBtn.UseVisualStyleBackColor = true;
            this.selectCencelBtn.Click += new System.EventHandler(this.selectCencelBtn_Click);
            // 
            // menuChangePrint
            // 
            this.menuChangePrint.Location = new System.Drawing.Point(714, 252);
            this.menuChangePrint.Name = "menuChangePrint";
            this.menuChangePrint.Size = new System.Drawing.Size(131, 41);
            this.menuChangePrint.TabIndex = 29;
            this.menuChangePrint.Text = "메뉴 변경 내역";
            this.menuChangePrint.UseVisualStyleBackColor = true;
            this.menuChangePrint.Click += new System.EventHandler(this.menuChangePrint_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(535, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(496, 172);
            this.dataGridView2.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 555);
            this.Controls.Add(this.menuChangePrint);
            this.Controls.Add(this.selectCencelBtn);
            this.Controls.Add(this.orderSelectText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderSelectBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuManagement);
            this.Controls.Add(this.userLogRecord);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuSaleMonthBtn);
            this.Controls.Add(this.menuSaleDayBtn);
            this.Controls.Add(this.UserSaleBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.login_info);
            this.Controls.Add(this.user_logout);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button user_logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label login_info;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UserSaleBtn;
        private System.Windows.Forms.Button menuSaleDayBtn;
        private System.Windows.Forms.Button menuSaleMonthBtn;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button userLogRecord;
        private System.Windows.Forms.Button menuManagement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button orderSelectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderSelectText;
        private System.Windows.Forms.Button selectCencelBtn;
        private System.Windows.Forms.Button menuChangePrint;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

