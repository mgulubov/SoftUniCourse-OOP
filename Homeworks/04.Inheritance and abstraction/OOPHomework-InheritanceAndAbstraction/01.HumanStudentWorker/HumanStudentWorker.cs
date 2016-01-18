using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.HumanStudentWorker.Classes;

namespace _01.HumanStudentWorker
{
    class HumanStudentWorker
    {
        private static List<Student> _studentsList;
        private static List<Worker> _workersList;
        private static List<Human> _mergedList;

        static void Main(string[] args)
        {
            _studentsList = new List<Student>();
            _workersList = new List<Worker>();
            _mergedList = new List<Human>();

            InitialyzeStudents();
            InitialyzeWorkers();

            OrderStudentsByFacultyNumber();
            OrderStudentsByPaymentPerHour();

            MergeLists();
            PrintMergedListByFirstAndLastName();
        }

        private static void PrintMergedListByFirstAndLastName()
        {
            _mergedList = _mergedList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (Human a in _mergedList)
            {
                Console.WriteLine("{0} {1}", a.FirstName, a.LastName);
            }
        }

        private static void MergeLists()
        {
            foreach (Student a in _studentsList)
            {
                _mergedList.Add(a);
            }

            foreach (Worker a in _workersList)
            {
                _mergedList.Add(a);
            }
        }

        private static void OrderStudentsByPaymentPerHour()
        {
            _workersList = _workersList.OrderByDescending(x => x.MoneyPerHour()).ToList();
        }

        private static void OrderStudentsByFacultyNumber()
        {
            _studentsList = _studentsList.OrderBy(x => x.FacultyNumber).ToList();
        }

        private static void InitialyzeStudents()
        {
            _studentsList.Add(new Student("Evlogi", "Evlogiev", "1231241324D"));
            _studentsList.Add(new Student("Pesho", "Peshov", "213d12r23rds"));
            _studentsList.Add(new Student("Goshko", "Goskov", "123dk92109j21"));
            _studentsList.Add(new Student("Pecko", "Peckov", "e12jfqj983r"));
            _studentsList.Add(new Student("Anastaska", "Anastaskieva", "dko290jf329f0j3"));
            _studentsList.Add(new Student("Georginka", "Georginkinkova", "kdf9021j9rf823u"));
            _studentsList.Add(new Student("Spaska", "Evtanazieva", "12rdsafr23r"));
            _studentsList.Add(new Student("asdasd", "dafqwsd", "jhf8hfh"));
            _studentsList.Add(new Student("asdasd", "dafqwsd", "y7reyhdsf"));
            _studentsList.Add(new Student("gsdasd", "fefwerg", "53456g"));
        }

        private static void InitialyzeWorkers()
        {
            _workersList.Add(new Worker("fasdf", "dgr", 847, 12));
            _workersList.Add(new Worker("fgewgf", "sdgsdfg", 3242, 10));
            _workersList.Add(new Worker("dsfsd", "ge4rg", 5, 1));
            _workersList.Add(new Worker("sdgvf", "xcfg", 324, 5));
            _workersList.Add(new Worker("hyre", "wetr", 1, 2));
            _workersList.Add(new Worker("fxg", "hjhk", 41324, 22));
            _workersList.Add(new Worker("gewg", "kghj", 156, 6));
            _workersList.Add(new Worker("gwegsdf", "yui", 34, 14));
            _workersList.Add(new Worker("ewrg", "poiu", 65, 19));
            _workersList.Add(new Worker("bgfhd", "ty", 325, 9));
        }
    }
}
