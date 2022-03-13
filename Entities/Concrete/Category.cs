using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
