using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class StudentsChangedEventArgs : EventArgs
    {
        public string CollectionName { get; set; }
        public Action ActionType { get; set; }
        public string SourceOfChanges { get; set; }
        public Student Key { get; set; }

        public StudentsChangedEventArgs(string collection_name, Action action_type, string source_of_changes, Student key)
        {
            CollectionName = collection_name;
            ActionType = action_type;
            SourceOfChanges = source_of_changes;
            Key = key;
        }

        public override string ToString()
        {
            return "Название коллекции: " + CollectionName + "\nТип действия: " + ActionType + "\nИсточник действия: " + SourceOfChanges + "" + Key.ToString();
        }
    }
}
