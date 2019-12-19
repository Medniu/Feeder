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
    public partial class CheckTimetable : Form , ICheckTimetable
    {
        public CheckTimetable()
        {
            InitializeComponent();
        }

        public string Field_1 { get => throw new NotImplementedException();
            set
            {
                textBox1.Text = value;
            } }
        public string Field_2 { get => throw new NotImplementedException();
            set
            {
                textBox2.Text = value;
            }
        }
        public string Field_3 { get => throw new NotImplementedException();
            set
            {
                textBox3.Text = value;
            }
        }
        public string Field_4 { get => throw new NotImplementedException();
            set
            {
                textBox4.Text = value;
            }
        }
        public string Field_5 { get => throw new NotImplementedException();
            set
            {
                textBox5.Text = value;
            }
        }
        public string Field_6 { get => throw new NotImplementedException();
            set
            {
                textBox6.Text = value;
            }
        }
        public string Field_7 { get => throw new NotImplementedException();
            set
            {
                textBox7.Text = value;
            }
        }
        public string Field_8 { get => throw new NotImplementedException();
            set
            {
                textBox8.Text = value;
            }
        }
        public string Field_9 { get => throw new NotImplementedException();
            set
            {
                textBox9.Text = value;
            }
        }
        public string Field_10 { get => throw new NotImplementedException();
            set
            {
                textBox10.Text = value;
            }
        }

        public event Action UpdateFields;

        private void CheckTimetable_Load(object sender, EventArgs e)
        {
            UpdateFields?.Invoke();
        }
    }
}
