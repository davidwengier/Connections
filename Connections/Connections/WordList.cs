using System.Text.Json.Serialization;

namespace Connections;

public record Game
{
    [JsonPropertyName("startingGroups")]
    public required string[][] StartingGroups { get; init; }

    [JsonPropertyName("groups")]
    public required Dictionary<string, WordGroup> Groups { get; init; }
}

public record WordGroup(
    [property: JsonPropertyName("level")]
    int Level,

    [property: JsonPropertyName("members")]
    string[] Members);
