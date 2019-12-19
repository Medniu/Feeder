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
        private IMainFrameService _mainFrameService;
        public CheckStatePresentor(IKernel kernel, CheckStateService service,IMainFrameService mainFrameService, ICheckState view)
        {
            _kernel = kernel;
            _service = service;
            _view = view;
            _mainFrameService = mainFrameService;

            _view.UpdateState += () => UpdateState();
        }

        private void UpdateState()
        {
            _view.StateTextBox = _mainFrameService.SelectedFeeder.Amount_of_food.ToString();
        }
    }
}
