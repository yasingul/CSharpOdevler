using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        //Abstract'lar class yapısına sahiptir. Referans tiptir. İçerisinde hem tamamlanmış hemde tamamlanmamış yapılar barındıran bir yapıdır.
        //hem ortak, hemde ortak olmaya operasyonları barındırır. Ortak operasyonları tamamlanmış operasyyon olarak yazıyorken, ortak olmayan operasyonları imza şeklinde yazarız.
        //Class; içerisinde birbiriyle ilgili operasyonları, property ve field gibi alanları tutan yapıdır.
        //Abstract Class ile Class arasında ki tek fark, Abstract  Sınıflar new'lenemez. İçerisinde tamamlanmamış operasyon olduğu için new'lenemez.
        //Bir Class sadece bir tane Abstract Sınıfı inherit edebilir. Başka bir class'ı inherit edemez.
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Değerlendir();
            aMevzuat.Kaydet();
            Console.ReadLine();
        }
    }
    abstract class MevzuatBase
    {
        protected MevzuatBase()
        {
            //Abstract Class'lar constructor yapısı içerir ve BestPractice olarak public ile değil protected ile yazılmalıdır.
            //Sadece İnherit edildiği yerde çalıştırılabildiği için protected ile yazılması daha doğrudur.
        }
        public abstract void Değerlendir(); //Yarım operasyonlarda ki olay herkes kendine göre o operasyonu implemente edebiliyor.
        public void Kaydet()    //Bu hem A mevzuatında hem B mevzuatında geçerlidir.
        {
            Console.WriteLine("Kaydedildi.");
        }
    }
    class AMevzuat : MevzuatBase    //Inheritance
    {
        public override void Değerlendir()
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi.");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Değerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi.");
        }
    }
}
