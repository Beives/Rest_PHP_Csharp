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
    public partial class Form2 : Form
    {
        string URL = "http://localhost/Rest/REST_SERVER/";
        string ROUTE = "index.php";
        public Form2()
        {
            InitializeComponent();
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
            fillListView();
        }
        private void idListaBtn_Click(object sender, EventArgs e)
        {
            string id = idNumeric.Value.ToString();
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
                            fillListView();
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
        private void torlesBtn_Click(object sender, EventArgs e)
        {
            string id = deleteIdNumeric.Value.ToString();

            if (id == "" || id == "0")
                MessageBox.Show("Hiba: Nullánál nagyobb id-t kell megadni", "Figyelem!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    var client = new RestClient(URL);
                    var request = new RestRequest(ROUTE + "/{id}", Method.DELETE);
                    request.AddParameter("id", id);
                    IRestResponse response = client.Execute(request);
                    fillListView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void hozzaadBtn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);

            request.RequestFormat = DataFormat.Json;

            request.AddBody(new Guitar
            {
                Marka = markaTxtBox.Text,
                Bundok = (int)bundokNumeric.Value,
                Forma = formaTxtBox.Text,
                Hangszedo = hangszedoTxtBox.Text,
                Hurok = (int)hurokNumeric.Value,
                Tipus = tipusTxtBox.Text
            });

            IRestResponse<List<string>> restResponse = client.Execute<List<string>>(request);
            fillListView();
        }
        private void fillListView()
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

        private void modositasBtn_Click(object sender, EventArgs e)
        {
            int id = (int)modositasNumeric.Value;
            if (id == 0)
                MessageBox.Show("Hiba: Nullánál nagyobb id-t kell megadni", "Figyelem!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    var client = new RestClient(URL);
                    var request = new RestRequest(ROUTE + "?id=" + id, Method.GET);

                    IRestResponse<List<Guitar>> response = client.Execute<List<Guitar>>(request);
                    foreach (Guitar gt in response.Data)
                    {
                        if (gt == null)
                        {
                            MessageBox.Show("Nincs ilyen id", "Figyelem!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                        else
                        {
                            Módosítás form = new Módosítás(id,gt.Marka, gt.Forma, gt.Bundok, gt.Hurok, gt.Tipus, gt.Hangszedo);
                            form.ShowDialog();
                            this.Show();
                            fillListView();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba: " + ex, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
