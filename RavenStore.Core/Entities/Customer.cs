using RavenStore.Core.ValueObjects;

namespace RavenStore.Core.Entities;

public class Customer : Entity
{
    public Customer(Name name, Email email)
    {
        Name = name;
        Email = email;
    }

    public Name Name { get; }
    public Email Email { get; }
}