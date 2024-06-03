using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetClinic.View
{
    public partial class AddNewAccount : Form
    {
        public string Username => UsernameTxt.Text;
        public string Password => PassTxt.Text;

        public AddNewAccount()
        {
            InitializeComponent();
        }
        private void DoneBtn_Click_1(object sender, EventArgs e)
        {
            OnAccountAdded();
            this.DialogResult = DialogResult.OK;
        }
        public event EventHandler AccountAdded;
        protected virtual void OnAccountAdded()
        {
            AccountAdded?.Invoke(this, EventArgs.Empty);
        }
    }
}
