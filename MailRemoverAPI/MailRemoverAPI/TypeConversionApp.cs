using System;

namespace TypeConversionApp{
    public class Base{
        public int email = 50;
        public virtual void Basic(){
            Console.WriteLine("email50");
        }
    }

    //derived class, widening
    class Extended1 : Base{
        public override void Basic(){
            Base email1 = new Base();
            short email = (short)email1.email;
            Console.WriteLine("int -> short");
        }

    }

    //derived class, narrowing
    class Extended2 : Base{
        public override void Basic(){
            Base email2 = new Base();
            byte email = (byte)email2.email;
            Console.WriteLine("int -> byte");
        }
    }

    class WideningAndNarrowing{
        static void Main(string[] args){
            
            Base Base1 = new Base();
            Base Extended111 = new Extended1();
            Base Extended222 = new Extended2();

            Base1.Basic();
            Extended111.Basic();
            Extended222.Basic();

        }
    }
}