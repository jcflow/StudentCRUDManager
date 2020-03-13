using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace StudentManageCRUD
{
    public class LoginWindowController
    {
        public LoginCommand LoginCommand { get; set; }
        public LoginWindow Window { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int SelectedResourceIndex { get; set; }

        public LoginWindowController(LoginWindow window)
        {
            this.Window = window;
            this.LoginCommand = new LoginCommand(this);
        }

        public void Login()
        {
            if (Validate())
            {
                MainWindow mainWindow = new MainWindow(this.SelectedResourceIndex);
                mainWindow.Show();
                this.Window.Close();
            }
            else
            {
                MessageBox.Show("The credentials do not exists.", "Login", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        public bool Validate()
        {
            var xmlDocument = XDocument.Load("Data/users.xml");
            var items = from s in xmlDocument.Element("users")
                        .Descendants("user")
                        select new
                        {
                            Username = (string)s.Element("name"),
                            Password = (string)s.Element("password")
                        };
            return items.ToList().FindIndex(user => user.Username == Username && user.Password == Password) > -1;
        }
    }
}
