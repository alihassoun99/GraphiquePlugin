using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using LiveCharts.Wpf;
using LiveCharts;

namespace MissionPlanner
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer incomingDataTimer;
        private SeriesCollection series;
        private LineSeries lSeries;
        private LineSeries lSeries2;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Form1 init");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            //DataGraphique.DataSource ;
            var ressources = new List<data>();
            ressources.Add(new data() { hauteur = 2, name = "Ali" });
            ressources.Add(new data() { hauteur = 3, name = "test" });

            DataGraphique.DataSource = ressources;

           

            incomingDataTimer = new System.Timers.Timer();
            series = new SeriesCollection();
            lSeries = new LineSeries();
            lSeries2 = new LineSeries();

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "temps",
                LabelFormatter = value => value.ToString("0")
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Valuers",
                LabelFormatter = value => value.ToString("0.00")
            });

            lSeries.Values = new ChartValues<float>();
            lSeries2.Values = new ChartValues<float>();
            series.Add(lSeries);
            series.Add(lSeries2);
            cartesianChart1.Series = series;

            
            //Console.WriteLine("TEST valeur sideslip  : " + val.ToString());

            incomingDataTimer.Elapsed += new ElapsedEventHandler(AddRandomItemToChart);
            incomingDataTimer.Interval = 100; // 1000 ms is one second
            incomingDataTimer.Start();
        }

        public void AddRandomItemToChart(object source, ElapsedEventArgs e)
        {
            // code here will run every second
            float val = (float)CurrentState._sideslip;
            //lSeries.Values.Add((float)(random.NextDouble() * 20.0));
            lSeries.Values.Add(val);

            float val1 = (float)CurrentState._capteurcharge;
            lSeries2.Values.Add(val1);

            if (lSeries.Values.Count >= 200)
            {
                //  incomingDataTimer.Stop();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pnlNavigation_CloseClick(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }



    public class data
    {
        public int hauteur { get; set; }
        public string name { get; set; }
    }    
}
