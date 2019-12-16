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
    class GetLogsPresentor : AbstractPresenter<IGetLogsService, IGetLogs>
    {
        public GetLogsPresentor(IKernel kernel, GetLogsService service, IGetLogs view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
        }
    }
}
