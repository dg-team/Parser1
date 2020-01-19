using System.IO;
using System.Net;
using System.Text;
using HtmlAgilityPack;
using Parser1.Entities;

namespace Parser1.Helpers
{
    public static class ParsingHelper
    {
        public static HtmlDocument LoadPage(string url)
        {
            var result = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var receiveStream = response.GetResponseStream();
                if (receiveStream != null)
                {
                    StreamReader readStream;
                    if (response.CharacterSet == null)
                        readStream = new StreamReader(receiveStream);
                    else
                        readStream = new StreamReader(receiveStream, Encoding.UTF8);//.GetEncoding(response.CharacterSet));
                    result = readStream.ReadToEnd();
                    readStream.Close();
                }
                response.Close();
            }

            var document = new HtmlDocument();
            document.LoadHtml(result);
            return document;
        }

        public static GameBet GetBet(string url="https://1xstavka.ru/line/Football/127733-Spain-La-Liga/65549697-Real-Madrid-Sevilla/")
        {

            double team_1 = 0.0;
            double team_2 = 0.0;
            double draw = 0.0;

            return new GameBet(team_1, team_2, draw);
        }
    }
}
