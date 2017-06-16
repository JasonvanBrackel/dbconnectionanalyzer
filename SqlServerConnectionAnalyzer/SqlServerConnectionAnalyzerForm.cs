using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Apprenda.ClientServices.SqlServerConnectionAnalyzer
{
    public partial class SqlServerConnectionAnalyzerForm : Form
    {
        private readonly StringBuilder _logbuilder = new StringBuilder();

        public SqlServerConnectionAnalyzerForm()
        {
            InitializeComponent();
        }

        private void SqlServerConnectionAnalyzerForm_Load(object sender, EventArgs e)
        {
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            ResultsTextBox.Text = "Running Test.  Screen may freeze while the connection is tested.  Please wait...";
            _logbuilder.Clear();
            var userName = UsernameTextBox.Text;
            var password = PasswordMaskedTextBox.Text;
            var server = ServerTextBox.Text;
            var database = DatabaseTextBox.Text;
            var connectionString = ConnectionStringTextBox.Text;

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                LogActivity($"Testing with connection string.");
                LogActivity(connectionString);
            }
            else
            {
                LogActivity($"Building Connection String Username: {userName} Password: {password} Server: {server} Database: {database}");
                connectionString = BuildConnectionString(userName, password, server, database);
            }


            

            LogActivity("Creating connection object.");
            using (var conn = new SqlConnection(connectionString))
            {
                try
                {
                    LogActivity("Opening connection object");
                    conn.Open();

                    LogActivity("Creating SQL Command \"select 1\"");
                    var command = new SqlCommand("select 1", conn);

                    LogActivity("Executing Command");
                    var n = (int) command.ExecuteScalar();

                    LogActivity("Checking result");
                    if (n == 1)
                        LogActivity("Success.");
                    else
                        LogActivity($"ERROR: Unexpected value {n}");
                }
                catch (Exception ex)
                {
                    LogActivity("Exception occurred.");
                    LogActivity(ex.Message);
                    LogActivity(ex.StackTrace);
                }
            }
            ResultsTextBox.Text = _logbuilder.ToString();
        }

        private void LogActivity(string log)
        {
            _logbuilder.AppendLine($"[{Environment.MachineName}]: {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {log}");
        }

        private string BuildConnectionString(string username, string password, string server, string database)
        {
            LogActivity("Building connection string.");
            var builderInitial = new SqlConnectionStringBuilder();
            builderInitial.UserID = username;
            builderInitial.DataSource = server;
            builderInitial.InitialCatalog = database;
            builderInitial.Password = password;
            LogActivity("Built initial connection string");
            var connectionString = builderInitial.ConnectionString;
            LogActivity(connectionString);
            var builderNoCatalog = new SqlConnectionStringBuilder(connectionString) {InitialCatalog = string.Empty};
            LogActivity("Building connection string, no initial catalog.");
            connectionString = builderNoCatalog.ConnectionString;
            LogActivity($"Connection String: {connectionString}");
            return connectionString;

        }

        private void ConnectionStringTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}