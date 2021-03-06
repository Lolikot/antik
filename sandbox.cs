using System;

namespace AntiSandbox
{
    internal sealed class SandBox
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        
        public static bool Check()
        {
            string[] dlls = new string[5]
            {
                "SbieDll.dll",
                "SxIn.dll",
                "Sf2.dll",
                "snxhk.dll",
                "cmdvrt32.dll"
            };
            for (int i = 0; i < dlls.Length; i++)
                if (GetModuleHandle(dlls[i]).ToInt32() != 0)
                    return true;
            return false;
        }

    }
}
