using FramWorkV2.Domain;
using System;

namespace FramWorkV2
{
    public interface ISpecification<T>
    {
        bool IsStatisFieldBy(T value);
    }



    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract bool IsStatisFieldBy(T value);
        public Specification<T> And(ISpecification<T> left)
        {
            return new AndSpection<T>(this, _left);
        }
    }


    public abstract class CompositeSpection<T> : Specification<T>
    {

        public ISpecification<T> _left { get; private set; }
        public ISpecification<T> _right { get; private set; }

        //public readonly ISpecification<T> _left;
        //public readonly ISpecification<T> _right;

        protected CompositeSpection(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }


        

    }

    public class AndSpection<T> : CompositeSpection<T>
    {
        public AndSpection(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsStatisFieldBy(T value)
        {
            return _right.IsStatisFieldBy(value) && _left.IsStatisFieldBy(value);
        }
    }


    public class OrSpection<T> : CompositeSpection<T>
    {
        public OrSpection(ISpecification<T> left, ISpecification<T> right) : base(left, right)
        {
        }

        public override bool IsStatisFieldBy(T value)
        {
            return _right.IsStatisFieldBy(value) || _left.IsStatisFieldBy(value);
        }
    }



    public class kidsAppropriateMovie : Specification<MovieDoamin>
    {

        public override bool IsStatisFieldBy(MovieDoamin value)
        {
            return value.Rate == Rating.E;

        }
    }


    public class ComediMovie : Specification<MovieDoamin>
    {
        public override bool IsStatisFieldBy(MovieDoamin value)
        {
            return value.Genre == GenreEnum.Comedy;
        }
    }

}
