using System;
using System.Collections.Generic;

namespace NotelyApp.Models.Repositories
{
    public interface INoteRepository
    {
        void DeleteNote(NoteModel noteModel);
        NoteModel FindNoteById(Guid id);
        void SaveNote(NoteModel noteModel);
        IEnumerable<NoteModel> GetAllNotes();
    }
}