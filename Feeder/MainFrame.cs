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
    public partial class MainFrame : Form,IMainForm
    {
        public MainFrame(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            _applicationContext.MainForm = this;
            InitializeComponent();
        }
        private readonly ApplicationContext _applicationContext;

        public event Action ClickFeederControl;
        public event Action ClickAddFeeder;
        public event Action ClickCheckState;
        public event Action ClickCheckTimetable;
        public event Action ClickCreateUser;
        public event Action ClickGetLogs;
        public event Action ClickSetTimeTable;
        public event Action ClickMakeRequest;

        private void FeederControl_Click(object sender, EventArgs e)
        {
            ClickFeederControl?.Invoke();
        }

        private void AddFeeder_Click(object sender, EventArgs e)
        {
            ClickAddFeeder?.Invoke();
        }
        
        private void UserCheckState_Click(object sender, EventArgs e)
        {
            ClickCheckState?.Invoke();
        }
        private void CheckState_Click(object sender, EventArgs e)
        {
            ClickCheckState?.Invoke();
        }

        private void CheckTimetable_Click(object sender, EventArgs e)
        {
            ClickCheckTimetable?.Invoke();
        }

        private void UserCheckTimeTable_Click(object sender, EventArgs e)
        {
            ClickCheckTimetable?.Invoke();
        }
        

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            ClickCreateUser?.Invoke();
        }

        private void GetLogs_Click(object sender, EventArgs e)
        {
            ClickGetLogs?.Invoke();
        }

        private void UserGetLogs_Click(object sender, EventArgs e)
        {
            ClickGetLogs?.Invoke();
        }

        private void SetTimetable_Click(object sender, EventArgs e)
        {
            ClickSetTimeTable?.Invoke();
        }

        private void MakeRequest_Click(object sender, EventArgs e)
        {
            ClickMakeRequest?.Invoke();
        }
    }
}
