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
        MainFrameService _mainFrameService;
        public CheckTimetablePresentor(IKernel kernel, CheckTimetableService service,MainFrameService mainFrameService, ICheckTimetable view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _mainFrameService = mainFrameService;
        }


    }
    
}
