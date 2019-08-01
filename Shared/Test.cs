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
            // Console.WriteLine("Toaster:" + _Toaster.ToString());
            _Toaster.Info("Inside a class with async Info Toaster"); 
            Toaster.Error(" Inside a class with async Error Toaster");
        }
    }
}
