namespace CKAN.GUI
{
    partial class CompatibleGameVersionsDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new SingleAssemblyComponentResourceManager(typeof(CompatibleGameVersionsDialog));
            this.InstancePathLabel = new System.Windows.Forms.Label();
            this.ActualInstancePathLabel = new System.Windows.Forms.Label();
            this.GameVersionLabel = new System.Windows.Forms.Label();
            this.ActualGameVersionLabel = new System.Windows.Forms.Label();
            this.ListHeaderLabel = new System.Windows.Forms.Label();
            this.SelectedVersionsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.ClearSelectionButton = new System.Windows.Forms.Button();
            this.AddVersionLabel = new System.Windows.Forms.Label();
            this.AddVersionToListTextBox = new System.Windows.Forms.TextBox();
            this.AddVersionToListButton = new System.Windows.Forms.Button();
            this.WildcardExplanationLabel = new System.Windows.Forms.Label();
            this.FutureUpdatesLabel = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.CancelChooseCompatibleVersionsButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // InstancePathLabel
            //
            this.InstancePathLabel.AutoSize = true;
            this.InstancePathLabel.Location = new System.Drawing.Point(12, 11);
            this.InstancePathLabel.Name = "InstancePathLabel";
            this.InstancePathLabel.Size = new System.Drawing.Size(60, 13);
            this.InstancePathLabel.TabIndex = 0;
            resources.ApplyResources(this.InstancePathLabel, "InstancePathLabel");
            //
            // ActualInstancePathLabel
            //
            this.ActualInstancePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActualInstancePathLabel.AutoSize = false;
            this.ActualInstancePathLabel.Location = new System.Drawing.Point(100, 11);
            this.ActualInstancePathLabel.Name = "ActualInstancePathLabel";
            this.ActualInstancePathLabel.Size = new System.Drawing.Size(336, 32);
            this.ActualInstancePathLabel.TabIndex = 1;
            resources.ApplyResources(this.ActualInstancePathLabel, "ActualInstancePathLabel");
            //
            // GameVersionLabel
            //
            this.GameVersionLabel.Location = new System.Drawing.Point(12, 43);
            this.GameVersionLabel.Name = "GameVersionLabel";
            this.GameVersionLabel.Size = new System.Drawing.Size(75, 13);
            this.GameVersionLabel.TabIndex = 2;
            resources.ApplyResources(this.GameVersionLabel, "GameVersionLabel");
            //
            // ActualGameVersionLabel
            //
            this.ActualGameVersionLabel.AutoSize = true;
            this.ActualGameVersionLabel.Location = new System.Drawing.Point(100, 43);
            this.ActualGameVersionLabel.Name = "ActualGameVersionLabel";
            this.ActualGameVersionLabel.Size = new System.Drawing.Size(53, 13);
            this.ActualGameVersionLabel.TabIndex = 3;
            resources.ApplyResources(this.ActualGameVersionLabel, "ActualGameVersionLabel");
            //
            // ListHeaderLabel
            //
            this.ListHeaderLabel.Location = new System.Drawing.Point(12, 73);
            this.ListHeaderLabel.Name = "ListHeaderLabel";
            this.ListHeaderLabel.Size = new System.Drawing.Size(422, 13);
            this.ListHeaderLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ListHeaderLabel.TabIndex = 4;
            resources.ApplyResources(this.ListHeaderLabel, "ListHeaderLabel");
            //
            // selectedVersionsCheckedListBox
            //
            this.SelectedVersionsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedVersionsCheckedListBox.CheckOnClick = true;
            this.SelectedVersionsCheckedListBox.FormattingEnabled = true;
            this.SelectedVersionsCheckedListBox.Location = new System.Drawing.Point(12, 88);
            this.SelectedVersionsCheckedListBox.Name = "selectedVersionsCheckedListBox";
            this.SelectedVersionsCheckedListBox.Size = new System.Drawing.Size(419, 115);
            this.SelectedVersionsCheckedListBox.TabIndex = 5;
            //
            // clearSelectionButton
            //
            this.ClearSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSelectionButton.Location = new System.Drawing.Point(12, 211);
            this.ClearSelectionButton.Name = "clearSelectionButton";
            this.ClearSelectionButton.Size = new System.Drawing.Size(95, 23);
            this.ClearSelectionButton.TabIndex = 6;
            this.ClearSelectionButton.UseVisualStyleBackColor = true;
            this.ClearSelectionButton.Click += new System.EventHandler(this.ClearSelectionButton_Click);
            resources.ApplyResources(this.ClearSelectionButton, "ClearSelectionButton");
            //
            // AddVersionLabel
            //
            this.AddVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddVersionLabel.AutoSize = true;
            this.AddVersionLabel.Location = new System.Drawing.Point(111, 216);
            this.AddVersionLabel.Name = "AddVersionLabel";
            this.AddVersionLabel.Size = new System.Drawing.Size(93, 13);
            this.AddVersionLabel.TabIndex = 7;
            resources.ApplyResources(this.AddVersionLabel, "AddVersionLabel");
            //
            // AddVersionToListTextBox
            //
            this.AddVersionToListTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.AddVersionToListTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AddVersionToListTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.AddVersionToListTextBox.Location = new System.Drawing.Point(242, 211);
            this.AddVersionToListTextBox.Name = "addVersionToListTextBox";
            this.AddVersionToListTextBox.Size = new System.Drawing.Size(113, 15);
            this.AddVersionToListTextBox.TabIndex = 8;
            //
            // AddVersionToListButton
            //
            this.AddVersionToListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom
            | System.Windows.Forms.AnchorStyles.Right));
            this.AddVersionToListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVersionToListButton.Location = new System.Drawing.Point(356, 209);
            this.AddVersionToListButton.Name = "addVersionToListButton";
            this.AddVersionToListButton.Size = new System.Drawing.Size(75, 23);
            this.AddVersionToListButton.TabIndex = 9;
            this.AddVersionToListButton.UseVisualStyleBackColor = true;
            this.AddVersionToListButton.Click += new System.EventHandler(this.AddVersionToListButton_Click);
            resources.ApplyResources(this.AddVersionToListButton, "AddVersionToListButton");
            //
            // WildcardExplanationLabel
            //
            this.WildcardExplanationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.WildcardExplanationLabel.Location = new System.Drawing.Point(12, 240);
            this.WildcardExplanationLabel.Name = "WildcardExplanationLabel";
            this.WildcardExplanationLabel.Size = new System.Drawing.Size(419, 32);
            this.WildcardExplanationLabel.TabIndex = 10;
            resources.ApplyResources(this.WildcardExplanationLabel, "WildcardExplanationLabel");
            //
            // FutureUpdatesLabel
            //
            this.FutureUpdatesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.FutureUpdatesLabel.Location = new System.Drawing.Point(12, 273);
            this.FutureUpdatesLabel.Name = "FutureUpdatesLabel";
            this.FutureUpdatesLabel.Size = new System.Drawing.Size(419, 32);
            this.FutureUpdatesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FutureUpdatesLabel.TabIndex = 11;
            resources.ApplyResources(this.FutureUpdatesLabel, "FutureUpdatesLabel");
            //
            // WarningLabel
            //
            this.WarningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(12, 315);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(419, 32);
            this.WarningLabel.TabIndex = 12;
            resources.ApplyResources(this.WarningLabel, "WarningLabel");
            //
            // CancelChooseCompatibleVersionsButton
            //
            this.CancelChooseCompatibleVersionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelChooseCompatibleVersionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChooseCompatibleVersionsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelChooseCompatibleVersionsButton.Location = new System.Drawing.Point(275, 350);
            this.CancelChooseCompatibleVersionsButton.Name = "cancelButton";
            this.CancelChooseCompatibleVersionsButton.Size = new System.Drawing.Size(75, 23);
            this.CancelChooseCompatibleVersionsButton.TabIndex = 14;
            this.CancelChooseCompatibleVersionsButton.UseVisualStyleBackColor = true;
            this.CancelChooseCompatibleVersionsButton.Click += new System.EventHandler(this.CancelButton_Click);
            resources.ApplyResources(this.CancelChooseCompatibleVersionsButton, "CancelChooseCompatibleVersionsButton");
            //
            // saveButton
            //
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(356, 350);
            this.SaveButton.Name = "saveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            resources.ApplyResources(this.SaveButton, "SaveButton");
            //
            // CompatibleGameVersionsDialog
            //
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelChooseCompatibleVersionsButton;
            this.ClientSize = new System.Drawing.Size(443, 383);
            this.Controls.Add(this.InstancePathLabel);
            this.Controls.Add(this.ActualInstancePathLabel);
            this.Controls.Add(this.GameVersionLabel);
            this.Controls.Add(this.ActualGameVersionLabel);
            this.Controls.Add(this.ListHeaderLabel);
            this.Controls.Add(this.SelectedVersionsCheckedListBox);
            this.Controls.Add(this.ClearSelectionButton);
            this.Controls.Add(this.AddVersionLabel);
            this.Controls.Add(this.AddVersionToListTextBox);
            this.Controls.Add(this.AddVersionToListButton);
            this.Controls.Add(this.WildcardExplanationLabel);
            this.Controls.Add(this.FutureUpdatesLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.CancelChooseCompatibleVersionsButton);
            this.Controls.Add(this.SaveButton);
            this.Icon = EmbeddedImages.AppIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 383);
            this.HelpButton = true;
            this.Name = "CompatibleGameVersionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Shown += new System.EventHandler(this.CompatibleGameVersionsDialog_Shown);
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label InstancePathLabel;
        private System.Windows.Forms.Label ActualInstancePathLabel;
        private System.Windows.Forms.Label GameVersionLabel;
        private System.Windows.Forms.Label ActualGameVersionLabel;
        private System.Windows.Forms.Label ListHeaderLabel;
        private System.Windows.Forms.CheckedListBox SelectedVersionsCheckedListBox;
        private System.Windows.Forms.Button ClearSelectionButton;
        private System.Windows.Forms.Label AddVersionLabel;
        private System.Windows.Forms.TextBox AddVersionToListTextBox;
        private System.Windows.Forms.Button AddVersionToListButton;
        private System.Windows.Forms.Label WildcardExplanationLabel;
        private System.Windows.Forms.Label FutureUpdatesLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Button CancelChooseCompatibleVersionsButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
