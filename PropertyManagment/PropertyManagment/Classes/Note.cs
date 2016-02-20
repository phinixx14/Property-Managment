using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagment
{
    public class Note
    {
        private static int NextID { get; set; }
        public string WrittenBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string Text { get; set; }
        public string NoteID { get; private set; }

        public Note()
        {
            NoteID = "Note_" + NextID++;
        }
    }
}
