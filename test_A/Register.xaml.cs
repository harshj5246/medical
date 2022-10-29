﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using test_A.DAL;
using test_A.Model;

namespace test_A
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public void Clear()
        {
            txt_email.Clear();
            txt_fullname.Clear();
            txt_phonenumber.Clear();
            txt_username.Clear();
            p_password.Clear();
            p_confirmpassword.Clear();
        }
        public Register()
        {
            InitializeComponent();
            Dp_Dob.DisplayDateEnd = DateTime.Now;
        }

        string gender = "";

        string conString = ConnectionString.conString;



        private void lb_register_Click(object sender, RoutedEventArgs e)
        {

            if (txt_username.Text == String.Empty)
            {
                txt_username.Focus();
                MessageBox.Show("fill the username  fields");
                return;
            }
            else if (string.IsNullOrEmpty(txt_fullname.Text.Trim()))

            {

                MessageBox.Show("fill the full name  fields");

                txt_fullname.Text = String.Empty;

                return;

            }

            else if (txt_fullname.Text.StartsWith("."))

            {

                MessageBox.Show("Value can not start with .");

                txt_fullname.Text = String.Empty;

                return;

            }

            else if (txt_fullname.Text.StartsWith(" "))

            {

                MessageBox.Show(" Value can not start with blank space");

                txt_fullname.Text = String.Empty;

                return;

            }


            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_fullname.Text, "[^a-z A-z]"))
            {
                txt_fullname.Focus();
                MessageBox.Show("fill the names only in fullname fields");
                return;
            }
            else if (txt_email.Text.StartsWith(" "))

            {

                MessageBox.Show(" Value can not start with blank space");

                txt_fullname.Text = String.Empty;

                return;

            }
            else if (txt_email.Text == String.Empty)
            {
                txt_email.Focus();
                MessageBox.Show("fill the email  fields");
                return;
            }
            else if (!(txt_email.Text.Contains("@")))
            {
                txt_email.Focus();
                MessageBox.Show("you entered incorrect email format in  the email  fields");
                return;
            }
            else if (!(txt_email.Text.EndsWith(".com")))
            {
                txt_email.Focus();
                MessageBox.Show("you entered incorrect email format in  the email  fields");
                return;
            }

            else if (txt_phonenumber.Text == String.Empty)
            {
                txt_phonenumber.Focus();
                MessageBox.Show("fill the phonenumber fields");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txt_phonenumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers in phonenumber fields.");
                txt_phonenumber.Text = String.Empty;

                txt_phonenumber.Focus();
                return;
            }
            else if (txt_phonenumber.Text.Length != 10)
            {
                txt_phonenumber.Focus();
                MessageBox.Show("phonenumber must be 10 digits");
                return;
            }
            else if ((rdo_female.IsChecked == false) && (rdo_male.IsChecked == false) && (rdo_prefernotosay.IsChecked == false))
            {
                rdo_female.Focus();
                MessageBox.Show("select the gender  fields");
                return;


            }
            var input = p_password.Password;
            string ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one lower case letter.";
                MessageBox.Show(ErrorMessage);
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one upper case letter.";
                MessageBox.Show(ErrorMessage);
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be lesser than 8 or greater than 15 characters.";
                MessageBox.Show(ErrorMessage);
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one numeric value.";
                MessageBox.Show(ErrorMessage);

            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain at least one special case character.";
                MessageBox.Show(ErrorMessage);
               
            }

            else if (p_password.Password.Length < 8)
            {
                p_password.Focus();
                ErrorMessage = " password must be more than 8 letters";
                MessageBox.Show(ErrorMessage);

               

            }
      


            else if (p_confirmpassword.Password.ToString() == String.Empty)
            {
                p_confirmpassword.Focus();
                MessageBox.Show("fill the confirm passwrod  fields");
               
            }

            else if (p_confirmpassword.Password != p_password.Password)
            {
                p_confirmpassword.Focus();
                MessageBox.Show("confirm passwrod is not matched with password fields");
                

            }
            else
            {
                UsersModel model = new UsersModel();
                model.UserName = txt_username.Text;
                model.FullName = txt_fullname.Text;
                model.EmailId = txt_email.Text;

                model.PhoneNo = long.Parse(txt_phonenumber.Text);

                model.Gender = gender;
                model.Password = p_password.Password;
                model.ConfirmPassword = p_confirmpassword.Password;
                model.DOB = Dp_Dob.Text;
                bool res = UsersDAL.Create(model);
                if (!res)
                {
                    MessageBox.Show("User is not register");
                    return;
                }
                MessageBox.Show("User register succesfully");


                Clear();



            }

           

            
        }

        private void rdo_male_Checked(object sender, RoutedEventArgs e)
        {
            gender = "MALE";
        }

        private void rdo_prefernotosay_Checked(object sender, RoutedEventArgs e)
        {
            gender = "PREFER NOT TO SAY";

        }

        private void rdo_female_Checked(object sender, RoutedEventArgs e)
        {
            gender = "FEMALE";

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

            Login login = new Login();
            this.Visibility = Visibility.Collapsed;
            login.Show();

        }
    }
}
