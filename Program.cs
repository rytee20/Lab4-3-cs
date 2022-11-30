using System;
using System.Collections;
using System.Collections.Generic;

namespace lab1
{

    class Program
    {
        static void Main(string[] args)
        {

            //2
            Console.WriteLine("\nСоздать объект Journal и подписать его на события StudentsChanged из обеих коллекций StudentCollection");


            StudentCollection TheFirstCollection = new StudentCollection("Первая коллекция");
            StudentCollection TheSecondCollection = new StudentCollection("Вторая коллекция");

            Journal changes_journal = new Journal();
            TheFirstCollection.StudentsChanged += changes_journal.NewEntry;
            TheSecondCollection.StudentsChanged += changes_journal.NewEntry;
            Console.WriteLine("Журнал создан и подписан на события.");

            //1
            Console.WriteLine(" Создать две коллекции StudentCollection<string> с разными названиями.");
            
            Student student1 = new Student("Екатерина", "Афонина", new DateTime(2003, 12, 13), 21, Education.Bachelor);
            Exam exam = new Exam("Математика", 4, new DateTime(2022, 6, 18));
            student1.AddExams(exam);
            exam = new Exam("Физика", 4, new DateTime(2022, 6, 12));
            student1.AddExams(exam);
            exam = new Exam("Иностранный язык", 5, new DateTime(2022, 6, 11));
            student1.AddExams(exam);
            exam = new Exam("ПрЧМИ", 5, new DateTime(2022, 6, 24));
            student1.AddExams(exam);
            Test test = new Test("Физ-ра", true);
            student1.AddTests(test);
            test = new Test("Физика", true);
            student1.AddTests(test);
            test = new Test("Иностранный язык", true);
            student1.AddTests(test);
            test = new Test("ПрЧМИ", false);
            student1.AddTests(test);
            TheFirstCollection.AddStudents(student1);

            Student student2 = new Student("Мельпомена", "Сурана", new DateTime(2003, 6, 7), 21, Education.Bachelor);
            exam = new Exam("Математика", 5, new DateTime(2022, 6, 18));
            student2.AddExams(exam);
            exam = new Exam("Физика", 5, new DateTime(2022, 6, 12));
            student2.AddExams(exam);
            exam = new Exam("Иностранный язык", 5, new DateTime(2022, 6, 11));
            student2.AddExams(exam);
            exam = new Exam("ПрЧМИ", 5, new DateTime(2022, 6, 24));
            student2.AddExams(exam);
            test = new Test("Физ-ра", false);
            student2.AddTests(test);
            test = new Test("Физика", true);
            student2.AddTests(test);
            test = new Test("Иностранный язык", true);
            student2.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student2.AddTests(test);
            TheFirstCollection.AddStudents(student2);

            Student student3 = new Student("Бия", "Тревельян", new DateTime(1999, 1, 10), 14, Education.SecondEducation);
            exam = new Exam("Математика", 4, new DateTime(2022, 6, 19));
            student3.AddExams(exam);
            exam = new Exam("Физика", 3, new DateTime(2022, 6, 12));
            student3.AddExams(exam);
            exam = new Exam("Иностранный язык", 5, new DateTime(2022, 6, 1));
            student3.AddExams(exam);
            exam = new Exam("ПрЧМИ", 3, new DateTime(2022, 6, 30));
            student3.AddExams(exam);
            test = new Test("Физ-ра", false);
            student3.AddTests(test);
            test = new Test("Физика", false);
            student3.AddTests(test);
            test = new Test("Иностранный язык", true);
            student3.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student3.AddTests(test);
            TheFirstCollection.AddStudents(student3);

            Student student4 = new Student("Лаард", "Адаар", new DateTime(2004, 7, 28), 13, Education.Specialist);
            exam = new Exam("Математика", 4, new DateTime(2022, 6, 5));
            student4.AddExams(exam);
            exam = new Exam("Физика", 3, new DateTime(2022, 6, 8));
            student4.AddExams(exam);
            exam = new Exam("Иностранный язык", 5, new DateTime(2022, 6, 19));
            student4.AddExams(exam);
            exam = new Exam("ПрЧМИ", 3, new DateTime(2022, 6, 30));
            student4.AddExams(exam);
            test = new Test("Физ-ра", true);
            student4.AddTests(test);
            test = new Test("Физика", true);
            student4.AddTests(test);
            test = new Test("Иностранный язык", true);
            student4.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student4.AddTests(test);
            TheFirstCollection.AddStudents(student4);

            Student student5 = new Student("Церера", "Тревельян", new DateTime(1999, 1, 10), 14, Education.Bachelor);
            exam = new Exam("Математика", 3, new DateTime(2022, 6, 19));
            student5.AddExams(exam);
            exam = new Exam("Физика", 5, new DateTime(2022, 6, 12));
            student5.AddExams(exam);
            exam = new Exam("Иностранный язык", 4, new DateTime(2022, 6, 1));
            student5.AddExams(exam);
            exam = new Exam("ПрЧМИ", 4, new DateTime(2022, 6, 30));
            student5.AddExams(exam);
            test = new Test("Физ-ра", true);
            student5.AddTests(test);
            test = new Test("Физика", true);
            student5.AddTests(test);
            test = new Test("Иностранный язык", true);
            student5.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student5.AddTests(test);
            TheSecondCollection.AddStudents(student5);

            Student student6 = new Student("Нефет", "Лавеллан", new DateTime(2004, 7, 28), 13, Education.SecondEducation);
            exam = new Exam("Математика", 5, new DateTime(2022, 6, 5));
            student6.AddExams(exam);
            exam = new Exam("Физика", 5, new DateTime(2022, 6, 8));
            student6.AddExams(exam);
            exam = new Exam("Иностранный язык", 5, new DateTime(2022, 6, 19));
            student6.AddExams(exam);
            exam = new Exam("ПрЧМИ", 5, new DateTime(2022, 6, 30));
            student6.AddExams(exam);
            test = new Test("Физ-ра", true);
            student6.AddTests(test);
            test = new Test("Физика", true);
            student6.AddTests(test);
            test = new Test("Иностранный язык", true);
            student6.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student6.AddTests(test);
            TheSecondCollection.AddStudents(student6);


            Console.WriteLine(TheFirstCollection.ToString());
            Console.WriteLine(TheSecondCollection.ToString());

            //3
            Console.WriteLine("\nВнести изменения в коллекции StudentCollection.");
            Console.WriteLine("\n1)Добавить элементы Student в коллекции.");

            Student student8 = new Student("Илеос", "Хоук", new DateTime(2003, 6, 7), 22, Education.Bachelor);
            exam = new Exam("Математика", 3, new DateTime(2022, 6, 18));
            student8.AddExams(exam);
            exam = new Exam("Физика", 4, new DateTime(2022, 6, 12));
            student8.AddExams(exam);
            exam = new Exam("Иностранный язык", 3, new DateTime(2022, 6, 11));
            student8.AddExams(exam);
            exam = new Exam("ПрЧМИ", 4, new DateTime(2022, 6, 24));
            student8.AddExams(exam);
            test = new Test("Физ-ра", true);
            student8.AddTests(test);
            test = new Test("Физика", false);
            student8.AddTests(test);
            test = new Test("Иностранный язык", false);
            student8.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student8.AddTests(test);
            TheFirstCollection.AddStudents(student8);

            Student student9 = new Student("Бетани", "Хоук", new DateTime(2003, 6, 7), 21, Education.Bachelor);
            exam = new Exam("Математика", 5, new DateTime(2022, 6, 18));
            student9.AddExams(exam);
            exam = new Exam("Физика", 4, new DateTime(2022, 6, 12));
            student9.AddExams(exam);
            exam = new Exam("Иностранный язык", 5, new DateTime(2022, 6, 11));
            student9.AddExams(exam);
            exam = new Exam("ПрЧМИ", 5, new DateTime(2022, 6, 24));
            student9.AddExams(exam);
            test = new Test("Физ-ра", true);
            student9.AddTests(test);
            test = new Test("Физика", true);
            student9.AddTests(test);
            test = new Test("Иностранный язык", true);
            student9.AddTests(test);
            test = new Test("ПрЧМИ", true);
            student9.AddTests(test);
            TheSecondCollection.AddStudents(student9);

            Console.WriteLine(TheSecondCollection.ToString());

            Console.WriteLine("\n2)изменить значения разных свойств элементов, входящих в коллекцию.");
            Console.WriteLine("Бетани перевелась в группу 22.");
            TheSecondCollection.Students[2].GroupNumber = 22;

            Console.WriteLine("\n2)удалить элемент из коллекции.");
            Console.WriteLine("Бетани выпустилась.");
            TheSecondCollection.DeleteStudents(2);

            //4
            Console.WriteLine("\n Вывести данные объекта Journal.");
            Console.WriteLine(changes_journal.ToString());
        }
    }
}
