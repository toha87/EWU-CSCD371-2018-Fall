<<<<<<< HEAD
﻿namespace Assignment7UnitTest
{
    //Caveats
    //As long as I understood this assignment, I picked generic of reference type 
    //I was able to make non nulleble generic type but it doesn't work if you pass in value type

    public class NonNullable<T>
        where T: new()
    {
        private T _value;
        public T Value
        {
            get
            {
                if (_value == null)
                {
                    _value = new T();
                }
                return _value;
            }
            set
            {
                if (value == null)
                {
                    new T();
                }
                else
                    _value = value;
            }

=======
﻿using System;

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
>>>>>>> assignment7
        }

    }
}