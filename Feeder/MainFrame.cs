using Model.Entity;
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

            comboBox2.TextChanged += UserComboboxChanged;
            comboBox4.TextChanged += UserComboboxChanged;

            comboBox1.TextChanged += FeederComboboxChanged;
            comboBox3.TextChanged += FeederComboboxChanged;
        }


        private readonly ApplicationContext _applicationContext;

        public string RequestsTextBox { get => textBox1.Text; set { textBox1.Text = value; } }

        public CurrentTab CurrentTab
        {
            get
            {
                return (CurrentTab)tabControl1.SelectedIndex;
            }
            set { throw new NotImplementedException(); } }

        public string AdminTabUserCombobox { get => comboBox4.Text; set => throw new NotImplementedException(); }
        public string UserTabUserCombobox { get => comboBox2.Text; set => throw new NotImplementedException(); }
        public string AdminTabFeederCombobox { get => comboBox1.Text; set => throw new NotImplementedException(); }
        public string UserTabFeederCombobox { get => comboBox3.Text; set => throw new NotImplementedException(); }

        public event Action ClickFeederControl;
        public event Action ClickAddFeeder;
        public event Action ClickCheckState;
        public event Action ClickCheckTimetable;
        public event Action ClickCreateUser;
        public event Action ClickGetLogs;
        public event Action ClickSetTimeTable;
        public event Action ClickMakeRequest;
        public event Action SelectedUserChanged;
        public event Action SelectedFeederChanged;

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

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        public void UpdateUsers(IEnumerable<string> users)
        {
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            foreach (var item in users)
            {
                comboBox2.Items.Add(item);
                comboBox4.Items.Add(item);
            }
        }

        private void UserComboboxChanged(object sender, EventArgs e)
        {
            SelectedUserChanged?.Invoke();
        }

        private void FeederComboboxChanged(object sender, EventArgs e)
        {
            SelectedFeederChanged?.Invoke();
        }

        public void UpdateAdminTabFeederList(IEnumerable<string> feederNames)
        {
            comboBox1.Text = String.Empty;
            comboBox1.Items.Clear();
            foreach (var item in feederNames)
                comboBox1.Items.Add(item);
        }

        public void UpdateUserTabFeederList(IEnumerable<string> feederNames)
        {
            comboBox3.Text = String.Empty;
            comboBox3.Items.Clear();
            foreach (var item in feederNames)
                comboBox3.Items.Add(item);
        }

        private void User_Click(object sender, EventArgs e)
        {

        }
    }
}
