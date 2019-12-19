using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;

namespace Model.Service
{
    public class SetTimeTableService : ISetTimeTableService
    {
        public string Field_1 { get; set; }
        public string Field_2 { get; set; }
        public string Field_3 { get; set; }
        public string Field_4 { get; set; }
        public string Field_5 { get; set; }
        public string Field_6 { get; set; }
        public string Field_7 { get; set; }
        public string Field_8 { get; set; }
        public string Field_9 { get; set; }
        public string Field_10 { get; set; }


        public TimeTable GetTimeTable()
        {
            TimeTable timeTable = new TimeTable();
            timeTable.TimeValue.Add((4, double.Parse(Field_1)));
            timeTable.TimeValue.Add((8, double.Parse(Field_2)));
            timeTable.TimeValue.Add((10, double.Parse(Field_3)));
            timeTable.TimeValue.Add((12, double.Parse(Field_4)));
            timeTable.TimeValue.Add((14, double.Parse(Field_5)));
            timeTable.TimeValue.Add((16, double.Parse(Field_6)));
            timeTable.TimeValue.Add((18, double.Parse(Field_7)));
            timeTable.TimeValue.Add((20, double.Parse(Field_8)));
            timeTable.TimeValue.Add((22, double.Parse(Field_9)));
            timeTable.TimeValue.Add((0, double.Parse(Field_10)));
            return timeTable;
        }
    }
}
