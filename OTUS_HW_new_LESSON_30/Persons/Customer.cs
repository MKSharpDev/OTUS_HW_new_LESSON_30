using OTUS_HW_new_LESSON_30.ClientsDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_new_LESSON_30.Persons
{
    /// <summary>
    /// Класс, для создания персоны которая заказывает услугу и оплачивает счета.
    /// </summary>
    public class Customer : Guest
    {
        public CreditCard CreditCard { get; set; }
        public Customer(Passport passport, int id, int bookingId, CreditCard creditCard) : base(passport, id, bookingId)
        {
            CreditCard = creditCard;
        }
        /// <summary>
        /// Метод создающий глубокую копию обьекта.
        /// </summary>

        public override Customer MyClone()
        {
            return new Customer((Passport)Passport.Clone(), Id, BookingId, CreditCard);
        }
    }
}
