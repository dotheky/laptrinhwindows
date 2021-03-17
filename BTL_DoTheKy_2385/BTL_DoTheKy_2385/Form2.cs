using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DoTheKy_2385
{
    public partial class Form2 : Form
    {        
        public Form2(int id, string date, string time, string from, string to, string aircraft, string eprice)
        {
            InitializeComponent();
            lblID.Text = id.ToString();
            lblFrom.Text = from;
            lblTo.Text = to;
            lblAircraft.Text = aircraft;
            txtdate.Text = date;
            txttime.Text = time;
            txteconomy.Text = eprice;

        }
        xulyform2 xl = new xulyform2();
        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                xl.update(lblID, txtdate, txttime, txteconomy);
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
            catch (Exception a)
            {
                a.ToString();
                MessageBox.Show("Bạn nhập sai dữ liệu");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }        
        private void Form2_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
        }
    }
}
