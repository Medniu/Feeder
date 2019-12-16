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
    public class MakeRequestPresentor : AbstractPresenter<IMakeRequestService, IMakeRequest>
    {
        public MakeRequestPresentor(IKernel kernel, MakeRequestService service, IMakeRequest view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            _view.ClickMakeRequest += () => MakeRequest();
        }

        private void MakeRequest()
        {
            //try
            //{
                _service.AddRequest(_view.Request);
            //}
            //catch(Exception e)
            //{
            //    // todo
            //    // add show error message
            //}
        }
    }
}
