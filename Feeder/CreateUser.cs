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
    public partial class CreateUser : Form , ICreateUser
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        public string CharacterName => textBox1.Text;

        public event Action AddUser;
        private void Button1_Click(object sender, EventArgs e)
        {
            AddUser.Invoke();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }






        /*private void lv_Characters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Characters.SelectedItems.Count > 0)
            {
                tb_CharacterName.Text = lv_Characters.SelectedItems[0].Text;
            }
        }*/
    }
}
