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
   public  class AddFeederPresentor : AbstractPresenter
   {
        public AddFeederPresentor(IKernel kernel, AddFeederService service, IAddFeeder view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
        }
    }
}
