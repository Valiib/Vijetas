using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace VijetasNews.Functions
{
    class PersonalHTTPs {
        public  string ResponseFromRequest(string json, string Where)
        {
            try {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Where);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return streamReader.ReadToEnd();
                }

            }
            catch(Exception a )
            {
                string msg = a.Message;  
            }

            return null;

        }
    } 
}
