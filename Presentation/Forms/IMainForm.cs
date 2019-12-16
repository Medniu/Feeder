using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public enum CurrentTab
    {
        Admin,
        User
    }
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
        event Action SelectedUserChanged;
        event Action SelectedFeederChanged;

        string RequestsTextBox { get; set; }
        CurrentTab CurrentTab { get; set; }
        string AdminTabUserCombobox { get; set; }
        string UserTabUserCombobox { get; set; }
        string AdminTabFeederCombobox { get; set; }
        string UserTabFeederCombobox { get; set; }

        void UpdateUsers(IEnumerable<string> userNames);
        void UpdateAdminTabFeederList(IEnumerable<string> feederNames);
        void UpdateUserTabFeederList(IEnumerable<string> feederNames);
    }
}
