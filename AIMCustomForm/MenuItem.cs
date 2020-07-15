using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMCustomForm
{
    [ComVisible(true)]
    [Guid("F0C79255-AB2D-4F88-89C1-A2A40AC35027")]
    [ClassInterface(ClassInterfaceType.None)]
    [ProgId("AIMCustomForm.MenuItem.Test")]
    public class MenuItem : IMenuItem
    {
        public void Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        public void DeInit()
        {
        }
        public string Display(string aimStatusXml)
        {
            var form = new Form1();
            form.setStatus(aimStatusXml);
            Application.Run(form);
            form.Dispose();
            return aimStatusXml;
        }
    }
}
