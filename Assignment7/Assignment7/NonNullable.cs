using System;

namespace Assignment7UnitTest
{

    public interface IFactory<T>
    {
        T Create();
    }

    public class NonNullable<T>
        where T: struct, IComparable
    {
       
        public T Value
        {
            get => Value;
            set
            {
                if (value.Equals(null))
                    throw new ArgumentNullException("Value cannot be null");
                else
                    Value = value;
            }
        }

    }
}