using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Gift_Giver
{
    public partial class AddNameForm : Form
    {
        private List<string> names = new List<string>();
        
        public List<string> Names { get { return names; } }

        public AddNameForm()
        {
            InitializeComponent();
            AcceptButton = btnAddNewName;
        }

        private void btnAddNewName_Click(object sender, EventArgs e)
        {
            if (txtBxName.Text != string.Empty)
            {
                names.Add(txtBxName.Text);
                txtBxName.Text = string.Empty;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtBxName.Text != string.Empty)
                names.Add(txtBxName.Text);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
