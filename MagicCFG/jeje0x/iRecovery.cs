/*
 * 
 * Developed By Gerson Aldaz [ AldazActivator ]
 * if you wanna source full dm telegram @gerson_5
 * 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCFG
{
    public static class iRecovery
    {
        private static int deviceInfoLock = 0;
        public static bool getIdeviceInfo()
        {

            Process ideviceinfo = new Process();

            ideviceinfo.StartInfo.FileName = Environment.CurrentDirectory + "/resources/import/irecovery.exe";

            ideviceinfo.StartInfo.Arguments = "-q";

            ideviceinfo.StartInfo.UseShellExecute = false;

            ideviceinfo.StartInfo.RedirectStandardOutput = true;

            ideviceinfo.StartInfo.CreateNoWindow = true;

            ideviceinfo.Start();

            var lines = 0;

            while (!ideviceinfo.StandardOutput.EndOfStream)
            {
                lines++;

                string line = ideviceinfo.StandardOutput.ReadLine();

                var text2 = line.Replace("\r", "");

                if (text2.StartsWith("ECID: "))
                {

                    var text3 = text2.Replace("ECID: ", "");

                    var textecid = text3.Replace("0x", "");

                    iOSDevice.ECID = textecid.Trim().ToUpper();


                }


                else if (text2.StartsWith("PWND: "))
                {
                    var text3 = text2.Replace("PWND: ", "");

                    iOSDevice.ipwndfu = text3;

                }

                else if (text2.StartsWith("PRODUCT: "))
                {
                    var text3 = text2.Replace("PRODUCT: ", "");

                    iOSDevice.ProductType = text3;

                }


                else if (text2.StartsWith("CPID: "))
                {
                    var text3 = text2.Replace("CPID: 0x", "");

                    iOSDevice.CPID = text3;


                }

                else if (text2.StartsWith("NAME: "))
                {
                    var text3 = text2.Replace("NAME: ", "");


                    iOSDevice.Model = text3;


                }

                else if (text2.StartsWith("MODEL: "))
                {
                    var text3 = text2.Replace("MODEL: ", "");

                    iOSDevice.HWM = text3;



                }


                else if (text2.StartsWith("MODE: "))
                {
                    var text3 = text2.Replace("MODE: ", "");

                    iOSDevice.Mode = text3;



                }

            }

            Interlocked.Exchange(ref deviceInfoLock, 0);

            if (lines <= 2)
            {
                return false;
            }

            return true;
        }


        public static void Logs(string messageCFG)
        {


            MainCFG form1 = Application.OpenForms.OfType<MainCFG>().FirstOrDefault();
            if (form1 != null)
            {
                form1.LogMessage($"{messageCFG}");
            }

        }

        public static void IRecovery(string arg, string rmdisk, out string output, out string error)
        {
            output = "";

            error = "";

            Console.WriteLine(rmdisk);

            try

            {

                Process process = new Process();

                process.StartInfo.FileName = $".\\resources\\import\\irecovery.exe";

                process.StartInfo.Arguments = $"{arg} {rmdisk} -v";

                process.StartInfo.UseShellExecute = false;

                process.StartInfo.RedirectStandardOutput = true;

                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.StartInfo.CreateNoWindow = true;

                process.Start();

                output = process.StandardOutput.ReadToEnd();

                error = process.StandardError.ReadToEnd().ToLower();

                if (output.Contains("File not found"))
                {

                }

                Console.WriteLine("my out: " + output);

                Console.WriteLine("-> error: " + error);

                process.WaitForExit();

                Thread.Sleep(4000);


            }
            catch (Exception ex)
            {
                Console.WriteLine("IRecovery failed: " + ex);
            }


        }
    }
}
