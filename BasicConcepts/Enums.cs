using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts
{
    enum WeekDays : byte
    {
        Monday = 1,
        Tuesday = 2, //assign different values to enum member.
        Wedsnesday = 3,
        Thrusday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 0
    }

    //enum is an abstract class.
    //used to assign constant names to a group of numeric integer values.
    

    //The enum can be of any numeric data type such as byte, sbyte, short, ushort, int, uint, long, or ulong. However, an enum cannot be a string type.


    //Enum Values
    //If values are not assigned to enum members, then the compiler will assign integer values to each member
    //starting with zero by default. The first member of an enum will be 0, and the value of each successive
    //enum member is increased by 1.
}
