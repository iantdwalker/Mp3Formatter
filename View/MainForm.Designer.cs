namespace Mp3Formatter.View
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
			this._buttonOpen = new System.Windows.Forms.Button();
			this._textBoxPath = new System.Windows.Forms.TextBox();
			this._groupBoxOptions = new System.Windows.Forms.GroupBox();
			this._labelProgress = new System.Windows.Forms.Label();
			this._progressBar = new System.Windows.Forms.ProgressBar();
			this._groupBoxID3Tags = new System.Windows.Forms.GroupBox();
			this._comboBoxGenre = new System.Windows.Forms.ComboBox();
			this._checkBoxFileName = new System.Windows.Forms.CheckBox();
			this._textBoxFileName = new System.Windows.Forms.TextBox();
			this._checkBoxYear = new System.Windows.Forms.CheckBox();
			this._checkBoxGenre = new System.Windows.Forms.CheckBox();
			this._checkBoxComments = new System.Windows.Forms.CheckBox();
			this._checkBoxArtist = new System.Windows.Forms.CheckBox();
			this._checkBoxAlbum = new System.Windows.Forms.CheckBox();
			this._checkBoxTitle = new System.Windows.Forms.CheckBox();
			this._checkBoxTrackNumber = new System.Windows.Forms.CheckBox();
			this._textBoxYear = new System.Windows.Forms.TextBox();
			this._textBoxComments = new System.Windows.Forms.TextBox();
			this._textBoxArtist = new System.Windows.Forms.TextBox();
			this._textBoxAlbum = new System.Windows.Forms.TextBox();
			this._textBoxTitle = new System.Windows.Forms.TextBox();
			this._textBoxTrackNumber = new System.Windows.Forms.TextBox();
			this._groupBoxManualOverride = new System.Windows.Forms.GroupBox();
			this._checkBoxAutoFormat = new System.Windows.Forms.CheckBox();
			this._radioButtonSetIndividually = new System.Windows.Forms.RadioButton();
			this._radioButtonSetAll = new System.Windows.Forms.RadioButton();
			this._checkBoxManualOverride = new System.Windows.Forms.CheckBox();
			this._groupBoxDesiredFileNameFormat = new System.Windows.Forms.GroupBox();
			this._radioButtonDesiredFileNameFormat5 = new System.Windows.Forms.RadioButton();
			this._radioButtonDesiredFileNameFormat1 = new System.Windows.Forms.RadioButton();
			this._radioButtonDesiredFileNameFormat2 = new System.Windows.Forms.RadioButton();
			this._radioButtonDesiredFileNameFormat3 = new System.Windows.Forms.RadioButton();
			this._radioButtonDesiredFileNameFormat4 = new System.Windows.Forms.RadioButton();
			this._labelMP3 = new System.Windows.Forms.Label();
			this._groupBoxFormattingOptions = new System.Windows.Forms.GroupBox();
			this._checkBoxUseDictionaryXml = new System.Windows.Forms.CheckBox();
			this._checkBoxPopupError = new System.Windows.Forms.CheckBox();
			this._checkBoxReplaceUnderscoreWithSpace = new System.Windows.Forms.CheckBox();
			this._checkBoxUnderscore = new System.Windows.Forms.CheckBox();
			this._checkBoxBrackets = new System.Windows.Forms.CheckBox();
			this._checkBoxPopupConfirmation = new System.Windows.Forms.CheckBox();
			this._checkBoxPrefix0 = new System.Windows.Forms.CheckBox();
			this._buttonClearTags = new System.Windows.Forms.Button();
			this._buttonProcess = new System.Windows.Forms.Button();
			this._radioButtonSingle = new System.Windows.Forms.RadioButton();
			this._radioButtonMulti = new System.Windows.Forms.RadioButton();
			this._groupBoxOutput = new System.Windows.Forms.GroupBox();
			this._richTextBoxOutput = new System.Windows.Forms.RichTextBox();
			this._buttonClose = new System.Windows.Forms.Button();
			this._buttonClearOutput = new System.Windows.Forms.Button();
			this._groupBoxMode = new System.Windows.Forms.GroupBox();
			this._checkBoxRecursive = new System.Windows.Forms.CheckBox();
			this._tabControl = new System.Windows.Forms.TabControl();
			this._tabPageFormat = new System.Windows.Forms.TabPage();
			this._buttonReloadDictionary = new System.Windows.Forms.Button();
			this._groupBoxID3Mode = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this._radioButtonID3v2 = new System.Windows.Forms.RadioButton();
			this._radioButtonID3v1 = new System.Windows.Forms.RadioButton();
			this._groupBoxFileNameTitleOptions = new System.Windows.Forms.GroupBox();
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle = new System.Windows.Forms.RadioButton();
			this._radioButtonUseOriginalFileNameAndTitle = new System.Windows.Forms.RadioButton();
			this._radioButtonUseOriginalFileNameAsTitle = new System.Windows.Forms.RadioButton();
			this._radioButtonUseTitleAsNewFileName = new System.Windows.Forms.RadioButton();
			this._checkBoxAutoFormatOriginalFileName = new System.Windows.Forms.CheckBox();
			this._groupBoxOptions.SuspendLayout();
			this._groupBoxID3Tags.SuspendLayout();
			this._groupBoxManualOverride.SuspendLayout();
			this._groupBoxDesiredFileNameFormat.SuspendLayout();
			this._groupBoxFormattingOptions.SuspendLayout();
			this._groupBoxOutput.SuspendLayout();
			this._groupBoxMode.SuspendLayout();
			this._tabControl.SuspendLayout();
			this._tabPageFormat.SuspendLayout();
			this._groupBoxID3Mode.SuspendLayout();
			this._groupBoxFileNameTitleOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// _buttonOpen
			// 
			this._buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonOpen.Location = new System.Drawing.Point(979, 19);
			this._buttonOpen.Name = "_buttonOpen";
			this._buttonOpen.Size = new System.Drawing.Size(75, 23);
			this._buttonOpen.TabIndex = 2;
			this._buttonOpen.Text = "Open";
			this._buttonOpen.UseVisualStyleBackColor = true;
			this._buttonOpen.Click += new System.EventHandler(this._buttonOpen_Click);
			// 
			// _textBoxPath
			// 
			this._textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxPath.Location = new System.Drawing.Point(97, 21);
			this._textBoxPath.Name = "_textBoxPath";
			this._textBoxPath.Size = new System.Drawing.Size(876, 20);
			this._textBoxPath.TabIndex = 1;
			this._textBoxPath.TextChanged += new System.EventHandler(this._textBoxPath_TextChanged);
			// 
			// _groupBoxOptions
			// 
			this._groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._groupBoxOptions.BackColor = System.Drawing.Color.Transparent;
			this._groupBoxOptions.Controls.Add(this._groupBoxFileNameTitleOptions);
			this._groupBoxOptions.Controls.Add(this._labelProgress);
			this._groupBoxOptions.Controls.Add(this._progressBar);
			this._groupBoxOptions.Controls.Add(this._groupBoxID3Tags);
			this._groupBoxOptions.Controls.Add(this._groupBoxManualOverride);
			this._groupBoxOptions.Controls.Add(this._groupBoxDesiredFileNameFormat);
			this._groupBoxOptions.Controls.Add(this._labelMP3);
			this._groupBoxOptions.Controls.Add(this._textBoxPath);
			this._groupBoxOptions.Controls.Add(this._buttonOpen);
			this._groupBoxOptions.Controls.Add(this._groupBoxFormattingOptions);
			this._groupBoxOptions.Location = new System.Drawing.Point(8, 61);
			this._groupBoxOptions.Name = "_groupBoxOptions";
			this._groupBoxOptions.Size = new System.Drawing.Size(1060, 329);
			this._groupBoxOptions.TabIndex = 2;
			this._groupBoxOptions.TabStop = false;
			this._groupBoxOptions.Text = "Options";
			// 
			// _labelProgress
			// 
			this._labelProgress.AutoSize = true;
			this._labelProgress.Location = new System.Drawing.Point(602, 284);
			this._labelProgress.Name = "_labelProgress";
			this._labelProgress.Size = new System.Drawing.Size(106, 13);
			this._labelProgress.TabIndex = 8;
			this._labelProgress.Text = "Processing Progress:";
			// 
			// _progressBar
			// 
			this._progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._progressBar.Location = new System.Drawing.Point(595, 300);
			this._progressBar.Name = "_progressBar";
			this._progressBar.Size = new System.Drawing.Size(456, 23);
			this._progressBar.TabIndex = 9;
			// 
			// _groupBoxID3Tags
			// 
			this._groupBoxID3Tags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._groupBoxID3Tags.Controls.Add(this._comboBoxGenre);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxFileName);
			this._groupBoxID3Tags.Controls.Add(this._textBoxFileName);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxYear);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxGenre);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxComments);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxArtist);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxAlbum);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxTitle);
			this._groupBoxID3Tags.Controls.Add(this._checkBoxTrackNumber);
			this._groupBoxID3Tags.Controls.Add(this._textBoxYear);
			this._groupBoxID3Tags.Controls.Add(this._textBoxComments);
			this._groupBoxID3Tags.Controls.Add(this._textBoxArtist);
			this._groupBoxID3Tags.Controls.Add(this._textBoxAlbum);
			this._groupBoxID3Tags.Controls.Add(this._textBoxTitle);
			this._groupBoxID3Tags.Controls.Add(this._textBoxTrackNumber);
			this._groupBoxID3Tags.Location = new System.Drawing.Point(595, 49);
			this._groupBoxID3Tags.Name = "_groupBoxID3Tags";
			this._groupBoxID3Tags.Size = new System.Drawing.Size(462, 232);
			this._groupBoxID3Tags.TabIndex = 6;
			this._groupBoxID3Tags.TabStop = false;
			this._groupBoxID3Tags.Text = "Manual Override ID3 Tags";
			// 
			// _comboBoxGenre
			// 
			this._comboBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._comboBoxGenre.Enabled = false;
			this._comboBoxGenre.Location = new System.Drawing.Point(122, 180);
			this._comboBoxGenre.Name = "_comboBoxGenre";
			this._comboBoxGenre.Size = new System.Drawing.Size(334, 21);
			this._comboBoxGenre.Sorted = true;
			this._comboBoxGenre.TabIndex = 13;
			// 
			// _checkBoxFileName
			// 
			this._checkBoxFileName.AutoSize = true;
			this._checkBoxFileName.Enabled = false;
			this._checkBoxFileName.Location = new System.Drawing.Point(10, 24);
			this._checkBoxFileName.Name = "_checkBoxFileName";
			this._checkBoxFileName.Size = new System.Drawing.Size(76, 17);
			this._checkBoxFileName.TabIndex = 0;
			this._checkBoxFileName.Text = "File Name:";
			this._checkBoxFileName.UseVisualStyleBackColor = true;
			this._checkBoxFileName.CheckedChanged += new System.EventHandler(this._checkBoxFileName_CheckedChanged);
			// 
			// _textBoxFileName
			// 
			this._textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxFileName.Enabled = false;
			this._textBoxFileName.Location = new System.Drawing.Point(122, 22);
			this._textBoxFileName.Name = "_textBoxFileName";
			this._textBoxFileName.Size = new System.Drawing.Size(334, 20);
			this._textBoxFileName.TabIndex = 1;
			// 
			// _checkBoxYear
			// 
			this._checkBoxYear.AutoSize = true;
			this._checkBoxYear.Enabled = false;
			this._checkBoxYear.Location = new System.Drawing.Point(10, 209);
			this._checkBoxYear.Name = "_checkBoxYear";
			this._checkBoxYear.Size = new System.Drawing.Size(51, 17);
			this._checkBoxYear.TabIndex = 14;
			this._checkBoxYear.Text = "Year:";
			this._checkBoxYear.UseVisualStyleBackColor = true;
			this._checkBoxYear.CheckedChanged += new System.EventHandler(this._checkBoxYear_CheckedChanged);
			// 
			// _checkBoxGenre
			// 
			this._checkBoxGenre.AutoSize = true;
			this._checkBoxGenre.Enabled = false;
			this._checkBoxGenre.Location = new System.Drawing.Point(10, 182);
			this._checkBoxGenre.Name = "_checkBoxGenre";
			this._checkBoxGenre.Size = new System.Drawing.Size(58, 17);
			this._checkBoxGenre.TabIndex = 12;
			this._checkBoxGenre.Text = "Genre:";
			this._checkBoxGenre.UseVisualStyleBackColor = true;
			this._checkBoxGenre.CheckedChanged += new System.EventHandler(this._checkBoxGenre_CheckedChanged);
			// 
			// _checkBoxComments
			// 
			this._checkBoxComments.AutoSize = true;
			this._checkBoxComments.Enabled = false;
			this._checkBoxComments.Location = new System.Drawing.Point(10, 154);
			this._checkBoxComments.Name = "_checkBoxComments";
			this._checkBoxComments.Size = new System.Drawing.Size(78, 17);
			this._checkBoxComments.TabIndex = 10;
			this._checkBoxComments.Text = "Comments:";
			this._checkBoxComments.UseVisualStyleBackColor = true;
			this._checkBoxComments.CheckedChanged += new System.EventHandler(this._checkBoxComments_CheckedChanged);
			// 
			// _checkBoxArtist
			// 
			this._checkBoxArtist.AutoSize = true;
			this._checkBoxArtist.Enabled = false;
			this._checkBoxArtist.Location = new System.Drawing.Point(10, 128);
			this._checkBoxArtist.Name = "_checkBoxArtist";
			this._checkBoxArtist.Size = new System.Drawing.Size(52, 17);
			this._checkBoxArtist.TabIndex = 8;
			this._checkBoxArtist.Text = "Artist:";
			this._checkBoxArtist.UseVisualStyleBackColor = true;
			this._checkBoxArtist.CheckedChanged += new System.EventHandler(this._checkBoxArtist_CheckedChanged);
			// 
			// _checkBoxAlbum
			// 
			this._checkBoxAlbum.AutoSize = true;
			this._checkBoxAlbum.Enabled = false;
			this._checkBoxAlbum.Location = new System.Drawing.Point(10, 102);
			this._checkBoxAlbum.Name = "_checkBoxAlbum";
			this._checkBoxAlbum.Size = new System.Drawing.Size(58, 17);
			this._checkBoxAlbum.TabIndex = 6;
			this._checkBoxAlbum.Text = "Album:";
			this._checkBoxAlbum.UseVisualStyleBackColor = true;
			this._checkBoxAlbum.CheckedChanged += new System.EventHandler(this._checkBoxAlbum_CheckedChanged);
			// 
			// _checkBoxTitle
			// 
			this._checkBoxTitle.AutoSize = true;
			this._checkBoxTitle.Enabled = false;
			this._checkBoxTitle.Location = new System.Drawing.Point(10, 76);
			this._checkBoxTitle.Name = "_checkBoxTitle";
			this._checkBoxTitle.Size = new System.Drawing.Size(49, 17);
			this._checkBoxTitle.TabIndex = 4;
			this._checkBoxTitle.Text = "Title:";
			this._checkBoxTitle.UseVisualStyleBackColor = true;
			this._checkBoxTitle.CheckedChanged += new System.EventHandler(this._checkBoxTitle_CheckedChanged);
			// 
			// _checkBoxTrackNumber
			// 
			this._checkBoxTrackNumber.AutoSize = true;
			this._checkBoxTrackNumber.Enabled = false;
			this._checkBoxTrackNumber.Location = new System.Drawing.Point(10, 50);
			this._checkBoxTrackNumber.Name = "_checkBoxTrackNumber";
			this._checkBoxTrackNumber.Size = new System.Drawing.Size(97, 17);
			this._checkBoxTrackNumber.TabIndex = 2;
			this._checkBoxTrackNumber.Text = "Track Number:";
			this._checkBoxTrackNumber.UseVisualStyleBackColor = true;
			this._checkBoxTrackNumber.CheckedChanged += new System.EventHandler(this._checkBoxTrackNumber_CheckedChanged);
			// 
			// _textBoxYear
			// 
			this._textBoxYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxYear.Enabled = false;
			this._textBoxYear.Location = new System.Drawing.Point(122, 207);
			this._textBoxYear.Name = "_textBoxYear";
			this._textBoxYear.Size = new System.Drawing.Size(334, 20);
			this._textBoxYear.TabIndex = 15;
			// 
			// _textBoxComments
			// 
			this._textBoxComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxComments.Enabled = false;
			this._textBoxComments.Location = new System.Drawing.Point(122, 152);
			this._textBoxComments.Name = "_textBoxComments";
			this._textBoxComments.Size = new System.Drawing.Size(334, 20);
			this._textBoxComments.TabIndex = 11;
			// 
			// _textBoxArtist
			// 
			this._textBoxArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxArtist.Enabled = false;
			this._textBoxArtist.Location = new System.Drawing.Point(122, 126);
			this._textBoxArtist.Name = "_textBoxArtist";
			this._textBoxArtist.Size = new System.Drawing.Size(334, 20);
			this._textBoxArtist.TabIndex = 9;
			// 
			// _textBoxAlbum
			// 
			this._textBoxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxAlbum.Enabled = false;
			this._textBoxAlbum.Location = new System.Drawing.Point(122, 100);
			this._textBoxAlbum.Name = "_textBoxAlbum";
			this._textBoxAlbum.Size = new System.Drawing.Size(334, 20);
			this._textBoxAlbum.TabIndex = 7;
			// 
			// _textBoxTitle
			// 
			this._textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxTitle.Enabled = false;
			this._textBoxTitle.Location = new System.Drawing.Point(122, 74);
			this._textBoxTitle.Name = "_textBoxTitle";
			this._textBoxTitle.Size = new System.Drawing.Size(334, 20);
			this._textBoxTitle.TabIndex = 5;
			// 
			// _textBoxTrackNumber
			// 
			this._textBoxTrackNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._textBoxTrackNumber.Enabled = false;
			this._textBoxTrackNumber.Location = new System.Drawing.Point(122, 48);
			this._textBoxTrackNumber.Name = "_textBoxTrackNumber";
			this._textBoxTrackNumber.Size = new System.Drawing.Size(334, 20);
			this._textBoxTrackNumber.TabIndex = 3;
			// 
			// _groupBoxManualOverride
			// 
			this._groupBoxManualOverride.Controls.Add(this._checkBoxAutoFormat);
			this._groupBoxManualOverride.Controls.Add(this._radioButtonSetIndividually);
			this._groupBoxManualOverride.Controls.Add(this._radioButtonSetAll);
			this._groupBoxManualOverride.Controls.Add(this._checkBoxManualOverride);
			this._groupBoxManualOverride.Location = new System.Drawing.Point(442, 49);
			this._groupBoxManualOverride.Name = "_groupBoxManualOverride";
			this._groupBoxManualOverride.Size = new System.Drawing.Size(147, 138);
			this._groupBoxManualOverride.TabIndex = 5;
			this._groupBoxManualOverride.TabStop = false;
			this._groupBoxManualOverride.Text = "Manual Override";
			// 
			// _checkBoxAutoFormat
			// 
			this._checkBoxAutoFormat.AutoSize = true;
			this._checkBoxAutoFormat.Checked = true;
			this._checkBoxAutoFormat.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxAutoFormat.Enabled = false;
			this._checkBoxAutoFormat.Location = new System.Drawing.Point(6, 85);
			this._checkBoxAutoFormat.Name = "_checkBoxAutoFormat";
			this._checkBoxAutoFormat.Size = new System.Drawing.Size(146, 17);
			this._checkBoxAutoFormat.TabIndex = 3;
			this._checkBoxAutoFormat.Text = "Auto-format manual tags?";
			this._checkBoxAutoFormat.UseVisualStyleBackColor = true;
			// 
			// _radioButtonSetIndividually
			// 
			this._radioButtonSetIndividually.AutoSize = true;
			this._radioButtonSetIndividually.Checked = true;
			this._radioButtonSetIndividually.Enabled = false;
			this._radioButtonSetIndividually.Location = new System.Drawing.Point(38, 42);
			this._radioButtonSetIndividually.Name = "_radioButtonSetIndividually";
			this._radioButtonSetIndividually.Size = new System.Drawing.Size(101, 17);
			this._radioButtonSetIndividually.TabIndex = 1;
			this._radioButtonSetIndividually.TabStop = true;
			this._radioButtonSetIndividually.Text = "Set individually?";
			this._radioButtonSetIndividually.UseVisualStyleBackColor = true;
			this._radioButtonSetIndividually.CheckedChanged += new System.EventHandler(this._radioButtonSetIndividually_CheckedChanged);
			// 
			// _radioButtonSetAll
			// 
			this._radioButtonSetAll.AutoSize = true;
			this._radioButtonSetAll.Enabled = false;
			this._radioButtonSetAll.Location = new System.Drawing.Point(38, 62);
			this._radioButtonSetAll.Name = "_radioButtonSetAll";
			this._radioButtonSetAll.Size = new System.Drawing.Size(60, 17);
			this._radioButtonSetAll.TabIndex = 2;
			this._radioButtonSetAll.Text = "Set all?";
			this._radioButtonSetAll.UseVisualStyleBackColor = true;
			this._radioButtonSetAll.CheckedChanged += new System.EventHandler(this._radioButtonSetAll_CheckedChanged);
			// 
			// _checkBoxManualOverride
			// 
			this._checkBoxManualOverride.AutoSize = true;
			this._checkBoxManualOverride.Location = new System.Drawing.Point(6, 19);
			this._checkBoxManualOverride.Name = "_checkBoxManualOverride";
			this._checkBoxManualOverride.Size = new System.Drawing.Size(135, 17);
			this._checkBoxManualOverride.TabIndex = 0;
			this._checkBoxManualOverride.Text = "Set ID3 tags manually?";
			this._checkBoxManualOverride.UseVisualStyleBackColor = true;
			this._checkBoxManualOverride.CheckedChanged += new System.EventHandler(this._checkBoxManualOverride_CheckedChanged);
			// 
			// _groupBoxDesiredFileNameFormat
			// 
			this._groupBoxDesiredFileNameFormat.Controls.Add(this._radioButtonDesiredFileNameFormat5);
			this._groupBoxDesiredFileNameFormat.Controls.Add(this._radioButtonDesiredFileNameFormat1);
			this._groupBoxDesiredFileNameFormat.Controls.Add(this._radioButtonDesiredFileNameFormat2);
			this._groupBoxDesiredFileNameFormat.Controls.Add(this._radioButtonDesiredFileNameFormat3);
			this._groupBoxDesiredFileNameFormat.Controls.Add(this._radioButtonDesiredFileNameFormat4);
			this._groupBoxDesiredFileNameFormat.Location = new System.Drawing.Point(9, 49);
			this._groupBoxDesiredFileNameFormat.Name = "_groupBoxDesiredFileNameFormat";
			this._groupBoxDesiredFileNameFormat.Size = new System.Drawing.Size(221, 138);
			this._groupBoxDesiredFileNameFormat.TabIndex = 3;
			this._groupBoxDesiredFileNameFormat.TabStop = false;
			this._groupBoxDesiredFileNameFormat.Text = "Desired File Name Output Format";
			// 
			// _radioButtonDesiredFileNameFormat5
			// 
			this._radioButtonDesiredFileNameFormat5.AutoSize = true;
			this._radioButtonDesiredFileNameFormat5.Location = new System.Drawing.Point(6, 109);
			this._radioButtonDesiredFileNameFormat5.Name = "_radioButtonDesiredFileNameFormat5";
			this._radioButtonDesiredFileNameFormat5.Size = new System.Drawing.Size(72, 17);
			this._radioButtonDesiredFileNameFormat5.TabIndex = 4;
			this._radioButtonDesiredFileNameFormat5.Text = "File Name";
			this._radioButtonDesiredFileNameFormat5.UseVisualStyleBackColor = true;
			// 
			// _radioButtonDesiredFileNameFormat1
			// 
			this._radioButtonDesiredFileNameFormat1.AutoSize = true;
			this._radioButtonDesiredFileNameFormat1.Checked = true;
			this._radioButtonDesiredFileNameFormat1.Location = new System.Drawing.Point(6, 19);
			this._radioButtonDesiredFileNameFormat1.Name = "_radioButtonDesiredFileNameFormat1";
			this._radioButtonDesiredFileNameFormat1.Size = new System.Drawing.Size(87, 17);
			this._radioButtonDesiredFileNameFormat1.TabIndex = 0;
			this._radioButtonDesiredFileNameFormat1.TabStop = true;
			this._radioButtonDesiredFileNameFormat1.Text = "01-File Name";
			this._radioButtonDesiredFileNameFormat1.UseVisualStyleBackColor = true;
			// 
			// _radioButtonDesiredFileNameFormat2
			// 
			this._radioButtonDesiredFileNameFormat2.AutoSize = true;
			this._radioButtonDesiredFileNameFormat2.Location = new System.Drawing.Point(6, 42);
			this._radioButtonDesiredFileNameFormat2.Name = "_radioButtonDesiredFileNameFormat2";
			this._radioButtonDesiredFileNameFormat2.Size = new System.Drawing.Size(87, 17);
			this._radioButtonDesiredFileNameFormat2.TabIndex = 1;
			this._radioButtonDesiredFileNameFormat2.Text = "01.File Name";
			this._radioButtonDesiredFileNameFormat2.UseVisualStyleBackColor = true;
			// 
			// _radioButtonDesiredFileNameFormat3
			// 
			this._radioButtonDesiredFileNameFormat3.AutoSize = true;
			this._radioButtonDesiredFileNameFormat3.Location = new System.Drawing.Point(6, 64);
			this._radioButtonDesiredFileNameFormat3.Name = "_radioButtonDesiredFileNameFormat3";
			this._radioButtonDesiredFileNameFormat3.Size = new System.Drawing.Size(93, 17);
			this._radioButtonDesiredFileNameFormat3.TabIndex = 2;
			this._radioButtonDesiredFileNameFormat3.Text = "01 - File Name";
			this._radioButtonDesiredFileNameFormat3.UseVisualStyleBackColor = true;
			// 
			// _radioButtonDesiredFileNameFormat4
			// 
			this._radioButtonDesiredFileNameFormat4.AutoSize = true;
			this._radioButtonDesiredFileNameFormat4.Location = new System.Drawing.Point(6, 86);
			this._radioButtonDesiredFileNameFormat4.Name = "_radioButtonDesiredFileNameFormat4";
			this._radioButtonDesiredFileNameFormat4.Size = new System.Drawing.Size(87, 17);
			this._radioButtonDesiredFileNameFormat4.TabIndex = 3;
			this._radioButtonDesiredFileNameFormat4.Text = "01 File Name";
			this._radioButtonDesiredFileNameFormat4.UseVisualStyleBackColor = true;
			// 
			// _labelMP3
			// 
			this._labelMP3.AutoSize = true;
			this._labelMP3.Location = new System.Drawing.Point(6, 24);
			this._labelMP3.Name = "_labelMP3";
			this._labelMP3.Size = new System.Drawing.Size(85, 13);
			this._labelMP3.TabIndex = 0;
			this._labelMP3.Text = "MP3 File/Folder:";
			// 
			// _groupBoxFormattingOptions
			// 
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxAutoFormatOriginalFileName);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxUseDictionaryXml);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxPopupError);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxReplaceUnderscoreWithSpace);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxUnderscore);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxBrackets);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxPopupConfirmation);
			this._groupBoxFormattingOptions.Controls.Add(this._checkBoxPrefix0);
			this._groupBoxFormattingOptions.Location = new System.Drawing.Point(9, 193);
			this._groupBoxFormattingOptions.Name = "_groupBoxFormattingOptions";
			this._groupBoxFormattingOptions.Size = new System.Drawing.Size(580, 130);
			this._groupBoxFormattingOptions.TabIndex = 7;
			this._groupBoxFormattingOptions.TabStop = false;
			this._groupBoxFormattingOptions.Text = "Formatting Options";
			// 
			// _checkBoxUseDictionaryXml
			// 
			this._checkBoxUseDictionaryXml.AutoSize = true;
			this._checkBoxUseDictionaryXml.Checked = true;
			this._checkBoxUseDictionaryXml.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxUseDictionaryXml.Location = new System.Drawing.Point(9, 61);
			this._checkBoxUseDictionaryXml.Name = "_checkBoxUseDictionaryXml";
			this._checkBoxUseDictionaryXml.Size = new System.Drawing.Size(126, 17);
			this._checkBoxUseDictionaryXml.TabIndex = 2;
			this._checkBoxUseDictionaryXml.Text = "Use Dictionary XML?";
			this._checkBoxUseDictionaryXml.UseVisualStyleBackColor = true;
			// 
			// _checkBoxPopupError
			// 
			this._checkBoxPopupError.AutoSize = true;
			this._checkBoxPopupError.Checked = true;
			this._checkBoxPopupError.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxPopupError.Location = new System.Drawing.Point(9, 107);
			this._checkBoxPopupError.Name = "_checkBoxPopupError";
			this._checkBoxPopupError.Size = new System.Drawing.Size(251, 17);
			this._checkBoxPopupError.TabIndex = 4;
			this._checkBoxPopupError.Text = "Pop-up confirmation on fatal error encountered?";
			this._checkBoxPopupError.UseVisualStyleBackColor = true;
			// 
			// _checkBoxReplaceUnderscoreWithSpace
			// 
			this._checkBoxReplaceUnderscoreWithSpace.AutoSize = true;
			this._checkBoxReplaceUnderscoreWithSpace.Checked = true;
			this._checkBoxReplaceUnderscoreWithSpace.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxReplaceUnderscoreWithSpace.Location = new System.Drawing.Point(264, 39);
			this._checkBoxReplaceUnderscoreWithSpace.Name = "_checkBoxReplaceUnderscoreWithSpace";
			this._checkBoxReplaceUnderscoreWithSpace.Size = new System.Drawing.Size(182, 17);
			this._checkBoxReplaceUnderscoreWithSpace.TabIndex = 6;
			this._checkBoxReplaceUnderscoreWithSpace.Text = "Replace underscore with space?";
			this._checkBoxReplaceUnderscoreWithSpace.UseVisualStyleBackColor = true;
			// 
			// _checkBoxUnderscore
			// 
			this._checkBoxUnderscore.AutoSize = true;
			this._checkBoxUnderscore.Checked = true;
			this._checkBoxUnderscore.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxUnderscore.Location = new System.Drawing.Point(9, 39);
			this._checkBoxUnderscore.Name = "_checkBoxUnderscore";
			this._checkBoxUnderscore.Size = new System.Drawing.Size(167, 17);
			this._checkBoxUnderscore.TabIndex = 1;
			this._checkBoxUnderscore.Text = "Upper case after underscore?";
			this._checkBoxUnderscore.UseVisualStyleBackColor = true;
			// 
			// _checkBoxBrackets
			// 
			this._checkBoxBrackets.AutoSize = true;
			this._checkBoxBrackets.Checked = true;
			this._checkBoxBrackets.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxBrackets.Location = new System.Drawing.Point(264, 19);
			this._checkBoxBrackets.Name = "_checkBoxBrackets";
			this._checkBoxBrackets.Size = new System.Drawing.Size(168, 17);
			this._checkBoxBrackets.TabIndex = 5;
			this._checkBoxBrackets.Text = "Upper case after [{( brackets?";
			this._checkBoxBrackets.UseVisualStyleBackColor = true;
			// 
			// _checkBoxPopupConfirmation
			// 
			this._checkBoxPopupConfirmation.AutoSize = true;
			this._checkBoxPopupConfirmation.Location = new System.Drawing.Point(9, 84);
			this._checkBoxPopupConfirmation.Name = "_checkBoxPopupConfirmation";
			this._checkBoxPopupConfirmation.Size = new System.Drawing.Size(241, 17);
			this._checkBoxPopupConfirmation.TabIndex = 3;
			this._checkBoxPopupConfirmation.Text = "Pop-up confirmation on processing complete?";
			this._checkBoxPopupConfirmation.UseVisualStyleBackColor = true;
			// 
			// _checkBoxPrefix0
			// 
			this._checkBoxPrefix0.AutoSize = true;
			this._checkBoxPrefix0.Checked = true;
			this._checkBoxPrefix0.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxPrefix0.Location = new System.Drawing.Point(9, 19);
			this._checkBoxPrefix0.Name = "_checkBoxPrefix0";
			this._checkBoxPrefix0.Size = new System.Drawing.Size(226, 17);
			this._checkBoxPrefix0.TabIndex = 0;
			this._checkBoxPrefix0.Text = "Prefix file name track numbers 1-9 with \'0\'?";
			this._checkBoxPrefix0.UseVisualStyleBackColor = true;
			// 
			// _buttonClearTags
			// 
			this._buttonClearTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._buttonClearTags.Location = new System.Drawing.Point(89, 555);
			this._buttonClearTags.Name = "_buttonClearTags";
			this._buttonClearTags.Size = new System.Drawing.Size(100, 23);
			this._buttonClearTags.TabIndex = 5;
			this._buttonClearTags.Text = "Clear Tag Values";
			this._buttonClearTags.UseVisualStyleBackColor = true;
			this._buttonClearTags.Click += new System.EventHandler(this._buttonClearTags_Click);
			// 
			// _buttonProcess
			// 
			this._buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonProcess.Enabled = false;
			this._buttonProcess.Location = new System.Drawing.Point(906, 555);
			this._buttonProcess.Name = "_buttonProcess";
			this._buttonProcess.Size = new System.Drawing.Size(75, 23);
			this._buttonProcess.TabIndex = 7;
			this._buttonProcess.Text = "Process";
			this._buttonProcess.UseVisualStyleBackColor = true;
			this._buttonProcess.Click += new System.EventHandler(this._buttonProcess_Click);
			// 
			// _radioButtonSingle
			// 
			this._radioButtonSingle.AutoSize = true;
			this._radioButtonSingle.Location = new System.Drawing.Point(9, 19);
			this._radioButtonSingle.Name = "_radioButtonSingle";
			this._radioButtonSingle.Size = new System.Drawing.Size(54, 17);
			this._radioButtonSingle.TabIndex = 0;
			this._radioButtonSingle.Text = "Single";
			this._radioButtonSingle.UseVisualStyleBackColor = true;
			this._radioButtonSingle.CheckedChanged += new System.EventHandler(this._radioButtonSingle_CheckedChanged);
			// 
			// _radioButtonMulti
			// 
			this._radioButtonMulti.AutoSize = true;
			this._radioButtonMulti.Checked = true;
			this._radioButtonMulti.Location = new System.Drawing.Point(69, 19);
			this._radioButtonMulti.Name = "_radioButtonMulti";
			this._radioButtonMulti.Size = new System.Drawing.Size(47, 17);
			this._radioButtonMulti.TabIndex = 1;
			this._radioButtonMulti.TabStop = true;
			this._radioButtonMulti.Text = "Multi";
			this._radioButtonMulti.UseVisualStyleBackColor = true;
			this._radioButtonMulti.CheckedChanged += new System.EventHandler(this._radioButtonMulti_CheckedChanged);
			// 
			// _groupBoxOutput
			// 
			this._groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._groupBoxOutput.Controls.Add(this._richTextBoxOutput);
			this._groupBoxOutput.Location = new System.Drawing.Point(8, 396);
			this._groupBoxOutput.Name = "_groupBoxOutput";
			this._groupBoxOutput.Size = new System.Drawing.Size(1060, 153);
			this._groupBoxOutput.TabIndex = 3;
			this._groupBoxOutput.TabStop = false;
			this._groupBoxOutput.Text = "Output";
			// 
			// _richTextBoxOutput
			// 
			this._richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this._richTextBoxOutput.Location = new System.Drawing.Point(3, 16);
			this._richTextBoxOutput.Name = "_richTextBoxOutput";
			this._richTextBoxOutput.ReadOnly = true;
			this._richTextBoxOutput.Size = new System.Drawing.Size(1054, 134);
			this._richTextBoxOutput.TabIndex = 0;
			this._richTextBoxOutput.Text = "";
			// 
			// _buttonClose
			// 
			this._buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonClose.Location = new System.Drawing.Point(987, 555);
			this._buttonClose.Name = "_buttonClose";
			this._buttonClose.Size = new System.Drawing.Size(75, 23);
			this._buttonClose.TabIndex = 8;
			this._buttonClose.Text = "Exit";
			this._buttonClose.UseVisualStyleBackColor = true;
			this._buttonClose.Click += new System.EventHandler(this._buttonClose_Click);
			// 
			// _buttonClearOutput
			// 
			this._buttonClearOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._buttonClearOutput.Location = new System.Drawing.Point(8, 555);
			this._buttonClearOutput.Name = "_buttonClearOutput";
			this._buttonClearOutput.Size = new System.Drawing.Size(75, 23);
			this._buttonClearOutput.TabIndex = 4;
			this._buttonClearOutput.Text = "Clear Output";
			this._buttonClearOutput.UseVisualStyleBackColor = true;
			this._buttonClearOutput.Click += new System.EventHandler(this._buttonClearOutput_Click);
			// 
			// _groupBoxMode
			// 
			this._groupBoxMode.Controls.Add(this._checkBoxRecursive);
			this._groupBoxMode.Controls.Add(this._radioButtonSingle);
			this._groupBoxMode.Controls.Add(this._radioButtonMulti);
			this._groupBoxMode.Location = new System.Drawing.Point(8, 6);
			this._groupBoxMode.Name = "_groupBoxMode";
			this._groupBoxMode.Size = new System.Drawing.Size(215, 49);
			this._groupBoxMode.TabIndex = 0;
			this._groupBoxMode.TabStop = false;
			this._groupBoxMode.Text = "Mode";
			// 
			// _checkBoxRecursive
			// 
			this._checkBoxRecursive.AutoSize = true;
			this._checkBoxRecursive.Location = new System.Drawing.Point(122, 20);
			this._checkBoxRecursive.Name = "_checkBoxRecursive";
			this._checkBoxRecursive.Size = new System.Drawing.Size(80, 17);
			this._checkBoxRecursive.TabIndex = 2;
			this._checkBoxRecursive.Text = "Recursive?";
			this._checkBoxRecursive.UseVisualStyleBackColor = true;
			// 
			// _tabControl
			// 
			this._tabControl.Controls.Add(this._tabPageFormat);
			this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tabControl.Location = new System.Drawing.Point(0, 0);
			this._tabControl.Name = "_tabControl";
			this._tabControl.SelectedIndex = 0;
			this._tabControl.Size = new System.Drawing.Size(1084, 612);
			this._tabControl.TabIndex = 0;
			// 
			// _tabPageFormat
			// 
			this._tabPageFormat.AutoScroll = true;
			this._tabPageFormat.Controls.Add(this._buttonReloadDictionary);
			this._tabPageFormat.Controls.Add(this._groupBoxID3Mode);
			this._tabPageFormat.Controls.Add(this._buttonClearTags);
			this._tabPageFormat.Controls.Add(this._buttonClearOutput);
			this._tabPageFormat.Controls.Add(this._buttonProcess);
			this._tabPageFormat.Controls.Add(this._groupBoxMode);
			this._tabPageFormat.Controls.Add(this._buttonClose);
			this._tabPageFormat.Controls.Add(this._groupBoxOutput);
			this._tabPageFormat.Controls.Add(this._groupBoxOptions);
			this._tabPageFormat.Location = new System.Drawing.Point(4, 22);
			this._tabPageFormat.Name = "_tabPageFormat";
			this._tabPageFormat.Padding = new System.Windows.Forms.Padding(3);
			this._tabPageFormat.Size = new System.Drawing.Size(1076, 586);
			this._tabPageFormat.TabIndex = 0;
			this._tabPageFormat.Text = "Format";
			this._tabPageFormat.UseVisualStyleBackColor = true;
			// 
			// _buttonReloadDictionary
			// 
			this._buttonReloadDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._buttonReloadDictionary.Location = new System.Drawing.Point(196, 555);
			this._buttonReloadDictionary.Name = "_buttonReloadDictionary";
			this._buttonReloadDictionary.Size = new System.Drawing.Size(99, 23);
			this._buttonReloadDictionary.TabIndex = 6;
			this._buttonReloadDictionary.Text = "Reload Dictionary";
			this._buttonReloadDictionary.UseVisualStyleBackColor = true;
			this._buttonReloadDictionary.Click += new System.EventHandler(this._buttonReloadDictionary_Click);
			// 
			// _groupBoxID3Mode
			// 
			this._groupBoxID3Mode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._groupBoxID3Mode.Controls.Add(this.label1);
			this._groupBoxID3Mode.Controls.Add(this._radioButtonID3v2);
			this._groupBoxID3Mode.Controls.Add(this._radioButtonID3v1);
			this._groupBoxID3Mode.Location = new System.Drawing.Point(229, 6);
			this._groupBoxID3Mode.Name = "_groupBoxID3Mode";
			this._groupBoxID3Mode.Size = new System.Drawing.Size(839, 49);
			this._groupBoxID3Mode.TabIndex = 1;
			this._groupBoxID3Mode.TabStop = false;
			this._groupBoxID3Mode.Text = "ID3 Tags To Update";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(127, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "(The Comments tag will update both versions)";
			// 
			// _radioButtonID3v2
			// 
			this._radioButtonID3v2.AutoSize = true;
			this._radioButtonID3v2.Checked = true;
			this._radioButtonID3v2.Location = new System.Drawing.Point(67, 19);
			this._radioButtonID3v2.Name = "_radioButtonID3v2";
			this._radioButtonID3v2.Size = new System.Drawing.Size(54, 17);
			this._radioButtonID3v2.TabIndex = 1;
			this._radioButtonID3v2.TabStop = true;
			this._radioButtonID3v2.Text = "ID3v2";
			this._radioButtonID3v2.UseVisualStyleBackColor = true;
			this._radioButtonID3v2.CheckedChanged += new System.EventHandler(this._radioButtonID3v2_CheckedChanged);
			// 
			// _radioButtonID3v1
			// 
			this._radioButtonID3v1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._radioButtonID3v1.AutoSize = true;
			this._radioButtonID3v1.Location = new System.Drawing.Point(7, 19);
			this._radioButtonID3v1.Name = "_radioButtonID3v1";
			this._radioButtonID3v1.Size = new System.Drawing.Size(54, 17);
			this._radioButtonID3v1.TabIndex = 0;
			this._radioButtonID3v1.Text = "ID3v1";
			this._radioButtonID3v1.UseVisualStyleBackColor = true;
			this._radioButtonID3v1.CheckedChanged += new System.EventHandler(this._radioButtonID3v1_CheckedChanged);
			// 
			// _groupBoxFileNameTitleOptions
			// 
			this._groupBoxFileNameTitleOptions.Controls.Add(this._radioButtonUseTitleAsNewFileName);
			this._groupBoxFileNameTitleOptions.Controls.Add(this._radioButtonUseOriginalFileNameAsTitle);
			this._groupBoxFileNameTitleOptions.Controls.Add(this._radioButtonUseOriginalFileNameAndTitle);
			this._groupBoxFileNameTitleOptions.Controls.Add(this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle);
			this._groupBoxFileNameTitleOptions.Location = new System.Drawing.Point(236, 49);
			this._groupBoxFileNameTitleOptions.Name = "_groupBoxFileNameTitleOptions";
			this._groupBoxFileNameTitleOptions.Size = new System.Drawing.Size(200, 138);
			this._groupBoxFileNameTitleOptions.TabIndex = 4;
			this._groupBoxFileNameTitleOptions.TabStop = false;
			this._groupBoxFileNameTitleOptions.Text = "File Name/Title Options";
			// 
			// _radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle
			// 
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.AutoSize = true;
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.Checked = true;
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.Location = new System.Drawing.Point(6, 19);
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.Name = "_radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle";
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.Size = new System.Drawing.Size(185, 17);
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.TabIndex = 0;
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.TabStop = true;
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.Text = "Title and new File Name the same";
			this._radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.UseVisualStyleBackColor = true;
			// 
			// _radioButtonUseOriginalFileNameAndTitle
			// 
			this._radioButtonUseOriginalFileNameAndTitle.AutoSize = true;
			this._radioButtonUseOriginalFileNameAndTitle.Location = new System.Drawing.Point(6, 42);
			this._radioButtonUseOriginalFileNameAndTitle.Name = "_radioButtonUseOriginalFileNameAndTitle";
			this._radioButtonUseOriginalFileNameAndTitle.Size = new System.Drawing.Size(154, 17);
			this._radioButtonUseOriginalFileNameAndTitle.TabIndex = 1;
			this._radioButtonUseOriginalFileNameAndTitle.Text = "Original File Name and Title";
			this._radioButtonUseOriginalFileNameAndTitle.UseVisualStyleBackColor = true;
			// 
			// _radioButtonUseOriginalFileNameAsTitle
			// 
			this._radioButtonUseOriginalFileNameAsTitle.AutoSize = true;
			this._radioButtonUseOriginalFileNameAsTitle.Location = new System.Drawing.Point(6, 64);
			this._radioButtonUseOriginalFileNameAsTitle.Name = "_radioButtonUseOriginalFileNameAsTitle";
			this._radioButtonUseOriginalFileNameAsTitle.Size = new System.Drawing.Size(148, 17);
			this._radioButtonUseOriginalFileNameAsTitle.TabIndex = 2;
			this._radioButtonUseOriginalFileNameAsTitle.Text = "Original File Name for Title";
			this._radioButtonUseOriginalFileNameAsTitle.UseVisualStyleBackColor = true;
			// 
			// _radioButtonUseTitleAsNewFileName
			// 
			this._radioButtonUseTitleAsNewFileName.AutoSize = true;
			this._radioButtonUseTitleAsNewFileName.Location = new System.Drawing.Point(6, 86);
			this._radioButtonUseTitleAsNewFileName.Name = "_radioButtonUseTitleAsNewFileName";
			this._radioButtonUseTitleAsNewFileName.Size = new System.Drawing.Size(132, 17);
			this._radioButtonUseTitleAsNewFileName.TabIndex = 3;
			this._radioButtonUseTitleAsNewFileName.Text = "Title as new File Name";
			this._radioButtonUseTitleAsNewFileName.UseVisualStyleBackColor = true;
			// 
			// _checkBoxAutoFormatOriginalFileName
			// 
			this._checkBoxAutoFormatOriginalFileName.AutoSize = true;
			this._checkBoxAutoFormatOriginalFileName.Checked = true;
			this._checkBoxAutoFormatOriginalFileName.CheckState = System.Windows.Forms.CheckState.Checked;
			this._checkBoxAutoFormatOriginalFileName.Location = new System.Drawing.Point(264, 61);
			this._checkBoxAutoFormatOriginalFileName.Name = "_checkBoxAutoFormatOriginalFileName";
			this._checkBoxAutoFormatOriginalFileName.Size = new System.Drawing.Size(167, 17);
			this._checkBoxAutoFormatOriginalFileName.TabIndex = 7;
			this._checkBoxAutoFormatOriginalFileName.Text = "Auto-format original file name?";
			this._checkBoxAutoFormatOriginalFileName.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 612);
			this.Controls.Add(this._tabControl);
			this.Name = "MainForm";
			this.Text = " Mp3Formatter";
			this._groupBoxOptions.ResumeLayout(false);
			this._groupBoxOptions.PerformLayout();
			this._groupBoxID3Tags.ResumeLayout(false);
			this._groupBoxID3Tags.PerformLayout();
			this._groupBoxManualOverride.ResumeLayout(false);
			this._groupBoxManualOverride.PerformLayout();
			this._groupBoxDesiredFileNameFormat.ResumeLayout(false);
			this._groupBoxDesiredFileNameFormat.PerformLayout();
			this._groupBoxFormattingOptions.ResumeLayout(false);
			this._groupBoxFormattingOptions.PerformLayout();
			this._groupBoxOutput.ResumeLayout(false);
			this._groupBoxMode.ResumeLayout(false);
			this._groupBoxMode.PerformLayout();
			this._tabControl.ResumeLayout(false);
			this._tabPageFormat.ResumeLayout(false);
			this._groupBoxID3Mode.ResumeLayout(false);
			this._groupBoxID3Mode.PerformLayout();
			this._groupBoxFileNameTitleOptions.ResumeLayout(false);
			this._groupBoxFileNameTitleOptions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _buttonOpen;
		private System.Windows.Forms.TextBox _textBoxPath;
		private System.Windows.Forms.GroupBox _groupBoxOptions;
		private System.Windows.Forms.RadioButton _radioButtonSingle;
		private System.Windows.Forms.RadioButton _radioButtonMulti;
		private System.Windows.Forms.GroupBox _groupBoxOutput;
		private System.Windows.Forms.Button _buttonClose;
		private System.Windows.Forms.RichTextBox _richTextBoxOutput;
		private System.Windows.Forms.Label _labelMP3;
		private System.Windows.Forms.Button _buttonProcess;
		private System.Windows.Forms.Button _buttonClearOutput;
		private System.Windows.Forms.GroupBox _groupBoxMode;
		private System.Windows.Forms.RadioButton _radioButtonDesiredFileNameFormat4;
		private System.Windows.Forms.RadioButton _radioButtonDesiredFileNameFormat3;
		private System.Windows.Forms.RadioButton _radioButtonDesiredFileNameFormat1;
		private System.Windows.Forms.RadioButton _radioButtonDesiredFileNameFormat2;
		private System.Windows.Forms.CheckBox _checkBoxManualOverride;
		private System.Windows.Forms.TabControl _tabControl;
		private System.Windows.Forms.TabPage _tabPageFormat;
		private System.Windows.Forms.GroupBox _groupBoxDesiredFileNameFormat;
		private System.Windows.Forms.GroupBox _groupBoxManualOverride;
		private System.Windows.Forms.RadioButton _radioButtonSetIndividually;
		private System.Windows.Forms.RadioButton _radioButtonSetAll;
		private System.Windows.Forms.Button _buttonClearTags;
		private System.Windows.Forms.CheckBox _checkBoxRecursive;
		private System.Windows.Forms.CheckBox _checkBoxPopupConfirmation;
		private System.Windows.Forms.CheckBox _checkBoxPrefix0;
		private System.Windows.Forms.CheckBox _checkBoxAutoFormat;
		private System.Windows.Forms.CheckBox _checkBoxPopupError;
		private System.Windows.Forms.RadioButton _radioButtonDesiredFileNameFormat5;
		private System.Windows.Forms.GroupBox _groupBoxID3Mode;
		private System.Windows.Forms.RadioButton _radioButtonID3v2;
		private System.Windows.Forms.RadioButton _radioButtonID3v1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox _groupBoxFormattingOptions;
		private System.Windows.Forms.CheckBox _checkBoxUnderscore;
		private System.Windows.Forms.CheckBox _checkBoxBrackets;
		private System.Windows.Forms.CheckBox _checkBoxReplaceUnderscoreWithSpace;
		private System.Windows.Forms.GroupBox _groupBoxID3Tags;
		private System.Windows.Forms.ComboBox _comboBoxGenre;
		private System.Windows.Forms.CheckBox _checkBoxFileName;
		private System.Windows.Forms.TextBox _textBoxFileName;
		private System.Windows.Forms.CheckBox _checkBoxYear;
		private System.Windows.Forms.CheckBox _checkBoxGenre;
		private System.Windows.Forms.CheckBox _checkBoxComments;
		private System.Windows.Forms.CheckBox _checkBoxArtist;
		private System.Windows.Forms.CheckBox _checkBoxAlbum;
		private System.Windows.Forms.CheckBox _checkBoxTitle;
		private System.Windows.Forms.CheckBox _checkBoxTrackNumber;
		private System.Windows.Forms.TextBox _textBoxYear;
		private System.Windows.Forms.TextBox _textBoxComments;
		private System.Windows.Forms.TextBox _textBoxArtist;
		private System.Windows.Forms.TextBox _textBoxAlbum;
		private System.Windows.Forms.TextBox _textBoxTitle;
		private System.Windows.Forms.TextBox _textBoxTrackNumber;
		private System.Windows.Forms.CheckBox _checkBoxUseDictionaryXml;
		private System.Windows.Forms.Button _buttonReloadDictionary;
		private System.Windows.Forms.Label _labelProgress;
		private System.Windows.Forms.ProgressBar _progressBar;
		private System.Windows.Forms.GroupBox _groupBoxFileNameTitleOptions;
		private System.Windows.Forms.RadioButton _radioButtonUseTitleAsNewFileName;
		private System.Windows.Forms.RadioButton _radioButtonUseOriginalFileNameAsTitle;
		private System.Windows.Forms.RadioButton _radioButtonUseOriginalFileNameAndTitle;
		private System.Windows.Forms.RadioButton _radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle;
		private System.Windows.Forms.CheckBox _checkBoxAutoFormatOriginalFileName;
	}
}

