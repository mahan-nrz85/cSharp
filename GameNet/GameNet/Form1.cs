﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameNet
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=GAMENET;Integrated Security=True";
        public Form1()
        {
            
            InitializeComponent();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormpoint;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(1) FROM admins WHERE Username=@username AND pass=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("ورود موفقیت آمیز بود", "تبریک", MessageBoxButtons.OK,
                             MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        frmAdminPanel formAdminPanel = new frmAdminPanel();
                        this.Hide();
                        formAdminPanel.Show();
                    }
                    else
                    {
                        MessageBox.Show( "نام کاربری یا پسوورد اشتباه است" , "خطا در ورود" , MessageBoxButtons.OK ,
                             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
    }
}
