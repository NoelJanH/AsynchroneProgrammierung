using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchroneProgrammierung
{
    public interface IExampleSystem
    {
        Task<string> GetContentAsync(string url);

        void AsyncVoidExceptions_CannotBeCaughtByCatch();

        void ThowException_CanBeCaughtByCatch();   
    }
}
