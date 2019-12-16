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
    public partial class AddFeeder : Form , IAddFeeder
    {
        public AddFeeder()
        {
            InitializeComponent();
            comboBox1.TextChanged += Combobox1_TextChanged;
        }
        public string UserName => comboBox1.Text;
        public string FeederName => FdrName.Text;
        
        public event Action CreateFeeder;
        public event Action UpdateUserList;
        public event Action SelectedUserChanged;

        private void Button1_Click(object sender, EventArgs e)
        {
            CreateFeeder.Invoke();
        }

        private void AddFeeder_Load(object sender, EventArgs e)
        {
            UpdateUserList.Invoke();
        }

        public void UpdateListOfUsers(List<string> userNames)
        {
            comboBox1.Items.Clear();

            foreach (var username in userNames)
                comboBox1.Items.Add(username);
        }

        private void Combobox1_TextChanged(object sender, EventArgs e)
        {
            SelectedUserChanged?.Invoke();
        }
    }
}
