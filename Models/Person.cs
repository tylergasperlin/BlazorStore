using Microsoft.JSInterop;

namespace BlazorStore.Models
{
    public class Person
    {
        public string Name { get; set; }

        [JSInvokable]
        public string SayHello(string greeting) {
            return $"Hello {Name}, {greeting}";
        }
    }
}