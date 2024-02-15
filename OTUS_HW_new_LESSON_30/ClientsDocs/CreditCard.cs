using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_new_LESSON_30.ClientsDocs
{
    /// <summary>
    /// Класс, представляющий кредитную карту.
    /// </summary>
    public class CreditCard: ICloneable
    {
        /// <summary>
        /// Id карты внутри системы.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Владелец карты указанный на карте.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Номер счета.
        /// </summary>
        public string CardNumber { get; set; }

        public CreditCard(int id, string owner, string cardNumber )
        {
            Id = id; 
            Owner = owner; 
            CardNumber = cardNumber;
        }
        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
