using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feeder
{
    public partial class FeederControl : Form, IFeederControl
    {
        public event Action ClickPourFeed;
        public event Action ClickSwitchMode;
        public event Action ClickCreateTag;
        public string FeederName { get => textBox1.Text; }


        public FeederControl()
        {
            InitializeComponent();
        }


        private void PourFeed_Click(object sender, EventArgs e)
        {
            ClickPourFeed?.Invoke();
        }

        private void SwitchMode_Click(object sender, EventArgs e)
        {
            ClickSwitchMode?.Invoke();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ClickCreateTag?.Invoke();
        }
    }
}
