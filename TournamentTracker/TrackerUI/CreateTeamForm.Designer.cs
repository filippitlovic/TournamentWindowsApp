namespace TrackerUI
{
    partial class CreateTeamForm
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
            headerLabel = new Label();
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            addTeamMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(29, 45);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(92, 20);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(33, 122);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(236, 27);
            teamNameValue.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(29, 86);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(86, 20);
            teamNameLabel.TabIndex = 11;
            teamNameLabel.Text = "Team name";
            // 
            // addTeamMemberButton
            // 
            addTeamMemberButton.Location = new Point(67, 239);
            addTeamMemberButton.Name = "addTeamMemberButton";
            addTeamMemberButton.Size = new Size(167, 29);
            addTeamMemberButton.TabIndex = 19;
            addTeamMemberButton.Text = "Add team member";
            addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(33, 205);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(236, 28);
            selectTeamMemberDropDown.TabIndex = 18;
            selectTeamMemberDropDown.SelectedIndexChanged += selectTeamMemberDropDown_SelectedIndexChanged;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Location = new Point(29, 182);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(147, 20);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select team member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(40, 293);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(229, 184);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add new member";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(98, 35);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(125, 27);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(17, 38);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(77, 20);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First name";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(98, 68);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(125, 27);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(17, 71);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(76, 20);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last name";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(98, 101);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(125, 27);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(17, 104);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(98, 134);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(125, 27);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Location = new Point(17, 137);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(76, 20);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.Location = new Point(67, 483);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(167, 29);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.Location = new Point(340, 122);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(222, 362);
            teamMembersListBox.TabIndex = 22;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.Location = new Point(592, 264);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(94, 57);
            deleteSelectedMemberButton.TabIndex = 23;
            deleteSelectedMemberButton.Text = "Delete selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.Location = new Point(255, 547);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(177, 29);
            createTeamButton.TabIndex = 25;
            createTeamButton.Text = "Create team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 604);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(createMemberButton);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addTeamMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Button addTeamMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}