using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Harrison_SWE_Intern_Problem
{
    public partial class Form1 : Form
    {
        const int daysToHours = 24;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorLabel.Parent = panel1;
            errorLabel.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Change text of the button to Searching, and triggers it to do this event before other events. 
            searchButton.Text = "Searching...";
            Application.DoEvents();

            //Take data from user and put it into string variables
            string stationID = txtBoxID.Text;
            string date = datePicker.Value.ToString("yyyyMMdd");
            string range = null;

            try {
                range = ((Convert.ToInt32(txtBoxRange.Text)) * daysToHours).ToString();      //user puts in a string, converts it to an int, converts that to hours, which is needed for our API. 
            }
            catch(FormatException err)
            {
                Console.WriteLine("Can't convert to Int");
                Console.ReadLine();
            }

            //new class that requests and retrieves data from XML on NOAA. 
            TideRequest request = new TideRequest(stationID, date, range);
            
            
            if (request.DataRetrieval())
            {

                //add min and max data
                lblMax.Text = "Max Tide Height: " + request.tideData.Values.Max().ToString() + " ft";
                lblMin.Text = "Min Tide Height: " + request.tideData.Values.Min().ToString() + " ft";

                //set up chart
                tideChart.Titles["tideTitle"].Text = request.stationName;
                tideChart.Series["TideSeries"].Points.Clear();

                //Add data to chart
                foreach (var data in request.tideData)
                {
                    tideChart.Series["TideSeries"].Points.AddXY(data.Key, data.Value);
                }
            }
            //reset button back to search and print the errorlabel message (if there is one).
            searchButton.Text = "Search";
            errorLabel.Text = request.errorMessage;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
