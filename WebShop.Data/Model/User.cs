namespace WebShop.Model
{
    enum Tip { Administrator, Prodavac, Kupac }
    public class User
    {
        public int KorisnickoIme { get; set; }
        public int Email { get; set; }
        public int Lozinka { get; set; }
        public int ImeIPrezime { get; set; }
        DateTime DatumRodjenja { get; set; }
        public int Adresa { get; set; }
        Tip TipKorisnika { get; set; }

    }
}
