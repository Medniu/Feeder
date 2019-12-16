using Ninject;
using Presentation.Forms;
using Model.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presentors
{
   public  class AddFeederPresentor : AbstractPresenter<IAddFeederService,IAddFeeder>
   {
        private IMainFrameService _mainFrameService;
        public AddFeederPresentor(IKernel kernel, AddFeederService service,IMainFrameService mainFrameService, IAddFeeder view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
            _mainFrameService = mainFrameService;

            _view.CreateFeeder += () => CreateFeeder();
            _view.UpdateUserList += () => UpdateUserList();
            _view.SelectedUserChanged += () => SelectedUserChanged();
        }

        private void CreateFeeder()
        {
            // нахуй убрать потом
            var feeder = new Model.Entity.Feeder();
            feeder.Name = _view.FeederName;
            _service.CreateFeeder(feeder);


        }

        private void UpdateUserList()
        {
            _view.UpdateListOfUsers(_mainFrameService.Users.Select(u => u.Name).ToList());
        }

        private void SelectedUserChanged()
        {
            _service.SetSelectedUser(_view.UserName);
        }
    }
}
