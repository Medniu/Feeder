using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IMakeRequestService : IService
    {
        void AddRequest(string message);

        List<string> Requests { get; set; }
    }
}
