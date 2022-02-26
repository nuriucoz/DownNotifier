using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace DownNotifier.Entities.Model
{
    [Index(nameof(CreateDate), IsUnique = false)]
    public class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;

        }

        [Key]
        public Guid Id { get; set; }
        public virtual DateTime CreateDate { get; set; }
        public virtual DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}

