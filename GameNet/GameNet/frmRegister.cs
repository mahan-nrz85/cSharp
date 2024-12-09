using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Drawing;

namespace GameNet
{
    public partial class frmRegister : Form
    {
        private Timer errTimer;

        private void clearInputs()
        {
            txt_password.Text = "";
            txt_repassword.Text = "";
            txt_password.Focus();
        }
        // minimize form
        public bool dragging = false;
        public Point dragCursorPoint;
        public Point dragFormpoint;
        ///برای گرد کردن فررم
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }
        // sql connection
        private string connectionString = "Data Source=localhost;Initial Catalog=GAMENET;Integrated Security=True";
        public bool IsUsernameUnique(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM admins WHERE username = @Username"; // کوئری بررسی تکراری بودن نام کاربری

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username); // تنظیم پارامترهای کوئری
                    int count = (int)command.ExecuteScalar(); // اجرای کوئری و دریافت نتیجه
                    return count == 0; // اگر تعداد صفر بود یعنی نام کاربری یکتا است
                }
            }
        }


        public frmRegister()
        {
            InitializeComponent();

            errTimer = new Timer();
            errTimer.Interval = 3000;
            errTimer.Tick += register_timer_Tick;
            
        }

        

            private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {
            Form1 frmlogin = new Form1();
            this.Hide();
            frmlogin.Show();
        }

        private void frmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormpoint = this.Location;
            }
        }

        private void frmRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormpoint, new Size(dif));
            }
        }

        private void frmRegister_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string repass = txt_repassword.Text;
            bool is_equal = true;
            
            if (String.IsNullOrWhiteSpace(username))
            {
                lbl_error.Text = "نام کاربری را پر کنید";
                lbl_error.Visible = true;
                is_equal = false;
                register_timer.Start();

            } else if (String.IsNullOrWhiteSpace(password))
            {
                lbl_errorpass.Text = "رمز عبور مناسب وارد کنید";
                lbl_errorpass.Visible = true;
                is_equal = false;
                register_timer.Start();

            } else if (password != repass)
            {
                lbl_errRepass.Text = "تکرار رمز عبور صحیح نیست";
                lbl_errRepass.Visible = true;
                is_equal = false;
                register_timer.Start();
            }
            if (IsUsernameUnique(username))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // نوشتن درخواست به دیتا بیس و دادن پاارمتر ها به یک دیگر
                    string query = "INSERT INTO admins (username , password) VALUES (@username , @password)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    try
                    {
                        // در صورت درست بودن فلگ چک کردن مقادیر فیلد ها ارتباط و احرا دستورات برای دیتا بیس انجام میشود
                        if (is_equal == true)
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("کاربر با موفقیت ثبت شد");
                            Form1 frmlogin = new Form1();
                            this.Hide();
                            frmlogin.Show();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("خطا", "invalid");
            }
            
       
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_error_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;

        }

        private void register_timer_Tick(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            lbl_errorpass.Visible = false;
            lbl_errRepass.Visible = false;
            register_timer.Stop();
            // متوقف کردن تایمر
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void register_timer_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
