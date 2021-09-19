using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorStore.Services
{
    public class LocalStorageService
    {
        private readonly IJSRuntime jSRuntime;
        private readonly CounterStateService CounterModel;

        public LocalStorageService(IJSRuntime jSRuntime, CounterStateService CounterModel)
        {
            this.jSRuntime = jSRuntime;
            this.CounterModel = CounterModel;
        }

        public async Task SaveAsync()
        {
            var data = JsonSerializer.Serialize(CounterModel);
            await jSRuntime.InvokeAsync<object>(
                "stateManager.save", nameof(CounterStateService), data);

        }

        public async Task LoadAsync()
        {
            string data;
            data = await jSRuntime.InvokeAsync<string>("stateManager.load", nameof(CounterStateService));
            if (!string.IsNullOrEmpty(data))
            {
                try
                {
                    var model = JsonSerializer.Deserialize<CounterStateService>(data);
                    if (model != null)
                    {
                        CounterModel.CounterCount = model.CounterCount;
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}