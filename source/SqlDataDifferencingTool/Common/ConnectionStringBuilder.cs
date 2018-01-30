using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlDataDifferencingTool.Common
{
	public class ConnectionStringBuilder
	{
		private string ServerName;
		private string DatabaseName;
		private string Login;
		private string Password;

		private bool IntegratedSecurity;

		public ConnectionStringBuilder()
		{
			IntegratedSecurity = true;
		}

		public ConnectionStringBuilder AppendServerName(string serverName)
		{
			ServerName = serverName;
			return this;
		}
		public ConnectionStringBuilder AppendDatabaseName(string databaseName)
		{
			DatabaseName = databaseName;
			return this;
		}
		public ConnectionStringBuilder AppendLogin(string login)
		{
			if (!string.IsNullOrWhiteSpace(login))
			{
				IntegratedSecurity = false;
				Login = login;
			}

			return this;
		}
		public ConnectionStringBuilder AppendPassword(string password)
		{
			if (!string.IsNullOrWhiteSpace(password))
			{
				IntegratedSecurity = false;
				Password = password;
			}

			return this;
		}

		// sample connection string 
		// Initial Catalog=Optum_live;Data Source=.\sqlexpress;User ID=optumuser2;password=P@ssw0rd;
		public override string ToString()
		{
			if (!Validate())
				return string.Empty;

			string connectionString = "Data Source=" + ServerName + ";Initial Catalog=" + DatabaseName;

			if (IntegratedSecurity)
				connectionString += ";Integrated Security=true";
			else
				connectionString += ";User ID=" + Login + ";password=" + Password;

			return connectionString;
		}

		private bool Validate()
		{
			bool isServerNameValid = !string.IsNullOrWhiteSpace(ServerName);
			bool isDatabaseNameValid = !string.IsNullOrWhiteSpace(DatabaseName);

			bool isValidAuth = IntegratedSecurity || !(string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password));

			return isServerNameValid && isDatabaseNameValid && isValidAuth;
		}
	}
}
