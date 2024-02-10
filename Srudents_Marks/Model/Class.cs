using System;
using System.Collections.Generic;

namespace Srudents_Marks.Model
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
