using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        //public EntityNotFoundException(string entityId, string entityType)
        //    : base($"Entity with id {entityId} of type {entityType} does not exist.")
        //{ }

        public EntityNotFoundException()
           : base("This user doesnt exist")
        { }
    }
}
