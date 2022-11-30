using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Journal
    {
        private List<JournalEntry> _journal = new List<JournalEntry>();

        public void NewEntry(object student, StudentsChangedEventArgs e)
        {
            //var it = e as StudentsChangedEventArgs;
            _journal.Add(new JournalEntry(e.CollectionName, e.ActionType, e.SourceOfChanges, e.Key));
        }

        public override string ToString()
        {
            string JournalString = "";
            foreach (var journal in _journal)
            {
                JournalString = JournalString + journal.ToString() + "\n";
            }
            return JournalString;
        }

        public void DeleteChanges(Student student)
        {
            foreach (JournalEntry change in _journal)
            {
                if(change.Key==student.ToString())
                {
                    _journal.Remove(change);
                }
            }
        }
    }
}
