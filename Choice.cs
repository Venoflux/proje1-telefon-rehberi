namespace proje1_telefon_rehberi
{
    public static class Choice
    {
        static List<Person> personList = new List<Person>(){
            new Person("Ali", "Bozkurt", "5327514141"),

        };

        /// Working for now however better methods needed to receive prefered inputs
        public static void NumaraEkle()
        {
            Console.WriteLine("Lütfen isim giriniz             : ");
            string ad = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz          : ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            string numara = Console.ReadLine();


            Person yenikullanıcı = new Person(ad, soyisim, numara);
            personList.Add(yenikullanıcı);

            Console.WriteLine("Yeni kullanıcı başarıyla eklendi. ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}