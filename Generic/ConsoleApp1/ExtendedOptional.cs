using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExtendedOptional<T> : Optional<T> where T : struct
    {
        public Action<T> OnOptionalFilled;
        public Action OnOptionalEmptied;

        public ExtendedOptional()
        {
        }

        public ExtendedOptional(T value) : base(value)
        {
            
        }

        public override void SetValue(T? value)
        {
            base.SetValue(value);
            if (value.HasValue)
                OnOptionalFilled?.Invoke(value.Value);
            else
                OnOptionalEmptied?.Invoke();
        }
    }
}
