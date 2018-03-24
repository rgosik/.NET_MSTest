using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    public interface IMineSample
    {
        double quadraticEquation(int a, int b, int c);
    }
    public class Mine
    {
        int x { get; set; }
        string you;
        private IMineSample mineSample; //

        public Mine(){}
        public Mine(IMineSample sample) //
        {
            mineSample = sample;
        }

        public int daj(int y)
        {
            x = y +5;
            return x;
        }
        public string poloncz(string dwa)
        {
            you = "tak";
            return you + dwa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
