using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TimeList
    {
        private List<String> timeList;
        private List<String> dateList;
     

        public TimeList()
        {
            this.timeList = new List<String>();
            this.dateList = new List<String>();
        }

        public void add(String time, String date)
        {
            timeList.Add(time);
            dateList.Add(date);

        }

        public void removeAt(int index)
        {
            timeList.RemoveAt(index);
            dateList.RemoveAt(index);
        }

        public string getTimeAt(int index)
        {
            try
            {
                return timeList.ElementAt(index);
            }
            catch(Exception e)
            {
                return "";
            }
        }

        public string getDateAt(int index)
        {
            try
            {
                return dateList.ElementAt(index);
            }
            catch (Exception e)
            {
                return "";
            }
        }
            
    }
}
