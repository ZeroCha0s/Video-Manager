namespace King_CourseProject_Part1
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(43, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(126, 24);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(274, 32);
            this.titleText.TabIndex = 0;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(126, 184);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(274, 32);
            this.yearText.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(40, 184);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(65, 26);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year:";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(126, 233);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(274, 32);
            this.urlText.TabIndex = 4;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(43, 233);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(62, 26);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "URL:";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(126, 129);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(274, 32);
            this.genreText.TabIndex = 2;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(27, 129);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(78, 26);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Genre:";
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(126, 77);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(274, 32);
            this.artistText.TabIndex = 1;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(37, 77);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(68, 26);
            this.artistLabel.TabIndex = 8;
            this.artistLabel.Text = "Artist:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(116, 291);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 61);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add Song";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(396, 291);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(379, 304);
            this.outputText.TabIndex = 11;
            this.outputText.TabStop = false;
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 25;
            this.songList.Location = new System.Drawing.Point(427, 53);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(348, 179);
            this.songList.TabIndex = 12;
            this.songList.TabStop = false;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // allSongsButton
            // 
            this.allSongsButton.Location = new System.Drawing.Point(116, 358);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(168, 61);
            this.allSongsButton.TabIndex = 6;
            this.allSongsButton.Text = "Show All Songs";
            this.allSongsButton.UseVisualStyleBackColor = true;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Song List:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(443, 262);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(85, 26);
            this.detailsLabel.TabIndex = 15;
            this.detailsLabel.Text = "Details:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 62);
            this.button1.TabIndex = 16;
            this.button1.Text = "Find Song";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 62);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(794, 53);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(524, 343);
            this.webViewDisplay.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 18;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(794, 414);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(168, 62);
            this.PlayButton.TabIndex = 19;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 677);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button PlayButton;
    }
}

