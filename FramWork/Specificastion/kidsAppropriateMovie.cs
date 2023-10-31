using FramWork.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramWork.Specificastion
{

    //فیلم مناسب کئدک 
    public class kidsAppropriateMovie : ISpecification<Movie>
    {
        public bool IsStatisFieldBy(Movie value)
        {
            return value.Rate == Rating.E;
        }
    }


    public class ComediMovie : ISpecification<Movie>
    {
        public bool IsStatisFieldBy(Movie value)
        {
            return value.Genre == GenreEnum.Comedy;
        }
    }



    


}
