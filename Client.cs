using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelManagementSystem
{
    public class Client
    {

        DateTime dateofArrival;
        DateTime dateofDeparture;
        public int clientId;
        String firstName;
        String lastName;
        public String Gender { get; set; }
        String telephoneNumber;
        String roomType;
        String meal;
        Decimal totalCost;
        int totalDays;
        int roomNumber;

        public static int sizeRooms = 300;
        public static List<int> IdiList = new List<int>();
        public List<int> myIdiList = new List<int>();
        Random random = new Random();
        public int ClientId
        {


            get
            {
                return clientId;
            }
            set
            {

                Boolean b = false;
                foreach (int i in myIdiList.ToArray())
                {
                    foreach (int j in IdiList.ToArray())
                    {
                        if (i == j)
                        {
                            IdiList.Remove(i);
                            myIdiList.Remove(j);
                        }
                    }
                }

                foreach (int j in IdiList.ToArray())
                {
                    if (j == value)
                    {
                        b = true;
                        break;
                    }
                }



                if (b)
                {

                    MessageBox.Show("This id is not available");

                }
                else
                {
                    clientId = value;
                    myIdiList.Add(value);
                    IdiList.Add(value);
                }
            }
        }

        public String FirstName
        {
            set
            {
                try
                {
                    Regex regex = new Regex(@"[\p{P}\d]"); //регулярное выражение соответствует всем
                                                           // знакам препинания и десятичным цифрам.
                    Match match = regex.Match(value);
                    if (!match.Success)
                    {
                        firstName = value;

                    }
                    else
                    {
                        MessageBox.Show("Wrong FirstName\nCheck,please\nFirstName can contains only letters!");
                        firstName = "";
                    }

                }
                catch (System.ArgumentNullException)
                {
                    MessageBox.Show("Null Argument!");
                }

            }
            get
            {
                return firstName;
            }
        }

        public String LastName
        {

            set
            {
                try
                {
                    Regex regex = new Regex(@"[\p{P}\d]"); //регулярное выражение соответствует всем
                                                           // знакам препинания и десятичным цифрам.

                    Match match = regex.Match(value);
                    if (!match.Success)
                    {
                        lastName = value;
                    }
                    else
                    {
                        MessageBox.Show("Wrong LastName!\nCheck,please!\nLastName can contains only letters!");
                        lastName = "";
                    }
                }
                catch (System.ArgumentNullException)
                {
                    MessageBox.Show("Null Argument!");
                }
            }


            get
            {
                return lastName;
            }
        }
        public String TelephoneNumber
        {
            set
            {
                try
                {
                    Regex regex = new Regex(@"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$");
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        telephoneNumber = value;

                    }
                    else
                    {
                        MessageBox.Show("Wrong phone number\nCheck,please\nExample:+37529XXXXXXX");
                        telephoneNumber = "";
                    }
                }
                catch (System.ArgumentNullException)
                {
                    MessageBox.Show("Null Argument!");
                }

            }
            get
            {
                return telephoneNumber;
            }
        }
        public DateTime DateofArival
        {
            set
            {

                dateofArrival = value;
                totalDays = (dateofDeparture - dateofArrival).Days;
                value.ToString();

            }
            get
            {
                return dateofArrival;
            }
        }
        public DateTime DateofDeparture
        {
            get
            {
                return dateofDeparture;
            }
            set
            {



                dateofDeparture = value;
                Boolean b = true;
                while (b)
                {
                    if (dateofDeparture < dateofArrival)
                    {

                        MessageBox.Show("Wrong date");
                        dateofDeparture = dateofArrival;

                    }
                    else

                    {
                        b = false;
                        totalDays = (dateofDeparture - dateofArrival).Days;
                    }
                }

            }
        }
        public String RoomType
        {
            get
            {
                return roomType;
            }
            set
            {


                roomType = value;

                int costForDaysMeals = 0;

                switch (meal)
                {
                    case "no meal":
                        costForDaysMeals = 0;
                        break;
                    case "one":
                        costForDaysMeals = 50;
                        break;
                    case "two":
                        costForDaysMeals = 80;
                        break;
                    case "three":
                        costForDaysMeals = 130;
                        break;
                }
                int costForRoom = 0;
                switch (roomType)
                {
                    case Room.typeOne:
                        costForRoom = 120;
                        break;
                    case Room.typeTwo:
                        costForRoom = 160;
                        break;
                    case Room.typeThree:
                        costForRoom = 200;
                        break;


                }
                totalCost = (costForDaysMeals + costForRoom) * totalDays;

                switch (roomType)
                {
                    case Room.typeOne:
                        costForRoom = 120;
                        break;
                    case Room.typeTwo:
                        costForRoom = 160;
                        break;
                    case Room.typeThree:
                        costForRoom = 200;
                        break;



                }

            }
        }


        public String Meal
        {
            get
            {
                return meal;
            }
            set
            {

                meal = value;
                int costForDaysMeals = 0;



                switch (meal)
                {
                    case "no meal":
                        costForDaysMeals = 0;
                        break;
                    case "one":
                        costForDaysMeals = 50;
                        break;
                    case "two":
                        costForDaysMeals = 80;
                        break;
                    case "three":
                        costForDaysMeals = 130;
                        break;
                }
                int costForRoom = 0;
                switch (roomType)
                {
                    case Room.typeOne:
                        costForRoom = 120;
                        break;
                    case Room.typeTwo:
                        costForRoom = 160;
                        break;
                    case Room.typeThree:
                        costForRoom = 200;
                        break;
                }
                totalCost = (costForDaysMeals + costForRoom) * totalDays;
            }
        }

        public int TotalDays
        {
            get
            {
                return totalDays;
            }

        }
        public Decimal TotalCost
        {
            get
            {
                return totalCost;
            }

        }
        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {

              
                Boolean b = true;
               



                switch (this.roomType)
                {
                    case Room.typeOne:
                        for (int i = 1; i < 101; i++)
                        {


                            if (i == value)
                            {


                                roomNumber = i;
                                b = false;
                                


                                break;
                            }
                        }

                        break;



                  


                    case Room.typeTwo:
                        for (int i = 101; i < 201; i++)
                        {

                            
                            if (i == value)
                            {


                                roomNumber = i;
                                b = false;
                                break;
                            }
                            



                            
                        }
                        break;



                    case Room.typeThree:
                        for (int i = 201; i < 301; i++)
                        {

                            if (i == value)
                            {


                                roomNumber = i;
                                b = false;
                                



                                break;
                            }
                        }
                        break;






                }
                if (b)
                {
                    MessageBox.Show("Этот номер относится к другому типу\nsingleRoom:1-100 room number\ndoubleRoom:101-200 room number\nfamilyRoom:201-300 room number");
                    switch (this.roomType)
                    {
                        case Room.typeOne:
                           

                            while (b)
                            {
                                int r = random.Next(1,100);
                                if (r != value)
                                {
                                    roomNumber = r;
                                    b = false;
                                }

                            }
                           

                            break;





                        case Room.typeTwo:

                            

                            while (b)
                            {
                                int r = random.Next(101,200);
                                if (r != value)
                                {
                                    roomNumber = r;
                                    b = false;
                                }

                            }
                            

                            break;




                        case Room.typeThree:
                            

                            while (b)
                            {
                                int r = random.Next(201,300);
                                if (r != value)
                                {
                                    roomNumber = r;
                                    b = false;
                                }
                            }
                            

                            break;
                    }
                }


            }
        }
        public void Read(StreamReader f)
        {
            try
            {
                ClientId = Convert.ToInt32(f.ReadLine());
                FirstName = f.ReadLine();
                LastName = f.ReadLine();
                Gender = f.ReadLine();
                TelephoneNumber = f.ReadLine();
                DateofArival = Convert.ToDateTime(f.ReadLine());
                DateofDeparture = Convert.ToDateTime(f.ReadLine());
                RoomType = f.ReadLine();
                Meal = f.ReadLine();
                RoomNumber = Convert.ToInt32(f.ReadLine());
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Wrong file, check,please");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Wrong data");
            }

        }
        public void Write(StreamWriter f)
        {

            f.WriteLine(ClientId);
            f.WriteLine(FirstName);
            f.WriteLine(LastName);
            f.WriteLine(Gender);
            f.WriteLine(TelephoneNumber);
            f.WriteLine(DateofArival);
            f.WriteLine(DateofDeparture);
            f.WriteLine(RoomType);
            f.WriteLine(Meal);
            f.WriteLine(RoomNumber);

        }
        public static decimal operator +(Client s1, Client s2)
        {
            return s1.TotalCost + s2.TotalCost;
        }
        public static decimal operator +(decimal d, Client s)
        {
            return d + s.TotalCost;
        }
        public static decimal operator +(Client s, decimal d)
        {
            return s.TotalCost + d;
        }
    }


}

           
          
