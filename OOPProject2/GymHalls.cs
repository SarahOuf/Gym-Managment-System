using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject2
{
  /* public class Manager
    {
        public void AddTrainer(string firstname, string lastname, string trainemail, string gender, string contact, int hours, int salary)
        {
            Trainer t = new Trainer();
            t.AddTrainer(firstname, lastname, trainemail, gender, contact, hours, salary);
        }

       // public void AddCustomer(string FirstName, string LastName, string Email, string Gender, string contact, string subdate, int weight, int height)
        //{
          //  Customer c = new Customer();
            //c.AddCustomer(FirstName, LastName, Email, Gender, contact ,  subdate ,  weight ,  height);
        //}

        public void AddEq(string eqId, string eqName, string eqGategory, string eqAmount)
        {
            Equipment e = new Equipment();
            e.Addeq(eqId, eqName, eqGategory, eqAmount);
        }

        //public void AddHall(string hallName, int hallID)
        //{
          //  GymHalls h = new GymHalls();
          //  h.AddHall(hallName, hallID);
        //}

    }*/
    public class GymHalls
    {
        private static int hours = 16;
        private string HallName;
        private int HallID;
       
       
        public GymHalls()
        { }

        public void AddHall(string hallName, int hallID)
        {
            this.HallName = hallName;
            this.HallID = hallID;
           
        }
        /*public isAvaliable()
         {

         }
        public TimeCount()
        {

        } */


    }
    
    public class Person
    {
        protected int ID;
        protected string FirstName;
        protected string LastName;
        protected string Email;
        protected string Gender;
        protected string Contact;
        protected int gymhallID;


        public Person()
        {
        }

        public Person(int id , string fname , string lname , string email , string gender , string contact , int gymhall )
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Gender = gender;
            this.Contact = contact;
            this.gymhallID = gymhall;
           
        }

        virtual public void Add(int id, string fname, string lname, string email, string gender, string contact, int gymhall)
        {
        this.ID = id;
        this.FirstName = fname;
        this.LastName = lname;
        this.Email = email;
        this.Gender = gender;
        this.Contact = contact;
        this.gymhallID = gymhall;
        }

    }
    public class Customer : Person
    {
        private string  CustSubdate;
        private int CustHeight;
        private int CustWeight;
        private string Trainingtime;
        private int exerID;

        public Customer(int CustID, string CustFirstName, string CustLastName, string CustEmail, string CustGender, string CustConact, int CustHeight, int CustWeight , string time)
            : base()
        {
        this.ID = CustID;
            this.FirstName = CustFirstName;
            this.LastName = CustLastName;                                                                        
            this.Email = CustEmail;
            this.Gender = CustGender;
            this.Contact = CustConact;
            this.CustHeight = CustHeight;
            this.CustWeight = CustWeight;
            this.Trainingtime = time;
        }

        public Customer()
        {

        }

        public override void Add(int id, string fname, string lname, string email, string gender, string contact, int gymhall)
        {
            this.ID = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Gender = gender;
            this.Contact = contact;
            this.gymhallID = gymhall;
           
        }

        public void setHeightAndWeight(int height , int weight)
        {
            this.CustHeight = height;
            this.CustWeight = weight;
        }

        public void setTrainingtime(string time)
            {
                this.Trainingtime = time;
            }

        public void setSubDate(string date)
        {
        this.CustSubdate = date;
        }

        public void setExerid(int exerid)
        {
        this.exerID = exerid;
        }



        //public int FitnessPlan(int CustHeight, int CustWeight, string Gender)
        //{
        //    int x = CustHeight - CustWeight;
        //    if (Gender == "Male")
        //    {
        //        if (x == 100)
        //        {
        //            return 1;
        //        }
        //        else if (x > 100 && (x < 120 || x == 120))
        //        {
        //            return 2;
        //        }
        //        else if (x > 120)
        //        {
        //            return 3;
        //        }
        //        else if (x < 100)
        //        {
        //            return 4;
        //        }
        //    }
        //    else if (Gender == "Female")
        //    {
        //        if (x == 110)
        //        {
        //            return 1;
        //        }
        //        else if (x > 110 && (x < 130 || x == 130))
        //        {
        //            return 2;
        //        }
        //        else if (x > 130)
        //        {
        //            return 3;
        //        }
        //        else if (x < 110)
        //        {
        //            return 4;
        //        }
        //    }
        //    return 0;

        //}
    }

    public class Trainer : Person
    {
        private string WorkingHours;
        private int Salary;

        //private List<Trainer> LstTrainers = new List<Trainer>();
        

        public Trainer(int TrainID, string TrainFirstName, string TrainLastName, string TrainEmail, string TrainPassword, string TrainGender, string TrainContact, string WorkingHours , int GymID)
            : base()
        {
            this.ID = TrainID;                                                                                                                                         
            this.FirstName = TrainFirstName;
            this.LastName = TrainLastName;
            this.Email = TrainEmail;
            this.Gender = TrainGender;
            this.Contact = TrainContact;
            this.WorkingHours = WorkingHours;
            this.gymhallID = GymID;

        }

        public Trainer()
        { }

        public override void Add(int id, string fname, string lname, string email, string gender, string contact, int gymhall)
        {
            this.ID = id;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
            this.Gender = gender;
            this.Contact = contact;
            this.gymhallID = gymhall;
        }

        public void setSalary(int salary)
        {
            this.Salary = salary;
        }

        public void setWorkingHours(string hours)
        {
        this.WorkingHours = hours;
        }

        //public void setList(Trainer t)
        //{
        //    LstTrainers.Add(t);
        //}

        //public List<Trainer> getList()
        //{
        //    return LstTrainers;
        //}

        public static Trainer operator+(Trainer t1 , int x)      //x is bonus
        {
            t1.Salary = t1.Salary + x;
            return t1;
        }

        public int getSalary()
        {
        return Salary;
        }

    }
    public class ExercisePlan
    {
        private string ExerID;
        private string ExerName;
        private int ExerTime;
        private List<EquipmentExer> eqLst = new List<EquipmentExer>();

        public void setListEq(EquipmentExer eq)
        {
            eqLst.Add(eq);
        }

        public List<EquipmentExer> getListeq()
        {
            return eqLst;
        }

        public ExercisePlan()
        { }

        public void AddExerPlan(string exerID ,  string name , int time  , List<EquipmentExer> lst)
        {
            this.ExerName = name;
            this.ExerTime = time;
            this.eqLst = lst;
            this.ExerID = exerID;
        }

        //public static ExercisePlan operator +(ExercisePlan a, ExercisePlan b)
        //    {
        //    List<EquipmentExer> newEqLst = new List<EquipmentExer>(a.eqLst);
        //    newEqLst.AddRange(b.eqLst);
        //    return new ExercisePlan() { ExerID = a.ExerID + b.ExerID, ExerName = a.ExerName + " & " + b.ExerName, ExerTime = a.ExerTime + b.ExerTime, eqLst = newEqLst };
        //    }

        public static ExercisePlan operator +(ExercisePlan a, ExercisePlan b)
            {
            List<EquipmentExer> newEqLst = new List<EquipmentExer>(a.eqLst);
            newEqLst.AddRange(b.eqLst);
            ExercisePlan result = new ExercisePlan();
            result.ExerID = a.ExerID + b.ExerID;
            result.ExerName = a.ExerName + " & " + b.ExerName;
            result.ExerTime = a.ExerTime + b.ExerTime;
            result.eqLst = newEqLst;
            return result;
            }

    }

    public class EquipmentExer
    {
        private string equipmentName;
        private string duration;
        private string steps;

        public EquipmentExer()
        { }

        public void AddExerciseEq(string eqName, string duration, string steps)
        {
            this.equipmentName = eqName;
            this.duration = duration;
            this.steps = steps;
        }
    }

    public class Equipment
    {
        private string EqID;
        private string EqName;
        private string EqCategory;
        private string EqAmount;

        public Equipment()
        { }

        public void Addeq(string eqId, string eqName, string eqGategory, string eqAmount)
        {
            this.EqID = eqId;
            this.EqName = eqName;
            this.EqCategory = eqGategory;
            this.EqAmount = eqAmount;
        }

        public string getID()
        {
            return EqID;
        }




    }


    
}
