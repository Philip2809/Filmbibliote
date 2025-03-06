using System.ComponentModel.DataAnnotations;

namespace Filmbibliote.Modeller
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Titel { get; set; }
        public string Genre { get; set; }
        public int År { get; set; }
        public double Betyg { get; set; }


        public string UserID { get; set; }
        public User User { get; set; }

    }
}

