
namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameInsertLabel = new System.Windows.Forms.Label();
            this.firstNameInsertText = new System.Windows.Forms.TextBox();
            this.lastNameInsertLabel = new System.Windows.Forms.Label();
            this.lastNameInsertText = new System.Windows.Forms.TextBox();
            this.phoneNumberInsertLabel = new System.Windows.Forms.Label();
            this.phoneNumberInsertText = new System.Windows.Forms.TextBox();
            this.emailAddressInsertLabel = new System.Windows.Forms.Label();
            this.emailAddressInsertText = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 37;
            this.peopleFoundListbox.Location = new System.Drawing.Point(40, 283);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(878, 152);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(242, 92);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(261, 44);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(43, 92);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(173, 37);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(141, 170);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(206, 62);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameInsertLabel
            // 
            this.firstNameInsertLabel.AutoSize = true;
            this.firstNameInsertLabel.Location = new System.Drawing.Point(46, 481);
            this.firstNameInsertLabel.Name = "firstNameInsertLabel";
            this.firstNameInsertLabel.Size = new System.Drawing.Size(175, 37);
            this.firstNameInsertLabel.TabIndex = 5;
            this.firstNameInsertLabel.Text = "First Name";
            // 
            // firstNameInsertText
            // 
            this.firstNameInsertText.Location = new System.Drawing.Point(345, 481);
            this.firstNameInsertText.Name = "firstNameInsertText";
            this.firstNameInsertText.Size = new System.Drawing.Size(261, 44);
            this.firstNameInsertText.TabIndex = 4;
            // 
            // lastNameInsertLabel
            // 
            this.lastNameInsertLabel.AutoSize = true;
            this.lastNameInsertLabel.Location = new System.Drawing.Point(46, 545);
            this.lastNameInsertLabel.Name = "lastNameInsertLabel";
            this.lastNameInsertLabel.Size = new System.Drawing.Size(173, 37);
            this.lastNameInsertLabel.TabIndex = 7;
            this.lastNameInsertLabel.Text = "Last Name";
            // 
            // lastNameInsertText
            // 
            this.lastNameInsertText.Location = new System.Drawing.Point(345, 545);
            this.lastNameInsertText.Name = "lastNameInsertText";
            this.lastNameInsertText.Size = new System.Drawing.Size(261, 44);
            this.lastNameInsertText.TabIndex = 6;
            // 
            // phoneNumberInsertLabel
            // 
            this.phoneNumberInsertLabel.AutoSize = true;
            this.phoneNumberInsertLabel.Location = new System.Drawing.Point(46, 684);
            this.phoneNumberInsertLabel.Name = "phoneNumberInsertLabel";
            this.phoneNumberInsertLabel.Size = new System.Drawing.Size(233, 37);
            this.phoneNumberInsertLabel.TabIndex = 11;
            this.phoneNumberInsertLabel.Text = "Phone Number";
            // 
            // phoneNumberInsertText
            // 
            this.phoneNumberInsertText.Location = new System.Drawing.Point(345, 684);
            this.phoneNumberInsertText.Name = "phoneNumberInsertText";
            this.phoneNumberInsertText.Size = new System.Drawing.Size(261, 44);
            this.phoneNumberInsertText.TabIndex = 10;
            // 
            // emailAddressInsertLabel
            // 
            this.emailAddressInsertLabel.AutoSize = true;
            this.emailAddressInsertLabel.Location = new System.Drawing.Point(46, 614);
            this.emailAddressInsertLabel.Name = "emailAddressInsertLabel";
            this.emailAddressInsertLabel.Size = new System.Drawing.Size(224, 37);
            this.emailAddressInsertLabel.TabIndex = 9;
            this.emailAddressInsertLabel.Text = "Email Address";
            // 
            // emailAddressInsertText
            // 
            this.emailAddressInsertText.Location = new System.Drawing.Point(345, 614);
            this.emailAddressInsertText.Name = "emailAddressInsertText";
            this.emailAddressInsertText.Size = new System.Drawing.Size(261, 44);
            this.emailAddressInsertText.TabIndex = 8;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(203, 770);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(206, 62);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 915);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.phoneNumberInsertLabel);
            this.Controls.Add(this.phoneNumberInsertText);
            this.Controls.Add(this.emailAddressInsertLabel);
            this.Controls.Add(this.emailAddressInsertText);
            this.Controls.Add(this.lastNameInsertLabel);
            this.Controls.Add(this.lastNameInsertText);
            this.Controls.Add(this.firstNameInsertLabel);
            this.Controls.Add(this.firstNameInsertText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label firstNameInsertLabel;
        private System.Windows.Forms.TextBox firstNameInsertText;
        private System.Windows.Forms.Label lastNameInsertLabel;
        private System.Windows.Forms.TextBox lastNameInsertText;
        private System.Windows.Forms.Label phoneNumberInsertLabel;
        private System.Windows.Forms.TextBox phoneNumberInsertText;
        private System.Windows.Forms.Label emailAddressInsertLabel;
        private System.Windows.Forms.TextBox emailAddressInsertText;
        private System.Windows.Forms.Button insertRecordButton;
    }
}

