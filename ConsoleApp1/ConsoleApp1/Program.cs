using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*URL do site*/
            var url = "http://10.0.0.13:8020/api/todo";

            /*Cliente sincrono que vai consumir a aplicação*/
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);


            /*Criaçao do parser do json*/

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ObjectPackage));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var obj = (ObjectPackage)serializer.ReadObject(ms);
            }
           
            
            /// <sumary>
            /// pega os dados de uma app json
            /// </sumary>
            /// <param name="id"

        }
    }
}
