using Microsoft.AspNetCore.Components;

namespace MusicCast.Components.Events;


[EventHandler("onanimationend", typeof(EventArgs),
    enableStopPropagation: true, enablePreventDefault: false)]
public static class EventHandlers
{
}
