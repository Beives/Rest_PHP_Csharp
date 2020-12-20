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
    public partial class Módosítás : Form
    {
        string URL = "http://localhost/Rest/REST_SERVER/";
        string ROUTE = "index.php";
        private int id;
        public Módosítás(int id, string marka, string forma, int bundok, int hurok, string tipus, string hangszedo)
        {
            InitializeComponent();
            bundokNumeric.Value = bundok;
            hurokNumeric.Value = hurok;
            markaTxtBox.Text = marka;
            formaTxtBox.Text = forma;
            tipusTxtBox.Text = tipus;
            hangszedoTxtBox.Text = hangszedo;
            this.id = id;
        }

        private void megsemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modositBtn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.PUT);

            request.RequestFormat = DataFormat.Json;

            request.AddBody(new Guitar
            {
                Id = id.ToString(),
                Marka = markaTxtBox.Text,
                Bundok = (int)bundokNumeric.Value,
                Forma = formaTxtBox.Text,
                Hangszedo = hangszedoTxtBox.Text,
                Hurok = (int)hurokNumeric.Value,
                Tipus = tipusTxtBox.Text
            });

            IRestResponse response = client.Execute(request);
            this.Close();
        }
    }
}
