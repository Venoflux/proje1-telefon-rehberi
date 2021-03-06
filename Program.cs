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
                    case 0:{
                        power = false;
                        break;
                    }
                    case 1:{
                        Console.Clear();
                        Choice.NumaraEkle();
                        break;
                    }
                    case 2:{
                        Console.Clear();
                        Choice.NumaraKaldir();
                        break;
                    }
                    case 3:{
                        Console.Clear();
                        Choice.NumaraDegistir();
                        break;
                    }
                    case 4:{
                        Console.Clear();
                        Choice.NumaraListele();
                        break;
                    }
                    case 5:{
                        Console.Clear();
                        Choice.NumaraArama();
                        break;
                    }
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


