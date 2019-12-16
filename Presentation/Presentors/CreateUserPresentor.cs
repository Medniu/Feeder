using Model.Service;
using Ninject;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presentors
{
    public class CreateUserPresentor : AbstractPresenter<ICreateUserService,ICreateUser>
    {
        public CreateUserPresentor(IKernel kernel, CreateUserService service, ICreateUser view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _view.AddUser += () => AddUser();
        }

        private void AddUser()
        {
            var user = new Model.Entity.User();
            user.Name = _view.CharacterName; 
            _service.AddUser(user);
        }
    }

}
