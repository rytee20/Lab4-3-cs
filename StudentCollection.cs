using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace lab1
{
    class StudentCollection
    {
        public string CollectionName { get; set; }
        //private Dictionary<TKey, Student> _students = new Dictionary<TKey, Student>();
        //private KeySelector<TKey> ks;
        //public delegate TKey KeySelector<TKey>(Student st);
        private List<Student> _students;
        
        public List<Student> Students
        {
            get
            {
                return _students;
            }
            set
            {
                _students = value;
            }
        }

        public StudentCollection(string name)
        {
            CollectionName = name;
            _students = new List<Student>();
        }

        private void HandleEvent(Object sender, PropertyChangedEventArgs e)
        {
            StudentsChanged((Student)sender, new StudentsChangedEventArgs(CollectionName, Action.Property,e.PropertyName, (Student)sender));
        }

        public void AddStudents(params Student[] students)
        {
            _students.AddRange(students);
            foreach(Student student in students)
            {
                //  StudentsPropertyChanged(Action.Add, "", student);
                StudentsChanged(student, new StudentsChangedEventArgs(CollectionName, Action.Add, "", student));
                student.PropertyChanged += HandleEvent;
            }
            //StudentsPropertyChanged(Action.Add, "", students);
            //students.PropertyChanged += HandleEvent;
        }

        public void DeleteStudents(int index)
        {

            Student student = Students[index];
            StudentsChanged(student, new StudentsChangedEventArgs(CollectionName, Action.Remove, "", student));
            Students.RemoveAt(index);
            
        }

        public override string ToString() //перегруженный метод ToString
        {
            string StudentsString = "Название коллекции: " + CollectionName+"\n";
            foreach (var student in _students)
            {
                StudentsString = StudentsString + student.ToString() + "\n";
            }
            return StudentsString;
        }

        public string ToShortString() //перегруженный метод ToShortString
        {
            string StudentsString = "Название коллекции: " + CollectionName + "\n";
            foreach (var student in Students)
            {
                StudentsString = StudentsString + student.ToShortString() + "\n";
            }
            return StudentsString;
        }

       public void SortByLastName() //сортировка по фамилии
       {
            _students.Sort((x, y) => x.LastName.CompareTo(y.LastName));
       }

        public void SortByDateOfBirth() //сортировка по дате рождения
        {
            _students.Sort();
        }

        public void SortByGPA() //сортировка по среднему баллу
        {
            StudentComparer comp = new StudentComparer();
            _students.Sort(comp);
        }

        public double MaxGPA //максимальный средний балл
        {
            get
            {
                if (_students.Count == 0)
                {
                    return 0;
                }
                return _students.Max(student => student.GPA);
            }
        }

        public IEnumerable<Student> GetSpecialists //находим специалистов
        {
            get
            {
                IEnumerable<Student> Specialists = _students.Where(student => student.DegreeOfEducation == Education.Specialist);
                return Specialists;
            }
        }

        public List<Student> AverageMarkGroup(double value) //находим студентов с заданным средним баллом
        {
            IEnumerable<IGrouping<double,Student>> StudentsWithGPA = _students.GroupBy(student => student.GPA);
            foreach (IGrouping<double, Student> student in StudentsWithGPA)
            {
                if (student.Key == value)
                {
                    return student.ToList<Student>();
                }
            }
            return null;
        }

        public delegate void StudentsChangedHandler(object source, StudentsChangedEventArgs args);

        public event StudentsChangedHandler StudentsChanged;


    }
}

