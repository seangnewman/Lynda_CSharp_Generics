using System;
using System.Collections;


namespace Waste
{
    
    public class Program
    {
        private static MultiSlot _dumpster;

        public static void Main(string[] args)
        {
            _dumpster = new MultiSlot();
            _dumpster.Bottles.Add(new Bottle());
            _dumpster.Bottles.Add(new Bottle());
            _dumpster.Bottles.Add(new Bottle());
            _dumpster.Foods.Add(new Food());
            _dumpster.Foods.Add(new Food());
            _dumpster.Foods.Add(new Food());
            _dumpster.Bottles.Add(new Bottle());
            _dumpster.Bottles.Add(new Bottle());
            // _dumpster.Dispose(new Bottle(), new Bottle(), new Food(), new Trash());
            _dumpster.processAll();
        }

       
    }
}
