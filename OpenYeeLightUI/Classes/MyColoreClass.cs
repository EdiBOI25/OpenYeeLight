using Colore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenYeeLightUI.Classes
{
    internal static class MyColoreClass
    {
        private static IChroma _chroma;

        public static async Task<IChroma> GetInstanceAsync()
        {
            if (_chroma != null)
            {
                return _chroma;
            }

            // Or use CreateRestAsync() if you need/want the Chroma REST API.
            _chroma = await ColoreProvider.CreateNativeAsync();

            return _chroma;
        }
    }
}
