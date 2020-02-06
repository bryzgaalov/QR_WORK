using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

namespace QR_LIBRARY
{
    public class QR
    {
         public static  void genQR(string text,int size)
        {
            string query = string.Format("code/?{0}&{1}&0", text, size);
            var client = new RestClient("http://qrcoder.ru");

            var request = new RestRequest(query);

            var response = client.Execute(request);

            var result = response.Content;
        }
    }
}
