using Model;
using Ninject;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presentors
{
    public class AbstractPresenter<T,V> : IPresenter
        where V: class, IView
        where T: class, IService
    {
        protected IKernel _kernel { get; set; }
        protected T _service { get; set; }
        protected V _view { get; set; }
        public void Run()
        {
            _view.Show();
        }
    }
}
