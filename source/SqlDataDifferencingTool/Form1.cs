using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlDataDifferencingTool.Common;
using SqlDataDifferencingTool.Properties;

namespace SqlDataDifferencingTool
{
	public partial class SqlTableDiffForm : Form
	{
		public SqlTableDiffForm()
		{
			InitializeComponent();

			// initialize comboboxes (SQL Authentication)
			ComboBoxSourceAuth.SelectedIndex = 1;
			ComboBoxDestinationAuth.SelectedIndex = 1;
		}
		//
		// UI helpers
		//
		private string GetServerName(InputGroup group)
		{
			bool isSource = (group == InputGroup.Source);
			return isSource ? TextBoxSourceServer.Text : TextBoxDesitnationServer.Text;
		}
		private string GetDatabaseName(InputGroup group)
		{
			bool isSource = (group == InputGroup.Source);
			return isSource ? TextBoxSourceDatabase.Text : TextBoxDestinationDatabase.Text;
		}
		private string GetLogin(InputGroup group)
		{
			bool isSource = (group == InputGroup.Source);
			AuthType authType = GetAuthType(group);

			if (authType == AuthType.Sql)
				return isSource ? TextBoxSourceLogin.Text : TextBoxDestinationLogin.Text;

			else // Windows Auth
				return string.Empty;
		}
		private string GetPassword(InputGroup group)
		{
			bool isSource = (group == InputGroup.Source);
			AuthType authType = GetAuthType(group);

			if (authType == AuthType.Sql)
				return isSource ? TextBoxSourcePassword.Text : TextBoxDestinationPassword.Text;

			else
				return string.Empty;
		}
		private AuthType GetAuthType(InputGroup group)
		{
			bool isSource = (group == InputGroup.Source);
			int selectedIndex;
			
			if (isSource)
				selectedIndex = ComboBoxSourceAuth.SelectedIndex;
			else
				selectedIndex = ComboBoxDestinationAuth.SelectedIndex;

			return (selectedIndex == 0) ? AuthType.Windows : AuthType.Sql;
		}

		private void EnableDisableSqlAuthFields(InputGroup group, bool enable)
		{
			if (group == InputGroup.Source)
			{
				TextBoxSourceLogin.Enabled = enable;
				TextBoxSourcePassword.Enabled = enable;
			}
			else
			{
				TextBoxDestinationLogin.Enabled = enable;
				TextBoxDestinationPassword.Enabled = enable;
			}

		}

		private void ButtonSourceTest_Click(object sender, EventArgs e)
		{
			string connectionString = GetConnectionString(InputGroup.Source);
			Util.TestConnection(connectionString, true);
		}

		private void ButtonDestinationTest_Click(object sender, EventArgs e)
		{
			string connectionString = GetConnectionString(InputGroup.Source);
			Util.TestConnection(connectionString, true);
		}

		private void ButtonCompare_Click(object sender, EventArgs e)
		{
			string connectionStringSource = GetConnectionString(InputGroup.Source);
			string connectionStringDestination = GetConnectionString(InputGroup.Destination);

			// test both connections
			if ((Util.TestConnection(connectionStringSource, false) == null) || (Util.TestConnection(connectionStringDestination, false) == null))
			{
				MessageBox.Show("Connection could not be established.");
				return;
			}
			
			// check whether the input tables were obtained
			string[] tableNames = Util.GetTableNames(TextBoxInputFile.Text);
			if (tableNames == null)
			{
				MessageBox.Show("input file path does not exist");
				return;
			}

			// check if the output path exists
			if (!Util.CheckPathExists(TextBoxOutputFile.Text))
			{
				MessageBox.Show("Output path does not exist");
				return;
			}

			string outputFilePath = Util.GetOutputFilePath(TextBoxOutputFile.Text);

			// build command (most of it anyway)
			TableDiffArgBuilder builder = CreateArgs();

			// run the command on each input table
			foreach (string tableName in tableNames)
			{
				string args = builder.AppendSourceTable(tableName).AppendDestinationTable(tableName).ToString(); // append the table name

				string tableDiffUtilityPath = Util.GetTableDbDiffUtilityPath();
				if (string.IsNullOrEmpty(tableDiffUtilityPath))
					return;

				Util.RunTableDbDiff(tableDiffUtilityPath, args);
			}

			MessageBox.Show("Success! Check the output file at:\n" + TextBoxOutputFile.Text);					
		}

		private void ComboBoxSourceAuth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboBoxSourceAuth.SelectedIndex == 0)
				EnableDisableSqlAuthFields(InputGroup.Source, false);

			else
				EnableDisableSqlAuthFields(InputGroup.Source, true);
		}

		private void ComboBoxDestinationAuth_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboBoxSourceAuth.SelectedIndex == 0)
				EnableDisableSqlAuthFields(InputGroup.Destination, false);

			else
				EnableDisableSqlAuthFields(InputGroup.Destination, true);
		}

		private void ButtonBrowseInput_Click(object sender, EventArgs e)
		{
			OpenFileDialog openDialog = new OpenFileDialog();
			openDialog.Filter = "Text Files (.txt)|*.txt";
			openDialog.AddExtension = true;
			openDialog.Multiselect = false;

			DialogResult result = openDialog.ShowDialog();
			if (result == System.Windows.Forms.DialogResult.OK)
				TextBoxInputFile.Text = openDialog.FileName;
		}

		// save settings
		private void SqlTableDiffForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Save();
		}

		// gets either Source connection string, or the destination connection string
		private string GetConnectionString(InputGroup group)
		{
			string serverName = GetServerName(group);
			string databaseName = GetDatabaseName(group);
			string login = GetLogin(group);
			string password = GetPassword(group);

			ConnectionStringBuilder builder = new ConnectionStringBuilder();
			return builder.AppendServerName(serverName).AppendDatabaseName(databaseName).AppendLogin(login).AppendPassword(password).ToString();
		}

		// creates a TableDiff args builder with all argumnets specified except for the table name
		private TableDiffArgBuilder CreateArgs()
		{
			TableDiffArgBuilder builder = new TableDiffArgBuilder();
			builder.AppendSourceServer(GetServerName(InputGroup.Source)).
				AppendSourceDatabase(GetDatabaseName(InputGroup.Source)).
				AppendSourceUser(GetLogin(InputGroup.Source)).
				AppendSourcePassword(GetPassword(InputGroup.Source)).

				AppendDestinationServer(GetServerName(InputGroup.Destination)).
				AppendDestinationDatabase(GetDatabaseName(InputGroup.Destination)).
				AppendDestinationUser(GetLogin(InputGroup.Destination)).
				AppendDestinationPassword(GetPassword(InputGroup.Destination)).

				AppendOutputFilePath(TextBoxOutputFile.Text);

			return builder;
		}
	}
}
