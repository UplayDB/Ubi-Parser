namespace ParserGUI
{
    partial class ParserGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileAsButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // OpenFileAsButton
            // 
            this.OpenFileAsButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OpenFileAsButton.ForeColor = System.Drawing.Color.Black;
            this.OpenFileAsButton.Location = new System.Drawing.Point(30, 45);
            this.OpenFileAsButton.Name = "OpenFileAsButton";
            this.OpenFileAsButton.Size = new System.Drawing.Size(101, 23);
            this.OpenFileAsButton.TabIndex = 0;
            this.OpenFileAsButton.Text = "Open File as ...";
            this.OpenFileAsButton.UseVisualStyleBackColor = false;
            this.OpenFileAsButton.Click += new System.EventHandler(this.OpenFileAsButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Location = new System.Drawing.Point(450, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(340, 410);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Black;
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "ClubCache",
            "ConfigurationCache",
            "ConversationCache",
            "DownloadInstallState",
            "DownloadManifest",
            "GameActivationListCache",
            "GameStatsCache",
            "OwnershipCache",
            "PlaytimeCache",
            "UserDat",
            "UserSettings"});
            this.checkedListBox1.Location = new System.Drawing.Point(30, 110);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 220);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // ParserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.OpenFileAsButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ParserGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubi Parser GUI";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button OpenFileAsButton;
        private RichTextBox richTextBox1;
        private CheckedListBox checkedListBox1;
    }
}