using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project_2_PRG_182
{
    // Henko Meyer : 578420@student.belgiumcampus.ac.za
    // George Hammond : 577175@student.belgiumcampus.ac.za
    // Willem Engelbrecht : 578334@student.belgiumcampus.ac.za
    // Leander Botha : 578404@student.belgiumcampus.ac.za
    class Program
    {


        static public int[] burgerarray = new int[4];
        static public int[] breakarray = new int[4];
        static public int[] Pizzaarray = new int[4];
        static public int[] Softarray = new int[5];
        static public int[] Desertarray = new int[5];
        static public int[] Litearray = new int[5];
        static public int[] Kidarray = new int[5];
        static public int[] Specialarray = new int[3];


        enum MainMenu
        {
            burgers = 1,
            breakfast,
            pizzas,
            Softdrinks,
            Desert,
            LiteSoftdrinks,
            Kiddies,
            specials,
            checkout,
            Total,
            exit
        }
        enum BurgerMenu
        {
            cheeseBurger = 1,
            chickenBurger,
            beefBurger,
            Burger182,
            displayinfo1,
            back
        }
        enum BreakfastMenu
        {
            eggsNtoast = 1,
            toastedCheese,
            Hashbrown,
            Farmhouse,
            displayinfo2,
            back
        }
        enum PizzaMenu
        {
            MeatyPizza = 1,
            VeggiePizza,
            SeafoodPizza,
            ProgrammingPizza,
            displayinfo3,
            back
        }
        enum SoftDrinksMenu
        {
            Coke = 1,
            Pepsi,
            Fanta,
            Sprite,
            drpepper,
            back
        }
        enum LiteSoftdrinkMenu
        {
            Cokelite = 1,
            pepsimax,
            Fantalite,
            spritelite,
            back

        }
        enum Desertmenu
        {
            Waffle = 1,
            Chocolatevolc,
            Chocmilkshake,
            Cheesecake,
            Milktart,
            displayinfo5,
            back
        }
        enum kiddiesmenu
        {
            littlenugs = 1,
            minipotatoes,
            LittleMac,
            minihash,
            smallboer,
            displayinfo,
            back
        }
        enum SpecialsMenu
        {
            PentaByte = 1,
            RTX2070Super,
            RaymondRisotto,
            back
        }
        enum CheckoutMenu
        {
            Cash = 1,
            Card,
            EFT,
            back
        }

        static void Main(string[] args)
        {
            List<string> checkoutList = new List<string>();
            RegistrationProcess();
            Mainmenu(checkoutList);
        }

        public static int Total()
        {
            int total;



            int kidsum = 0;
            foreach (int item in Kidarray)
            {
                kidsum += item;
            }

            int burgersum = 0;
            foreach (int item in burgerarray)
            {
                burgersum += item;
            }

            int breaksum = 0;
            foreach (int item in breakarray)
            {
                breaksum += item;
            }

            int pizzasum = 0;
            foreach (int item in Pizzaarray)
            {
                pizzasum += item;
            }

            int softsum = 0;
            foreach (int item in Softarray)
            {
                softsum += item;
            }

            int desertsum = 0;
            foreach (int item in Desertarray)
            {
                desertsum += item;
            }

            int litesum = 0;
            foreach (int item in Litearray)
            {
                litesum += item;
            }

            int specialsum = 0;
            foreach (int item in Specialarray)
            {
                specialsum += item;
            }

            total = desertsum + specialsum + pizzasum + litesum + softsum + kidsum + burgersum + breaksum;
            return (total);



        }
        static void RegistrationProcess()
        {
            bool login = false, detailsNull = true;
            string answer, username, password, inputUsername, inputPassword;
            while (login == false)
            {
                Console.WriteLine("Are you already a Registered user ? Y/N");
                answer = Console.ReadLine();
                Console.Clear();
                if (answer.ToUpper() == "Y" || answer.ToLower() == "y")
                {
                    LoginProcess();
                    break;
                }
                else if (string.IsNullOrEmpty(answer))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Select 'Y' for Yes or 'N' for No");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (answer.ToUpper() == "N" || answer.ToLower() == "n")
                {
                    while (detailsNull == true)
                    {
                        Console.WriteLine("Enter a username:");
                        username = Console.ReadLine();
                        Console.WriteLine("Enter a password:");
                        password = Console.ReadLine();
                        Console.Clear();
                        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Username or Password field can't be empty");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            detailsNull = false;
                            Console.WriteLine("Enter your registered username:");
                            inputUsername = Console.ReadLine();
                            Console.WriteLine("Enter your registered password:");
                            inputPassword = GetConsolePassword();
                            if (username == inputUsername && password == inputPassword)
                            {
                                login = true;
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Wrong Username or Password!!");
                                Console.WriteLine("=============================");
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Select 'Y' for Yes or 'N' for No");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
        static void LoginProcess()
        {
            bool login = false;
            string inputUsername, inputPassword;
            string[,] users =
            {
                {"RaymondHood","RH22" },
                {"LawrenceM" , "LM67" },
                {"HungryDude","Food1234"},
                {"debug","1" }
            };
            while (login == false)
            {
                Console.WriteLine("Please enter your login details... ");
                Console.WriteLine();
                Console.WriteLine("Enter your Username : ");
                inputUsername = Console.ReadLine();
                Console.WriteLine("Enter your password: ");
                inputPassword = GetConsolePassword();
                Console.Clear();
                for (int r = 0; r < users.GetLength(0); r++)
                {
                    if (inputUsername == users[r, 0] && inputPassword == users[r, 1])
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Welcome " + users[r, 0] + " !");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        login = true;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Username or Password!!");
                        Console.WriteLine("=============================");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

            }
        }

        static void Mainmenu(List<string> checkoutList)
        {
            bool exit = false;


            while (exit == false)
            {

                Console.WriteLine("Welcome to the CrusyCrab \nMENU:");
                Console.WriteLine("Please select an option");
                Console.WriteLine();
                Console.WriteLine("1. Burgers");
                Console.WriteLine("2. Breakfast");
                Console.WriteLine("3. Pizzas");
                Console.WriteLine("4. Soft Drinks");
                Console.WriteLine("5. Deserts");
                Console.WriteLine("6. Lite Soft Drinks");
                Console.WriteLine("7. Kiddies meals");
                Console.WriteLine("8. Specials");
                Console.WriteLine("9. Checkout");
                Console.WriteLine("10. Running Total");
                Console.WriteLine("11. Exit");

                int choice = int.Parse(Console.ReadLine());
                switch ((MainMenu)choice)
                {
                    case MainMenu.burgers:
                        Console.Clear();
                        Burgermenu(checkoutList);
                        break;
                    case MainMenu.breakfast:
                        Console.Clear();
                        Breakfastmenu(checkoutList);
                        break;
                    case MainMenu.pizzas:
                        Console.Clear();
                        Pizzamenu(checkoutList);
                        break;
                    case MainMenu.Softdrinks:
                        Console.Clear();
                        Drinksmenu(checkoutList);
                        break;
                    case MainMenu.Desert:
                        Console.Clear();
                        Desertmen(checkoutList);
                        break;
                    case MainMenu.LiteSoftdrinks:
                        Console.Clear();
                        LiteSoftdrinkMen(checkoutList);
                        break;
                    case MainMenu.Kiddies:
                        Console.Clear();
                        Kiddiesmenu(checkoutList);
                        break;
                    case MainMenu.specials:
                        Console.Clear();
                        Specialsmenu(checkoutList);
                        break;
                    case MainMenu.checkout:
                        Console.Clear();
                        Console.WriteLine("Item / Quantity / Price (in Rand)");
                        foreach (var item in checkoutList)
                        {
                            Console.WriteLine("{0}", item);
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("=================================");
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Your Total due is: R " + Total());
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("=================================");
                        Console.WriteLine("What pay Method do you Prefer ? \n");

                        Checkoutmenu(checkoutList);
                        break;
                    case MainMenu.Total:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your Current total is : R " + Total());



                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case MainMenu.exit:
                        Console.Clear();
                        Console.WriteLine("Thank you for shopping with us !");
                        Thread.Sleep(3000);

                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nThe value entered is not correct\n");
                        break;
                }
            }

        }

        static int LiteSoftdrinkMen(List<string> checkoutList)
        {
            int choice, price = 0, quantity = 1;

            Console.WriteLine("Lite Soft drinks Menu ");
            Console.WriteLine("For those who are tired of only drinking water");
            Console.WriteLine();
            Console.WriteLine("1. Coke Lite R15");
            Console.WriteLine("2. Pepsi Max R14");
            Console.WriteLine("3. Fanta Lite R15 ");
            Console.WriteLine("4. Sprite Lite R10");
            Console.WriteLine("5. Back");

            choice = int.Parse(Console.ReadLine());
            switch ((LiteSoftdrinkMenu)choice)
            {
                case LiteSoftdrinkMenu.Cokelite:
                    Console.Clear();
                    price = 15;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Litearray[0] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Coke Lite , which adds up to : " + price + "\n");
                    checkoutList.Add("Coke Lite" + "," + quantity + "," + price);
                    break;
                case LiteSoftdrinkMenu.pepsimax:
                    Console.Clear();
                    price = 14;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Litearray[1] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Pepsi MAX , which adds up to : " + price + "\n");
                    checkoutList.Add("Pepsi Max" + "," + quantity + "," + price);
                    break;
                case LiteSoftdrinkMenu.Fantalite:
                    Console.Clear();
                    price = 15;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Litearray[2] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Fanta Lite , which adds up to : " + price + "\n");
                    checkoutList.Add("Fanta Lite" + "," + quantity + "," + price);
                    break;
                case LiteSoftdrinkMenu.spritelite:
                    Console.Clear();
                    price = 10;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Litearray[3] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Sprite Lite , which adds up to : " + price + "\n");
                    checkoutList.Add("Sprite Lite" + "," + quantity + "," + price);
                    break;
                case LiteSoftdrinkMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        public static int Kiddiesmenu(List<string> checkoutList)
        {

            int choice, price = 0, quantity = 1;

            Console.WriteLine("Kiddies Meals Menu ");
            Console.WriteLine("Not only for kids , but also ideal as a on the go snack");
            Console.WriteLine();
            Console.WriteLine("1. Little Nuggets R35");
            Console.WriteLine("2. Mini Potatoes R24");
            Console.WriteLine("3. Little Mac R45 ");
            Console.WriteLine("4. Mini hashbrown R13");
            Console.WriteLine("5. Small Boerewors R27");
            Console.WriteLine("6. Display information about product");
            Console.WriteLine("7. Back");
            choice = int.Parse(Console.ReadLine());
            switch ((kiddiesmenu)choice)
            {
                case kiddiesmenu.littlenugs:
                    Console.Clear();
                    price = 35;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Kidarray[0] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Little Nuggets , which adds up to : " + price + "\n");
                    checkoutList.Add("Little Nuggets" + "," + quantity + "," + price);
                    break;
                case kiddiesmenu.minipotatoes:
                    Console.Clear();
                    price = 24;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Kidarray[1] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Mini Potatoes , which adds up to : " + price + "\n");
                    checkoutList.Add("Mini Potatoes" + "," + quantity + "," + price);
                    break;
                case kiddiesmenu.LittleMac:
                    Console.Clear();
                    price = 45;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Kidarray[2] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Little Mac , which adds up to : " + price + "\n");
                    checkoutList.Add("Little mac" + "," + quantity + "," + price);
                    break;
                case kiddiesmenu.minihash:
                    Console.Clear();
                    price = 13;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Kidarray[3] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Mini Hashbrown , which adds up to : " + price + "\n");
                    checkoutList.Add("Mini Hashbrown" + "," + quantity + "," + price);
                    break;
                case kiddiesmenu.smallboer:
                    Console.Clear();
                    price = 27;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Kidarray[4] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Small Boerewors , which adds up to : " + price + "\n");
                    checkoutList.Add("Small boerewors" + "," + quantity + "," + price);
                    break;
                case kiddiesmenu.displayinfo:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Kiddies Meals Description");
                    Console.WriteLine("Little Nuggets : Chicken Nuggets obtained from a dwarf Chicken  \n  {Chicken Nuggets in smaller portions} \n");
                    Console.WriteLine();
                    Console.WriteLine("Mini potatoes : Some say that these Potatoes was obtained from the Giants , not so Giant brother \n {Potatoes chopped into small fries}  \n");
                    Console.WriteLine();
                    Console.WriteLine("Little Mac : This might seem like a rip off , but its just business   \n{Sesame seed buns, filled with a mouthwatering beef patty , mint green crispy lettuce and fire melted cheese} \n ");
                    Console.WriteLine();
                    Console.WriteLine("Mini hashbrown : Because who does not want something that looks like Chicken but tastes like Potatoes  \n{Sliced miniature potatoes with a deep fried crisp layer}  \n ");
                    Console.WriteLine();
                    Console.WriteLine("Small Boerewors : Locally sourced Boerewors with a trademark name straight out of Mzansi \n{ Mini Hotdog Bun , filled with a South African Sausage and filled with Tomato Relish}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("================================================================================");
                    break;
                case kiddiesmenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }

            return price;
        }

        private static int Desertmen(List<string> checkoutList)
        {
            int choice, price = 0, quantity = 1;

            Console.WriteLine("Desert Menu");
            Console.WriteLine("For those with a little sweettooth!");
            Console.WriteLine();
            Console.WriteLine("1. Waffle R32");
            Console.WriteLine("2. Chocolate Volcano R34");
            Console.WriteLine("3. Chocolate  Milkshake R25 ");
            Console.WriteLine("4. Cheesecake R 33");
            Console.WriteLine("5. Milktart R47");
            Console.WriteLine("6. Description of Deserts");
            Console.WriteLine("7. Back");
            choice = int.Parse(Console.ReadLine());
            switch ((Desertmenu)choice)
            {
                case Desertmenu.Waffle:
                    Console.Clear();
                    price = 32;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Desertarray[0] = price;
                    checkoutList.Add("Waffle" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Waffle , which adds up to : " + price + "\n");
                    break;
                case Desertmenu.Chocolatevolc:
                    Console.Clear();
                    price = 34;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Desertarray[1] = price;
                    checkoutList.Add("Chocolate Volcano" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Choclate Volcano , which adds up to : " + price + "\n");
                    break;
                case Desertmenu.Chocmilkshake:
                    Console.Clear();
                    price = 25;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Desertarray[2] = price;
                    checkoutList.Add("Chocolate Milkshake" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Choclate Milkshake , which adds up to : " + price + "\n");
                    break;
                case Desertmenu.Cheesecake:
                    Console.Clear();
                    price = 33;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Desertarray[3] = price;
                    checkoutList.Add("Cheesecake" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Cheesecake , which adds up to : " + price + "\n");
                    break;
                case Desertmenu.Milktart:
                    Console.Clear();
                    price = 47;
                    Console.WriteLine("Enter quantity: ");
                    quantity = int.Parse(Console.ReadLine());
                    price = price * quantity;
                    Desertarray[4] = price;
                    checkoutList.Add("Milk Tart" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Milktart , which adds up to : " + price + "\n");
                    break;
                case Desertmenu.displayinfo5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("Deserts Description");
                    Console.WriteLine();
                    Console.WriteLine("Waffle : The biggest Waffles in Town served with\n Either Fresh Cream or Ice Cream ");
                    Console.WriteLine();
                    Console.WriteLine("Chocolate Volcano : Made with with only the best chocolate \nthat will simply melt once the cake is broken into");
                    Console.WriteLine();
                    Console.WriteLine("Chocolate Milkshake : Made by blending milk, Northern Atlantic ice\n and Choclate served with 3 small MarshMallows");
                    Console.WriteLine();
                    Console.WriteLine("Cheescake : Consiting of a triple layer filled with our\n special filling made out of Cream Cheese and Lime Flavoured sugar ");
                    Console.WriteLine();
                    Console.WriteLine("Milktart : This is the Real Deal made with real pastry and\n filled with our special flling topped with fresh cinnamon");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("================================================================================");
                    break;
                case Desertmenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        static int Burgermenu(List<string> checkoutList)
        {
            int choice, price = 0, qamount = 1;
            string quantity;
            bool correct;
            correct = false;

            Console.WriteLine("Burger Menu ");
            Console.WriteLine("For Those BIG Eaters");
            Console.WriteLine();
            Console.WriteLine("1. Cheese Burger R55");
            Console.WriteLine("2. Chicken Burger R44");
            Console.WriteLine("3. Beef Burger R35 ");
            Console.WriteLine("4. 182 Burger R100");
            Console.WriteLine("5. Description of Burgers");
            Console.WriteLine("6. Back");
            choice = int.Parse(Console.ReadLine());
            switch ((BurgerMenu)choice)
            {
                case BurgerMenu.cheeseBurger:
                    Console.Clear();
                    price = 55;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    burgerarray[0] = price;
                    checkoutList.Add("CheeseBurger" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Cheese Burger , which adds up to : " + price + "\n");
                    break;
                case BurgerMenu.chickenBurger:
                    Console.Clear();
                    price = 44;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    burgerarray[1] = price;
                    checkoutList.Add("Chicken Burger" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Chicken Burger , which adds up to : " + price + "\n");
                    break;
                case BurgerMenu.beefBurger:
                    Console.Clear();
                    price = 35;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    burgerarray[2] = price;
                    checkoutList.Add("Beef Burger" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Beef Burger , which adds up to : " + price + "\n");
                    break;
                case BurgerMenu.Burger182:
                    Console.Clear();
                    price = 100;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    burgerarray[3] = price;
                    checkoutList.Add("182 Burger" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Burger 182 , which adds up to : " + price + "\n");
                    break;
                case BurgerMenu.displayinfo1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Burgers Description");
                    Console.WriteLine();
                    Console.WriteLine("Cheese Burger : Sesame Bun with two 180 gram Wagyu beef patties\n topped with melted cheddar cheese\n {served with medium chips} ");
                    Console.WriteLine();
                    Console.WriteLine("Chicken Burger: Toasted Burger Bun with two free range chicken fillets\n topped with chilli sauce \n {served with medium salad} ");
                    Console.WriteLine();
                    Console.WriteLine("Beef Burger : Sesame Bun with two 180 gram Imported Wagyu patties\n topped with sweet & sour sauce \n {served with medium cheese chips}");
                    Console.WriteLine();
                    Console.WriteLine("182 Burger : Prego Rol Bun with two 100% Grass Fed beef patties\n served with c# sauce \n {served with rice}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("================================================================================");
                    break;
                case BurgerMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        static int Breakfastmenu(List<string> checkoutList)
        {

            int choice, price = 0, qamount = 1;
            string quantity;
            bool correct;
            correct = false;


            Console.WriteLine("Breakfast Menu ");
            Console.WriteLine("For those early Birds");
            Console.WriteLine();
            Console.WriteLine("1. Eggs and Toast R30");
            Console.WriteLine("2. Toasted Cheese Sandwich R25");
            Console.WriteLine("3. Hashbrown R20");
            Console.WriteLine("4. Farmhouse R55");
            Console.WriteLine("5. Description of BreakFast");
            Console.WriteLine("6. Back");
            choice = int.Parse(Console.ReadLine());

            switch ((BreakfastMenu)choice)
            {
                case BreakfastMenu.eggsNtoast:
                    Console.Clear();
                    price = 30;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    breakarray[0] = price;
                    checkoutList.Add("Eggs and toast" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Eggs and Toast , which adds up to : " + price + "\n");
                    break;
                case BreakfastMenu.toastedCheese:
                    Console.Clear();
                    price = 25;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    breakarray[1] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Toasted Cheese , which adds up to : " + price + "\n");
                    checkoutList.Add("Toasted Cheese Sandwich" + "," + quantity + "," + price);
                    break;
                case BreakfastMenu.Hashbrown:
                    Console.Clear();
                    price = 20;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    breakarray[2] = price;
                    Console.WriteLine("You have chosen " + quantity + " of Hashbrown , which adds up to : " + price + "\n");
                    checkoutList.Add("Hashbrown" + "," + quantity + "," + price);
                    break;
                case BreakfastMenu.Farmhouse:
                    Console.Clear();
                    price = 55;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    breakarray[3] = price;
                    checkoutList.Add("Farmhouse" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Farmhouse , which adds up to : " + price + "\n");
                    break;
                case BreakfastMenu.displayinfo2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Breakfast Description");
                    Console.WriteLine();
                    Console.WriteLine("Eggs and Toast : Two baked eggs served with two slices\n of Low GI bread\n {Note eggs are made sunny side up} ");
                    Console.WriteLine();
                    Console.WriteLine("Toasted Cheese Sandwich : Toasted sesame bread with\n cheddar chees(An old favourite ideal for those light morning eaters) ");
                    Console.WriteLine();
                    Console.WriteLine("Hashbrown: Mashed Patato pressed into a square and\n filled with our unique sweet chilli sauce ");
                    Console.WriteLine();
                    Console.WriteLine("Farmhouse : Two slices of whole wheat bread,medium chips\n two grilled tomatoes, 3 boiled eggs and one 200 gram Wagyu fillet ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("================================================================================");
                    break;
                case BreakfastMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        static int Pizzamenu(List<string> checkoutList)
        {
            int choice, price = 0, qamount = 0;
            string quantity;
            bool correct;
            correct = false;
            Console.Clear();
            Console.WriteLine("Pizza Menu");
            Console.WriteLine("Simply the best Pizza you will ever TASTE! ");
            Console.WriteLine();
            Console.WriteLine("1. Meaty Pizza R75");
            Console.WriteLine("2. Veggie Pizza R55");
            Console.WriteLine("3. Seafood Pizza R95");
            Console.WriteLine("4. Programming Pizza R80");
            Console.WriteLine("5. Description of Pizza");
            Console.WriteLine("6. Back");
            choice = int.Parse(Console.ReadLine());
            switch ((PizzaMenu)choice)
            {
                case PizzaMenu.MeatyPizza:
                    Console.Clear();
                    price = 75;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Pizzaarray[0] = price;
                    checkoutList.Add("Meaty Pizza" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Meaty Pizza , which adds up to : " + price + "\n");
                    break;
                case PizzaMenu.VeggiePizza:
                    Console.Clear();
                    price = 55;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Pizzaarray[1] = price;
                    checkoutList.Add("Veggie Pizza" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of VeggiePizza , which adds up to : " + price + "\n");
                    break;
                case PizzaMenu.SeafoodPizza:
                    Console.Clear();
                    price = 95;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Pizzaarray[2] = price;
                    checkoutList.Add("Seafood Pizza" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Seafood Pizz , which adds up to : " + price + "\n");
                    break;
                case PizzaMenu.ProgrammingPizza:
                    Console.Clear();
                    price = 80;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Pizzaarray[3] = price;
                    checkoutList.Add("Programming Pizza" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Programming Pizza , which adds up to : " + price + "\n");
                    break;
                case PizzaMenu.displayinfo3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Pizza Description");
                    Console.WriteLine();
                    Console.WriteLine("Meaty Pizza : Thin base pizza topped with beef sirlion\n aged cheddar cheese and our famous BBQ sauce ");
                    Console.WriteLine();
                    Console.WriteLine("Veggie Pizza : Thin base 100% plant based and gluten-free.\nTopped with crispy lettuce,rocket,spinach and mushrooms and salad sauce ");
                    Console.WriteLine();
                    Console.WriteLine("Seafood Pizza: Thin base pizza topped with wild caught Salmon\nmussels and shrimp served with a melted butter and garlic sauce ");
                    Console.WriteLine();
                    Console.WriteLine("Programming Pizza : Thin base pizza with mushrooms,feta and\n chicken topped with a bit of bytes ");
                    Console.WriteLine();
                    Console.WriteLine("Note: every Pizza is baked in the Pizza oven! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("================================================================================");

                    break;
                case PizzaMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        static int Drinksmenu(List<string> checkoutList)
        {
            int choice, price = 0, qamount = 0;
            string quantity;
            bool correct;
            correct = false;

            Console.WriteLine("Soft Drinks Menu ");
            Console.WriteLine("The coldest Soft Drinks in town!");
            Console.WriteLine();
            Console.WriteLine("1. Coke R10");
            Console.WriteLine("2. Pepsi R10");
            Console.WriteLine("3. Fanta  R13");
            Console.WriteLine("4. Mountain Dew R15");
            Console.WriteLine("5. Tropica R20");
            Console.WriteLine("6. Back");
            choice = int.Parse(Console.ReadLine());

            switch ((SoftDrinksMenu)choice)
            {
                case SoftDrinksMenu.Coke:
                    Console.Clear();
                    price = 10;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Softarray[0] = price;
                    checkoutList.Add("Coke" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Coke , which adds up to : " + price + "\n");
                    break;
                case SoftDrinksMenu.Pepsi:
                    Console.Clear();
                    price = 10;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Softarray[1] = price;
                    checkoutList.Add("Pepsi" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Pepsi , which adds up to : " + price + "\n");
                    break;
                case SoftDrinksMenu.Fanta:
                    Console.Clear();
                    price = 13;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Softarray[2] = price;
                    checkoutList.Add("Fanta" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Fanta , which adds up to : " + price + "\n");
                    break;
                case SoftDrinksMenu.Sprite:
                    Console.Clear();
                    price = 15;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Softarray[3] = price;
                    checkoutList.Add("Sprite" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Sprite , which adds up to : " + price + "\n");
                    break;
                case SoftDrinksMenu.drpepper:
                    Console.Clear();
                    price = 20;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Softarray[4] = price;
                    checkoutList.Add("Dr.Pepper" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of drpepper , which adds up to : " + price + "\n");
                    break;
                case SoftDrinksMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        static int Specialsmenu(List<string> checkoutList)
        {
            int choice, price = 0, qamount = 0;
            string quantity;
            bool correct;
            correct = false;

            Console.WriteLine("Specials Menu ");
            Console.WriteLine("Make sure to grab these specials WHILE THEY LAST!");
            Console.WriteLine();
            Console.WriteLine("1. PentaByte R40");
            Console.WriteLine("2. RTX 2070 Super R55");
            Console.WriteLine("3. Raymond Risotto R70");
            Console.WriteLine("4. Back");
            choice = int.Parse(Console.ReadLine());
            switch ((SpecialsMenu)choice)
            {
                case SpecialsMenu.PentaByte:
                    Console.Clear();
                    price = 40;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Specialarray[0] = price;
                    checkoutList.Add("Pentabyte" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of PentaByte , which adds up to : " + price + "\n");
                    break;
                case SpecialsMenu.RTX2070Super:
                    Console.Clear();
                    price = 55;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Specialarray[1] = price;
                    checkoutList.Add("RTX 2070 Super" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of RTX2070Super , which adds up to : " + price + "\n");
                    break;
                case SpecialsMenu.RaymondRisotto:
                    Console.Clear();
                    price = 70;
                    Console.WriteLine("Enter quantity: ");
                    quantity = Console.ReadLine();
                    while (correct == false)
                    {
                        if (string.IsNullOrEmpty(quantity))
                        {
                            Console.WriteLine("Please enter a valid quantity");
                            quantity = Console.ReadLine();
                            correct = false;
                        }
                        else
                        {
                            correct = true;
                            Console.Clear();
                        }
                    }
                    qamount = int.Parse(quantity);
                    price = price * qamount;
                    Specialarray[2] = price;
                    checkoutList.Add("Raymond Risotto" + "," + quantity + "," + price);
                    Console.WriteLine("You have chosen " + quantity + " of Raymond Risotto , which adds up to : " + price + "\n");
                    break;
                case SpecialsMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return price;
        }

        static int Checkoutmenu(List<string> checkoutList)
        {
            int choice, total = 0;
            bool validcvv = false, validexp = false, validcnum = false;


            Console.WriteLine("1. Cash");
            Console.WriteLine("2. Card");
            Console.WriteLine("3. EFT");
            Console.WriteLine("4. Back");
            choice = int.Parse(Console.ReadLine());
            switch ((CheckoutMenu)choice)
            {
                case CheckoutMenu.Cash:
                    Console.Clear();
                    Console.WriteLine("Please pay at the nearest store cashier, thank you \n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    reset();
                    checkoutList.Clear();
                    break;
                case CheckoutMenu.Card:
                    string type, number, name, surname, cvv, exp;

                    Console.WriteLine("Please insert cardholder name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Please insert cardholder surname:");
                    surname = Console.ReadLine();
                    Console.WriteLine("Please insert card type: visa/american express/mastercard");
                    type = Console.ReadLine();
                    Console.WriteLine("Please insert card number (16-19 digits):");
                    number = Console.ReadLine();
                    while (validcnum == false)
                    {
                        if (number.Length < 16 || number.Length > 19)
                        {
                            Console.WriteLine("Please enter a valid card number (16-19 digits)");
                            number = Console.ReadLine();
                        }
                        else if (number.Length >= 16 && number.Length <= 19)
                        {
                            validcnum = true;
                        }
                    }
                    Console.WriteLine("Please insert exp date: MM/YY");
                    exp = Console.ReadLine();
                    while (validexp == false)
                    {
                        if (exp.Length < 5 || exp.Length > 5)
                        {
                            Console.WriteLine("Please enter a valid exp date");
                            exp = Console.ReadLine();
                        }
                        else if (exp.Length == 5)
                        {
                            validexp = true;
                        }
                    }
                    Console.WriteLine("Please insert CVV number:");
                    cvv = Console.ReadLine();
                    while (validcvv == false)
                    {
                        if (cvv.Length < 3 || cvv.Length > 3)
                        {
                            Console.WriteLine("Please enter a valid CVV number");
                            cvv = Console.ReadLine();
                        }
                        else if (cvv.Length == 3)
                        {
                            validcvv = true;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Processing Purchase please wait");
                    Thread.Sleep(5000);
                    reset();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Purchase successful!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(3000);
                    Console.Clear();
                    checkoutList.Clear();
                    break;
                case CheckoutMenu.EFT:
                    string bankname;
                    Console.WriteLine("CrusyCrab PTA");
                    Console.WriteLine("FNB Pretoria north");
                    Console.WriteLine("Branch code: 34526");
                    Console.WriteLine("Acc number: 5429 4157 63214");
                    Console.WriteLine(" ");
                    Console.WriteLine("Please insert a bank name");
                    bankname = Console.ReadLine();
                    Console.WriteLine("Processing Purchase please wait");
                    Thread.Sleep(5000);
                    reset();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Purchase successful!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Thread.Sleep(3000);
                    Console.Clear();
                    checkoutList.Clear();
                    break;
                case CheckoutMenu.back:
                    Console.Clear();
                    Mainmenu(checkoutList);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\nThe value entered is not correct\n");
                    break;
            }
            return total;
        }

        private static void reset()
        {
            Array.Clear(Kidarray, 0, Kidarray.Length);
            Array.Clear(burgerarray, 0, burgerarray.Length);
            Array.Clear(breakarray, 0, breakarray.Length);
            Array.Clear(Pizzaarray, 0, Pizzaarray.Length);
            Array.Clear(Softarray, 0, Softarray.Length);
            Array.Clear(Desertarray, 0, Desertarray.Length);
            Array.Clear(Litearray, 0, Litearray.Length);
            Array.Clear(Specialarray, 0, Specialarray.Length);

        }

        static string GetConsolePassword()
        {
            StringBuilder pword = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo ckey = Console.ReadKey(true);
                if (ckey.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                if (ckey.Key == ConsoleKey.Backspace)
                {
                    if (pword.Length > 0)
                    {
                        Console.Write("\b\0\b");
                        pword.Length--;
                    }
                    continue;
                }
                Console.Write('*');
                pword.Append(ckey.KeyChar);
            }
            return pword.ToString();
        }

    }
}
