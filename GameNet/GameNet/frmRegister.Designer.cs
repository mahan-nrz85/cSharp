namespace GameNet
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.lbl_repassword = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_repassword = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.minimize_btn = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.lbl_errorpass = new System.Windows.Forms.Label();
            this.lbl_errRepass = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.register_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_repassword
            // 
            this.lbl_repassword.AutoSize = true;
            this.lbl_repassword.Font = new System.Drawing.Font("Yekan Bakh", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_repassword.Location = new System.Drawing.Point(68, 307);
            this.lbl_repassword.Name = "lbl_repassword";
            this.lbl_repassword.Size = new System.Drawing.Size(115, 26);
            this.lbl_repassword.TabIndex = 22;
            this.lbl_repassword.Text = "تکرار رمز عبور :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Yekan Bakh", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(68, 216);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(77, 26);
            this.lbl_password.TabIndex = 20;
            this.lbl_password.Text = "رمز عبور :";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_login.Font = new System.Drawing.Font("Yekan Bakh", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_login.Location = new System.Drawing.Point(155, 480);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(65, 20);
            this.lbl_login.TabIndex = 25;
            this.lbl_login.Text = "وارد شوید";
            this.lbl_login.Click += new System.EventHandler(this.lbl_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yekan Bakh", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "حساب کاربری دارید؟";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Yekan Bakh", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(42, 410);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(377, 37);
            this.btn_create.TabIndex = 23;
            this.btn_create.Text = "ساخت حساب";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_repassword
            // 
            this.txt_repassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_repassword.Location = new System.Drawing.Point(42, 339);
            this.txt_repassword.Name = "txt_repassword";
            this.txt_repassword.Size = new System.Drawing.Size(377, 27);
            this.txt_repassword.TabIndex = 21;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(42, 252);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(377, 27);
            this.txt_password.TabIndex = 19;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Yekan Bakh", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(66, 130);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(94, 26);
            this.lbl_username.TabIndex = 18;
            this.lbl_username.Text = "نام کاربری :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yekan Bakh Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(103, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 57);
            this.label1.TabIndex = 17;
            this.label1.Text = "صفحه ثبت نام";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(42, 164);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(377, 27);
            this.txt_username.TabIndex = 15;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(36, 1);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(25, 30);
            this.minimize_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_btn.TabIndex = 30;
            this.minimize_btn.TabStop = false;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.Location = new System.Drawing.Point(5, 1);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(25, 30);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 29;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GameNet.Properties.Resources.PassIcon;
            this.pictureBox4.Location = new System.Drawing.Point(42, 303);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GameNet.Properties.Resources.PassIcon;
            this.pictureBox3.Location = new System.Drawing.Point(42, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameNet.Properties.Resources.UserIcon;
            this.pictureBox2.Location = new System.Drawing.Point(42, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameNet.Properties.Resources.pic_2;
            this.pictureBox1.Location = new System.Drawing.Point(471, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 548);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Yekan Bakh", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(275, 194);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(37, 17);
            this.lbl_error.TabIndex = 31;
            this.lbl_error.Text = "label2";
            this.lbl_error.Visible = false;
            this.lbl_error.Click += new System.EventHandler(this.lbl_error_Click);
            // 
            // lbl_errorpass
            // 
            this.lbl_errorpass.AutoSize = true;
            this.lbl_errorpass.Font = new System.Drawing.Font("Yekan Bakh", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorpass.ForeColor = System.Drawing.Color.Red;
            this.lbl_errorpass.Location = new System.Drawing.Point(275, 284);
            this.lbl_errorpass.Name = "lbl_errorpass";
            this.lbl_errorpass.Size = new System.Drawing.Size(37, 17);
            this.lbl_errorpass.TabIndex = 32;
            this.lbl_errorpass.Text = "label2";
            this.lbl_errorpass.Visible = false;
            // 
            // lbl_errRepass
            // 
            this.lbl_errRepass.AutoSize = true;
            this.lbl_errRepass.Font = new System.Drawing.Font("Yekan Bakh", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errRepass.ForeColor = System.Drawing.Color.Red;
            this.lbl_errRepass.Location = new System.Drawing.Point(275, 371);
            this.lbl_errRepass.Name = "lbl_errRepass";
            this.lbl_errRepass.Size = new System.Drawing.Size(37, 17);
            this.lbl_errRepass.TabIndex = 33;
            this.lbl_errRepass.Text = "label2";
            this.lbl_errRepass.Visible = false;
            // 
            // register_timer
            // 
            this.register_timer.Tick += new System.EventHandler(this.register_timer_Tick_1);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 526);
            this.Controls.Add(this.lbl_errRepass);
            this.Controls.Add(this.lbl_errorpass);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.lbl_repassword);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_repassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmRegister_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimize_btn;
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.Label lbl_repassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_repassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label lbl_errorpass;
        private System.Windows.Forms.Label lbl_errRepass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer register_timer;
    }
}