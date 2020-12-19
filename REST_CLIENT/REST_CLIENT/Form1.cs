using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using REST_CLIENT.Classes;

namespace REST_CLIENT
{
    public partial class Form1 : Form
    {
        string URL = "http://localhost/Rest/REST_SERVER/";
        string ROUTE = "index.php";
        public Form1()
        {
            InitializeComponent();
        }

        private void listaBtn_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.GET);

        }
    }
}
