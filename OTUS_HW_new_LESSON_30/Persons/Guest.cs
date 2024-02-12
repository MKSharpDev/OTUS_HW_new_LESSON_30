using OTUS_HW_new_LESSON_30.ClientsDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_new_LESSON_30.Persons
{
    /// <summary>
    /// Класс, для создания персоны которая заселяется в отель.
    /// </summary>
    public class Guest : Person
    {

        public int BookingId { get; set; }

        public Guest(Passport passport, int id, int bookingId) : base(passport, id)
        {
            BookingId = bookingId;
        }
        /// <summary>
        /// Метод создающий глубокую копию обьекта.
        /// </summary>
        public override Guest MyClone()
        {
            return new Guest((Passport)Passport.Clone(), Id, BookingId);
        }
    }
}
