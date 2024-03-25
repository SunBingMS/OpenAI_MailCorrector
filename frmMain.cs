using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace EmailCorrector
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBaseUrl.Text == "" || txtApiKey.Text == "" || txtBefore.Text == "")
                {
                    MessageBox.Show("BaseUrl、ApiKeyと訂正前のメール本文を入力してください。",
                                "未入力",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return;
                }

                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtApiKey.Text.Trim());

                string strBefore = "以下のメール内容を訂正してください。\r\n" + txtBefore.Text.Trim();

                JObject data = new JObject(
                    //new JProperty("model", "gpt-3.5-turbo"),
                    new JProperty("model", "gpt-3.5-turbo"),
                    new JProperty("messages", new JArray(
                        new JObject(
                            new JProperty("role", "user"),
                            new JProperty("content", strBefore)
                        )
                    ))
                );

                var content = new StringContent(data.ToString(), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(txtBaseUrl.Text.Trim(), content);

                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic jsonObject = JsonConvert.DeserializeObject(responseBody);

                if (jsonObject.error != null)
                {
                    txtAfter.Text = jsonObject.error.message;
                }
                else
                {
                    txtAfter.Text = jsonObject.choices[0].message.content;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        //private void txtBefore_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && !e.Shift && !e.Alt && e.KeyCode == Keys.V)
        //    {
        //        txtBefore.Paste(System.Windows.Forms.DataFormats.GetFormat(System.Windows.Forms.DataFormats.Text));
        //        e.Handled = true;
        //    }
        //}

    }
}
