using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL_DoTheKy_2385
{
    public class xulyform2
    {
        QLyLichBayDataContext db = new QLyLichBayDataContext();
        public void update(Label id, TextBox date, TextBox time, TextBox eprice)
        {
            // lấy bản ghi có id giống với id click từ form 1 qua label id
            Schedule s = db.Schedules.Where(sch => sch.ID.Equals(Convert.ToInt32(id.Text))).SingleOrDefault();            
            DialogResult d = MessageBox.Show("Bạn có chắc muốn sửa chuyến bay này?", "", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                //gán giá trị date của bản ghi bằng giá trị nhập trên textbox
                s.Date = Convert.ToDateTime(date.Text);
                //gán giá trị time của bản ghi bằng giá trị nhập trên textbox
                s.Time = TimeSpan.Parse(time.Text);
                //gán giá trị giá tiền của bản ghi bằng giá trị nhập trên textbox
                s.EconomyPrice = decimal.Parse(eprice.Text);
                //gửi giá trị chỉnh sửa để lưu vào database
                db.SubmitChanges();
                MessageBox.Show("Đã sửa chuyến bay thành công");
            } 
        }
    }
}
