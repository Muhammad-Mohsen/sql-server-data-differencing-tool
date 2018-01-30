using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlDataDifferencingTool.Common
{
	public class Util
	{
		//
		// File helpers
		//
		// reads the input file and parses out the tables to be compared
		public static string[] GetTableNames(string inputPath)
		{
			try
			{
				string tableNameString = File.ReadAllText(inputPath);
				return tableNameString.Split(';');
			}
			catch (Exception e)
			{
				return null;
			}
		}

		// appends a file name if the passed path didn't have one
		public static string GetOutputFilePath(string outputFilePath)
		{
			FileAttributes attributes = File.GetAttributes(outputFilePath);
			// if only directory is specified, append file name
			if (attributes.HasFlag(FileAttributes.Directory))
			{
				DirectoryInfo directroy = new DirectoryInfo(outputFilePath);
				return directroy.FullName + "\\results.txt";
			}

			return outputFilePath;
		}

		public static bool CheckPathExists(string path)
		{
			try
			{
				DirectoryInfo outputdirectory = new FileInfo(path).Directory; // to ensure we get the directory whether the textbox had a file, or a directory
				return outputdirectory.Exists;
			}
			catch (Exception e)
			{
				return false;
			}
		}

		public static bool CheckFileExists(string path)
		{
			try
			{
				FileInfo file = new FileInfo(path); // to ensure we get the directory whether the textbox had a file, or a directory
				return file.Exists;
			}
			catch (Exception e)
			{
				return false;
			}
		}
		//
		// DB helpers
		//
		// tests a SQL connection and returns it if 
		public static SqlConnection TestConnection(string connectionString, bool shouldShowMessageBox)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			try
			{
				connection.Open();

				if (shouldShowMessageBox)
					MessageBox.Show("Connection successful!");

				return connection;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return null;
			}
		}

		// gets all databases in a given server
		public static string[] GetDatabaseNames(string connectionString)
		{
			using (SqlConnection connection = TestConnection(connectionString, false))
			{
				if (connection != null)
				{
					if (connection.State != ConnectionState.Open)
						connection.Open();

					List<string> databaseNames = new List<string>();

					DataTable databases = connection.GetSchema("Databases");
					foreach (DataRow database in databases.Rows)
					{
						string databaseName = database.Field<string>("database_name");
						databaseNames.Add(databaseName);
					}

					string[] databaseNamesArray = databaseNames.ToArray<string>();
					Array.Sort(databaseNamesArray);

					return databaseNamesArray;
				}
			}

			return null;
		}
		//
		// Table Diff helpers
		//
		public static string GetTableDbDiffUtilityPath()
		{
			string tableDiffPath = @"C:\Program Files\Microsoft SQL Server\100\COM\tablediff.exe";
			if (!CheckFileExists(tableDiffPath))
			{
				MessageBox.Show("Table Diff utility could not be found");

				OpenFileDialog openDialog = new OpenFileDialog();
				openDialog.Title = "Specify Table Diff utility path";
				openDialog.Filter = "Executable file (tablediff.exe)|tablediff.exe";
				openDialog.AddExtension = true;

				DialogResult result = openDialog.ShowDialog();

				if (result == DialogResult.OK)
					tableDiffPath = openDialog.FileName;

				else return string.Empty;
			}

			return tableDiffPath;
		}

		public static void RunTableDbDiff(string path, string args)
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = path;
			startInfo.Arguments = args;
			startInfo.UseShellExecute = false;
			Process diffProcess = Process.Start(startInfo);

			diffProcess.WaitForExit();
		}
	}
}
