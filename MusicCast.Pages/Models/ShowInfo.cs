using MusicCast.Shared;

namespace MusicCast.Pages.Models;

public record ShowInfo
{
    public string Id { get; init; } = default!;
    public string Title { get; init; } = default!;
    public string Author { get; init; } = default!;
    public string Image { get; init; } = default!;

    public ShowInfo() { }

    public ShowInfo(string id, string title, string author, string image) =>
        (Id, Title, Author, Image) = (id, title, author, image);

    public ShowInfo(Show show) =>
        (Id, Title, Author, Image) = (show.Id, show.Title, show.Author, show.Image);
}

