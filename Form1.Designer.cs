namespace VideoDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.Label();
            this.textBox_URL = new System.Windows.Forms.TextBox();
            this.button_Download = new System.Windows.Forms.Button();
            this.textBox_Filename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_Path = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.label_Path = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.linkLabel_Manual = new System.Windows.Forms.LinkLabel();
            this.button_Update = new System.Windows.Forms.Button();
            this.label_help = new System.Windows.Forms.Label();
            this.textBox_OptionalArgs = new System.Windows.Forms.TextBox();
            this.label_OptionalArgs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Location = new System.Drawing.Point(9, 26);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(56, 15);
            this.input.TabIndex = 0;
            this.input.Text = "Url videa:";
            // 
            // textBox_URL
            // 
            this.textBox_URL.Location = new System.Drawing.Point(9, 44);
            this.textBox_URL.Name = "textBox_URL";
            this.textBox_URL.Size = new System.Drawing.Size(274, 23);
            this.textBox_URL.TabIndex = 1;
            this.textBox_URL.TextChanged += new System.EventHandler(this.EnableDownloadButton);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(481, 240);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 4;
            this.button_Download.Text = "Stáhnout";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // textBox_Filename
            // 
            this.textBox_Filename.Location = new System.Drawing.Point(289, 44);
            this.textBox_Filename.Name = "textBox_Filename";
            this.textBox_Filename.Size = new System.Drawing.Size(274, 23);
            this.textBox_Filename.TabIndex = 5;
            this.textBox_Filename.TextChanged += new System.EventHandler(this.EnableDownloadButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Název souboru:";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(25, 240);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(89, 15);
            this.linkLabel.TabIndex = 7;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Dostupné weby";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // button_Path
            // 
            this.button_Path.Location = new System.Drawing.Point(259, 113);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(24, 24);
            this.button_Path.TabIndex = 8;
            this.button_Path.Text = "...";
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.Location = new System.Drawing.Point(9, 169);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Output.Size = new System.Drawing.Size(554, 61);
            this.textBox_Output.TabIndex = 11;
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(9, 95);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(39, 15);
            this.label_Path.TabIndex = 12;
            this.label_Path.Text = "Cesta:";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(9, 113);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(244, 23);
            this.textBox_Path.TabIndex = 13;
            this.textBox_Path.TextChanged += new System.EventHandler(this.EnableDownloadButton);
            // 
            // linkLabel_Manual
            // 
            this.linkLabel_Manual.AutoSize = true;
            this.linkLabel_Manual.Location = new System.Drawing.Point(120, 240);
            this.linkLabel_Manual.Name = "linkLabel_Manual";
            this.linkLabel_Manual.Size = new System.Drawing.Size(47, 15);
            this.linkLabel_Manual.TabIndex = 14;
            this.linkLabel_Manual.TabStop = true;
            this.linkLabel_Manual.Text = "Manuál";
            this.linkLabel_Manual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Manual_LinkClicked);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(379, 240);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(87, 23);
            this.button_Update.TabIndex = 15;
            this.button_Update.Text = "Aktualizovat";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Location = new System.Drawing.Point(25, 225);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(64, 15);
            this.label_help.TabIndex = 16;
            this.label_help.Text = "Nápověda:";
            // 
            // textBox_OptionalArgs
            // 
            this.textBox_OptionalArgs.Location = new System.Drawing.Point(289, 113);
            this.textBox_OptionalArgs.Name = "textBox_OptionalArgs";
            this.textBox_OptionalArgs.Size = new System.Drawing.Size(274, 23);
            this.textBox_OptionalArgs.TabIndex = 17;
            this.textBox_OptionalArgs.TextChanged += new System.EventHandler(this.EnableDownloadButton);
            // 
            // label_OptionalArgs
            // 
            this.label_OptionalArgs.AutoSize = true;
            this.label_OptionalArgs.Location = new System.Drawing.Point(289, 95);
            this.label_OptionalArgs.Name = "label_OptionalArgs";
            this.label_OptionalArgs.Size = new System.Drawing.Size(116, 15);
            this.label_OptionalArgs.TabIndex = 18;
            this.label_OptionalArgs.Text = "Volitelné argumenty:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 275);
            this.Controls.Add(this.label_OptionalArgs);
            this.Controls.Add(this.textBox_OptionalArgs);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.linkLabel_Manual);
            this.Controls.Add(this.textBox_Output);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.button_Path);
            this.Controls.Add(this.input);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.textBox_URL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.textBox_Filename);
            this.Controls.Add(this.textBox_Path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VideoDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label input;
        private TextBox textBox_URL;
        private Button button_Download;
        private TextBox textBox_Filename;
        private Label label1;
        private LinkLabel linkLabel;
        private FolderBrowserDialog folderBrowserDialog;
        private Button button_Path;
        private TextBox textBox_Output;
        private Label label_Path;
        private TextBox textBox_Path;
        private LinkLabel linkLabel_Manual;
        private Button button_Update;
        private Label label_help;
        private TextBox textBox_OptionalArgs;
        private Label label_OptionalArgs;
    }
}