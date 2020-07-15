using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AIMCustomForm
{
    [ComVisible(true)]
    [Guid("957FE39A-87C7-44F9-8DB6-A3C98B816231")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IMenuItem
    {
        [DispId(1)]
        void Init();

        [DispId(2)]
        void DeInit();

        [DispId(3)]
        string Display(string loadXml);
    }
}
