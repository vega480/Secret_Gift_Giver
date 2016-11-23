using System;
using System.Windows.Forms;

namespace Secret_Gift_Giver
{
    public partial class EventForm : Form
    {
        public string EventName { get; set; }

        public EventForm()
        {
            InitializeComponent();
            AcceptButton = btnAdd;
            CancelButton = btnCancel;
        }

        public EventForm(string name)
        {
            InitializeComponent();
            AcceptButton = btnAdd;
            CancelButton = btnCancel;
            btnAdd.Text = "Save";
            txtBxEventName.Text = name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EventName = txtBxEventName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
