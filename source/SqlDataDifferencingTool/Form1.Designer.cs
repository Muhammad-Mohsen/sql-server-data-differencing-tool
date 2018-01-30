namespace SqlDataDifferencingTool
{
	partial class SqlTableDiffForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlTableDiffForm));
			this.ButtonSourceTest = new System.Windows.Forms.Button();
			this.labelSource = new System.Windows.Forms.Label();
			this.ComboBoxSourceAuth = new CustomControls.BorderedComboBox();
			this.labelSourceAuth = new System.Windows.Forms.Label();
			this.labelSourceLogin = new System.Windows.Forms.Label();
			this.labelSourcePassword = new System.Windows.Forms.Label();
			this.labelSourceDatabase = new System.Windows.Forms.Label();
			this.labelDestinationDatabase = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ComboBoxDestinationAuth = new CustomControls.BorderedComboBox();
			this.labelDestinationServer = new System.Windows.Forms.Label();
			this.ButtonDestinationTest = new System.Windows.Forms.Button();
			this.labelInput = new System.Windows.Forms.Label();
			this.labelOutput = new System.Windows.Forms.Label();
			this.ButtonCompare = new System.Windows.Forms.Button();
			this.TextBoxOutputFile = new System.Windows.Forms.TextBox();
			this.TextBoxInputFile = new System.Windows.Forms.TextBox();
			this.TextBoxDestinationDatabase = new System.Windows.Forms.TextBox();
			this.TextBoxDestinationPassword = new System.Windows.Forms.TextBox();
			this.TextBoxDestinationLogin = new System.Windows.Forms.TextBox();
			this.TextBoxDesitnationServer = new System.Windows.Forms.TextBox();
			this.TextBoxSourceDatabase = new System.Windows.Forms.TextBox();
			this.TextBoxSourcePassword = new System.Windows.Forms.TextBox();
			this.TextBoxSourceLogin = new System.Windows.Forms.TextBox();
			this.TextBoxSourceServer = new System.Windows.Forms.TextBox();
			this.ButtonBrowse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonSourceTest
			// 
			this.ButtonSourceTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonSourceTest.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.ButtonSourceTest.FlatAppearance.BorderSize = 0;
			this.ButtonSourceTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ButtonSourceTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSourceTest.Location = new System.Drawing.Point(283, 158);
			this.ButtonSourceTest.Name = "ButtonSourceTest";
			this.ButtonSourceTest.Size = new System.Drawing.Size(103, 23);
			this.ButtonSourceTest.TabIndex = 1;
			this.ButtonSourceTest.Text = "Test connection";
			this.ButtonSourceTest.UseVisualStyleBackColor = false;
			this.ButtonSourceTest.Click += new System.EventHandler(this.ButtonSourceTest_Click);
			// 
			// labelSource
			// 
			this.labelSource.AutoSize = true;
			this.labelSource.Location = new System.Drawing.Point(12, 19);
			this.labelSource.Name = "labelSource";
			this.labelSource.Size = new System.Drawing.Size(76, 13);
			this.labelSource.TabIndex = 2;
			this.labelSource.Text = "Source server:";
			// 
			// ComboBoxSourceAuth
			// 
			this.ComboBoxSourceAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ComboBoxSourceAuth.BorderColor = System.Drawing.Color.DimGray;
			this.ComboBoxSourceAuth.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ComboBoxSourceAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxSourceAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxSourceAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboBoxSourceAuth.ForeColor = System.Drawing.Color.Silver;
			this.ComboBoxSourceAuth.FormattingEnabled = true;
			this.ComboBoxSourceAuth.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
			this.ComboBoxSourceAuth.Location = new System.Drawing.Point(96, 71);
			this.ComboBoxSourceAuth.Name = "ComboBoxSourceAuth";
			this.ComboBoxSourceAuth.Size = new System.Drawing.Size(290, 23);
			this.ComboBoxSourceAuth.TabIndex = 3;
			this.ComboBoxSourceAuth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSourceAuth_SelectedIndexChanged);
			// 
			// labelSourceAuth
			// 
			this.labelSourceAuth.AutoSize = true;
			this.labelSourceAuth.Location = new System.Drawing.Point(12, 76);
			this.labelSourceAuth.Name = "labelSourceAuth";
			this.labelSourceAuth.Size = new System.Drawing.Size(78, 13);
			this.labelSourceAuth.TabIndex = 4;
			this.labelSourceAuth.Text = "Authentication:";
			// 
			// labelSourceLogin
			// 
			this.labelSourceLogin.AutoSize = true;
			this.labelSourceLogin.Location = new System.Drawing.Point(54, 104);
			this.labelSourceLogin.Name = "labelSourceLogin";
			this.labelSourceLogin.Size = new System.Drawing.Size(36, 13);
			this.labelSourceLogin.TabIndex = 5;
			this.labelSourceLogin.Text = "Login:";
			// 
			// labelSourcePassword
			// 
			this.labelSourcePassword.AutoSize = true;
			this.labelSourcePassword.Location = new System.Drawing.Point(34, 133);
			this.labelSourcePassword.Name = "labelSourcePassword";
			this.labelSourcePassword.Size = new System.Drawing.Size(56, 13);
			this.labelSourcePassword.TabIndex = 6;
			this.labelSourcePassword.Text = "Password:";
			// 
			// labelSourceDatabase
			// 
			this.labelSourceDatabase.AutoSize = true;
			this.labelSourceDatabase.Location = new System.Drawing.Point(12, 193);
			this.labelSourceDatabase.Name = "labelSourceDatabase";
			this.labelSourceDatabase.Size = new System.Drawing.Size(91, 13);
			this.labelSourceDatabase.TabIndex = 10;
			this.labelSourceDatabase.Text = "Source database:";
			// 
			// labelDestinationDatabase
			// 
			this.labelDestinationDatabase.AutoSize = true;
			this.labelDestinationDatabase.Location = new System.Drawing.Point(12, 446);
			this.labelDestinationDatabase.Name = "labelDestinationDatabase";
			this.labelDestinationDatabase.Size = new System.Drawing.Size(110, 13);
			this.labelDestinationDatabase.TabIndex = 21;
			this.labelDestinationDatabase.Text = "Destination database:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 386);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 357);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Login:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 329);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Authentication:";
			// 
			// ComboBoxDestinationAuth
			// 
			this.ComboBoxDestinationAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ComboBoxDestinationAuth.BorderColor = System.Drawing.Color.DimGray;
			this.ComboBoxDestinationAuth.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ComboBoxDestinationAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxDestinationAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxDestinationAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboBoxDestinationAuth.ForeColor = System.Drawing.Color.Silver;
			this.ComboBoxDestinationAuth.FormattingEnabled = true;
			this.ComboBoxDestinationAuth.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
			this.ComboBoxDestinationAuth.Location = new System.Drawing.Point(96, 324);
			this.ComboBoxDestinationAuth.Name = "ComboBoxDestinationAuth";
			this.ComboBoxDestinationAuth.Size = new System.Drawing.Size(290, 23);
			this.ComboBoxDestinationAuth.TabIndex = 14;
			this.ComboBoxDestinationAuth.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDestinationAuth_SelectedIndexChanged);
			// 
			// labelDestinationServer
			// 
			this.labelDestinationServer.AutoSize = true;
			this.labelDestinationServer.Location = new System.Drawing.Point(12, 273);
			this.labelDestinationServer.Name = "labelDestinationServer";
			this.labelDestinationServer.Size = new System.Drawing.Size(95, 13);
			this.labelDestinationServer.TabIndex = 13;
			this.labelDestinationServer.Text = "Destination server:";
			// 
			// ButtonDestinationTest
			// 
			this.ButtonDestinationTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonDestinationTest.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.ButtonDestinationTest.FlatAppearance.BorderSize = 0;
			this.ButtonDestinationTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ButtonDestinationTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDestinationTest.Location = new System.Drawing.Point(283, 411);
			this.ButtonDestinationTest.Name = "ButtonDestinationTest";
			this.ButtonDestinationTest.Size = new System.Drawing.Size(103, 23);
			this.ButtonDestinationTest.TabIndex = 12;
			this.ButtonDestinationTest.Text = "Test connection";
			this.ButtonDestinationTest.UseVisualStyleBackColor = false;
			this.ButtonDestinationTest.Click += new System.EventHandler(this.ButtonDestinationTest_Click);
			// 
			// labelInput
			// 
			this.labelInput.AutoSize = true;
			this.labelInput.Location = new System.Drawing.Point(12, 529);
			this.labelInput.Name = "labelInput";
			this.labelInput.Size = new System.Drawing.Size(50, 13);
			this.labelInput.TabIndex = 23;
			this.labelInput.Text = "Input file:";
			// 
			// labelOutput
			// 
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(12, 584);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(58, 13);
			this.labelOutput.TabIndex = 25;
			this.labelOutput.Text = "Output file:";
			// 
			// ButtonCompare
			// 
			this.ButtonCompare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonCompare.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.ButtonCompare.FlatAppearance.BorderSize = 0;
			this.ButtonCompare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ButtonCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonCompare.Location = new System.Drawing.Point(15, 656);
			this.ButtonCompare.Name = "ButtonCompare";
			this.ButtonCompare.Size = new System.Drawing.Size(371, 23);
			this.ButtonCompare.TabIndex = 26;
			this.ButtonCompare.Text = "Compare";
			this.ButtonCompare.UseVisualStyleBackColor = false;
			this.ButtonCompare.Click += new System.EventHandler(this.ButtonCompare_Click);
			// 
			// TextBoxOutputFile
			// 
			this.TextBoxOutputFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxOutputFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxOutputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxOutputFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxOutputFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "OutputFilePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxOutputFile.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxOutputFile.Location = new System.Drawing.Point(15, 600);
			this.TextBoxOutputFile.Name = "TextBoxOutputFile";
			this.TextBoxOutputFile.Size = new System.Drawing.Size(371, 21);
			this.TextBoxOutputFile.TabIndex = 24;
			this.TextBoxOutputFile.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.OutputFilePath;
			// 
			// TextBoxInputFile
			// 
			this.TextBoxInputFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxInputFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxInputFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxInputFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxInputFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "InputFilePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxInputFile.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxInputFile.Location = new System.Drawing.Point(15, 545);
			this.TextBoxInputFile.Name = "TextBoxInputFile";
			this.TextBoxInputFile.Size = new System.Drawing.Size(262, 21);
			this.TextBoxInputFile.TabIndex = 22;
			this.TextBoxInputFile.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.InputFilePath;
			// 
			// TextBoxDestinationDatabase
			// 
			this.TextBoxDestinationDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxDestinationDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxDestinationDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxDestinationDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDestinationDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "DestinationDatabase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxDestinationDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxDestinationDatabase.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxDestinationDatabase.Location = new System.Drawing.Point(15, 462);
			this.TextBoxDestinationDatabase.Multiline = true;
			this.TextBoxDestinationDatabase.Name = "TextBoxDestinationDatabase";
			this.TextBoxDestinationDatabase.Size = new System.Drawing.Size(371, 23);
			this.TextBoxDestinationDatabase.TabIndex = 20;
			this.TextBoxDestinationDatabase.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.DestinationDatabase;
			// 
			// TextBoxDestinationPassword
			// 
			this.TextBoxDestinationPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxDestinationPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDestinationPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "DestinationPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxDestinationPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxDestinationPassword.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxDestinationPassword.Location = new System.Drawing.Point(96, 382);
			this.TextBoxDestinationPassword.Name = "TextBoxDestinationPassword";
			this.TextBoxDestinationPassword.PasswordChar = 'x';
			this.TextBoxDestinationPassword.Size = new System.Drawing.Size(290, 21);
			this.TextBoxDestinationPassword.TabIndex = 19;
			this.TextBoxDestinationPassword.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.DestinationPassword;
			// 
			// TextBoxDestinationLogin
			// 
			this.TextBoxDestinationLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxDestinationLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxDestinationLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxDestinationLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDestinationLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "DestinationLogin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxDestinationLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxDestinationLogin.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxDestinationLogin.Location = new System.Drawing.Point(96, 353);
			this.TextBoxDestinationLogin.Name = "TextBoxDestinationLogin";
			this.TextBoxDestinationLogin.Size = new System.Drawing.Size(290, 21);
			this.TextBoxDestinationLogin.TabIndex = 18;
			this.TextBoxDestinationLogin.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.DestinationLogin;
			// 
			// TextBoxDesitnationServer
			// 
			this.TextBoxDesitnationServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxDesitnationServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxDesitnationServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxDesitnationServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxDesitnationServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "DestinationServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxDesitnationServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxDesitnationServer.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxDesitnationServer.Location = new System.Drawing.Point(15, 289);
			this.TextBoxDesitnationServer.Name = "TextBoxDesitnationServer";
			this.TextBoxDesitnationServer.Size = new System.Drawing.Size(371, 21);
			this.TextBoxDesitnationServer.TabIndex = 11;
			this.TextBoxDesitnationServer.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.DestinationServer;
			// 
			// TextBoxSourceDatabase
			// 
			this.TextBoxSourceDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxSourceDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxSourceDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxSourceDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxSourceDatabase.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "SourceDatabase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxSourceDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSourceDatabase.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxSourceDatabase.Location = new System.Drawing.Point(15, 209);
			this.TextBoxSourceDatabase.Name = "TextBoxSourceDatabase";
			this.TextBoxSourceDatabase.Size = new System.Drawing.Size(371, 21);
			this.TextBoxSourceDatabase.TabIndex = 9;
			this.TextBoxSourceDatabase.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.SourceDatabase;
			// 
			// TextBoxSourcePassword
			// 
			this.TextBoxSourcePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxSourcePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxSourcePassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "SourcePassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxSourcePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSourcePassword.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxSourcePassword.Location = new System.Drawing.Point(96, 129);
			this.TextBoxSourcePassword.Name = "TextBoxSourcePassword";
			this.TextBoxSourcePassword.PasswordChar = 'x';
			this.TextBoxSourcePassword.Size = new System.Drawing.Size(290, 21);
			this.TextBoxSourcePassword.TabIndex = 8;
			this.TextBoxSourcePassword.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.SourcePassword;
			// 
			// TextBoxSourceLogin
			// 
			this.TextBoxSourceLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxSourceLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxSourceLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxSourceLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxSourceLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "SourceLogin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxSourceLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSourceLogin.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxSourceLogin.Location = new System.Drawing.Point(96, 100);
			this.TextBoxSourceLogin.Name = "TextBoxSourceLogin";
			this.TextBoxSourceLogin.Size = new System.Drawing.Size(290, 21);
			this.TextBoxSourceLogin.TabIndex = 7;
			this.TextBoxSourceLogin.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.SourceLogin;
			// 
			// TextBoxSourceServer
			// 
			this.TextBoxSourceServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.TextBoxSourceServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
			this.TextBoxSourceServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.TextBoxSourceServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxSourceServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SqlDataDifferencingTool.Properties.Settings.Default, "SourceServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.TextBoxSourceServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBoxSourceServer.ForeColor = System.Drawing.Color.Gainsboro;
			this.TextBoxSourceServer.Location = new System.Drawing.Point(15, 35);
			this.TextBoxSourceServer.Name = "TextBoxSourceServer";
			this.TextBoxSourceServer.Size = new System.Drawing.Size(371, 21);
			this.TextBoxSourceServer.TabIndex = 0;
			this.TextBoxSourceServer.Text = global::SqlDataDifferencingTool.Properties.Settings.Default.SourceServer;
			// 
			// ButtonBrowse
			// 
			this.ButtonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.ButtonBrowse.FlatAppearance.BorderSize = 0;
			this.ButtonBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonBrowse.Location = new System.Drawing.Point(283, 545);
			this.ButtonBrowse.Name = "ButtonBrowse";
			this.ButtonBrowse.Size = new System.Drawing.Size(103, 23);
			this.ButtonBrowse.TabIndex = 29;
			this.ButtonBrowse.Text = "Browse";
			this.ButtonBrowse.UseVisualStyleBackColor = false;
			this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowseInput_Click);
			// 
			// SqlTableDiffForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(400, 693);
			this.Controls.Add(this.ButtonBrowse);
			this.Controls.Add(this.ButtonCompare);
			this.Controls.Add(this.labelOutput);
			this.Controls.Add(this.TextBoxOutputFile);
			this.Controls.Add(this.labelInput);
			this.Controls.Add(this.TextBoxInputFile);
			this.Controls.Add(this.labelDestinationDatabase);
			this.Controls.Add(this.TextBoxDestinationDatabase);
			this.Controls.Add(this.TextBoxDestinationPassword);
			this.Controls.Add(this.TextBoxDestinationLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ComboBoxDestinationAuth);
			this.Controls.Add(this.labelDestinationServer);
			this.Controls.Add(this.ButtonDestinationTest);
			this.Controls.Add(this.TextBoxDesitnationServer);
			this.Controls.Add(this.labelSourceDatabase);
			this.Controls.Add(this.TextBoxSourceDatabase);
			this.Controls.Add(this.TextBoxSourcePassword);
			this.Controls.Add(this.TextBoxSourceLogin);
			this.Controls.Add(this.labelSourcePassword);
			this.Controls.Add(this.labelSourceLogin);
			this.Controls.Add(this.labelSourceAuth);
			this.Controls.Add(this.ComboBoxSourceAuth);
			this.Controls.Add(this.labelSource);
			this.Controls.Add(this.ButtonSourceTest);
			this.Controls.Add(this.TextBoxSourceServer);
			this.ForeColor = System.Drawing.Color.Gainsboro;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SqlTableDiffForm";
			this.Text = "SQL Data Differencing";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SqlTableDiffForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBoxSourceServer;
		private System.Windows.Forms.Button ButtonSourceTest;
		private System.Windows.Forms.Label labelSource;
		private CustomControls.BorderedComboBox ComboBoxSourceAuth;
		private System.Windows.Forms.Label labelSourceAuth;
		private System.Windows.Forms.Label labelSourceLogin;
		private System.Windows.Forms.Label labelSourcePassword;
		private System.Windows.Forms.TextBox TextBoxSourceLogin;
		private System.Windows.Forms.TextBox TextBoxSourcePassword;
		private System.Windows.Forms.Label labelSourceDatabase;
		private System.Windows.Forms.TextBox TextBoxSourceDatabase;
		private System.Windows.Forms.Label labelDestinationDatabase;
		private System.Windows.Forms.TextBox TextBoxDestinationDatabase;
		private System.Windows.Forms.TextBox TextBoxDestinationPassword;
		private System.Windows.Forms.TextBox TextBoxDestinationLogin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private CustomControls.BorderedComboBox ComboBoxDestinationAuth;
		private System.Windows.Forms.Label labelDestinationServer;
		private System.Windows.Forms.Button ButtonDestinationTest;
		private System.Windows.Forms.TextBox TextBoxDesitnationServer;
		private System.Windows.Forms.Label labelInput;
		private System.Windows.Forms.TextBox TextBoxInputFile;
		private System.Windows.Forms.Label labelOutput;
		private System.Windows.Forms.TextBox TextBoxOutputFile;
		private System.Windows.Forms.Button ButtonCompare;
		private System.Windows.Forms.Button ButtonBrowse;
	}
}

