namespace Message_Box_Maker
{
    partial class Interface
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.iconType = new System.Windows.Forms.ListBox();
            this.buttonPicker = new System.Windows.Forms.ListBox();
            this.pushButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(247, 20);
            this.titleBox.TabIndex = 0;
            this.titleBox.Text = "Title";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 38);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(247, 96);
            this.messageBox.TabIndex = 1;
            this.messageBox.Text = "Body";
            // 
            // iconType
            // 
            this.iconType.FormattingEnabled = true;
            this.iconType.Items.AddRange(new object[] {
            "Exclamation",
            "Error",
            "Question",
            "Stop",
            "Information"});
            this.iconType.Location = new System.Drawing.Point(265, 12);
            this.iconType.Name = "iconType";
            this.iconType.Size = new System.Drawing.Size(120, 121);
            this.iconType.TabIndex = 2;
            // 
            // buttonPicker
            // 
            this.buttonPicker.FormattingEnabled = true;
            this.buttonPicker.Items.AddRange(new object[] {
            "Ok",
            "Ok, Cancel",
            "Retry, Cancel",
            "Yes, No",
            "Yes, No, Cancel",
            "Abort, Retry, Ignore"});
            this.buttonPicker.Location = new System.Drawing.Point(391, 12);
            this.buttonPicker.Name = "buttonPicker";
            this.buttonPicker.Size = new System.Drawing.Size(120, 121);
            this.buttonPicker.TabIndex = 3;
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(12, 140);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(497, 23);
            this.pushButton.TabIndex = 4;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 172);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.buttonPicker);
            this.Controls.Add(this.iconType);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.titleBox);
            this.Name = "Interface";
            this.ShowIcon = false;
            this.Text = "Message Box Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.ListBox iconType;
        private System.Windows.Forms.ListBox buttonPicker;
        private System.Windows.Forms.Button pushButton;
    }
}

