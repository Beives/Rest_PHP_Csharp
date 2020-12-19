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
        }
    }
}
