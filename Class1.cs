using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface IVehDetails
    {
        
  int NoOfDoors { get; set; }
 string Type { get; set; }

    }

    public abstract class Vehicle:IVehDetails
    {

        public abstract string Vehno { get; set; }
        //public double Average { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public abstract int NoOfDoors { get; set; }
        public string Type { get; set; }

        public double CalculateAverage(double distanceTravelled,double speed, int fuelConsumption)
        {
            double avg=0;
            avg=(distanceTravelled * speed) / fuelConsumption;

            return avg;
          //  Average = avg;
        }
        


    }

    public class Car : Vehicle
    {
        string _vehno;
        public override string Vehno
        {
            get {

                return _vehno;

            }
            set {
                _vehno = value;
                //Console.WriteLine("Enter State Name");
                string stname = _vehno;
                string s=stname.Substring(0, 2);
                Random r = new Random(9);
                string no=r.Next().ToString();
                    _vehno = s + no.Substring(0, 4);

            }
        }

        int _doors=4;
        public override int NoOfDoors
        {
            get { return _doors; }
            set { _doors = value; }
        }
    }

  public  class TwoWheeler : Vehicle
    {
        string _vehno;
        public override string Vehno
        {
            get {
                return _vehno;
            }
             set { _vehno = value;
                Car car = new Car();
                car.Vehno = _vehno;
                
                _vehno = car.Vehno + 1;
            }
        }
        public override int NoOfDoors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
