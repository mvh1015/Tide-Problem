using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Harrison_SWE_Intern_Problem
{
    class TideRequest
    {
        //Strings used for API link
        string stationID;
        string startDate;
        string range;
        string product = "water_level";
        string datum = "mllw";
        string units = "english";
        string timezone = "lst";
        string application = "FarSounder";
        string format = "xml";
        string sourcePrefix = "https://tidesandcurrents.noaa.gov/api/datagetter?";
        string source;

        //public variables called for when button is pressed
        public Dictionary<DateTime, float> tideData = new Dictionary<DateTime, float>();
        public string stationName;
        public string errorMessage;


        public TideRequest(string inStationID, string inStartDate, string inRange)
        {
            stationID = inStationID;
            startDate = inStartDate;
            range = inRange;
            
            //uses paramaters to create the link to the XML file
            source = sourcePrefix +
                        "begin_date=" + startDate +
                        "&range=" + inRange +
                        "&station=" + stationID +
                        "&product=" + product +
                        "&datum=" + datum +
                        "&units=" + units +
                        "&time_zone=" + timezone +
                        "&application=" + application +
                        "&format=" + format;
        }
       

        public bool DataRetrieval()
        {
            //open up xml file and reader it
            XmlTextReader reader = new XmlTextReader(source);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {


                    case XmlNodeType.Element: // Node is an element.
                        Console.Write("<" + reader.Name);

                        while (reader.MoveToNextAttribute())
                        {
                            //Checks the element to see if it is a time/Date element.
                            switch(reader.Name)
                            {
                                case "t":
                                    DateTime dateAndTime = (Convert.ToDateTime(reader.Value));

                                    //Moves to the next attribute(height attribute), adds both to a dictionary.
                                    //Only works if tide height is after date/time attribute. 
                                    reader.MoveToNextAttribute();
                                    tideData.Add(dateAndTime, float.Parse(reader.Value));
                                    break;
                                case "name":
                                    stationName = reader.Value;
                                    break;
                                default:
                                    break;

                            }

                            
                        }

                        if (reader.Name == "error") //if there is an error, set error message and leave function. 
                        {
                            reader.Read();
                            errorMessage = reader.Value;
                            return false;   
                        }

                        Console.Write(">");
                        Console.WriteLine(">");
                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        
                        Console.WriteLine(reader.Value);
                        break;

                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;

                }
            }
            Console.ReadLine();

            return true;
        }

    }
}
