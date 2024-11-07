using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SourceGenerator.Sample.DtoGenerator;

public class Person
{
    public long Id { get; init; }
    
    public string Name { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }
    
    public ICollection<Cow> Cows { get; set; } = [];
}