using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnorexNotes.Models
{
    public class RegisterNote
    {
        public int UserId { get; set; }

        public string  NoteTitle { get; set; }

        public string Note { get; set; }
    }
}
