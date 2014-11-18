using Entity.Notes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactor
{
    public class NoteInteractions
    {

        public Note Create(string CreatedBy, string title, string noteText)
        {
            return new Note(CreatedBy, title, noteText);
        }
    }
}
