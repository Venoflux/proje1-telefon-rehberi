namespace proje1_telefon_rehberi
{
    class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }

        public Person(string ad, string soyad, string numara)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Numara = numara;
        }

        
    }
}