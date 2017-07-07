using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FlowersLanguage
{
    class Data
    {
        public static Dictionary<string,string> Read(){
            Dictionary<string, string> Databace = new Dictionary<string, string> { };

            if(File.Exists(@"Data\Data.csv") == false) { return Databace; }
            else
            {
                try {
                    using(StreamReader reader = new StreamReader
                        (@"Data\Data.csv", Encoding.Default))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null){
                            string[] ward = line.Split(',');
                            Databace.Add(ward[0],ward[1]);
                        }
                    }
                }
                catch(Exception e) {
                    MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Databace;
                }
            }
            return Databace;
        }


        public static void Write(List<string> list){
            if(Directory.Exists("Data") == false) { Directory.CreateDirectory("Data"); }


            try {
                using (StreamWriter writer = new StreamWriter
                    (@"Data\Data.csv", false, Encoding.Default)) {
                    
                    foreach (string s in list){
                        writer.Write(s);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }







    }
}
