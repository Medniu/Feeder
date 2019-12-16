using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IMainFrameService : IService
    {
        IEnumerable<string> Requests { get; set; }

        IEnumerable<User> Users { get; set; }

        event Action UpdateRequests;
        event Action UpdateUsers;
        event Action UpdateFeederList;

        User SelectedUser { get; }
        Feeder SelectedFeeder { get; }
        void SetSelectedUser(string userName);
        void SetSelectedFeeder(string feederName);

    }
}
