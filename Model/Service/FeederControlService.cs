using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class FeederControlService : IFeederControlService
    {
        public string FeederName { get => _feederName; set { if (value.Length > 0) _feederName = value; else throw new ArgumentException($"{value} is empty"); } }

        private string _feederName;
    }
}
