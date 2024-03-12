using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib1
{
    public class Class6
    {
        //Override Örneği
        public string Model{  get; set; }
        public string CPU {  get; set; }
        public string Ram { get; set; }
        public string Info {  get; set; }
        public virtual void ozellik()
        {
            Info = "Markası: " + Model+ "\nCPU: " + CPU+ "\nRAM: " + Ram;
            return;
        }
    }
    public class notebook : Class6
    {
        public string Bluetooth;
        public override void ozellik()
        {
            Info = "Markası: " + Model + "\nCPU: " + CPU + "\nRAM: " + Ram+ "\nBLUETOOH: " + Bluetooth;
            return;
        }
    }
}
