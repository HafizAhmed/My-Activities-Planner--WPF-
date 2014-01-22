using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace MyActivitiesPlannerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

        private void SubmitButton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=NEXIUS-01806;Initial Catalog=ActivitiesDB;Integrated Security=True";
                SqlConnection sqlCon = new SqlConnection(connectionString);
                string commandString = "INSERT INTO [ActivitiesDB].[dbo].[Activities] (Date,StartTime,EndTime,Activity) VALUES ( @Date,@STime, @ETime, @Activity)";
                SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                sqlCmd.Parameters.AddWithValue("@STime", StartTimeTB.Text);
                sqlCmd.Parameters.AddWithValue("@ETime", EndTimeTB.Text);
                sqlCmd.Parameters.AddWithValue("@Activity", ActivityTB.Text);
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Activity has been added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ActivitiesDBDataSet dt = new ActivitiesDBDataSet();
            try
            {
                string connectionString = @"Data Source=NEXIUS-01806;Initial Catalog=ActivitiesDB;Integrated Security=True";
                SqlConnection sqlCon = new SqlConnection(connectionString);
                string commandString = "SELECT ActID 'ID', Date, StartTime 'Start Time', EndTime 'End Time', Activity, CompletionRate 'Completion Rate (%)', Completed 'Is Completed' FROM [ActivitiesDB].[dbo].[Activities] WHERE (Date >= @dateTimePicker2 AND date <= @dateTimePicker3)";
                SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                sqlCmd.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Text);
                sqlCmd.Parameters.AddWithValue("@dateTimePicker3", dateTimePicker3.Text);

                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt.Activities);
                DataGrid.DataContext = dt.Activities.DefaultView;
                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SubmitChangesButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{

            //    string connectionString = @"Data Source=NEXIUS-01806;Initial Catalog=ActivitiesDB;Integrated Security=True";
            //    SqlConnection sqlCon = new SqlConnection(connectionString);
            //    string commandString = "UPDATE [ActivitiesDB].[dbo].[Activities] SET CompletionRate= @compRate, Completed=@completed WHERE ActID= @id";
            //    SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            //    SqlParameter compRate = new SqlParameter("@compRate", SqlDbType.Float);
            //    SqlParameter completed = new SqlParameter("@completed", SqlDbType.Bit);
            //    SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
            //    sqlCmd.Parameters.Add(compRate);
            //    sqlCmd.Parameters.Add(completed);
            //    sqlCmd.Parameters.Add(id);
            //    foreach (DataGridViewRow row in DataGrid.Rows)
            //    {
            //        if (!row.IsNewRow)
            //        {
            //            //sqlCmd.Parameters.AddWithValue("@compRate", dataGridView1.CurrentRow.Cells["CompletionRate"].Value);
            //            //sqlCmd.Parameters.AddWithValue("@completed", dataGridView1.CurrentRow.Cells["Completed"].Value);
            //            //sqlCmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["ActID"].Value);
            //            compRate.Value = row.Cells["Completion Rate (%)"].Value;
            //            completed.Value = row.Cells["Is Completed"].Value;
            //            id.Value = row.Cells["ID"].Value;

            //            sqlCon.Open();
            //            sqlCmd.ExecuteNonQuery();
            //            sqlCon.Close();
            //        }
            //    }

            //    MessageBox.Show("Activities has been updated successfully");
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
