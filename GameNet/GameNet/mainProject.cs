using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace GameNet
{
    public partial class Form1 : Form
    {
        private Timer errorTimer;
        public Form1()
        {
            
            InitializeComponent();
            errorTimer = new Timer();
            errorTimer.Interval = 3000;
            errorTimer.Tick += err_timer_Tick;
        }

        private bool AuthenticateUser(string username, string password)
        {
            // connection string
            string connectionString = "Data Source=localhost;Initial Catalog=GAMENET;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM admins WHERE Username=@username AND password=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count == 1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }

        }
        private void loginHandler(string username, string password)
        {
            if (AuthenticateUser(username, password))
            {
                frmAdminPanel formAdminPanel = new frmAdminPanel();
                this.Hide();
                formAdminPanel.Show();
            }
            else
            {

                lbl_err.Text = "اطلاعات وارد شده صحیح نمیباشد";
                lbl_err.Visible = true;
                clearTxt();
                errorTimer.Start();
            }
        }
        public bool dragging = false;
        public Point dragCursorPoint;
        public Point dragFormpoint;

        private void clearTxt()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtUsername.Focus();
        }
         
        // border-radius form
        ///برای گرد کردن فررم
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormpoint = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormpoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;

            loginHandler(username, password);
        }

        private void checkBox_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void pic_form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormpoint = this.Location;
            }
        }

        private void pic_form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormpoint, new Size(dif));
            }
        }

        private void pic_form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmRegister formRegiste = new frmRegister();
            this.Hide();
            formRegiste.Show();
        }


        private void Form1_Enter(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPass.Text;

            loginHandler(username, password);
        }

        private void err_timer_Tick(object sender, EventArgs e)
        {
            lbl_err.Visible = false;
            errorTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
