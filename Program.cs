namespace PolymorphicTest;

using System.Text.Json.Serialization;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Name")]
internal record Foo(
    [property: JsonPropertyName("name")]
    string Name);

internal class Program
{
    static void Main()
    {
    }
}
