using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface ISetTimetable : IView
    {
        event Action SetTimeTable;

        string Field_1 { get; set; }
        string Field_2 { get; set; }
        string Field_3 { get; set; }
        string Field_4 { get; set; }
        string Field_5 { get; set; }

        string Field_6 { get; set; }
        string Field_7 { get; set; }
        string Field_8 { get; set; }
        string Field_9 { get; set; }
        string Field_10 { get; set; }
    }

}
