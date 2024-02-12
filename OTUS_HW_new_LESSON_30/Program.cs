
using OTUS_HW_new_LESSON_30.ClientsDocs;
using OTUS_HW_new_LESSON_30.Persons;

Passport passportPerson = new Passport("Илья", "Семенович", "Потапов", "AF20153");
Person firstPerson = new Person(passportPerson, 1) ;
Person secondPerson = firstPerson.MyClone() ;
Person thirdPerson = (Person)firstPerson.Clone() ;

passportPerson.FirstName = "Семен";

//Выводим различие созданых копий при изменении passportPerson
Console.WriteLine($" Person original - {firstPerson.Passport.FirstName} \r\n" +
    $" Person MyClone - {secondPerson.Passport.FirstName} \r\n Person Clone(MemberwiseClone) - {thirdPerson.Passport.FirstName}");

Console.WriteLine();


Passport passportGuest = new Passport("Илья", "Семенович", "Потапов", "AF20153");
Guest firstGuest = new Guest(passportGuest, 1, 1);
Guest secondGuest = firstGuest.MyClone();
Guest thirdGuest = (Guest)firstGuest.Clone();

passportGuest.FirstName = "Семен";

//Выводим различие созданых копий при изменении passportGuest

Console.WriteLine($" Guest original - {firstGuest.Passport.FirstName} \r\n" +
    $" Guest MyClone - {secondGuest.Passport.FirstName} \r\n Guest Clone(MemberwiseClone) - {thirdGuest.Passport.FirstName}");

Console.WriteLine();


Passport passportCustomer = new Passport("Илья", "Семенович", "Потапов", "AF20153");
CreditCard creditCard = new CreditCard(1, "Ilya Potapov", "1111-2222-3333-4444");
Customer firstCustomer = new Customer(passportCustomer, 1, 1, creditCard);
Customer secondCustomer = firstCustomer.MyClone();
Customer thirdCustomer = (Customer)firstCustomer.Clone();

creditCard.Owner = "Semen Potapov";
passportCustomer.FirstName = "Семен";

//Выводим различие созданых копий при изменении passportCustomer и creditCard

Console.WriteLine($" Customer original - {firstCustomer.Passport.FirstName} {firstCustomer.CreditCard.Owner} \r\n" +
    $" Customer MyClone - {secondCustomer.Passport.FirstName} {secondCustomer.CreditCard.Owner}\r\n" +
    $" Customer Clone(MemberwiseClone) - {thirdCustomer.Passport.FirstName} {thirdCustomer.CreditCard.Owner}");

Console.ReadLine();