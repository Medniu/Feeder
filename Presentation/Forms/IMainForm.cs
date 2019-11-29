using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface IMainForm : IView
    {
        event Action ClickFeederControl;
        event Action ClickAddFeeder;
        event Action ClickCheckState;
        event Action ClickCheckTimetable;
        event Action ClickCreateUser;
        event Action ClickGetLogs;
        event Action ClickSetTimeTable;
        event Action ClickMakeRequest;
    }
}
