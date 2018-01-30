using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlDataDifferencingTool.Common
{
	// sample command
	// tablediff -sourceserver othdbdev.portal724.us -sourcedatabase Swaps -sourcetable tp_patient -sourceuser sa -sourcepassword Emerald200462 -destinationserver othdbdev.portal724.us -destinationdatabase Optum_Live_20190808 -destinationtable tp_patient -destinationuser sa -destinationpassword Emerald200462
	// args already validated when building the connection string for testing the connection
	public class TableDiffArgBuilder
	{
		private string SourceServer;
		private string SourceDatabase;
		private string SourceTable;
		private string SourceUser;
		private string SourcePassword;

		private string DestinationServer;
		private string DestinationDatabase;
		private string DestinationTable;
		private string DestinationUser;
		private string DestinationPassword;
		
		private string OutputFile;

		public TableDiffArgBuilder AppendSourceServer(string server) { SourceServer = server; return this; }
		public TableDiffArgBuilder AppendSourceDatabase(string database) { SourceDatabase = database; return this; }
		public TableDiffArgBuilder AppendSourceTable(string table) { SourceTable = table; return this; }
		public TableDiffArgBuilder AppendSourceUser(string user) { SourceUser = user; return this; }
		public TableDiffArgBuilder AppendSourcePassword(string password) { SourcePassword = password; return this; }

		public TableDiffArgBuilder AppendDestinationServer(string server) { DestinationServer = server; return this; }
		public TableDiffArgBuilder AppendDestinationDatabase(string database) { DestinationDatabase = database; return this; }
		public TableDiffArgBuilder AppendDestinationTable(string table) { DestinationTable = table; return this; }
		public TableDiffArgBuilder AppendDestinationUser(string user) { DestinationUser = user; return this; }
		public TableDiffArgBuilder AppendDestinationPassword(string password) { DestinationPassword = password; return this; }

		public TableDiffArgBuilder AppendOutputFilePath(string filePath) { OutputFile = filePath; return this; }

		public override string ToString()
		{
			string command = "-sourceserver " + SourceServer + " -sourcedatabase " + SourceDatabase + " -sourcetable " + SourceTable + " -sourceuser " + SourceUser + " -sourcepassword " + SourcePassword;
			command += " -destinationserver " + DestinationServer + " -destinationdatabase " + DestinationDatabase + " -destinationtable " + DestinationTable + " -destinationuser " + DestinationUser + " -destinationpassword " + DestinationPassword;
			command += " -o \"" + OutputFile + "\"";
			return command;
		}
	}
}
