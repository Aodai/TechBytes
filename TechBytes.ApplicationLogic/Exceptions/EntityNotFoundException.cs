using System;
using System.Collections.Generic;
using System.Text;

namespace TechBytes.ApplicationLogic.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public Guid EntityID { get; private set; }
        public EntityNotFoundException(Guid id) : base($"Entity with id {id} was not found") { }
        public EntityNotFoundException() : base() { }
        public EntityNotFoundException(string message) : base(message) { }
        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException) { }
    }
}
