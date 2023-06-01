using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Messaging;
using Newtonsoft.Json;

namespace AvukatMuvekkil
{
    public partial class MesajlasmaSayfasi : Form
    {
        public string senderkey;
        public string receiverkey;
        public string senderName;
        public MesajlasmaSayfasi()
        {
            InitializeComponent();
        }
        public class Messages
        {
            public string senderKey { get; set; }
            public string receiverKey { get; set; }
            public string message { get; set; }
        }

        public class ApiResponse
        {
            public List<Messages> Messages { get; set; }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            senderkey = "";
            receiverkey = "";
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            await MakePostRequest(senderkey, receiverkey, txtMessage.Text);
            txtMessage.Text = "";
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void MesajlasmaSayfasi_Load(object sender, EventArgs e)
        {
            await MakeGetRequest(senderkey, receiverkey);
        }
        private async Task MakeGetRequest(string senderKey, string receiverKey)
        {
            string url = $"http://localhost:1337/messages?senderKey={senderKey}&receiverKey={receiverKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                        if (apiResponse != null && apiResponse.Messages != null)
                        {
                            List<Messages> messages = apiResponse.Messages;
                            listMessage.Items.Clear();

                            foreach (Messages message in messages)
                            {
                                string item = $"{message.senderKey}: {message.message}";
                                listMessage.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No messages found.");
                        }

                        // Handle the response as per your application's requirements
                        // For example, update UI controls with the response data
                    }
                    else
                    {
                        MessageBox.Show($"Request failed with status code {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private async Task MakePostRequest(string senderKey, string receiverKey, string message)
        {
            string url = "http://localhost:1337/messages";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Messages newMessage = new Messages
                    {
                        senderKey = senderKey,
                        receiverKey = receiverKey,
                        message = message
                    };

                    string json = JsonConvert.SerializeObject(newMessage);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        await MakeGetRequest(senderKey, receiverKey);
                    }
                    else
                    {
                        MessageBox.Show($"Request failed with status code {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
