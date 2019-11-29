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
    public class CheckTimetablePresentor : AbstractPresenter
    {
        
        public CheckTimetablePresentor(IKernel kernel, CheckTimetableService service, ICheckTimetable view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
        }
    }
    
}
