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
    public class FeederControlPresentor : AbstractPresenter<IFeederControlService,IFeederControl>
    {
        public FeederControlPresentor(IKernel kernel, FeederControlService service, IFeederControl view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;

            (_view as IFeederControl).ClickPourFeed += () => ClickPourFeed();
            (_view as IFeederControl).ClickSwitchMode += () => ClickSwitchMode();
            (_view as IFeederControl).ClickCreateTag += () => ClickCreateTag();

        }
        private void ClickSwitchMode()
        {
            _kernel.Get<SwitchModePresentor>().Run();
        }
        private void ClickPourFeed()
        {
            _kernel.Get<PourFeedPresentor>().Run();
        }

        private void ClickCreateTag()
        {
            
                var view = _view as IFeederControl;
                var service = _service as FeederControlService;

                try
                {
                    service.FeederName = view.FeederName;                 
                }
                catch
                {
                    throw new NotImplementedException();
                }
            
        }

    }
}
