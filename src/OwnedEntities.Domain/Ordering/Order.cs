using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace OwnedEntities.Ordering
{
  public class Order : FullAuditedAggregateRoot<Guid>
  {
    public IEnumerable<OrderLine> OrderLines { get; set; }
  }

  public class OrderLine : CreationAuditedEntity<Guid>
  {
    public Guid OrderId { get; set; }
  }
}