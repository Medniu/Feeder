using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class AddFeederService : IAddFeederService
    {
        private IRepository<User> _user_repository;
        private IRepository<Feeder> _feeder_repository;

        public User SelectedUser { get; private set; }

        public AddFeederService(IRepository<User> user_repository, IRepository<Feeder> feeder_repository)
        {
            _user_repository = user_repository;
            _feeder_repository = feeder_repository;
        }
        public IEnumerable<string> GetAllFeeders()
        {
            return _feeder_repository.GetAll().Select(c => c.Name);
        }
        public IEnumerable<string> GetRemainingCharacters()
        {
            var users = _user_repository.GetAll();
            var feeders = _feeder_repository.GetAll();

            return users.Select(c => c.Name).Except(feeders.Select(i => i.Name));
        }

       /* public void AddFood(string name, int amount_of_food)
        {
            var entry = _feeder_repository.GetAll().FirstOrDefault(c => c.Name == name);
            if (entry == null)
            {
                _feeder_repository.Add(new Feeder { Name = name, Amount_of_food = amount_of_food });
            }
            else
            {
                entry.Amount_of_food = amount_of_food;
                _feeder_repository.Update(entry);
            }
            _feeder_repository.Save();
            FoodUpdated?.Invoke();
        }
        */
        public void CreateFeeder(Feeder feeder)
        {
            SelectedUser.Feeders.Add(feeder);
        }

        public void SetSelectedUser(string userName)
        {
            SelectedUser = _user_repository.GetAll()
                .Where(u => u.Name == userName).FirstOrDefault();
        }

       // public event Action FoodUpdated;

        //public event Action FeederUpdated;
    }
}