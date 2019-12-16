using Model;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FeederRepository :IRepository <Feeder>
    {
        private static List<Feeder> _data = new List<Feeder>();
        private static int _end_index = 0;
        public int Add(Feeder obj)
        {
            obj.Id = _end_index;
            _end_index += 1;
            _data.Add(obj);
            return obj.Id;
        }

        public void Update(Feeder obj)
        {
            var character = _data.Find(c => c.Id == obj.Id);
            if (character != null)
                character.Name = obj.Name;
        }

        public void Save()
        {
        }

        public Feeder Find(int id)
        {
            return _data.Find(c => c.Id == id);
        }

        public IEnumerable<Feeder> GetAll()
        {
            return _data;  // create copy to avoid update via reference
        }
    }
}
