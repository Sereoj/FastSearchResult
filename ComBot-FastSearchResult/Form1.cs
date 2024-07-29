using Newtonsoft.Json;
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

namespace ComBot_FastSearchResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected string getHostApiBuilder(string query, string lang = "all", int limit = 26, int offset = 0)
        {

            return $"https://combot.org/api/chart/"+ lang + "?limit="+ limit + "&offset="+ offset + "&q=" + query;
        }
        private async void button_search_Click(object sender, EventArgs e)
        {
            var query = textBox_search.Text;
            var lang = textBox_region.Text;
            var limit = int.Parse(textBox_limit.Text);
            var offset = int.Parse(textBox_offset.Text);

            HttpClient client = new HttpClient();
            var result = await client.GetAsync(getHostApiBuilder(query, lang, limit, offset));

            if (result.IsSuccessStatusCode)
            {
                string responseBody = await result.Content.ReadAsStringAsync();
                List<ResultModel> results = JsonConvert.DeserializeObject<List<ResultModel>>(responseBody);
                textBox_result.Text = "Название: \t Ссылка: \t Количество:" + Environment.NewLine;
                foreach (var item in results)
                {
                    textBox_result.Text += $"{item.t} \t t.me/{item.u} \t {item.s}" + Environment.NewLine;
                }
            }
            else
            {
                Console.WriteLine($"Error: {result.StatusCode}");
            }
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            textBox_result.Text = null;
        }
    }
}
