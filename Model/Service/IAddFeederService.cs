using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface IAddFeederService : IService
    {
        //event Action FoodUpdated;

       // event Action FeederUpdated;
        IEnumerable<string> GetRemainingCharacters();
        //void AddFood(string name, int amount_of_food);       
        IEnumerable<string> GetAllFeeders();       
        void CreateFeeder(Feeder feeder);
        User SelectedUser { get;  }
        void SetSelectedUser(string userName);
    }
}
