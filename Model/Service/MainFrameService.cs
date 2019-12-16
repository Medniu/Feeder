using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class MainFrameService : IMainFrameService
    {
        private readonly ITimer _timer;

        public event Action UpdateRequests;
        public event Action UpdateUsers;
        public event Action UpdateFeederList;

        public IEnumerable<string> Requests { get; set; }
        public IEnumerable<User> Users { get; set; }

        private IRepository <string> _request_repository { get; set; }
        private IRepository<User> _user_repository { get; set; }
        public User SelectedUser { get ; private set ; }

        public Feeder SelectedFeeder { get; private set; }

        public MainFrameService(ITimer timer , IRepository<string> request_repository,IRepository <User> user_repository)
        {
            _timer = timer;
            _timer.Interval = 1000;
            _timer.Tick += TimerTick;
            _timer.Start();

            _request_repository = request_repository;
            _user_repository = user_repository;
        }



        private void TimerTick(object sender, EventArgs e)
        {
            Requests = _request_repository.GetAll();
            Users = _user_repository.GetAll();
            UpdateUsers?.Invoke();
            UpdateRequests?.Invoke();
        }

        public void SetSelectedUser(string userName)
        {
            SelectedUser = 
                _user_repository.GetAll()
                .Where(u => u.Name == userName).FirstOrDefault();

            UpdateFeederList?.Invoke();
        }

        public void SetSelectedFeeder(string feederName)
        {
            SelectedFeeder =
                SelectedUser.Feeders
                .Where(u => u.Name == feederName).FirstOrDefault();
        }
    }
}
