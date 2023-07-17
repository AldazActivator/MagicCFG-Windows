using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace MagicCFG
{
    internal class Classx
    {
        protected enum Enum0 : uint
        {
            const_0,
            const_1
        }

        protected static readonly string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "inf");

        [CompilerGenerated]
        private string string_1;

        [CompilerGenerated]
        private string string_2;

        public string String_0
        {
            [CompilerGenerated]
            get
            {
                return string_1;
            }
            [CompilerGenerated]
            set
            {
                string_1 = value;
            }
        }

        public string String_1
        {
            [CompilerGenerated]
            get
            {
                return string_2;
            }
            [CompilerGenerated]
            set
            {
                string_2 = value;
            }
        }

        [DllImport("setupapi.dll", SetLastError = true)]
        protected static extern bool SetupUninstallOEMInf(string InfFileName, Enum0 Flags, IntPtr Reserved);

        public Classx(string infFilePath)
        {
            String_0 = Path.GetFileName(infFilePath);
            string input = File.ReadAllText(infFilePath);
            Regex regex = new Regex("Provider[\\s]*=[\\s]*(.*)", RegexOptions.IgnoreCase);
            Match match = regex.Match(input);
            regex = new Regex("CatalogFile[\\s]*=[\\s]*(.*)", RegexOptions.IgnoreCase);
            match = regex.Match(input);
            if (match.Success)
            {
                String_1 = match.Groups[1].Value.Trim();
            }
        }

        public static string[] smethod_0()
        {
            return Directory.GetFiles(string_0, "oem*.inf", SearchOption.TopDirectoryOnly);
        }
    }
}
