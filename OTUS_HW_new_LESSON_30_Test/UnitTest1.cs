using OTUS_HW_new_LESSON_30.ClientsDocs;
using OTUS_HW_new_LESSON_30.Persons;

namespace OTUS_HW_new_LESSON_30_Test
{
    public class UnitTest1
    {
        [Fact]
        public void PassportPersonTest()
        {

            //Arrange

            Passport passportPerson = new Passport("Илья", "Семенович", "Потапов", "AF20153");
            Person firstPerson = new Person(passportPerson, 1);


            //Act
            Person secondPerson = firstPerson.MyClone();
            Person thirdPerson = (Person)firstPerson.Clone();
            passportPerson.FirstName = "Семен";


            //Assert
            Assert.Equal("Семен", firstPerson.Passport.FirstName);
            Assert.Equal("Илья", secondPerson.Passport.FirstName);
            Assert.Equal("Семен", thirdPerson.Passport.FirstName);

        }

        [Fact]
        public void PassportGuestTest()
        {

            //Arrange

            Passport passportGuest = new Passport("Илья", "Семенович", "Потапов", "AF20153");
            Guest firstGuest = new Guest(passportGuest, 1, 1);


            //Act
            Guest secondGuest = firstGuest.MyClone();
            Guest thirdGuest = (Guest)firstGuest.Clone();
            passportGuest.FirstName = "Семен";


            //Assert
            Assert.Equal("Семен", firstGuest.Passport.FirstName);
            Assert.Equal("Илья", secondGuest.Passport.FirstName);
            Assert.Equal("Семен", thirdGuest.Passport.FirstName);

        }

        [Fact]
        public void PassportCustomerTest()
        {

            //Arrange
            Passport passportCustomer = new Passport("Илья", "Семенович", "Потапов", "AF20153");
            CreditCard creditCard = new CreditCard(1, "Ilya Potapov", "1111-2222-3333-4444");
            Customer firstCustomer = new Customer(passportCustomer, 1, 1, creditCard);


            //Act
            Customer secondCustomer = firstCustomer.MyClone();
            Customer thirdCustomer = (Customer)firstCustomer.Clone();
            creditCard.Owner = "Semen Potapov";
            passportCustomer.FirstName = "Семен";


            //Assert
            Assert.Equal("Семен", firstCustomer.Passport.FirstName);
            Assert.Equal("Илья", secondCustomer.Passport.FirstName);
            Assert.Equal("Семен", thirdCustomer.Passport.FirstName);

            Assert.Equal("Semen Potapov", firstCustomer.CreditCard.Owner);
            Assert.Equal("Ilya Potapov", secondCustomer.CreditCard.Owner);
            Assert.Equal("Semen Potapov", thirdCustomer.CreditCard.Owner);

        }
    }
}