using System;
using System.Collections.Generic;

namespace Generics
{
    //Generic yapılarda hangi tipi verirsek içinde ki operasyonlar -Add gibi- parametre olarak o tiple çalışmaktadırlar.
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();    //sistemde olan List
            sehirler1.Add("Antalya");
            sehirler1.Add("Ankara");
            sehirler1.Add("Ardahan");
            sehirler1.Add("İzmit");
            sehirler1.Add("Kastamonu");
            sehirler1.Add("Antakya");
            Console.WriteLine(sehirler1.Count);      //Count bir property ve sadece get kullanıyor. Sadece Read only çalışır.
            
            
            MyList<string> sehirler2 = new MyList<string>();    //Kendi oluştuduğumuz liste class'ı
            sehirler2.Add("Antalya");
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count); 
            

            MyList<int> plakalar1 = new MyList<int>();
            plakalar1.Add(07);
        }
    }

    class MyList<T> //<T> ile generic class haline getirdik class'ı.
    {
        T[] _array;
        T[] _tempArray;  //Geçici olarak oluşturulan arrayler için kullandığımız kalıp. Temporary'den gelir.
        public MyList()
        {
            _array = new T[0];  //sıfır elemanlı bir array yapmış olduk. MyList'i new'lediğimiz anda çalışır.
        }
        public void Add(T item) //Burada ki mantık ise class'ı örneklerken verdiğimiz tipte sorunsuz şekilde çalışmasını sağlar. DRY ve temiz kod prensiblerine uymamıza olanak verir.
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
            //Burada ki işlem ile artık class'ımıza yaptığımız eklemeleri görebileceğiz.
        }

        public int Count
        {
            get { return _array.Length; }   //MyList'in Count'unu çaağırırsak _array'in eleman sayısını bize verir.
            //set { _count = value; } sadece get çalışsın istediğimiz için bu kısmı sileriz.
        }

    }
}
