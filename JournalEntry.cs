using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class JournalEntry
    {
        public string CollectionName { get; set; }
        public Action ActionType { get; set; }
        public string SourceOfChanges { get; set; }
        public string Key { get; set; }

        public JournalEntry(string collection_name, Action action_type, string source_of_changes, Student key)
        {
            CollectionName = collection_name;
            ActionType = action_type;
            SourceOfChanges = source_of_changes;
            Key = key.ToString();
        }

        public override string ToString()
        {
            return "Название коллекции: " + CollectionName + "\nТип действия: " + ActionType + "\nИсточник действия: " + SourceOfChanges + "" + Key;
        }
    }
}
