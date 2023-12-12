using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCast.Components;


public class ClipboardInterop
{
    private readonly IJSRuntime _jsRuntime;

    public ClipboardInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public ValueTask<string> ReadTextAsync() =>
        _jsRuntime.InvokeAsync<string>("navigator.clipboard.readText");

    public ValueTask WriteTextAsync(string text) =>
        _jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
}