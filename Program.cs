namespace proje1_telefon_rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = true;

            while (power)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Uygulamadan Çıkmak");

                int choice;
                while (!Int32.TryParse(Console.ReadLine(), out choice)){}

                switch (choice)
                {
                    default:{
                        Console.Clear();
                        Console.WriteLine("Olan seçeneklerin dışında bir veri giridniz. \n");
                        break;
                    }
                }
            }
        }
    }
}


