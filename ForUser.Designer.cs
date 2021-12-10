
namespace gridManager
{
    partial class ForUser
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
            this.user_logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.NowSelectMenu = new System.Windows.Forms.ListBox();
            this.payMentBtn = new System.Windows.Forms.Button();
            this.deleteMenuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_logout
            // 
            this.user_logout.Location = new System.Drawing.Point(671, 12);
            this.user_logout.Name = "user_logout";
            this.user_logout.Size = new System.Drawing.Size(95, 52);
            this.user_logout.TabIndex = 6;
            this.user_logout.Text = "로그아웃";
            this.user_logout.UseVisualStyleBackColor = true;
            this.user_logout.Click += new System.EventHandler(this.user_logout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "admin menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 83);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(499, 365);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(115, 52);
            this.orderBtn.TabIndex = 10;
            this.orderBtn.Text = "주문";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBnt_Click);
            // 
            // NowSelectMenu
            // 
            this.NowSelectMenu.FormattingEnabled = true;
            this.NowSelectMenu.ItemHeight = 15;
            this.NowSelectMenu.Location = new System.Drawing.Point(499, 235);
            this.NowSelectMenu.Name = "NowSelectMenu";
            this.NowSelectMenu.Size = new System.Drawing.Size(120, 94);
            this.NowSelectMenu.TabIndex = 11;
            // 
            // payMentBtn
            // 
            this.payMentBtn.Location = new System.Drawing.Point(651, 365);
            this.payMentBtn.Name = "payMentBtn";
            this.payMentBtn.Size = new System.Drawing.Size(115, 52);
            this.payMentBtn.TabIndex = 12;
            this.payMentBtn.Text = "결제";
            this.payMentBtn.UseVisualStyleBackColor = true;
            this.payMentBtn.Click += new System.EventHandler(this.payMentBtn_Click);
            // 
            // deleteMenuBtn
            // 
            this.deleteMenuBtn.Location = new System.Drawing.Point(625, 235);
            this.deleteMenuBtn.Name = "deleteMenuBtn";
            this.deleteMenuBtn.Size = new System.Drawing.Size(101, 23);
            this.deleteMenuBtn.TabIndex = 13;
            this.deleteMenuBtn.Text = "메뉴 취소";
            this.deleteMenuBtn.UseVisualStyleBackColor = true;
            this.deleteMenuBtn.Click += new System.EventHandler(this.deleteMenuBtn_Click);
            // 
            // ForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteMenuBtn);
            this.Controls.Add(this.payMentBtn);
            this.Controls.Add(this.NowSelectMenu);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_logout);
            this.Name = "ForUser";
            this.Text = "ForUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button user_logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.ListBox NowSelectMenu;
        private System.Windows.Forms.Button payMentBtn;
        private System.Windows.Forms.Button deleteMenuBtn;
    }
}