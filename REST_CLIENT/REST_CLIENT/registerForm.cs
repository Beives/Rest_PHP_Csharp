using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using REST_CLIENT.Classes;

namespace REST_CLIENT
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            passwordTxtBox.PasswordChar = '*';
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost/Rest/REST_SERVER/");
                var request = new RestRequest("register.php", Method.POST);

                request.RequestFormat = DataFormat.Json;

                string userName = usernameTxtBox.Text;
                string password = passwordTxtBox.Text;

                if (userName == "" || password == "")
                    MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    request.AddBody(new User
                    {
                        UserName = userName,
                        Password = password
                    });
                    

                    IRestResponse<List<string>> restResponse = client.Execute<List<string>>(request);

                    foreach (string status in restResponse.Data)
                    {
                        MessageBox.Show(status);
                    }

                    /*
                     IRestResponse response = client.Execute(request);

                    string[] code = response.Content.Split(',')[0].Split(':');
                    string[] message = response.Content.Split(',')[1].Split(':');

                    switch (code[1])
                    {
                        case "1":
                            MessageBox.Show(message[1],"Siker", MessageBoxButtons.OK);
                            break;
                        case "0":
                            MessageBox.Show(message[1], "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
                    */

                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void megsemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
