namespace Secret_Gift_Giver
{
    partial class AddNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNameForm));
            this.lblNewName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.btnAddNewName = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(12, 25);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(91, 13);
            this.lblNewName.TabIndex = 0;
            this.lblNewName.Text = "Enter New Name:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(109, 22);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(223, 20);
            this.txtBxName.TabIndex = 1;
            // 
            // btnAddNewName
            // 
            this.btnAddNewName.Location = new System.Drawing.Point(90, 61);
            this.btnAddNewName.Name = "btnAddNewName";
            this.btnAddNewName.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewName.TabIndex = 2;
            this.btnAddNewName.Text = "Add";
            this.btnAddNewName.UseVisualStyleBackColor = true;
            this.btnAddNewName.Click += new System.EventHandler(this.btnAddNewName_Click);
            this.btnAddNewName.Enter += new System.EventHandler(this.btnAddNewName_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(185, 61);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // AddNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 96);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddNewName);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblNewName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNameForm";
            this.Text = "Add Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.Button btnAddNewName;
        private System.Windows.Forms.Button btnFinish;
    }
}