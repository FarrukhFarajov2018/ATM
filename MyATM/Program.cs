using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyATM
{
    class Card
    {
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public decimal Balance { get; set; }
        public DateTime Expiredate { get; set; }


        public Card(string pan, string pin, string cvc, decimal balance, DateTime expiredate)
        {
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            Balance = balance;
            Expiredate = expiredate;

        }
    }

    class User : Card
    {
        public string Name { get; set; }
        public string Surname { get; set; }


        public User(string name, string surname, string pan, string pin, string
            cvc, decimal balance, DateTime expiredate) : base(pan, pin, cvc, balance, expiredate)

        {
            Name = name;
            Surname = surname;

        }

    }

    class UArr
    {
        public List<User> localUsers = new List<User>();

        public void AddUser(string uname, string usurname, string upan, string upin,
                     string ucvc, decimal ubalance, DateTime uexpdate)
        {
            localUsers.Add(new User(uname, usurname, upan, upin, ucvc, ubalance, uexpdate));
        }
    }

    class Action
    {
        public void ActCard(List<User> localUsers)
        {
            int i = 0;
            int l = 0;

            bool fbool = true;
            int infoCount = 0;

            MyATM.UArr obj2 = new MyATM.UArr();
            List<decimal> currentMoneyOperation = new List<decimal>();
            List<DateTime> currentOperationDay = new List<DateTime>();

            while (true)
            {

                Console.WriteLine();
                Console.WriteLine("Dear Customer! Please enter your PIN");

                Console.WriteLine();
                Console.WriteLine("Just for Murad teacher correct PINs are 700-701-702");

                string cpin = Console.ReadLine();
                bool cpinbool = false;

                for (i = 0; i < localUsers.Count; i++)
                {
                    if (cpin == localUsers[i].Pin)
                    {
                        cpinbool = true;
                        break;
                    }
                }



                Console.WriteLine(i);

                if (cpinbool)
                {
                    infoCount++;

                    obj2.AddUser(localUsers[i].Name, localUsers[i].Surname,
                    localUsers[i].Pan, localUsers[i].Pin, localUsers[i].Cvc,
                    localUsers[i].Balance, localUsers[i].Expiredate);

                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"{localUsers[i].Name}  {localUsers[i].Surname} - Welcome");
                    Console.WriteLine("Please choose one of below options and Press 1  2  3 or 4 : ");
                    Console.WriteLine();
                    Console.WriteLine("1. Show Balance and Leave the system");
                    Console.WriteLine();
                    Console.WriteLine("2. Cash ");
                    Console.WriteLine();
                    Console.WriteLine("3. Print INFO ");
                    Console.WriteLine();
                    Console.WriteLine("4. Amount Transfer ");

                    int option = Int32.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine($"Your credit card balance is : {localUsers[i].Balance}");
                                Console.WriteLine();

                            }
                            goto Label;
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("1. 10 azn");
                                Console.WriteLine("2. 20 azn");
                                Console.WriteLine("3. 50 azn");
                                Console.WriteLine("4. 100 azn");
                                Console.WriteLine();
                                Console.WriteLine("Enter sum of money you want to get ");
                                Console.WriteLine();
                                Console.WriteLine("Enter 10-20-50-100 or another figure ");

                                decimal sumChoice = Decimal.Parse(Console.ReadLine());


                                if (sumChoice == 10)
                                {
                                    if (localUsers[i].Balance >= 10)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine("You're getting 10 AZN");
                                        localUsers[i].Balance -= 10;
                                        currentMoneyOperation.Add(10);
                                        currentOperationDay.Add(DateTime.Now);
                                        Console.WriteLine($"{localUsers[i].Balance} AZN remained in your balance");

                                    }
                                    else if (localUsers[i].Balance < 10)
                                    {
                                        Console.WriteLine("You have no enough money");
                                        currentMoneyOperation.Add(0);
                                        currentOperationDay.Add(DateTime.Now);
                                        break;
                                    }
                                }
                                else if (sumChoice == 20)
                                {
                                    if (localUsers[i].Balance >= 20)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine("You're getting 20 AZN");
                                        localUsers[i].Balance -= 20;
                                        currentMoneyOperation.Add(20);
                                        currentOperationDay.Add(DateTime.Now);
                                        Console.WriteLine($"{localUsers[i].Balance} AZN remained in your balance");

                                    }
                                    else if (localUsers[i].Balance < 20)
                                    {
                                        Console.WriteLine("You have no enough money");
                                        currentMoneyOperation.Add(0);
                                        currentOperationDay.Add(DateTime.Now);
                                        break;
                                    }

                                }


                                else if (sumChoice == 50)
                                {
                                    if (localUsers[i].Balance >= 50)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine("You're getting 50 AZN");
                                        localUsers[i].Balance -= 50;
                                        currentMoneyOperation.Add(50);
                                        currentOperationDay.Add(DateTime.Now);
                                        Console.WriteLine($"{localUsers[i].Balance} AZN remained in your balance");

                                    }
                                    else if (localUsers[i].Balance < 50)
                                    {
                                        Console.WriteLine("You have no enough money");
                                        currentMoneyOperation.Add(0);
                                        currentOperationDay.Add(DateTime.Now);
                                        break;
                                    }

                                }

                                else if (sumChoice == 100)
                                {
                                    if (localUsers[i].Balance >= 100)
                                    {
                                        Console.Clear();
                                        Console.WriteLine();
                                        Console.WriteLine("You're getting 100 AZN");
                                        localUsers[i].Balance -= 100;
                                        currentMoneyOperation.Add(100);
                                        currentOperationDay.Add(DateTime.Now);
                                        Console.WriteLine($"{localUsers[i].Balance} AZN remained in your balance");

                                    }
                                    else if (localUsers[i].Balance < 100)
                                    {
                                        Console.WriteLine("You have no enough money");
                                        currentMoneyOperation.Add(0);
                                        currentOperationDay.Add(DateTime.Now);
                                        break;
                                    }

                                }

                                else if (sumChoice >= 0.0m)
                                {
                                    if (localUsers[i].Balance >= sumChoice)
                                    {
                                        Console.WriteLine($"You're getting {sumChoice} AZN");
                                        localUsers[i].Balance -= sumChoice;
                                        currentMoneyOperation.Add(sumChoice);
                                        currentOperationDay.Add(DateTime.Now);
                                        Console.WriteLine($"({localUsers[i].Balance}) AZN remained in your balance");
                                    }
                                    if (localUsers[i].Balance < sumChoice)
                                    {
                                        Console.WriteLine("You have no enough money");
                                        currentMoneyOperation.Add(0);
                                        currentOperationDay.Add(DateTime.Now);
                                        continue;
                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Your choice is False");

                                    break;
                                }

                            }
                            break;

                        case 3:
                            {
                                currentMoneyOperation.Add(0);
                                currentOperationDay.Add(DateTime.Now);
                                Console.Clear();
                                Console.WriteLine();

                                for (int j = 0; j < infoCount; j++)
                                {
                                    Console.Write($"{obj2.localUsers[j].Name} , {obj2.localUsers[j].Surname} , {obj2.localUsers[j].Pan} , {obj2.localUsers[j].Pin}, " +
                                                  $" {obj2.localUsers[j].Cvc} , - {obj2.localUsers[j].Balance} - AZN, {obj2.localUsers[j].Expiredate} ");
                                    Console.WriteLine($" - {currentMoneyOperation[j]} - AZN , {(currentOperationDay[j] - obj2.localUsers[j].Expiredate).Days} gun evvel- ");
                                }
                            }
                            break;

                        case 4:
                            {

                                bool cpinbool2 = false;
                                Console.WriteLine("Please enter PIN number of the Credit Card you want to transfer some money");
                                string otherPin = Console.ReadLine();
                                Console.WriteLine("Please enter amount of money you want to transfer");
                                decimal tAmount = Decimal.Parse(Console.ReadLine());
                                int k;
                                for (k = 0; i < localUsers.Count; k++)
                                {
                                    if (otherPin == localUsers[k].Pin)
                                    {
                                        cpinbool2 = true;
                                        break;
                                    }
                                }
                                if (cpinbool2)
                                {
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"New balance for receiving credit card is with Pin {localUsers[k].Pin} is {localUsers[k].Balance + tAmount}");
                                    Console.WriteLine();
                                    Console.WriteLine($"New balance for sending credit card is with Pin {localUsers[i].Pin} is {localUsers[i].Balance - tAmount}");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Sorry NO CARD found with thad pin number");
                                }

                            }

                            break;

                        default:
                            {
                                Console.WriteLine("Please enter correct buttons");
                                continue;
                            }

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Sorry WRONG PIN");
                    continue;
                }
            }
        Label: Console.WriteLine("Thanks for choosing us. Waiting for you again");
            fbool = false;
            Console.WriteLine();


        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyATM.UArr obj = new MyATM.UArr();

            Console.Clear();
            Console.WriteLine();

            obj.AddUser("Farrukh", "Farajov", "021", "700", "550", 25.99m, new DateTime(2017, 11, 11));
            obj.AddUser("Farrukh1", "Farajov1", "021", "701", "551", 800.21m, new DateTime(2017, 11, 12));
            obj.AddUser("Farrukh2", "Farajov2", "021", "702", "552", 900.83m, new DateTime(2017, 11, 12));


            MyATM.Action acr = new MyATM.Action();

            try
            {
                acr.ActCard(obj.localUsers);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("My try !!!"); Console.WriteLine(ex.Message);
            }

        }
    }
}

