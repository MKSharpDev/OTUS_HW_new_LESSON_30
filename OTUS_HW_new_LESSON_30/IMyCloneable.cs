using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_new_LESSON_30
{
    public interface IMyCloneable<T>
    {
        public T MyClone();  
    }
}
