using OTUS_HW_new_LESSON_30.ClientsDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_new_LESSON_30.Persons
{
    /// <summary>
    /// Класс, для создания любой персоны. Является основой для всех классов связанных с человеком.
    /// </summary>
    public class Person : IMyCloneable<Person>, ICloneable
    {
        /// <summary>
        /// Id человека внутри системы.
        /// </summary>
        public int Id { get; set; }

        public Passport Passport { get; set; }


        public Person(Passport passport, int id) 
        { 
            this.Passport = passport;
            this.Id = id;
        }
        /// <summary>
        /// Метод создающий глубокую копию обьекта.
        /// </summary>
        public virtual Person MyClone()
        {       
            return new Person((Passport)Passport.Clone(), Id);
        }

        /// <summary>
        /// Метод создающий копию обьекта. Универсален для всех потомков.
        /// </summary>
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
