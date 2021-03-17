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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        xulyform1 xl = new xulyform1();
        private void Form1_Load(object sender, EventArgs e)
        {            
            xl.sx_date_hienthi(dgvds);
            xl.taocombo(cbfrom, cbto);
            xl.DoiMau(dgvds);
            dgvds.Columns[0].Visible = false;
            dgvds.Columns[10].Visible = false;
        }       
        private void btnCancel_Click(object sender, EventArgs e)
        {      
            xl.cancel_confirm(dgvds);            
            xl.sx_date_hienthi(dgvds);
            xl.DoiMau(dgvds);
        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            int index = dgvds.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvds.Rows[index];
            int id = Convert.ToInt32(row.Cells[0].Value);
            string date = Convert.ToString(row.Cells[1].Value);
            string time = Convert.ToString(row.Cells[2].Value);          
            string from = Convert.ToString(row.Cells[3].Value);
            string to = Convert.ToString(row.Cells[4].Value);
            string aircraft = Convert.ToString(row.Cells[6].Value);
            string eprice = Convert.ToString(row.Cells[7].Value);            
            this.Hide();            
            Form2 frm2 = new Form2(id,date,time,from,to,aircraft,eprice);
            frm2.Show();

        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbfrom.SelectedIndex == cbto.SelectedIndex && cbfrom.SelectedItem != null)
                    MessageBox.Show("Không thể tìm kiếm nếu điểm đi và đến giống nhau!!");
                //1. tìm kiếm theo sân bay đi
                else if (cbfrom.SelectedItem != null && cbto.SelectedItem == null
                    && txtdate.Text == "" && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_san_bay_f(dgvds, cbfrom);
                //2. tìm kiếm theo sân bay đến
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem != null
                    && txtdate.Text == "" && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_san_bay_t(dgvds, cbto);
                //3. tìm kiếm theo sân bay đi và đến
                else if (cbfrom.SelectedItem != cbto.SelectedItem && txtdate.Text == ""
                    && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_san_bay_f_t(dgvds, cbfrom, cbto);
                //4. tìm kiếm theo sân bay đi, ngày
                else if (cbfrom.SelectedItem != null && cbto.SelectedItem == null
                    && txtdate.Text != "" && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_san_bay_f_d(dgvds, cbfrom, txtdate);
                //5. tìm kiếm theo sân bay đến ,ngày
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem != null
                    && txtdate.Text != "" && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_san_bay_t_d(dgvds, cbto, txtdate);
                //6. tìm kiếm theo sân bay đi, số lượt
                else if (cbfrom.SelectedItem != null && cbto.SelectedItem == null
                    && txtdate.Text == "" && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_san_bay_f_f(dgvds, cbfrom, txtFlightNumber);
                //7. tìm kiếm theo sân bay đến và số lượt
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem != null
                    && txtdate.Text == "" && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_san_bay_t_f(dgvds, cbto, txtFlightNumber);
                //8. tìm kiếm theo sân bay đi, ngày và số lượt
                else if (cbfrom.SelectedItem != null && cbto.SelectedItem == null
                    && txtdate.Text != "" && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_san_bay_f_d_f(dgvds, cbfrom, txtdate, txtFlightNumber);
                //9. tìm kiếm theo sân bay đến, ngày và số lượt
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem != null
                    && txtdate.Text != "" && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_san_bay_t_d_f(dgvds, cbto, txtdate, txtFlightNumber);
                //10. tìm kiếm theo sân bay đi, đến và ngày bay
                else if (cbfrom.SelectedItem != cbto.SelectedItem && txtdate.Text != ""
                    && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_san_bay_f_t_d(dgvds, cbfrom, cbto, txtdate);
                //11. tìm kiếm theo sân bay đi, đến và số lượt bay
                else if (cbfrom.SelectedItem != cbto.SelectedItem && txtdate.Text == ""
                    && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_san_bay_f_t_f(dgvds, cbfrom, cbto, txtFlightNumber);
                //12. tìm kiếm cả 4 tt 
                else if (cbfrom.SelectedItem != cbto.SelectedItem && txtdate.Text != ""
                    && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_san_bay_f_t_d_f(dgvds, cbfrom, cbto, txtdate, txtFlightNumber);
                //13. tìm kiếm theo ngày và số lượt bay
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem == null
                    && txtdate.Text != "" && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_ngay_flight(dgvds, txtdate, txtFlightNumber);
                //14. tìm kiếm theo ngày
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem == null
                    && txtdate.Text != "" && txtFlightNumber.Text == "")
                    xl.tim_kiem_theo_ngay(dgvds, txtdate);
                //15. tìm kiếm theo số lượt bay
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem == null
                    && txtdate.Text == "" && txtFlightNumber.Text != "")
                    xl.tim_kiem_theo_flight(dgvds, txtFlightNumber);
                //16. TH không nhập
                else if (cbfrom.SelectedItem == null && cbto.SelectedItem == null
                    && txtdate.Text == "" && txtFlightNumber.Text == "")
                    xl.sx_date_hienthi(dgvds);
                xl.DoiMau(dgvds);
            }
            catch(Exception a)
            {
                a.ToString();
                MessageBox.Show("Bạn nhập sai dữ liệu trường Outbound(Ngày-Tháng)");
            }
        }
        private void cbsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsx.Text == "Date-time")
            {
                xl.sx_date_hienthi(dgvds);
            }
            else if (cbsx.Text == "Economy")
            {
                xl.sx_economy(dgvds);
            }
            else if (cbsx.Text == "Confirmed")
            {
                xl.sx_confirmed(dgvds);
            }
            xl.DoiMau(dgvds);
        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgvds.Rows[index];
                txtdate.Text = Convert.ToString(row.Cells[1].Value);
                cbfrom.Text = Convert.ToString(row.Cells[3].Value);
                cbto.Text = Convert.ToString(row.Cells[4].Value);
                txtFlightNumber.Text = Convert.ToString(row.Cells[5].Value);
                Boolean Confirmed = Convert.ToBoolean(row.Cells[10].Value);
                if (Confirmed == true)
                    btnCancel.Text = "Cancel Flight";
                else
                    btnCancel.Text = "Confirm Flight";
            }
            catch (Exception a)
            {
                a.ToString();
            }
        }

        
    }
}
