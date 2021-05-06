using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW.Factories
{
    public static class FormFactory
    {
        public static T OpenForm<T>()
        {
            return (T)Program.ServiceProvider.GetService(typeof(T));
        }
        public static T OpenForm<T>(object obj = null)
        {
            return (T)Program.ServiceProvider.GetService(typeof(T));
        }
    }
}
