using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Gift_Giver
{
    public partial class Main : Form
    {
        DataSet participantSet = new DataSet();
        DataTable participantTable = new DataTable();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FileCheck();
        }

        private void FileCheck()
        {
            if (File.Exists("Data\\Events.xml"))
            {
                LoadEventData();
            }
            else
            {
                File.Create("Data\\Events.xml");
            }
            if (File.Exists("Data\\Participants.xml"))
            {
                LoadParticipantInfo();
            }
            else
            {
                File.Create("Data\\Participants.xml");
            }
            
        }

        private void LoadEventData()
        {
            XmlDocument eventXml = new XmlDocument();

            eventXml.Load("Data\\Events.xml");
            XmlNodeList eventNodes = eventXml.GetElementsByTagName("event");

            foreach (XmlNode evnt in eventNodes)
            {
                cbxEventsList.Items.Add(evnt.InnerText);
            }
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            using (EventForm editEventName = new EventForm(cbxEventsList.SelectedItem.ToString()))
            {
                int eventIndex = cbxEventsList.SelectedIndex;
                var result = editEventName.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbxEventsList.Items[eventIndex] = editEventName.EventName;
                }
            }
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            using (EventForm newEventName = new EventForm())
            {
                var result = newEventName.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cbxEventsList.Items.Add(newEventName.EventName);
                }
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            if (cbxEventsList.SelectedIndex > -1)
            {
                int selectedEvent = cbxEventsList.SelectedIndex + 1;
                using (AddNameForm addName = new AddNameForm())
                {
                    var result = addName.ShowDialog();

                    foreach (string name in addName.Names)
                    {

                    }

                    LoadParticipantInfo();
                } 
            }
            else
            {
                MessageBox.Show("Select an Event first.");
            }
        }

        private void btnRemoveName_Click(object sender, EventArgs e)
        {
            LoadParticipantInfo();
        }

        private void LoadParticipantInfo()
        {
            participantSet.ReadXml("Data\\Participants.xml");
            participantTable = participantSet.Tables["participant"];
            participantDataGrid.DataSource = participantSet.Tables[0];

            //CreateListOfNames();
        }

        private void CreateListOfNames()
        {
            List<string> doNotMatch = new List<string>();
            foreach (DataGridViewRow row in participantDataGrid.Rows)
                if(row.Cells[1].Value != null)
                    doNotMatch.Add(row.Cells[1].Value.ToString());
            doNotMatch = doNotMatch.Distinct().ToList();

            //Not working yet
            ComboBox dnmCbx = new ComboBox();
            foreach (string dnm in doNotMatch)
            {
                dnmCbx.Items.Add(dnm);
            }

            foreach (DataGridViewRow row in participantDataGrid.Rows)
            {
                ((DataGridViewComboBoxColumn)participantDataGrid.Columns["DoNotMatch"]).DataSource = doNotMatch;
            }
        }

        private void cbxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditEvent.Visible = true;
            DataView dv = new DataView(participantTable);
            dv.RowFilter = "Event = '" + cbxEventsList.SelectedItem.ToString() + "'";
            participantDataGrid.DataSource = dv;
        }

        private void btnAddDntMatch_Click(object sender, EventArgs e)
        {

        }
    }
}
