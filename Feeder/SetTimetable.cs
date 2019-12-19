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
    public partial class SetTimetable : Form, ISetTimetable
    {
        public SetTimetable()
        {
            InitializeComponent();
        }

        public string Field_1 { get => textBox1.Text; set => throw new NotImplementedException(); }
        public string Field_2 { get => textBox2.Text; set => throw new NotImplementedException(); }
        public string Field_3 { get => textBox3.Text; set => throw new NotImplementedException(); }
        public string Field_4 { get => textBox4.Text; set => throw new NotImplementedException(); }
        public string Field_5 { get => textBox5.Text; set => throw new NotImplementedException(); }
        public string Field_6 { get => textBox6.Text; set => throw new NotImplementedException(); }
        public string Field_7 { get => textBox7.Text; set => throw new NotImplementedException(); }
        public string Field_8 { get => textBox8.Text; set => throw new NotImplementedException(); }
        public string Field_9 { get => textBox9.Text; set => throw new NotImplementedException(); }
        public string Field_10 { get => textBox10.Text; set => throw new NotImplementedException(); }

        public event Action SetTimeTable;

        private void Button1_Click(object sender, EventArgs e)
        {
            SetTimeTable?.Invoke();
        }



        private void SetTimetable_Load(object sender, EventArgs e)
        {

        }
    }
}
