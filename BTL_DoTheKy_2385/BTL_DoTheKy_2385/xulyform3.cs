using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace BTL_DoTheKy_2385
{
    class xulyform3
    {
        QLyLichBayDataContext db = new QLyLichBayDataContext();
        public int layIDft(string iatacode)
        {
            Airport layid = db.Airports.Where(aip => aip.IATACode.Equals(iatacode)).SingleOrDefault();
               
            
            return Convert.ToInt32(layid.ID);
            
        }
        public int layIDroutes(int f, int t)
        {
            Route layid = db.Routes.Where(rou => rou.DepartureAirportID.Equals(f) && rou.ArrivalAirportID.Equals(t)).SingleOrDefault();

            if (layid != null)
            {
                return Convert.ToInt32(layid.ID);
            }
            else
            {
                return 0;
            }
                
            
        }
        public int Kttontai(string date, string fl)
        {
            Schedule layid = db.Schedules.Where(sch => sch.Date.Equals(Convert.ToDateTime(date)) && sch.FlightNumber.Equals(Convert.ToInt32(fl))).SingleOrDefault();
            if (layid!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int layidsua(string date, string fl)
        {            
            Schedule layid = db.Schedules.Where(sch => sch.Date.Equals(Convert.ToDateTime(date)) && sch.FlightNumber.Equals(Convert.ToInt32(fl))).SingleOrDefault();
            return Convert.ToInt32(layid.ID);
        }
    }
}
