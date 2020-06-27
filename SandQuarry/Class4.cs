using System;
using System.Collections.Generic;
using System.Text;

namespace SandQuarry
{
    public class Conveyor : Engine
        {
            private string _result;
            public Conveyor(int N, int t, string res) : base(N,t)
            {
                int Res = N * t;
                res = Convert.ToString(Res);
                Result = res;
            }
            public string Result
            {
                get { return _result; }
                set { _result = value; }
            }
            public void Display(int t)
            {
                Console.WriteLine(_result + " ton of sand was transported by a Conveyor in " + t + " hours.");
            }
        }
}
