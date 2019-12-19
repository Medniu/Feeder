using Model;
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
    public class MainFormPresenter : AbstractPresenter<IMainFrameService, IMainForm>
    {
        public MainFormPresenter(IKernel kernel, IMainFrameService service, IMainForm view) : base()
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _view.ClickFeederControl += () => ClickFeederControl();
            _view.ClickAddFeeder += () => ClickAddFeeder();
            _view.ClickCheckState += () => ClickCheckState();
            _view.ClickCheckTimetable += () => ClickCheckTimetable();
            _view.ClickCreateUser += () => ClickCreateUser();
            _view.ClickGetLogs += () => ClickGetLogs();
            _view.ClickSetTimeTable += () => ClickSetTimeTable();
            _view.ClickMakeRequest += () => ClickMakeRequest();
            _view.SelectedUserChanged += () => SelectedUserChanged();
            _view.SelectedFeederChanged += () => SelectedFeederChanged();

            _service.UpdateRequests += () => UpdateRequests();
            _service.UpdateUsers += () => UpdateUsers();
            _service.UpdateFeederList += () => UpdateFeederList();

        }

        private void ClickFeederControl()
        {
            _kernel.Get<FeederControlPresentor>().Run();
        }
        private void ClickAddFeeder()
        {
            _kernel.Get<AddFeederPresentor>().Run();
        }
        private void ClickCheckState()
        {
            _kernel.Get<CheckStatePresentor>().Run();
        }
        private void ClickCheckTimetable()
        {
            _kernel.Get<CheckTimetablePresentor>().Run();
        }

        private void ClickCreateUser()
        {
            _kernel.Get<CreateUserPresentor>().Run();
        }
        private void ClickGetLogs()
        {
            _kernel.Get<GetLogsPresentor>().Run();
        }
        private void ClickSetTimeTable()
        {
            _kernel.Get<SetTimeTablePresentor>().Run();
        }
        private void ClickMakeRequest()
        {
            _kernel.Get<MakeRequestPresentor>().Run();
        }
        
        private void UpdateRequests()
        {
            var message = String.Empty;
            foreach (var req in _service.Requests)
                message += req + " , ";
            _view.RequestsTextBox = message;
        }

        private void UpdateUsers()
        {
            _view.UpdateUsers(_service.Users.Select(u => u.Name).ToList());
        }
        
        private void SelectedUserChanged()
        {
            switch(_view.CurrentTab)
            {
                case CurrentTab.Admin:
                    _service.SetSelectedUser(_view.AdminTabUserCombobox);
                    break;
                case CurrentTab.User:
                    _service.SetSelectedUser(_view.UserTabUserCombobox);
                    break;
            }; 
        }

        private void SelectedFeederChanged()
        {
            switch (_view.CurrentTab)
            {
                case CurrentTab.Admin:
                    _service.SetSelectedFeeder(_view.AdminTabFeederCombobox);
                    break;
                case CurrentTab.User:
                    _service.SetSelectedFeeder(_view.UserTabFeederCombobox);
                    break;
            };
        }

        private void UpdateFeederList()
        {
            switch (_view.CurrentTab)
            {
                case CurrentTab.Admin:
                    _view.UpdateAdminTabFeederList(_service.SelectedUser.Feeders.Select(f => f.Name).ToList());
                    break;
                case CurrentTab.User:
                    _view.UpdateUserTabFeederList(_service.SelectedUser.Feeders.Select(f => f.Name).ToList());
                    break;
            };
        }
    }
}
