using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._19
{
    internal class HomeRoomTeacher
    {
        
            public string Name { get; set; }
            public string OMId { get; set; }
            public bool hasClass { get; set; }
            public string ClassLabel { get; set; }
            public int ClassLevel { get; set; }

            public HomeRoomTeacher()
            {

            }
            public HomeRoomTeacher(string name, string OMId, bool hasClass, string label, int level)
            {
                this.Name = name;
                this.OMId = OMId;
                this.hasClass = hasClass;
                this.ClassLabel = label;
                this.ClassLevel = level;
            }

            public override string ToString()
            {
                return "A " + this.Name + " nevű tanár a " + this.ClassLevel + this.ClassLabel + " osztály osztályfőnöke.";
            }

            public bool isTheirHomeRoomTEacher(Student otherStudent)
            {
                if (otherStudent == null)
                {
                    return false;
                }
                if (!this.hasClass)
                {
                    return false;
                }
                return this.ClassLevel == otherStudent.ClassLevel && this.ClassLabel == otherStudent.ClassLabel;
            }
        
    }
}
