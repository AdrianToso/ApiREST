using ApiRESTAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRESTEntities
{
   public abstract class Entity :IEntity
    {
        public int Id { get; set; }

    }
}
