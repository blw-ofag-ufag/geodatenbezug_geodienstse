﻿using Geodatenbezug.Models;

namespace Geodatenbezug;

/// <summary>
/// Interface for the geodienste.ch API.
/// </summary>
public interface IGeodiensteApi
{
    /// <summary>
    /// Gets the information about all the topics from geodienste.ch.
    /// </summary>
    Task<List<Topic>> RequestTopicInfoAsync();

    /// <summary>
    /// Starts the export of a topic at geodienste.ch.
    /// </summary>
    Task<HttpResponseMessage> StartExportAsync(Topic topic, string token, int attempts = 0);

    /// <summary>
    /// Checks the status of the export of a topic at geodienste.ch and returns the download URL if the export is complete.
    /// </summary>
    Task<HttpResponseMessage> CheckExportStatusAsync(Topic topic, string token, int attempts = 0);
}
