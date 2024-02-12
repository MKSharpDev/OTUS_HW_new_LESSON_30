using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_new_LESSON_30.ClientsDocs
{
    /// <summary>
    /// Класс, предоставляющий паспотрные данные.
    /// </summary>
    public class Passport : ICloneable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SeriesAndNumber { get; set; }
        
        public Passport() { }
        public Passport(string firstName, string middleName, string lastName, string seriesAndNumber)
        { 
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            SeriesAndNumber = seriesAndNumber;
        }
        /// <summary>
        /// Метод создающий копию обьекта.
        /// </summary>
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
