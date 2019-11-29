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
    public class MainFormPresenter : AbstractPresenter
    {
        public MainFormPresenter(IKernel kernel, IMainFrameService service, IMainForm view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            (_view as IMainForm).ClickFeederControl += () => ClickFeederControl();
            (_view as IMainForm).ClickAddFeeder += () => ClickAddFeeder();
            (_view as IMainForm).ClickCheckState += () => ClickCheckState();
            (_view as IMainForm).ClickCheckTimetable += () => ClickCheckTimetable();
            (_view as IMainForm).ClickCreateUser += () => ClickCreateUser();
            (_view as IMainForm).ClickGetLogs += () => ClickGetLogs();
            (_view as IMainForm).ClickSetTimeTable += () => ClickSetTimeTable();
            (_view as IMainForm).ClickMakeRequest += () => ClickMakeRequest();

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
        
        
        
    }
}
