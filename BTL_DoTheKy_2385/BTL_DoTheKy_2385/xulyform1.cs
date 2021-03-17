using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL_DoTheKy_2385
{
    public class xulyform1
    {

        QLyLichBayDataContext db = new QLyLichBayDataContext();
        //hiển thị và sắp xếp theo ngày
        public void sx_date_hienthi(DataGridView dgv)
        {
            
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID  equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending , a.Time descending
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };
            dgv.DataSource = ds;
        }
        // sắp xếp theo economy
        public void sx_economy(DataGridView dgv)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.EconomyPrice descending , a.Date descending, a.Time descending
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };
            dgv.DataSource = ds;
        }
        //sắp xếp confirmed
        public void sx_confirmed(DataGridView dgv)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Confirmed descending , a.Date descending, a.Time descending
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //tạo combo from và to
        public void taocombo(ComboBox cbf, ComboBox cbt)
        {
            var f = from a in db.Airports
                    select a.IATACode;
            cbf.DataSource = f;
            var t = from a in db.Airports
                    select a.IATACode;
            cbt.DataSource = t;
            cbf.SelectedItem =null;
            cbt.SelectedItem =null;
        }
        //1. tìm kiếm theo sân bay đi
        public void tim_kiem_theo_san_bay_f(DataGridView dgv, ComboBox cbf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals(cbf.SelectedValue.ToString())
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //2. tìm kiếm theo sân bay đến
        public void tim_kiem_theo_san_bay_t(DataGridView dgv, ComboBox cbt)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where e.IATACode.Equals(cbt.SelectedValue.ToString())
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed            
                     };

            dgv.DataSource = ds;
        }
        //3. tìm kiếm theo sân bay đi và đến
        public void tim_kiem_theo_san_bay_f_t(DataGridView dgv, ComboBox cbf, ComboBox cbt)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals( cbf.SelectedValue.ToString()) 
                     && e.IATACode.Equals(cbt.SelectedValue.ToString())
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //4. tìm kiếm theo sân bay đi, ngày
        public void tim_kiem_theo_san_bay_f_d(DataGridView dgv, ComboBox cbf, TextBox txtd)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals(cbf.SelectedValue.ToString()) 
                     && a.Date.Equals(Convert.ToDateTime(txtd.Text))
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //5. tìm kiếm theo sân bay đến ,ngày
        public void tim_kiem_theo_san_bay_t_d(DataGridView dgv, ComboBox cbt, TextBox txtd)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where e.IATACode.Equals(cbt.SelectedValue.ToString()) 
                     && a.Date.Equals(Convert.ToDateTime(txtd.Text))
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //6. tìm kiếm theo sân bay đi, số lượt
        public void tim_kiem_theo_san_bay_f_f(DataGridView dgv, ComboBox cbf, TextBox txtf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals(cbf.SelectedValue.ToString()) && a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //7. tìm kiếm theo sân bay đến và số lượt
        public void tim_kiem_theo_san_bay_t_f(DataGridView dgv, ComboBox cbt, TextBox txtf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where e.IATACode.Equals(cbt.SelectedValue.ToString()) && a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //8. tìm kiếm theo sân bay đi, ngày và số lượt
        public void tim_kiem_theo_san_bay_f_d_f(DataGridView dgv, ComboBox cbf, TextBox txtd, TextBox txtf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals(cbf.SelectedValue.ToString())
                     && a.Date.Equals(Convert.ToDateTime(txtd.Text)) && a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //9. tìm kiếm theo sân bay đến, ngày và số lượt
        public void tim_kiem_theo_san_bay_t_d_f(DataGridView dgv, ComboBox cbt, TextBox txtd, TextBox txtf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where e.IATACode.Equals(cbt.SelectedValue.ToString())
                     && a.Date.Equals(Convert.ToDateTime(txtd.Text)) && a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //10. tìm kiếm theo sân bay đi,đến và ngày
        public void tim_kiem_theo_san_bay_f_t_d(DataGridView dgv, ComboBox cbf, ComboBox cbt, TextBox txtd)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals(cbf.SelectedValue.ToString()) && e.IATACode.Equals(cbt.SelectedValue.ToString())
                     && a.Date.Equals(Convert.ToDateTime(txtd.Text))
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //11. tìm kiếm theo sân bay đi, đến và số lượt bay
        public void tim_kiem_theo_san_bay_f_t_f(DataGridView dgv, ComboBox cbf, ComboBox cbt, TextBox txtf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where d.IATACode.Equals(cbf.SelectedValue.ToString()) && e.IATACode.Equals(cbt.SelectedValue.ToString())
                      && a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //12. tìm kiếm cả 4 tt
        public void tim_kiem_theo_san_bay_f_t_d_f(DataGridView dgv, ComboBox cbf, ComboBox cbt, TextBox txtd,TextBox txtf)
            {
                var ds = from a in db.Schedules
                         join b in db.Routes on a.RouteID equals b.ID
                         join c in db.Aircrafts on a.AircraftID equals c.ID
                         join d in db.Airports on b.DepartureAirportID equals d.ID
                         join e in db.Airports on b.ArrivalAirportID equals e.ID
                         orderby a.Date descending, a.Time descending
                         where d.IATACode.Equals(cbf.SelectedValue.ToString()) && e.IATACode.Equals(cbt.SelectedValue.ToString())
                         && a.Date.Equals(Convert.ToDateTime(txtd.Text)) && a.FlightNumber.Equals(txtf.Text)
                         select new
                         {
                             a.ID,
                             Date = a.Date,
                             Time = a.Time,
                             From = d.IATACode,
                             To = e.IATACode,
                             Flight_Number = a.FlightNumber,
                             Aircraft = c.Name,
                             Economy_Price = a.EconomyPrice,
                             Bussiness_Price = a.EconomyPrice * 135 / 100,
                             First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                             a.Confirmed
                         };

                dgv.DataSource = ds;
            }
        //13. tìm kiếm theo ngày và số lượt bay
        public void tim_kiem_theo_ngay_flight(DataGridView dgv, TextBox txtd, TextBox txtf)
        {
            
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where a.Date.Equals(Convert.ToDateTime(txtd.Text)) && a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //14. tìm kiếm theo ngày
        public void tim_kiem_theo_ngay(DataGridView dgv, TextBox txtd)
        {

            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where a.Date.Equals(Convert.ToDateTime(txtd.Text))
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        //15. tìm kiếm theo số lượt bay
        public void tim_kiem_theo_flight(DataGridView dgv,  TextBox txtf)
        {
            var ds = from a in db.Schedules
                     join b in db.Routes on a.RouteID equals b.ID
                     join c in db.Aircrafts on a.AircraftID equals c.ID
                     join d in db.Airports on b.DepartureAirportID equals d.ID
                     join e in db.Airports on b.ArrivalAirportID equals e.ID
                     orderby a.Date descending, a.Time descending
                     where a.FlightNumber.Equals(txtf.Text)
                     select new
                     {
                         a.ID,
                         Date = a.Date,
                         Time = a.Time,
                         From = d.IATACode,
                         To = e.IATACode,
                         Flight_Number = a.FlightNumber,
                         Aircraft = c.Name,
                         Economy_Price = a.EconomyPrice,
                         Bussiness_Price = a.EconomyPrice * 135 / 100,
                         First_Class_price = a.EconomyPrice * 135 / 100 * 130 / 100,
                         a.Confirmed
                     };

            dgv.DataSource = ds;
        }
        public void DoiMau(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
                if (Convert.ToBoolean(row.Cells[10].Value) == false)
                    row.DefaultCellStyle.BackColor = Color.Red;
        }
        public void cancel_confirm(DataGridView dgv)
        {
            int index = dgv.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgv.Rows[index];                         
            Boolean Confirmed = Convert.ToBoolean(row.Cells[10].Value);           
            int id = Convert.ToInt32(row.Cells[0].Value);
            Schedule can_con = db.Schedules.Where(sch => sch.ID.Equals(id)).SingleOrDefault();
            if (Confirmed == true)
            {
                DialogResult d = MessageBox.Show("Bạn muốn hủy chuyến bay?", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    can_con.Confirmed = false;
                    db.SubmitChanges();
                    MessageBox.Show("Chuyến bay đã được hủy!");
                }                
            }
            else
            {
                DialogResult d = MessageBox.Show("Bạn muốn xác nhận chuyến bay?", "", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    can_con.Confirmed = true;
                    db.SubmitChanges();
                    MessageBox.Show("Chuyến bay đã được xác nhận!");
                }
            }
        }
    }
}
