using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersLanguage
{
    static class Language
    {
        

        public static string Get(string flower,string color)
        {

            Dictionary<string, string> language = Data.Read();
            string check = flower;
            if(color != "") { check += "(" + color + ")"; }


            if (language.ContainsKey(check)){

                return check + "の花言葉は" + language[check] + "です。";

            }else { return check + "はデータベースに存在しません。"; }



        }

    }
}
