﻿using System.Text.Json.Serialization;

namespace Geodatenbezug.Models;

/// <summary>
/// Represents the success response for downloads/export.json.
/// </summary>
public record GeodiensteExportSuccess
{
    /// <summary>
    /// The info message.
    /// </summary>
    [JsonPropertyName("info")]
    public required string Info { get; set; }
}
