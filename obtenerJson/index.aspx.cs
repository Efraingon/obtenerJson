using System;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using System.Reflection;
namespace obtenerJson
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Obtener_Click(object sender, EventArgs e)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

            var JSONPath = Path.Combine(outPutDirectory, "Data\\data.json");
            string JSON_path = new Uri(JSONPath).LocalPath;
            string fileJSON = File.ReadAllText(JSON_path);
            DataTable dt =(DataTable)JsonConvert.DeserializeObject(fileJSON,typeof(DataTable));
            TablaJson.DataSource = dt;
            TablaJson.DataBind();

        }

        protected void ObtenerWeb_Click(object sender, EventArgs e)
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://www.test.readychatai.com/data");
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(json, typeof(DataTable));
                TablaJsonWeb.DataSource = dt;
                TablaJsonWeb.DataBind();


            }
        }

       

    }
}