using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class BaseClass
    {
        public class IEntity
        {
            public Guid uID;
            
            public Guid EntityID
            {
                get { return this.uID; }
                set { uID = value ;  } 
            }

        }
    }
}
