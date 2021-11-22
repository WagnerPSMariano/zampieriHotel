using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginHotel
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var response =  await ServiceHelper.GetAll();
            txtResponse.Text = ServiceHelper.BeautiflyJson(response);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var response = await ServiceHelper.Post(txtName.Text, txtNumber.Text);
            txtResponse.Text = ServiceHelper.BeautiflyJson(response);
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var response = await ServiceHelper.Get(txtID.Text);
            txtResponse.Text = ServiceHelper.BeautiflyJson(response);
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            var response = await ServiceHelper.Put(txtID.Text, txtName.Text, txtNumber.Text);
            txtResponse.Text = ServiceHelper.BeautiflyJson(response);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var response = await Delete(txtID.Text);
            txtResponse.Text = response;
        }

        private async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://44.197.120.242:5000/rooms/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(((int)res.StatusCode).ToString() + "-" + res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}
