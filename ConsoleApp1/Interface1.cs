using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    interface Interface1
    {
        public abstract void ReadFile(string path);//You cannot apply access modifiers to interface members. All the members are public by default

        void WriteFile(string path);//An interface can only contain declarations but not implementations.

        //int id;
        static int id2 = 1;
    }

    //can contain declarations of methods, properties, indexers, and events.
    //However, it cannot contain fields, auto-implemented properties.

    //Interface can inherits multiple interface.
}
