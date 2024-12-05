namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            headerLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePrecentageLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            resources.ApplyResources(headerLabel, "headerLabel");
            headerLabel.Name = "headerLabel";
            headerLabel.Click += headerLabel_Click;
            // 
            // placeNumberValue
            // 
            resources.ApplyResources(placeNumberValue, "placeNumberValue");
            placeNumberValue.Name = "placeNumberValue";
            // 
            // placeNumberLabel
            // 
            resources.ApplyResources(placeNumberLabel, "placeNumberLabel");
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Click += placeNumberLabel_Click;
            // 
            // placeNameValue
            // 
            resources.ApplyResources(placeNameValue, "placeNameValue");
            placeNameValue.Name = "placeNameValue";
            // 
            // placeNameLabel
            // 
            resources.ApplyResources(placeNameLabel, "placeNameLabel");
            placeNameLabel.Name = "placeNameLabel";
            // 
            // prizeAmountValue
            // 
            resources.ApplyResources(prizeAmountValue, "prizeAmountValue");
            prizeAmountValue.Name = "prizeAmountValue";
            // 
            // prizeAmountLabel
            // 
            resources.ApplyResources(prizeAmountLabel, "prizeAmountLabel");
            prizeAmountLabel.Name = "prizeAmountLabel";
            // 
            // prizePercentageValue
            // 
            resources.ApplyResources(prizePercentageValue, "prizePercentageValue");
            prizePercentageValue.Name = "prizePercentageValue";
            // 
            // prizePrecentageLabel
            // 
            resources.ApplyResources(prizePrecentageLabel, "prizePrecentageLabel");
            prizePrecentageLabel.Name = "prizePrecentageLabel";
            // 
            // orLabel
            // 
            resources.ApplyResources(orLabel, "orLabel");
            orLabel.Name = "orLabel";
            // 
            // createPrizeButton
            // 
            resources.ApplyResources(createPrizeButton, "createPrizeButton");
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePrecentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Name = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox prizePercentageValue;
        private Label prizePrecentageLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}