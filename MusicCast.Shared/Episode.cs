namespace MusicCast.Shared;

public record Episode(
    string Id,
    string Title,
    string Description,
    string Explicit,
    DateTime Published,
    TimeSpan? Duration,
    string Url);
