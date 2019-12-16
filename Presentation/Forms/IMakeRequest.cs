using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface IMakeRequest : IView
    {
        event Action ClickMakeRequest;
        string Request { get; set; }
    }
}
