using System.Collections.Generic;

namespace Administrador.Persistence.Entities
{
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}