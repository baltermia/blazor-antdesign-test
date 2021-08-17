using BlazorMedia;
using BlazorMedia.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System;

namespace blazor_antdesign_test.Shared
{
    public partial class Scanner
    {
        [Parameter]
        public string DividerTopMargin { get; set; }

        [Parameter]
        public string Height { get; set; }

        [Parameter]
        public string Width { get; set; }

        [Parameter]
        public string SelectedCamera { get; set; } = string.Empty;

        [Inject]
        private IJSRuntime JSRuntime { get; set; }
        private VideoMedia CameraControl { get; set; }
        private IEnumerable<MediaDeviceInfo> Cameras { get; set; } = Enumerable.Empty<MediaDeviceInfo>();
        private BlazorMediaAPI MediaAPI { get; set; }
        private int ResWidth { get; set; } = 1920;
        private int ResHeight { get; set; } = 1080;
        private bool ShowCamera { get; set; } = false;

        protected override async void OnInitialized()
        {
            MediaAPI = new BlazorMediaAPI(JSRuntime);

            await base.OnInitializedAsync();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await MediaAPI.StartDeviceChangeListenerAsync();
                await FetchCamerasAsync();
                await InvokeAsync(StateHasChanged);
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        private async void OnError(MediaError error)
        {
            await JSRuntime.InvokeVoidAsync("alert", error.Message);
        }

        private async Task FetchCamerasAsync()
        {
            IEnumerable<MediaDeviceInfo> Devices = await MediaAPI.EnumerateMediaDevices();

            Cameras = Devices.Where(d => d.Kind == MediaDeviceKind.VideoInput);

            if (Cameras.Any() && !Cameras.Any(d => d.DeviceId == SelectedCamera))
            {
                SelectedCamera = Cameras.ElementAt(0).DeviceId;

                ShowCamera = true;
            }
        }
    }
}
