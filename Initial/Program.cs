using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Initial
{
    public interface IMineSample
    {
        string StubUser(string a);
    }
    public class Mine : IMineSample
    {
        string name { get; set; }
        public List<int> ShaftIncomes;
        public Mine()
        {
            ShaftIncomes = new List<int>();
        }
        public Mine(string name)
        {
            this.name = name;
        }

        public double DoubleShaftIncome(Shaft shaft)
        {
            return shaft.income * 2;
        }
        public void ListShaftIncomes(Shaft shaftName)
        {
            ShaftIncomes.Add(shaftName.income);
        }
        public string JoinNames(Shaft shaft)
        {
            return name + " & " + shaft.name;
        }
        public string StubUser(string a)
        {
            //in DEVELOPMENT.
            return "false";
        }    
    }
    public class StubMine : IMineSample
    {
        public string StubUser(string a)
        {
            return a;
        }
    }
    public class StUserChecker
    {
        IMineSample objmanager = null;
        public StUserChecker()
        {
            objmanager = new Mine();
        }
        public StUserChecker(IMineSample tmpManager)
        {
            objmanager = tmpManager;
        }

        public string CheckSMeth(string a)
        {
            return objmanager.StubUser(a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
