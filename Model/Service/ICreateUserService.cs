using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Service
{
    public interface ICreateUserService : IService
    {
        event Action CharacterUpdated;
        IEnumerable<string> GetAllCharacters();
        void CreateCharacter(string name);

        void AddUser(User user);
    }
}
