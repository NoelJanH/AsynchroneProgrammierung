using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchroneProgrammierung
{
    internal class ExampleSystem : IExampleSystem
    {
        public async Task<string> GetContentAsync(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                return response;
            }

        }

        private async void ThrowExceptionAsync()
        {
            throw new InvalidOperationException();
        }

        public void AsyncVoidExceptions_CannotBeCaughtByCatch()
        {
            try
            {
                ThrowExceptionAsync();
            }
            catch (Exception)
            {
                // The exception is never caught here!
                throw;
            }
        }

        private void ThowException()
        {            
             throw new InvalidOperationException();                      
        }

        public void ThowException_CanBeCaughtByCatch()
        {
            try
            {
                ThowException();
            }
            catch (Exception)
            {
                // The exception is caught here!
                throw;
            }
        }
    }
}
