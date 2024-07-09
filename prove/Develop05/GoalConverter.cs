using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

[JsonConverter(typeof(GoalConverter))]
public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            var typeDiscriminator = root.GetProperty("TypeDiscriminator").GetString();

            switch (typeDiscriminator)
            {
                case "ChecklistGoal":
                    return JsonSerializer.Deserialize<ChecklistGoal>(root.GetRawText(), options);
                case "EternalGoal":
                    return JsonSerializer.Deserialize<EternalGoal>(root.GetRawText(), options);
                case "SimpleGoal":
                    return JsonSerializer.Deserialize<SimpleGoal>(root.GetRawText(), options);
                default:
                    throw new NotSupportedException($"Unknown goal type {typeDiscriminator}");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("TypeDiscriminator", value.GetType().Name);
        writer.WritePropertyName("Data");
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
        writer.WriteEndObject();
    }
}