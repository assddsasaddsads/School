//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarksSet
    {
        public int Id { get; set; }
        public int IdStudents { get; set; }
        public int IdSubjects { get; set; }
        public int Mark { get; set; }
    
        public virtual StudentsSet StudentsSet { get; set; }
        public virtual SubjectsSet SubjectsSet { get; set; }
    }
}