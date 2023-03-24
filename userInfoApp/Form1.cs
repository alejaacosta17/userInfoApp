using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInfoApp
{
    public partial class OutPutListBox : Form
    {
        //declare a list of users inside form1 - form data - for data member
        List<UserInfo> Users = new List<UserInfo>();
        public OutPutListBox()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            //method to add user via button called when that buttton is clicked
            if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("User Name cannot be blank");
            }
            else if (UserIdTextBox.Text == "")
            {
                MessageBox.Show("User Id cannot be blank");
            }
            else if (UserAgeTextBox.Text == "")
            {
                MessageBox.Show("User Age cannot be blank");
            }
            else if (!int.TryParse(UserIdTextBox.Text, out int userId) || userId <= 0)
            {
                MessageBox.Show("User Id must be a valid integer > 0");
            }
            else if (!double.TryParse(UserAgeTextBox.Text, out double userAge) || userAge <= 0)
            {
                MessageBox.Show("User Age must be a valid double > 0");
            }
            else 
            {
                //process only if there is valid data
                UserInfo eachUser = new UserInfo(UserNameTextBox.Text, userId, userAge);
                //MessageBox.Show(eachUser.ToString());
                Users.Add(eachUser);
                MessageBox.Show(Users.Count + " Users in the list");
                StatusLabel.Text = "Added User: " + eachUser.ToString();
                StatusLabel.Text += "\nTotal Users: " + Users.Count;

                OutputList.Items.Clear();
                OutputList.Items.Add("User Name: " + eachUser.UserName);
                OutputList.Items.Add("User ID: " + eachUser.UserId);
                OutputList.Items.Add("User Age: " + eachUser.UserAge.ToString("F1"));

                OutputList.Items.Add("User Category: " + eachUser.UserCategory);
                LoadAllUsersToListBox();
                ClearTextFields();
            }
        }

        private void LoadAllUsersToListBox()
        {
            OutputList.Items.Clear();
            OutputList.Items.Add("UserName\tUserId\tUserAge\tUserCategory");
            foreach (UserInfo eachUser in Users)
            {
                OutputList.Items.Add(eachUser); //automatically ToString is called
            }
        }

        private void ClearTextFields()
        {
            UserNameTextBox.Text = "";
            UserIdTextBox.Text = "";
            UserAgeTextBox.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
