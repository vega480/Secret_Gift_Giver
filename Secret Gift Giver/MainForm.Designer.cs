namespace Secret_Gift_Giver
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbxEventsList = new System.Windows.Forms.ComboBox();
            this.lblEventList = new System.Windows.Forms.Label();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.cbxDontMatch = new System.Windows.Forms.ComboBox();
            this.btnAddDntMatch = new System.Windows.Forms.Button();
            this.btnRemoveDntMatch = new System.Windows.Forms.Button();
            this.lbxDntMatch = new System.Windows.Forms.ListBox();
            this.lblDntMatch = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.participantDataGrid = new System.Windows.Forms.DataGridView();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoNotMatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Received = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Sent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEventsList
            // 
            this.cbxEventsList.FormattingEnabled = true;
            this.cbxEventsList.Location = new System.Drawing.Point(13, 37);
            this.cbxEventsList.Name = "cbxEventsList";
            this.cbxEventsList.Size = new System.Drawing.Size(237, 21);
            this.cbxEventsList.TabIndex = 0;
            this.cbxEventsList.SelectedIndexChanged += new System.EventHandler(this.cbxEvent_SelectedIndexChanged);
            // 
            // lblEventList
            // 
            this.lblEventList.AutoSize = true;
            this.lblEventList.Location = new System.Drawing.Point(12, 21);
            this.lblEventList.Name = "lblEventList";
            this.lblEventList.Size = new System.Drawing.Size(71, 13);
            this.lblEventList.TabIndex = 1;
            this.lblEventList.Text = "Select Event:";
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewEvent.Location = new System.Drawing.Point(258, 36);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(74, 23);
            this.btnNewEvent.TabIndex = 2;
            this.btnNewEvent.Text = "New Event";
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // cbxDontMatch
            // 
            this.cbxDontMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDontMatch.FormattingEnabled = true;
            this.cbxDontMatch.Location = new System.Drawing.Point(508, 77);
            this.cbxDontMatch.Name = "cbxDontMatch";
            this.cbxDontMatch.Size = new System.Drawing.Size(219, 21);
            this.cbxDontMatch.TabIndex = 4;
            // 
            // btnAddDntMatch
            // 
            this.btnAddDntMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDntMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDntMatch.Location = new System.Drawing.Point(554, 104);
            this.btnAddDntMatch.Name = "btnAddDntMatch";
            this.btnAddDntMatch.Size = new System.Drawing.Size(55, 23);
            this.btnAddDntMatch.TabIndex = 5;
            this.btnAddDntMatch.Text = "Add";
            this.btnAddDntMatch.UseVisualStyleBackColor = true;
            this.btnAddDntMatch.Click += new System.EventHandler(this.btnAddDntMatch_Click);
            // 
            // btnRemoveDntMatch
            // 
            this.btnRemoveDntMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDntMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveDntMatch.Location = new System.Drawing.Point(632, 104);
            this.btnRemoveDntMatch.Name = "btnRemoveDntMatch";
            this.btnRemoveDntMatch.Size = new System.Drawing.Size(56, 23);
            this.btnRemoveDntMatch.TabIndex = 6;
            this.btnRemoveDntMatch.Text = "Remove";
            this.btnRemoveDntMatch.UseVisualStyleBackColor = true;
            // 
            // lbxDntMatch
            // 
            this.lbxDntMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDntMatch.FormattingEnabled = true;
            this.lbxDntMatch.Location = new System.Drawing.Point(508, 141);
            this.lbxDntMatch.Name = "lbxDntMatch";
            this.lbxDntMatch.Size = new System.Drawing.Size(219, 108);
            this.lbxDntMatch.TabIndex = 7;
            // 
            // lblDntMatch
            // 
            this.lblDntMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDntMatch.AutoSize = true;
            this.lblDntMatch.Location = new System.Drawing.Point(508, 58);
            this.lblDntMatch.Name = "lblDntMatch";
            this.lblDntMatch.Size = new System.Drawing.Size(102, 13);
            this.lblDntMatch.TabIndex = 8;
            this.lblDntMatch.Text = "Do Not Match With:";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomize.BackColor = System.Drawing.Color.Red;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(554, 333);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(118, 37);
            this.btnRandomize.TabIndex = 9;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = false;
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditEvent.Location = new System.Drawing.Point(341, 36);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(74, 23);
            this.btnEditEvent.TabIndex = 10;
            this.btnEditEvent.Text = "Edit Event";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Visible = false;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // participantDataGrid
            // 
            this.participantDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.participantDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.participantDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event,
            this.Giver,
            this.Recipient,
            this.DoNotMatch,
            this.Received,
            this.Sent});
            this.participantDataGrid.Location = new System.Drawing.Point(13, 65);
            this.participantDataGrid.Name = "participantDataGrid";
            this.participantDataGrid.RowHeadersVisible = false;
            this.participantDataGrid.Size = new System.Drawing.Size(489, 382);
            this.participantDataGrid.TabIndex = 14;
            // 
            // Event
            // 
            this.Event.DataPropertyName = "Event";
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            // 
            // Giver
            // 
            this.Giver.DataPropertyName = "Name";
            this.Giver.HeaderText = "Giver";
            this.Giver.Name = "Giver";
            // 
            // Recipient
            // 
            this.Recipient.DataPropertyName = "Recipient";
            this.Recipient.HeaderText = "Recipient";
            this.Recipient.Name = "Recipient";
            // 
            // DoNotMatch
            // 
            this.DoNotMatch.DataPropertyName = "DoNotMatch";
            this.DoNotMatch.HeaderText = "Do Not Match";
            this.DoNotMatch.Name = "DoNotMatch";
            this.DoNotMatch.Sorted = true;
            this.DoNotMatch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Received
            // 
            this.Received.DataPropertyName = "Received";
            this.Received.HeaderText = "Received";
            this.Received.Name = "Received";
            // 
            // Sent
            // 
            this.Sent.DataPropertyName = "Sent";
            this.Sent.HeaderText = "Sent";
            this.Sent.Name = "Sent";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 459);
            this.Controls.Add(this.participantDataGrid);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.lblDntMatch);
            this.Controls.Add(this.lbxDntMatch);
            this.Controls.Add(this.btnRemoveDntMatch);
            this.Controls.Add(this.btnAddDntMatch);
            this.Controls.Add(this.cbxDontMatch);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.lblEventList);
            this.Controls.Add(this.cbxEventsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Secret Gift Giver";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEventsList;
        private System.Windows.Forms.Label lblEventList;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.ComboBox cbxDontMatch;
        private System.Windows.Forms.Button btnAddDntMatch;
        private System.Windows.Forms.Button btnRemoveDntMatch;
        private System.Windows.Forms.ListBox lbxDntMatch;
        private System.Windows.Forms.Label lblDntMatch;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.DataGridView participantDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipient;
        private System.Windows.Forms.DataGridViewComboBoxColumn DoNotMatch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Received;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sent;
    }
}

