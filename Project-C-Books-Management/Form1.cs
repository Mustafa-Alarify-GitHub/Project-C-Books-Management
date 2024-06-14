using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_C_Books_Management
{
    public partial class Form1 : Form
    {
        // var Move Form
        bool canMove = false;
        int moveX, moveY;

        // var DataBase Connctions
        

        public Form1()
        {
            InitializeComponent();
            //con.Open();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState |= FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (canMove)
            {
                this.SetDesktopLocation(
                    MousePosition.X - moveX, MousePosition.Y - moveY
                    );
            }
        }
    }
}
