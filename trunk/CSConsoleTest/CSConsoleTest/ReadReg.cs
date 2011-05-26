using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace CSConsoleTest
{
    class ReadReg
    {
        public void readReg()
        {
            using (RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Uninstall", false))
            {
                if (key != null)
                {
                    RegistryKey k = key.OpenSubKey("Digital Editions");
                    if (k != null)
                        Console.WriteLine(k.GetValue("UninstallString", ""));
                    foreach (string keyName in key.GetSubKeyNames())
                    {
                        using (RegistryKey key2 = key.OpenSubKey(keyName, false))
                        {
                            if (key2 != null)
                            {
                                string softwareName = key2.GetValue("DisplayName", "").ToString();
                                string installLocation = key2.GetValue("InstallLocation", "").ToString();
                                if (!string.IsNullOrEmpty(installLocation))
                                {
                                    if (softwareName.StartsWith("a")||softwareName.StartsWith("A"))
                                    Console.Write(string.Format("软件名：{0} -- 安装路径：{1}\r\n", softwareName, installLocation));
                                    //Console.Write(string.Format("软件名：{0}\n", softwareName));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
