using System.Text.Json.Serialization;

namespace my_school_front.Models;

public class Student
{
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("address")]
    public required string Address { get; set; }
}