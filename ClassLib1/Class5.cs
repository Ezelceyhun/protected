using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib1
{
    //Soyut Sınıflar Abstract
    public abstract class Class5
    {
        public int num1 {  get; set; }
        public int num2 { get; set; }
        public int num3 {  get; set; }
        public abstract int fuel();
        //doğrudan erişilemez ve içerisinde işlem yapılamaz.
        //miras aldığı class ile override edilerek kullanılabilir.
    }
    public class Car : Class5
    {
        public override int fuel()
        {
            num3 = num2 + num1;
            return num3;
            //geriye değer döndürmeli
        }
    }
    public class Bus : Class5
    {
        public override int fuel()
        {
            num3 = num2 + num1;
            return num3;
        }
    }
}
