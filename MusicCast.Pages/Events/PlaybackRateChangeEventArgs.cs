namespace MusicCast.Pages.Events;

public class PlaybackRateChangeEventArgs : EventArgs
{
    public double PlaybackRate { get; set; }
}
