using System;
using System.Collections.Generic;
using System.Text;

namespace SandQuarry
{
    public class Truck : Engine
        {
            private string _result;
            public Truck(int N, int t, string res) : base(N,t )
            {
                double accuracy = 1E-14;
                int rablichism = 2;
                int p = t % 2;
                t = t - p;
                if (t > rablichism + accuracy)
                {
                    int Res;
                    int quantity = t / rablichism;
                    Res = quantity * N;
                    res = Convert.ToString(Res);
                    //Console.WriteLine("Грузовая машина транспортировала {0} тонн песка за {1} захода.\n", Res, quantity);
                    Result = res;
                }
                else
                {
                    res = "0";
                    Result = res;
                }
            }
            public string Result
            {
                get { return _result; }
                set { _result = value; }
            }
            public void Display(int t)
            {
                Console.WriteLine(_result + " ton of sand was transported by a Truck in " + t + " hours.");
            }
        }
}
