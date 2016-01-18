using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.SoftwareUniversityLearningSystem.Classes.TrainerClasses;
using _04.SoftwareUniversityLearningSystem.Classes.TrainerClasses.TrainerTypes;
using _04.SoftwareUniversityLearningSystem.Classes.StudentClasses;
using _04.SoftwareUniversityLearningSystem.Classes.StudentClasses.StudentTypes;
using _04.SoftwareUniversityLearningSystem.Classes.StudentClasses.StudentTypes.CurrentStudentTypes;

namespace _04.SoftwareUniversityLearningSystem.Classes
{
    class SULSTest
    {
        private List<Person> _listOfPeople;

        public SULSTest()
        {
            this._listOfPeople = new List<Person>();
            this.AddPeopleToList();
        }

        public void AddPeopleToList()
        {
            this._listOfPeople.Add(new SeniorTrainer("Pesho", "Goshkov", 20));
            this._listOfPeople.Add(new SeniorTrainer("Geshko", "Peshkov", 30));
            this._listOfPeople.Add(new JuniorTrainer("Evlogi", "Evlogiev", 18));
            this._listOfPeople.Add(new JuniorTrainer("Haralampi", "Kitarkov", 19));
            this._listOfPeople.Add(new OnsiteStudent("Petrinka", "Smuchkova", 22, 6913, 5.35, "Gold Digging Basics", 10));
            this._listOfPeople.Add(new OnsiteStudent("Gerginka", "Podmostchieva", 25, 6914, 3.13, "Luvov Most Advanced", 13));
            this._listOfPeople.Add(new OnsiteStudent("Gencho", "Salfetkov", 33, 3333, 6.00, "Klub 33 Fashion Modeling", 9));
            this._listOfPeople.Add(new GraduateStudent("Ivanka", "'The Computer Guy' Kostilkova", 29, 314, 5.95));
            this._listOfPeople.Add(new DropoutStudent("Dimcho", "Sprihov", 23, 1313, 2.13, "Fighting in class"));
            this._listOfPeople.Add(new DropoutStudent("Ganio", "Maznikov", 55, 9999, 4.00, "Making inapropriate suggestions to the female students"));
            this._listOfPeople.Add(new OnlineStudent("Dimitar", "Medkov", 40, 1234124, 3.30, "Jica Making Open Course"));
            this._listOfPeople.Add(new OnlineStudent("Milka", "Mlechkova", 31, 1340, 5.90, "Extracting Cow Milk Techniques"));
        }

        public void CurrentStudentsInfo()
        {
            List<Student> list = new List<Student>();
            foreach (Student st in this._listOfPeople.Where(x => x.IsStudent() == true))
            {
                if (st.IsCurrent())
                {
                    list.Add(st);
                }
            }

            var avgSt = from s in list
                        orderby s.AvgGrade
                        select s;

            foreach (CurrentStudent c in avgSt)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
