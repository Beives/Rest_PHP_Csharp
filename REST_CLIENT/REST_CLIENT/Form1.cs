﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Serialization.Json;
using REST_CLIENT.Classes;

namespace REST_CLIENT
{
    public partial class Form1 : Form
    {
        String URL = "http://localhost/Rest/REST_SERVER/";
        String ROUTE = "index.php";
        JsonDeserializer deserializer = new JsonDeserializer();

        public Form1()
        {
            InitializeComponent();

            passwordTxtBox.PasswordChar = '*';

            listView.View = View.Details;
            listView.Columns.Add("ID");
            listView.Columns.Add("Márka");
            listView.Columns.Add("Tipus");
            listView.Columns.Add("Húrok");
            listView.Columns.Add("Bundok");
            listView.Columns.Add("Hangszedő");
            listView.Columns.Add("Forma");
        }

        private void listaBtn_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            try
            {
                var client = new RestClient(URL);
                var request = new RestRequest(ROUTE, Method.GET);

                

                IRestResponse<List<Guitar>> response = client.Execute<List<Guitar>>(request);
                foreach (Guitar gt in response.Data)
                {
                    addListItem(gt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void idListaBtn_Click(object sender, EventArgs e)
        {
            string id = IdNumeric.Value.ToString();
            if (id == "" || id == "0")
                MessageBox.Show("Hiba: Nullánál nagyobb id-t kell megadni", "Figyelem!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                listView.Items.Clear();
                try
                {
                    var client = new RestClient(URL);
                    var request = new RestRequest(ROUTE + "?id=" + id, Method.GET);

                    IRestResponse<List<Guitar>> response = client.Execute<List<Guitar>>(request);
                        
                    foreach (Guitar gt in response.Data)
                    {
                        if (gt == null)
                        {
                            MessageBox.Show("Nincs ilyen id", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        addListItem(gt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void addListItem(Guitar gt)
        {
            ListViewItem item = new ListViewItem(gt.Id);
            item.SubItems.Add(gt.Marka);
            item.SubItems.Add(gt.Tipus);
            item.SubItems.Add(gt.Hurok.ToString());
            item.SubItems.Add(gt.Bundok.ToString());
            item.SubItems.Add(gt.Hangszedo);
            item.SubItems.Add(gt.Forma);
            listView.Items.Add(item);
            for (int i = 0; i < 6; i++)
            {
                if (i == 3 || i == 4)
                    continue;
                listView.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registerForm form = new registerForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest("/login.php", Method.POST);

            string userName = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            request.RequestFormat = DataFormat.Json;

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
                    Form2 form = new Form2();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                    break;
                case "0":
                    MessageBox.Show(resp.status_message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
