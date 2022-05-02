using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormController.UI.Controllers;

public class Base
{
    public HttpClient httpClient;
    public string Url = @"https://127.0.0.1:7032/";

    public Base()
    {
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(Url);
    }
}
