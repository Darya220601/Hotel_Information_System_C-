using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace HotelManagementSystem
{
    public class Workers
    {
        int workerID;
        String firstName;
        String lastName;
        public String Gender { get; set; }
        String workPosition;
        
        public Decimal salary;
        public static List<int> IdiList = new List<int>();
        public List<int> myIdiList = new List<int>();
        public static int otherExpenses = 5000;
        

        public  int WorkerID
        {


            get
            {
                return workerID;
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
                    workerID = value;
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

        public String WorkPosition
        {
            get
            {
                return workPosition;
            }
            set
            {
                workPosition = value;
                switch (workPosition)
                {
                    case "Менеджер отдела продаж":
                        salary = 700;
                        break;
                    case "Менеджер отдела питания":
                        salary = 650;
                        break;
                    case "Главная горничная":
                        salary = 450;
                        break;
                    case "Администратор":
                        salary = 800;
                        break;
                    case "Бухгалтер":
                        salary = 800;
                        break;
                    case "Горничная":
                        salary = 250;
                        break;
                    case "Секретарь-ресепшионист":
                        salary = 300;
                        break;
                    case "Шеф-повар":
                        salary = 700;
                        break;

                    case "Повар":
                        salary = 450;
                        break;

                    case "Бармен":
                        salary = 350;
                        break;
                    case "Официант":
                        salary = 350;
                        break;

                    case "Маркетолог":
                        salary = 700;
                        break;

                    case "Электрик":
                        salary = 300;
                        break;
                    case "Сантехник":
                        salary = 300;
                        break;
                    case "Портье":
                        salary = 200;
                        break;




                }
            }
        }
        public Decimal Salary
        {
            get
            {
                return salary;
            }
        }
        public void Read(StreamReader f)
        {
            try
            {
                WorkerID = Convert.ToInt32(f.ReadLine());
                FirstName = f.ReadLine();
                LastName = f.ReadLine();
                Gender = f.ReadLine();
                WorkPosition = f.ReadLine();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Wrong file, check, please!");
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("wrong data");
            }
            

        }
        public void Write(StreamWriter f)
        {

            f.WriteLine(WorkerID);
            f.WriteLine(FirstName);
            f.WriteLine(LastName);
            f.WriteLine(Gender);
            f.WriteLine(WorkPosition);

        }
        public static decimal operator +(Workers s1, Workers s2)
        {
            return s1.Salary + s2.Salary;
        }
        public static decimal operator +(decimal d, Workers s)
        {
            return d + s.Salary;
        }
        public static decimal operator +(Workers s, decimal d)
        {
            return s.Salary + d;
        }
    }
}
