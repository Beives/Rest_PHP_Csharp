using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using REST_CLIENT.Classes;
using RestSharp.Serialization.Json;


namespace REST_CLIENT
{
    public partial class registerForm : Form
    {
        JsonDeserializer deserializer = new JsonDeserializer();

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

                    IRestResponse response = client.Execute(request);
                    Classes.ResponseStatus resp = deserializer.Deserialize<Classes.ResponseStatus>(response);
                    switch (resp.status)
                    {
                        case "1":
                            MessageBox.Show(resp.status_message,"Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            break;
                        case "0":
                            MessageBox.Show(resp.status_message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        default:
                            break;
                    }
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
