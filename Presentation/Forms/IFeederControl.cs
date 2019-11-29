using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Forms
{
    public interface IFeederControl : IView
    {
        event Action ClickPourFeed;
        event Action ClickSwitchMode;
        event Action ClickCreateTag;
        
        string FeederName { get; }
    }
}
