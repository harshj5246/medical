using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace test_A
{
    /// <summary>
    /// Interaction logic for Detail.xaml
    /// </summary>
    public partial class Detail : Window
    {
        public Detail()
        {
            InitializeComponent();
           BtnLoad_Click(null, null);
        }
        string conString = ConnectionString.conString;

      
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string que = ("insert into Patient values ('" + TxtPatientName.Text + "','" +
                TxtPatientRegistration.Text + "' )");

            cmd.CommandText = que;
            cmd.Connection = con;

            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Data insert succesfully");
            }
           

            con.Close();
            cmd.Dispose();

        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string query = "SELECT Patient_id,Patient_name,date_of_registration FROM Patient";
            SqlCommand cmd = new SqlCommand(query, con);


            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dtg_Grddetail.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            string que = ("Update Patient set  Patient_name = '" + TxtPatientName.Text  + "', date_of_registration = '" + TxtPatientRegistration.Text + "' Where Patient_id =" + TxtPatientID.Text );


            cmd.CommandText = que;
            cmd.Connection = con;
            if (MessageBox.Show("Do you really want to update", "Confirmation", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
            {

                return;

            }
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Data Update Successfully");
            }
            BtnLoad_Click(null, null);
         
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            string que = ("delete from Patient where Patient_id = " + TxtPatientID.Text );
            SqlCommand cmd = new SqlCommand(que, con);

            if (MessageBox.Show("Do you really want to Delete", "Confirmation", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
            {

                return;
            }

            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Delete Successfully");

            con.Close();
            cmd.Dispose();
            BtnLoad_Click(null, null);

        }

       

        private void name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select * from Doctor", con);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            name.ItemsSource = dt.DefaultView;
            name.DisplayMemberPath = "doctor_name";
            name.SelectedValuePath = "doctor_id";
            cmd.Dispose();
            con.Close();
        }
    }
}
