using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormController.UI.Services
{
    public class ImageService
    {
        private ClientHttp.ClientHttp _client;

        public ImageService()
        {
            _client = new ClientHttp.ClientHttp();
        }

        public ImageService(ClientHttp.ClientHttp client)
        {
            _client = client;
        }

        public void SendImage(string url, string img)
        {
            _client.Post<string>(url, img);
        }
    }
}
