using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        List<Distance> distanceList = new List<Distance>();
        public Form1()
        {
            InitializeComponent();

            Distance meters = new Distance("Meters", 1);
            distanceList.Add(meters);
            Distance centimeters = new Distance("Centimeters", 0.01);
            distanceList.Add(centimeters);
            Distance kilometers = new Distance("Kilometers", 1000);
            distanceList.Add(kilometers);

            Distance miles = new Distance("Miles", 1609.344);
            distanceList.Add(miles);

            Unit liters = new Unit();


            comboBox1.DataSource = distanceList.Select(x => x.name).ToList();
            comboBox2.DataSource = distanceList.Select(x => x.name).ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Distance startingUnit = null, endingUnit = null;
            double input = (double)numInput.Value;

            foreach(Distance obj in distanceList)
            {
                if(comboBox1.Text == obj.name)
                {
                    startingUnit = obj;
                }
                if (comboBox2.Text == obj.name)
                {
                    endingUnit = obj;
                }
            }

            lblAnswer.Text = (startingUnit.ConvertToMeters(input) /
                endingUnit.ConvertToMeters(1)).ToString();
        }
    }
}
