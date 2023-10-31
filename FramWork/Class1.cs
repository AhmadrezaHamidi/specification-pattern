using FramWork.Entity;
using FramWork.Specificastion;
using System;
using System.ComponentModel.DataAnnotations;

namespace FramWork
{
    
    public interface ISpecification<T>
    {
        bool IsStatisFieldBy(T value);
    }


    /*
    public class PositiveNumberSpecification : ISpecification<int>
    {
        public bool IsStatisFieldBy(int value)
        {
            return value > 0;
        }
    }
    //Re-Use      ---> Validation and Selection 
    */

    public class SatrtProgram
    {
        public void Set(int x , int y) {


        }
    }



    public abstract class CompositeSpection<T> : ISpecification<T>
    {

        public ISpecification<T> _left { get; private set; }
        public ISpecification<T> _right { get;private  set; }

        //public readonly ISpecification<T> _left;
        //public readonly ISpecification<T> _right;

        protected CompositeSpection(ISpecification<T> left, ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }

        public abstract bool IsStatisFieldBy(T value);
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
}


