using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;

namespace WPF_ModernChart_Client.HelperClasses
{
    /// <summary>
    /// The class used to store the Chart Name and its number
    /// from the xml file. 
    /// </summary>
    public class ChartNameStore
    {
        public int Number { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// The class used to load Chart types form the XML file.
    /// </summary>
    public class ChartTypeHelper
    {
        ObservableCollection<ChartNameStore> chartsNames;

        /// <summary>
        /// The Method Load the Xml file and return chart names.
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<ChartNameStore> GetChartNames()
        {
            chartsNames = new ObservableCollection<ChartNameStore>(); 

            var xDoc = XDocument.Load("ChartNames.xml");

            var charts = from c in xDoc.Descendants("ChartTypes").Elements("Chart")
                         select c;

            var child = xDoc.Descendants("ChartTypes").Elements("Chart").Elements();
            var child_ = xDoc.Descendants("ChartTypes").Elements("Chart");

            //foreach (var child in xDoc.Descendants("ChartTypes").Elements("Chart").Elements())
            //    Console.WriteLine($"{child.Name} : {child.Value}");




            foreach (var item in charts)
            {
                Console.WriteLine(item.Value);


                chartsNames.Add(new ChartNameStore()
                { 
                 Name = item.Attribute("Name")?.Value,
                 Number =Convert.ToInt32(item.Attribute("Number")?.Value)
                });
            }

            return chartsNames;

        }
    }
}
