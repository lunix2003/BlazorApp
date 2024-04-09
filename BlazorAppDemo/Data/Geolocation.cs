using Microsoft.JSInterop;

namespace BlazorAppDemo.Data
{
    public class Geolocation
    {
        private readonly IJSRuntime js;
        public Geolocation(IJSRuntime js)
        {
            this.js = js;
        }
        public async ValueTask<bool> HasGeolocationFeature() => await js.InvokeAsync<bool>("blazorGeolocation.hasGeolocaitonFeature");
    }
}
