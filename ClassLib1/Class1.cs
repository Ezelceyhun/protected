namespace ClassLib1
{
    public class Class1
    {
        //protected kendi class'ın içindeyse doğrudan erişilebiliyor.
        public int Property { get; set; }
        public int b;
        protected int sayi = 0;
        protected internal int a = 5;
        protected string islem()
        {
            a++;
            return sayi.ToString();            
        }

       public void Deneme()
        {
            islem();
            b = a;
        }

        class Class2: Class1
        {
            void Deneme()
            {
                islem();
                sayi = 0;
                a = 2;
            }
        }
        class Class3:Class2
        {           
            void yap()
            {
                islem();
                sayi = 0;
                a = 1;
            }
        }
    }
}

