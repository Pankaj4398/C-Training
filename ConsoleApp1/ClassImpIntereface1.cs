using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class ClassImpIntereface1 : Interface1
    {
        public void ReadFile(string path) //Interface members must be implemented with the public modifier
        {
            throw new NotImplementedException();
        }

        public void WriteFile(string path)
        {
            throw new NotImplementedException();
        }
    }

    //A class or a Struct can implement one or more interfaces using colon (:).

    /*Explicit Implementation
     * An interface can be implemented explicitly using <InterfaceName>.<MemberName>. 
     * Explicit implementation is useful when class is implementing multiple interfaces; thereby, it is more readable and eliminates the confusion. 
    It is also useful if interfaces have the same method name coincidently.
    Do not use public modifier with an explicit implementation. It will give a compile-time error.*/
}
