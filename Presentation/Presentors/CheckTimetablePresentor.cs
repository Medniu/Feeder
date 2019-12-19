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
    public class CheckTimetablePresentor : AbstractPresenter<ICheckTimetableService,ICheckTimetable>
    {
        IMainFrameService _mainFrameService;
        public CheckTimetablePresentor(IKernel kernel, CheckTimetableService service,IMainFrameService mainFrameService, ICheckTimetable view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _mainFrameService = mainFrameService;
            _view.UpdateFields += () => UpdateFields();
        }

        private void UpdateFields()
        {
            _view.Field_1 = _mainFrameService.SelectedFeeder.TimeTable[4].ToString();
            _view.Field_2 = _mainFrameService.SelectedFeeder.TimeTable[8].ToString();
            _view.Field_3 = _mainFrameService.SelectedFeeder.TimeTable[10].ToString();
            _view.Field_4 = _mainFrameService.SelectedFeeder.TimeTable[12].ToString();
            _view.Field_5 = _mainFrameService.SelectedFeeder.TimeTable[14].ToString();
            _view.Field_6 = _mainFrameService.SelectedFeeder.TimeTable[16].ToString();
            _view.Field_7 = _mainFrameService.SelectedFeeder.TimeTable[18].ToString();
            _view.Field_8 = _mainFrameService.SelectedFeeder.TimeTable[20].ToString();
            _view.Field_9 = _mainFrameService.SelectedFeeder.TimeTable[22].ToString();
            _view.Field_10 = _mainFrameService.SelectedFeeder.TimeTable[0].ToString();

        }
    }
    
}
