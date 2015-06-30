using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter time of day and list of dishes separate by comma:");
            try
            {
                string enter = Console.ReadLine();
                execute(enter);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();

            }

        }


        public static void execute(string enter)
        {

            try
            {
                string[] splitEnter = enter.Split(',');

                var listGroupInit = from x in splitEnter
                                    group x by x into g
                                    let count = g.Count()
                                    orderby count descending
                                    select new { Value = g.Key, Count = count };

                List<String> listString = new List<string>();
                List<String> listGroup = new List<string>();

                if (splitEnter.ToList().Count < 2)
                {
                    throw new Exception("Out of the input pattern!");
                }

                if (splitEnter[0].Equals("morning", StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (var x in listGroupInit.Where(a => a.Value.ToLower() != "morning"))
                    {
                        string enumConvert = Tools.stringValueOf(((Morning.EnumMornig)(Convert.ToInt32(x.Value))));

                        if (x.Count > 1)
                        {
                            listGroup.Add(enumConvert + "(x" + x.Count.ToString() + ")");
                        }
                        else
                        {
                            listGroup.Add(enumConvert);
                        }
                    }
                }
                else if (splitEnter[0].Equals("night", StringComparison.CurrentCultureIgnoreCase))
                {
                    foreach (var x in listGroupInit.Where(a => a.Value.ToLower() != "night"))
                    {
                        string enumConvert = Tools.stringValueOf(((Night.EnumNight)(Convert.ToInt32(x.Value))));

                        if (x.Count > 1)
                        {
                            listGroup.Add(enumConvert + "(x" + x.Count.ToString() + ")");
                        }
                        else
                        {
                            listGroup.Add(enumConvert);
                        }
                    }
                }
                else
                {
                    throw new Exception("Out of the input pattern!");
                }

                StringBuilder sb = new StringBuilder();

                foreach (var itemResult in listGroup)
                {
                    if (!string.IsNullOrEmpty(sb.ToString()))
                        sb.Append(",");
                    sb.Append(itemResult);
                }


                Console.WriteLine(sb.ToString());
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




        }



    }
}
