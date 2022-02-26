using System;

namespace DownNotifier.Entities.Model
{
    public interface IEntity
    {
        Guid Id { get; set; }
        public bool IsDeleted { get; set; } 
        public DateTime CreateDate { get; set; }    
        public DateTime UpdateDate { get; set; }   
    }
}