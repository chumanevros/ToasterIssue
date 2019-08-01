using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToasterTest.Shared
{
    public interface ITest
    {
        void Info(Sotsera.Blazor.Toaster.IToaster Toaster);
    }
    public class Test : ITest
    {
        public Test(Sotsera.Blazor.Toaster.IToaster Toaster)
        {
            this._Toaster = Toaster;
        }

     
        [Inject]
        public Sotsera.Blazor.Toaster.IToaster _Toaster { get; set; }

        public void Info(Sotsera.Blazor.Toaster.IToaster Toaster)
        {
            // Console.WriteLine("Toaster:" + _Toaster.ToString()); // This shouws Toaster is initialized
            _Toaster.Info("This Toaster does not display"); 
            Toaster.Error("This Toaster is displaying");
        }
    }
}
