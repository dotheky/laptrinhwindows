using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_DoTheKy_2385
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        xulyform3 xl = new xulyform3();
        QLyLichBayDataContext db = new QLyLichBayDataContext();
        private void btnimport_Click(object sender, EventArgs e)
        {
            int thanhcong = 0;
            int trung = 0;
            int loi = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection con = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + openFileDialog1.FileName + "';Extended Properties=Excel 8.0;");
                DataTable table = new DataTable();
                OleDbDataAdapter dap = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", con);
                try
                {
                    dap.Fill(table);
                }
                catch
                {
                    MessageBox.Show("File không hợp lệ");
                }
                txt_URL_ipmort.Text = openFileDialog1.FileName;
                foreach (DataRow row in table.Rows)
                {
                    try
                    {
                        if (row[0].ToString() == "" || row[1].ToString() == "" || row[2].ToString() == "" || row[3].ToString() == "" || row[4].ToString() == "" || row[5].ToString() == "" || row[6].ToString() == "" || row[7].ToString() == "" || row[8].ToString() == "")
                        {
                            loi++;
                        }
                        else
                        {
                            string from = Convert.ToString(row[4]);
                            string to = Convert.ToString(row[5]);

                            int IDto = xl.layIDft(to);
                            int IDfrom = xl.layIDft(from);

                            if (row[0].ToString() == "ADD")
                            {
                                if (row[8].ToString() == "OK" || row[8].ToString() == "CANCELLED")
                                {
                                    if (xl.layIDroutes(IDfrom, IDto) != 0)
                                    {
                                        string timeex = Convert.ToDateTime(row[2].ToString()).ToString("HH:mm");
                                        Schedule sch = new Schedule();
                                        sch.Date = Convert.ToDateTime(row[1]);
                                        sch.Time = TimeSpan.Parse(timeex);
                                        sch.RouteID = xl.layIDroutes(IDfrom, IDto);
                                        sch.FlightNumber = Convert.ToString(row[3]);
                                        sch.AircraftID = Convert.ToInt32(row[6]);
                                        sch.EconomyPrice = decimal.Parse(row[7].ToString());

                                        if (row[8].ToString() == "OK")
                                        {
                                            sch.Confirmed = true;
                                        }
                                        else if (row[8].ToString() == "CANCELLED")
                                        {
                                            sch.Confirmed = false;

                                        }
                                        if (xl.Kttontai(Convert.ToString(row[1]), Convert.ToString(row[3])) == 0)
                                        {
                                            db.Schedules.InsertOnSubmit(sch);
                                            db.SubmitChanges();
                                            thanhcong++;
                                        }
                                        else
                                            trung++;
                                    }
                                    else
                                        loi++;
                                    
                                }
                                else
                                    loi++;
                            }
                            if ((row[0].ToString() == "EDIT"))
                            {
                                if (row[8].ToString() == "OK" || row[8].ToString() == "CANCELLED")
                                {
                                    if (xl.layIDroutes(IDfrom, IDto) != 0)
                                    {
                                        if (xl.Kttontai(Convert.ToString(row[1]), Convert.ToString(row[3])) == 1)
                                        {
                                            Schedule sch = db.Schedules.SingleOrDefault(sp => sp.ID == xl.layidsua(Convert.ToString(row[1]), Convert.ToString(row[3])));
                                            sch.Time = TimeSpan.Parse(Convert.ToDateTime(row[2].ToString()).ToString("HH:mm"));
                                            sch.RouteID = xl.layIDroutes(IDfrom, IDto);
                                            sch.AircraftID = Convert.ToInt32(row[6]);
                                            sch.EconomyPrice = decimal.Parse(row[7].ToString());
                                            if (row[8].ToString() == "OK")
                                                sch.Confirmed = true;
                                            else if(row[8].ToString() == "CANCELLED")
                                                sch.Confirmed = false;
                                            db.SubmitChanges();
                                            thanhcong++;
                                        }
                                        else
                                            loi++;
                                    }
                                    else
                                        loi++;
                                }
                                else
                                    loi++;
                            }

                        }
                    }
                    catch
                    {
                        loi++;
                    }
                }
            }
            lblthanhcong.Text = thanhcong.ToString();
            lblloitrung.Text = trung.ToString();
            lblloikhac.Text = loi.ToString();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn quay lại Manage Flight Schedules?", "", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
