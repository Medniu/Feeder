using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface ICheckState : IView
    {
        event Action UpdateState;
        string StateTextBox { get; set; }
    }
}
