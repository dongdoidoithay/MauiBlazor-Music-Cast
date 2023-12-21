using Microsoft.AspNetCore.Components;

namespace MusicCast.Pages.Events;
//components
[EventHandler("onanimationend", typeof(EventArgs),
    enableStopPropagation: true, enablePreventDefault: false)]

[EventHandler("oncustomdurationchange", typeof(DurationChangeEventArgs),
    enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("oncustomtimeupdate", typeof(TimeUpdateEventArgs),
    enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("playbackratechange", typeof(PlaybackRateChangeEventArgs),
    enableStopPropagation: true, enablePreventDefault: true)]
public static class EventHandlers
{
}
