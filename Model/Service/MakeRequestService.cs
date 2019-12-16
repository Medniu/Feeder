using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class MakeRequestService : IMakeRequestService
    {
        private readonly ITimer _timer;
        private IRepository<string> _repository;
        public MakeRequestService(ITimer timer, IRepository<string> repository)
        {
            Requests = new List<string>();
            _timer = timer;
            _timer.Interval = 110;
            _timer.Tick += TimerTick;
            _timer.Start();

            _repository = repository;
        }

        public List<string> Requests { get; set; }

        public void AddRequest(string message)
        {
            if (message.Length > 0)
            {
                Requests.Add(message);
            }
            else
            {
                throw new ArgumentException("Not valid message");
            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            foreach (var item in Requests)
            {
                _repository.Add(item);
            }
            Requests = new List<string>();
        }
    }
}
