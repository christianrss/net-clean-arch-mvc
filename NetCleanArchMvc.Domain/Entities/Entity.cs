using System;

namespace NetCleanArchMvc.Domain.Entities;

public abstract class Entity
{
    public int Id { get; protected set; }
}
