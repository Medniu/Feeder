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
    public class CheckStatePresentor : AbstractPresenter<ICheckStateService, ICheckState>
    {
        public CheckStatePresentor(IKernel kernel, CheckStateService service, ICheckState view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
        }
    }
}
