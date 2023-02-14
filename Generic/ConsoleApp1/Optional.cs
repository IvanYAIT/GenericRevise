using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Optional<T> : IOptional<T> where T : struct
    {
        private T _value; 
        public virtual T Value
        {
            get
            {
                if (Empty)
                    throw new IncorrectOptionalAccessException();
                else
                    return _value;
            }
            private set => _value = value;
        }

        public bool Empty { get; private set; }

        public Optional()
        {
            Empty = true;
        }

        public Optional(T value)
        {
            Value = value;
            Empty = false;
        }

        public T GetValueOrDefault()
        {
            if (!Empty)
                return Value;
            else
                return default;
        }

        public virtual void SetValue(T? value)
        {
            if (value == null)
                Empty = true;
            else
                 Value = value.Value;
        }

        public override string ToString()
        {
            if (Empty)
                return "empty";
            else
                return $"{Value}";
        }
    }
}
