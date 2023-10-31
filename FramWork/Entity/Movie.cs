using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramWork.Entity
{
    public class Movie 
    {
        public DateTime PublishYear { get; set; }
        public Rating Rate { get; set; }
        public GenreEnum Genre { get; set; }

    }

    public enum GenreEnum
    {
        Comedy , 
        Derama, 
        Documentory
    }


    public enum Rating
    {
        E,
        R,
        C
    }

}
