using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Typesense;

public record SchemaUpdate
{
    [JsonPropertyName("fields")]
    public IEnumerable<IField> Fields { get; init; }

    [Obsolete("Use multi-arity constructor instead.")]
    public SchemaUpdate()
    {
        Fields = new List<IField>();
    }

    public SchemaUpdate(IEnumerable<IField> fields)
    {
        Fields = fields;
    }
}
