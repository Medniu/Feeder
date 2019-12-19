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
    public class SetTimeTablePresentor : AbstractPresenter<ISetTimeTableService, ISetTimetable>
    {
        private IMainFrameService _mainFrameService;
        public SetTimeTablePresentor(IKernel kernel, SetTimeTableService service,IMainFrameService mainFrameService, ISetTimetable view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
            _mainFrameService = mainFrameService;

            _view.SetTimeTable += () => SetTimeTable();
        }
        private void SetTimeTable()
        {
            // todo 
            // add try catch validation
            _service.Field_1 = _view.Field_1;
            _service.Field_2 = _view.Field_2;
            _service.Field_3 = _view.Field_3;
            _service.Field_4 = _view.Field_4;
            _service.Field_5 = _view.Field_5;
            _service.Field_6 = _view.Field_6;
            _service.Field_7 = _view.Field_7;
            _service.Field_8 = _view.Field_8;
            _service.Field_9 = _view.Field_9;
            _service.Field_10 = _view.Field_10;

            _mainFrameService.SelectedFeeder.TimeTable = _service.GetTimeTable();
        }

        
    }
}
