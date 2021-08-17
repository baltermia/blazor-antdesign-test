using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace blazor_antdesign_test.Data
{
    public class Global
    {
        private readonly IJSRuntime JSRuntime;

        /// <summary>
        /// Creates a nwe instance of the Global class
        /// </summary>
        /// <param name="JSRuntime">The injected JSRuntime of the page</param>
        public Global(IJSRuntime JSRuntime)
        {
            this.JSRuntime = JSRuntime;
        }

        /// <summary>
        /// Will display the javascript alert box on top over the page
        /// </summary>
        /// <param name="message">What text should be displayed in the alert box</param>
        public async Task Alert(string message)
        {
            await JSRuntime.InvokeVoidAsync("alert", message);
        }

        /// <summary>
        /// Will display the javascript alert box on top over the page
        /// </summary>
        /// <param name="JSRuntime">The injected JSRuntime of the page</param>
        /// <param name="message">What text should be displayed in the alert box</param>
        public static async Task Alert(IJSRuntime JSRuntime, string message)
        {
            await JSRuntime.InvokeVoidAsync("alert", message);
        }
    }
}
