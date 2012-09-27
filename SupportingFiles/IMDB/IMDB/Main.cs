using System.Collections.Generic;

namespace IMDB
{
    class main
    {
        static void Main(string[] args)
        {
            
            if (args.Length != 0)
            {
                string filename = System.IO.Path.GetFullPath(args[0]);
                
                do{
                filename = filename.Substring(filename.IndexOf("\\") +1);
                } while (filename.IndexOf("\\") > 0);

                for (int i = filename.Length-1; i >= 0; i--)
                {
                    if (filename[i] == '.')
                    {
                        filename = filename.Remove(filename.Length - (filename.Length-i));
                        break;
                    }
                }


                List<string> names = new List<string>();
                string temp = "";
                for (int i = 0; i < filename.Length; i++)
                {
                    if (filename[i] == ' ')
                    {
                        names.Add(temp);
                        temp = "";
                        continue;
                    }
                    temp += filename[i];
                    
                }
                names.Add(temp);

                string URL = "http://www.imdb.com/find?q=";
                string URLEnd = "&s=all";

                for (int i = 0; i < names.Count; i++)
                {
                    URL += names[i];
                    if (i != names.Count-1)
                        URL += "+";
                }

                URL += URLEnd;

                //http://www.imdb.com/find?q=Happy+Endings&s=all

                System.Diagnostics.Process.Start(URL);
            }
            else
            {
                //System.Console.WriteLine("Empty string");
                //System.Console.ReadLine();
            }

        }
    }
}
