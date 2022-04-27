using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner
{
    public class Program : MissionPlanner.Plugin.Plugin
    {

        public override string Name
        {
            get { return "GraphiquePlugin"; }
        }


        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Ali Hassoun"; }
        }

        public override bool Init()
        {
            this.testloop();
            return true;
        }

        public override bool Loaded()
        {
            Form1 plug = new Form1();
            plug.Activate();
            plug.Show();
            return true;
        }

        public override bool Loop()
        {
            //Console.WriteLine("Test : GraphiquePlugin Loop()");


            //MainV2.comPort.MAV.cs.sideslip = 9;

            // CurrentState.sideslip;
            float val = (float)CurrentState._sideslip;
            Console.WriteLine("TEST valeur sideslip  val = : " +  val.ToString());

            float val1 = (float)CurrentState._capteurcharge; 
            Console.WriteLine("TEST valeur capteur de charge  : " + val.ToString());

            float val2 = (float)CurrentState._capteurrpm1; 
            Console.WriteLine("TEST valeur capteur rpm  1 : " + val.ToString());
            float val3 = (float)CurrentState._capteurrpm2; 
            Console.WriteLine("TEST valeur capteur rpm  2 : " + val.ToString());
            float val4 = (float)CurrentState._capteurrpm3; 
            Console.WriteLine("TEST valeur capteur rpm  3 : " + val.ToString());
            float val5 = (float)CurrentState._capteurrpm4; 
            Console.WriteLine("TEST valeur capteur rpm  4 : " + val.ToString());
            //Console.WriteLine(MainV2.comPort.MAV.cs.sideslip);

            return true;
        }


        public bool testloop()
        {
            
            return true;
        }

        public override bool Exit()
        {
            return true;
        }


    }
}
