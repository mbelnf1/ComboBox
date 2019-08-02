namespace DataEntryScreen
{
    partial class DataEntryScreen
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
            this.DataEntryScreenLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.AgeField = new System.Windows.Forms.TextBox();
            this.AddPerson = new System.Windows.Forms.Button();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.UserAgeLabel = new System.Windows.Forms.Label();
            this.PeopleDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DataEntryScreenLabel
            // 
            this.DataEntryScreenLabel.AutoSize = true;
            this.DataEntryScreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEntryScreenLabel.Location = new System.Drawing.Point(254, 37);
            this.DataEntryScreenLabel.Name = "DataEntryScreenLabel";
            this.DataEntryScreenLabel.Size = new System.Drawing.Size(204, 25);
            this.DataEntryScreenLabel.TabIndex = 0;
            this.DataEntryScreenLabel.Text = "Data Entry Screen";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(45, 97);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "FirstName:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(44, 132);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "LastName:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(45, 165);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(29, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Age:";
            // 
            // FirstNameField
            // 
            this.FirstNameField.Location = new System.Drawing.Point(108, 94);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(100, 20);
            this.FirstNameField.TabIndex = 4;
            // 
            // LastNameField
            // 
            this.LastNameField.Location = new System.Drawing.Point(108, 129);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(100, 20);
            this.LastNameField.TabIndex = 5;
            // 
            // AgeField
            // 
            this.AgeField.Location = new System.Drawing.Point(108, 162);
            this.AgeField.Name = "AgeField";
            this.AgeField.Size = new System.Drawing.Size(100, 20);
            this.AgeField.TabIndex = 6;
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(81, 235);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(105, 23);
            this.AddPerson.TabIndex = 7;
            this.AddPerson.Text = "Add Person";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(47, 289);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(40, 13);
            this.PeopleLabel.TabIndex = 8;
            this.PeopleLabel.Text = "People";
            // 
            // UserAgeLabel
            // 
            this.UserAgeLabel.AutoSize = true;
            this.UserAgeLabel.Location = new System.Drawing.Point(50, 366);
            this.UserAgeLabel.Name = "UserAgeLabel";
            this.UserAgeLabel.Size = new System.Drawing.Size(94, 13);
            this.UserAgeLabel.TabIndex = 10;
            this.UserAgeLabel.Text = "Select User\'s Age:";
            // 
            // PeopleDropdown
            // 
            this.PeopleDropdown.FormattingEnabled = true;
            this.PeopleDropdown.Location = new System.Drawing.Point(108, 286);
            this.PeopleDropdown.Name = "PeopleDropdown";
            this.PeopleDropdown.Size = new System.Drawing.Size(121, 21);
            this.PeopleDropdown.TabIndex = 11;
            this.PeopleDropdown.SelectedValueChanged += new System.EventHandler(this.PeopleDropdown_SelectedValueChanged);
            // 
            // DataEntryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PeopleDropdown);
            this.Controls.Add(this.UserAgeLabel);
            this.Controls.Add(this.PeopleLabel);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.AgeField);
            this.Controls.Add(this.LastNameField);
            this.Controls.Add(this.FirstNameField);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.DataEntryScreenLabel);
            this.Name = "DataEntryScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataEntryScreenLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox FirstNameField;
        private System.Windows.Forms.TextBox LastNameField;
        private System.Windows.Forms.TextBox AgeField;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.Label UserAgeLabel;
        private System.Windows.Forms.ComboBox PeopleDropdown;
    }
}

