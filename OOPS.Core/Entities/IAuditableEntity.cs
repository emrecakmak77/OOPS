using System;
namespace OOPS.Core.Entities
{
    public interface IAuditableEntity<T> where T : struct
    {
        T CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        T? UpdatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
    }
}
