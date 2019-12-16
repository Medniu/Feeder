using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface IAddFeeder : IView
    {
        event Action CreateFeeder;
        event Action UpdateUserList;
        event Action SelectedUserChanged;
        string UserName { get; }
        string FeederName { get; }

        void UpdateListOfUsers(List<string> userNames);
    }
}
