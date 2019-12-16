using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public class CreateUserService : ICreateUserService
    {
        private readonly IRepository<User> _repository;
        public CreateUserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public IEnumerable<string> GetAllCharacters()
        {
            return _repository.GetAll().Select(c => c.Name);
        }
        public void CreateCharacter(string name)
        {
            var character = _repository.GetAll().FirstOrDefault(c => c.Name == name);
            if (character == null)
            {
                _repository.Add(new User { Name = name });
                _repository.Save();
                CharacterUpdated?.Invoke();
            }
        }
        public event Action CharacterUpdated;

        public void AddUser(User user)
        {
            _repository.Add(user);
        }
    }
}
