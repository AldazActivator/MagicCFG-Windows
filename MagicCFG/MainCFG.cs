/*
 * 
 * Developed By Gerson Aldaz [ AldazActivator ]
 * if you wanna source full dm telegram @gerson_5
 * 
 */

using LibUsbDotNet.DeviceNotify;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace MagicCFG
{
    public partial class MainCFG : Form
    {

        public static IDeviceNotifier UsbDeviceNotifier = DeviceNotifier.OpenDeviceNotifier();

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool IsWow64Process(IntPtr hProcess, out bool Wow64Process);

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool Wow64DisableWow64FsRedirection(out IntPtr OldValue);


        public string CFGAction = "";

        public MainCFG()
        {
            InitializeComponent();

            ReadMethod();

            InitializeDictionary();

            LogMessage("Welcome MagicCFG Windows\nDeveloped BY: @iAldazActivator Based on MagicCFG Mac from @J4NF4");

            UsbDeviceNotifier.Enabled = true;
        }


        public void DoPurpleMode()
        {

            iRecovery.getIdeviceInfo();

            if (iOSDevice.Mode.StartsWith("") && iOSDevice.ECID == "")
            {

                MessageBox.Show(@"No Device Dectected in Normal Mode! ", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }


            if (iOSDevice.Mode.StartsWith("Recovery") && iOSDevice.ECID != null)
            {

                MessageBox.Show(@"No Device Dectected in DFU Mode! ", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }


            if (!Support()) {

                MessageBox.Show(@"Sorry,This Device is not Supported", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            


            if (iOSDevice.ipwndfu == "" || iOSDevice.ipwndfu == "N/A") 
            {

                ipwndfu gaster = new ipwndfu();

                if (!gaster.Pwndevice())
                {
                    MessageBox.Show("[ERROR]\n\nNo Pudo Entrar En PWNDFU Prueba Intentando De Nuevo,\n\nSi El Problema Persiste Reinicia La Pc, Se Reiniciara La Tool, Espera...\n\nFailed to enter PWNDFU Try Trying Again,If the problem persists, restart the PC", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

            }


            Bootx PM = new Bootx();

            if (!PM.boot()) 
            {
                return;
            }


        }





        public bool Support() 
        {
            string filePath = $".\\resources\\diags\\{iOSDevice.ProductType}.CFG"; // Ruta del archivo que deseas verificar

            if (File.Exists(filePath))
            {
                return true;
            }

            return false;

        }

        private void backgroundWorkerCFG_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (CFGAction == "PurpleMode")
                {

                    DoPurpleMode();
                }
                if (CFGAction == "Read")
                {
                    Openport();
                    ReadNandDataDevice("SrNm", "Serial");
                }
            }
            catch
            {


            }
            finally 
            {
                DetenerAnimacion();
                DiagButton.Enabled = true;

            }
         
        }

        private void DiagButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            DiagButton.Enabled = false;
            UsbDeviceNotifier.Enabled = false;
            IniciarAnimacion();
            CFGAction = "PurpleMode";

            backgroundWorkerCFG.RunWorkerAsync();

        }

        private void DriverRepairButton_Click(object sender, EventArgs e)
        {
            DriverRepair ShowForm = new DriverRepair();
            ShowForm.ShowDialog();
        }








        public void ReadNandDataDevice(string infoShow, string key) 

        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Please open the serial port first", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string textxx = "syscfg print " + infoShow + "";

            if (key == "nandsize") {

                textxx = "nandsize";
            }
            
            
            Console.WriteLine(textxx);

            serialPort.WriteLine(textxx);

            Thread.Sleep(500);

            string text2xx = serialPort.ReadExisting();

            if (key == "Serial")
            {

                int num = text2xx.IndexOf(key + ":") + key.Length + 1;
                int num2 = text2xx.IndexOf("\n", num);
                string s = text2xx.Substring(num + 1, num2 - num);
                TextBoxSerial.Text = s;
                iOSDevice.SerialNumber = s;
                serialPort.DiscardInBuffer();

            }
            else if (key == "WMac")
            {


                string Wifi = ExtractValue(text2xx, "Mac");
                Wifi = MakeHex(Wifi);
                Wifi = RemoveDangerousCharsForSYSCFG(Wifi);
                Wifi = Wifi.Substring(0, Math.Min(12, Wifi.Length));
                Wifi = Wifi.Inserting(":", 2);

                Console.WriteLine(Wifi);


                LogMessage(text2xx);

                WMacText.Text = Wifi;

                /*
                string value = RemoveTheFuckingChars(text2xx, key);
                string input = text2xx.Replace("syscfg print " + key, "");
                MatchCollection hexMatches = Regex.Matches(input, "0x[0-9A-Fa-f]+");

                // Almacenar los valores hexadecimales en una lista
                List<string> hexValues = new List<string>();
                foreach (Match match in hexMatches)
                {
                    hexValues.Add(match.Value);
                }

                // Unir los valores hexadecimales en una cadena separados por "; - "
                string result = string.Join("", hexValues);

                string Wifi = MakeHex(result);
                //RemoveDangerousCharsForSYSCFG(ref Wifi);
                Wifi = Wifi.Substring(0, Math.Min(12, Wifi.Length));
                Wifi = Wifi.Inserting(":", 2);
                WMacText.Text = Wifi;

                */
            }
            else if (key == "BMac")
            {

                string Wifi = ExtractValue(text2xx, "Mac");
                Wifi = MakeHex(Wifi);
                Wifi = RemoveDangerousCharsForSYSCFG(Wifi);
                Wifi = Wifi.Substring(0, Math.Min(12, Wifi.Length));
                Wifi = Wifi.Inserting(":", 2);

                Console.WriteLine(Wifi);

                LogMessage(text2xx);

                BMacTxt.Text = Wifi;
            }

            else if (key == "EMac")
            {

                string Wifi = ExtractValue(text2xx, "Mac");
                Wifi = MakeHex(Wifi);
                Wifi = RemoveDangerousCharsForSYSCFG(Wifi);
                Wifi = Wifi.Substring(0, Math.Min(12, Wifi.Length));
                Wifi = Wifi.Inserting(":", 2);

                Console.WriteLine(Wifi);

                LogMessage(text2xx);

                EMacText.Text = Wifi;

            }
            else if (key == "nandsize") 
            {

                Match match = Regex.Match(text2xx, @"0x([0-9A-Fa-f]+)");
                if (match.Success)
                {
                    string nandSizeHex = match.Groups[1].Value;

                    switch (deviceAge)
                    {
                        case 1:
                            ulong result = Convert.ToUInt64(nandSizeHex, 16);
                            ulong actualNANDSize = (result * 1024) / 1000000000;
                            string nandSize = $"{actualNANDSize}GB";
                            Console.WriteLine(nandSize);

                            LblNand.Text = nandSize;
                            // Update the NANDSizeLabel with nandSize
                            break;

                        case 2:
                            nandSizeHex = nandSizeHex.Remove(nandSizeHex.Length - 4);
                            ulong result2 = Convert.ToUInt64(nandSizeHex, 16);
                            ulong actualNANDSize2 = (result2 * 1024) / 1000000000;
                            string nandSize2 = $"{actualNANDSize2}GB";
                            LblNand.Text = nandSize2;
                            Console.WriteLine(nandSize2);
                            // Update the NANDSizeLabel with nandSize2
                            break;

                        default:
                            Console.WriteLine("ERROR");
                            // Update the NANDSizeLabel with "ERROR"
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid output format.");
                }
            }
            else
            {
                string Result = ExtractValue(text2xx, key);

                Console.WriteLine(Result);

                LogMessage(Result);

                if (key == "Regn") { RegionText.Text = Result; }
                if (key == "MLB#") { MlbText.Text = Result; }
                if (key == "Mod#") { ModeTextB.Text = Result; }
                if (key == "RMd#") { ModelTextB.Text = Result; }
                if (key == "NvSn") { NVSNTEXT.Text = Result; }
                if (key == "NSrN") { NSRNTEXT.Text = Result; }
                if (key == "LCM#") { LCMTEXT.Text = Result; }
                if (key == "BCMS") { BCMS_TEXT.Text = Result; }
                if (key == "FCMS") { FCMS_TEXT.Text = Result; }
                if (key == "MtSN") { MTSNTEXT.Text = Result; }
                //BCMS
            }

        }

        
        private void ReadCDFGButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            IniciarAnimacion();

            if (!Openport()) 
            {
                DetenerAnimacion();
                return;
            
            }

            ReadNandDataDevice("SrNm", "Serial");
            ReadNandDataDevice("WMac", "WMac");
            ReadNandDataDevice("BMac", "BMac");
            ReadNandDataDevice("EMac", "EMac");
            ReadNandDataDevice("Regn", "Regn");
            ReadNandDataDevice("MLB#", "MLB#");
            ReadNandDataDevice("Mod#", "Mod#");
            ReadNandDataDevice("RMd#", "RMd#");
            ReadNandDataDevice("NvSn", "NvSn");
            ReadNandDataDevice("NSrN", "NSrN");
            ReadNandDataDevice("LCM#\t", "LCM#");
            ReadNandDataDevice("BCMS", "BCMS");
            ReadNandDataDevice("FCMS", "FCMS");
            ReadNandDataDevice("MtSN", "MtSN");
            ReadNandDataDevice("nandsize", "nandsize");
            // A1905
            

            if (TextBoxSerial.Text != "" && BMacTxt.Text != "" && WMacText.Text != "") 
            {
                Dissconect.Visible = false;
                connect.Visible = true;
                LBLMode.Text = "DIAG MODE";
                LBLModel.Text = GetModelByANumber(ModelTextB.Text);
                LblECID.Text = GetEcidDIAGMode();
                iOSDevice.Model = iOSDevice.DetermineModel(iOSDevice.ProductType);

                if (iOSDevice.Model.StartsWith("iPhone 6"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iPhone6sPlus;
                    connect.Image = imagenDesdeRecursos;
                }
                if (iOSDevice.Model.StartsWith("iPhone 7"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iphone7;
                    connect.Image = imagenDesdeRecursos;
                }
                if (iOSDevice.Model.StartsWith("iPhone 7 Plus"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iPhone7Plus;
                    connect.Image = imagenDesdeRecursos;
                }
                if (iOSDevice.Model.StartsWith("iPhone 8"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iphone8;
                    connect.Image = imagenDesdeRecursos;
                }
                if (iOSDevice.Model.StartsWith("iPhone 8 Plus"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iphone8Plus;
                    connect.Image = imagenDesdeRecursos;
                }
                if (iOSDevice.Model.StartsWith("iPhone X"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iphonex;
                    connect.Image = imagenDesdeRecursos;
                }
                if (iOSDevice.Model.StartsWith("iPad"))
                {
                    Image imagenDesdeRecursos = Properties.Resources.iPadblack;
                    connect.Image = imagenDesdeRecursos;
                }
                else
                {
                    Image imagenDesdeRecursos = Properties.Resources.iphone7;
                    connect.Image = imagenDesdeRecursos;

                }
            }

            DetenerAnimacion();
        }

        private void GoTerminal_Click(object sender, EventArgs e)
        {
            RunTerminalPort(TerminalBox.Text);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }



        public void WriteNandDataDevice(string infoShow, string Valor)

        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Please open the serial port first", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (infoShow == "WMac")
            {
                string NewValor = ParseMactoMacHex(Valor);
                Valor = NewValor;

            }
            else if (infoShow == "BMac")
            {
                string NewValor = ParseMactoMacHex(Valor);
                Valor = NewValor;
            }

            else if (infoShow == "EMac")
            {
                string NewValor = ParseMactoMacHex(Valor);
                Valor = NewValor;

            }
            else 
            {
                if (infoShow == "Regn") { Valor = RegionText.Text;  }
                if (infoShow == "MLB#") { Valor = MlbText.Text;  }
                if (infoShow == "Mod#") { Valor = ModeTextB.Text;  }
                if (infoShow == "RMd#") { Valor = ModelTextB.Text;  }
                if (infoShow == "NvSn") { Valor = NVSNTEXT.Text; }
                if (infoShow == "NSrN") { Valor = NSRNTEXT.Text; }
                if (infoShow == "LCM#") { Valor = LCMTEXT.Text; }
                if (infoShow == "BCMS") { Valor = BCMS_TEXT.Text;  }
                if (infoShow == "FCMS") { Valor = FCMS_TEXT.Text; }
                if (infoShow == "MtSN") { Valor = MTSNTEXT.Text; }
                if (infoShow == "SrNm") { Valor = TextBoxSerial.Text; }
               
            }

            string textxx = "syscfg add " + infoShow + " " + Valor;

            serialPort.WriteLine(textxx);

            Thread.Sleep(500);

            string text2xx = serialPort.ReadExisting();

            LogMessage(text2xx);

        }

        public void BackupNandData()

        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Please open the serial port first", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (iOSDevice.SerialNumber == "" || iOSDevice.SerialNumber == null)
            {
                MessageBox.Show("Please Read Syscfg first", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string textxx = "syscfg list";

            serialPort.WriteLine(textxx);

            Thread.Sleep(500);

            string text2xx = serialPort.ReadExisting();

            string name1 = $"{iOSDevice.ECID}_BACKUP";



            if (LblECID.Text == "" || LblECID.Text == null) 
            {
                name1 = $"{iOSDevice.SerialNumber}_BACKUP";
            }
            string nombreArchivo1 = name1 + ".txt";
            string nombreArchivo2 = "List.txt";

            string directorioBackupSysCFG = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BackupSysCFG");

            string directorioInfo = Path.Combine(directorioBackupSysCFG, $"{name1}");

            try
            {
                // Verificamos si la carpeta "BackupSysCFG" ya existe antes de crearla
                if (!Directory.Exists(directorioBackupSysCFG))
                {
                    // Creamos la carpeta "BackupSysCFG" si no existe
                    Directory.CreateDirectory(directorioBackupSysCFG);
                }

                // Verificamos si la carpeta "INFO" ya existe dentro de "BackupSysCFG" antes de crearla
                if (!Directory.Exists(directorioInfo))
                {
                    Directory.CreateDirectory(directorioInfo);
                }

                string ContenidoBueno = $"Serial : {iOSDevice.SerialNumber.Trim()}\n\n";
                ContenidoBueno += $"Ecid : {iOSDevice.ECID.Trim()}\n\n";
                ContenidoBueno += $"WMac : {WMacText.Text.Trim()}\n\n";
                ContenidoBueno += $"BMac : {BMacTxt.Text.Trim()}\n\n";
                ContenidoBueno += $"EMac : {EMacText.Text.Trim()}\n\n";
                ContenidoBueno += $"Region : {RegionText.Text.Trim()}\n\n";
                ContenidoBueno += $"MLB : {MlbText.Text.Trim()}\n\n";
                ContenidoBueno += $"Mode : {ModeTextB.Text.Trim()}\n\n";
                ContenidoBueno += $"Model : {ModelTextB.Text.Trim()}\n\n";
                ContenidoBueno += $"NVSN : {NVSNTEXT.Text.Trim()}\n\n";
                ContenidoBueno += $"NSRN : {NSRNTEXT.Text.Trim()}\n\n";
                ContenidoBueno += $"LCM : {LCMTEXT.Text.Trim()}\n\n";
                ContenidoBueno += $"BCMS : {BCMS_TEXT.Text.Trim()}\n\n";
                ContenidoBueno += $"FCMS : {FCMS_TEXT.Text.Trim()}\n\n";
                ContenidoBueno += $"MTSN : {MTSNTEXT.Text.Trim()}\n\n";


                string contenidoArchivo1 = ContenidoBueno;
                string contenidoArchivo2 = text2xx;

                string rutaArchivo1 = Path.Combine(directorioInfo, nombreArchivo1);
                string rutaArchivo2 = Path.Combine(directorioInfo, nombreArchivo2);

                // Escribimos el contenido en los archivos
                File.WriteAllText(rutaArchivo1, contenidoArchivo1);
                File.WriteAllText(rutaArchivo2, contenidoArchivo2);

                Console.WriteLine($"Se ha creado la carpeta \"BackupSysCFG\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear las carpetas o los archivos: {ex.Message}");
            }

            serialPort.DiscardInBuffer();
            serialPort.Close();

        }

        private void WriteAllBtn_Click(object sender, EventArgs e)
        {
            WriteAllNandData();
        }

        private void BackupCFGButton_Click(object sender, EventArgs e)
        {
            BackupNandData();
        }

        private void FactoryBtn_Click(object sender, EventArgs e)
        {
            RunTerminalPort("nvram --set oblit-inprogress 5\n");
            RunTerminalPort("nvram --save\n");
            RunTerminalPort("reset");
            serialPort.Close();
        }

        private void Rbtn_Click(object sender, EventArgs e)
        {
            UsbDeviceNotifier.Enabled = true;
            RunTerminalPort("reset");
            serialPort.Close();
        }

        private void UnlockBtn_Click(object sender, EventArgs e)
        {
            iCloudUnlockCFG Show = new iCloudUnlockCFG();
            Show.ShowDialog();
        }
    }
}
