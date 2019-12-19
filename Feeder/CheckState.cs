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
    public partial class CheckState : Form , ICheckState
    {
        public CheckState()
        {
            InitializeComponent();

        }

        public string StateTextBox { get => throw new NotImplementedException();
            set
            {
                textBox1.Text = value;
            }
        }

        public event Action UpdateState;

        private void CheckState_Load(object sender, EventArgs e)
        {
            UpdateState?.Invoke();
        }
    }
}
