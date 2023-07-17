using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCFG
{
    public partial class DriverRepair : Form
    {
        public DriverRepair()
        {
            InitializeComponent();
        }



        public static string string_11;
        private string string_12 = "";
        private string string_13 = "";
        public static string string_0_2 = Directory.GetCurrentDirectory();
        public static string string_0 = Directory.GetCurrentDirectory();
        public static string f000001 = string_0_2 + "\\resources\\lib\\";
        public static string string_4 = "";
        public static string string_5 = Environment.CurrentDirectory + "\\resources\\lib";
        public static string string_6_ = "null";
        public static string string_7_ = "null";
        public static string string_8_ = "null";
        public static string string_9 = "null";
        public static string string_10 = "";
        public static string string_14_2 = "";
        public static string string_15_2 = string_0 + "\\resources\\drivers\\usb\\";
        public static string string_16_ = "C:\\Windows\\System32\\DriverStore\\FileRepository\\usbser.inf_amd64_8de53ed035d71856\\";
        public static string string_18_ = ":-)";
        public void DSCD()
        {
            RepairDFU.Enabled = false;
            portBtn.Enabled = false;
            method_10();
            Gaster shit = new Gaster();
            shit.method_35(string_12);
            method_0(string_16_);
            method_12(string_16_);
            smethod_0(string_15_2 + "\\serial\\", string_16_);
            method_11();
            ipwndfu repair = new ipwndfu();
            repair.installport("");

            portBtn.Text = "Repair Port Driver";
            MessageBox.Show(@"Drivers Has been Successfully Repaired", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RepairDFU.Enabled = true;
            portBtn.Enabled = true;
        }

        public void RepairOtherCleass() 
        {

            method_10();
            Gaster shit = new Gaster();
            shit.method_35(string_12);
            method_0(string_16_);
            method_12(string_16_);
            smethod_0(string_15_2 + "\\serial\\", string_16_);
            method_11();
            ipwndfu repair = new ipwndfu();
            repair.installport("");

        }

        public void method_0(string pathDrivers)
        {
            if (!Directory.Exists(pathDrivers))
            {
                Directory.CreateDirectory(pathDrivers);
            }
        }

        public void method_10()
        {
            string[] array = Classx.smethod_0();
            for (int i = 0; i < array.Length; i++)
            {
                Classx @class = new Classx(array[i]);
                try
                {
                    if (@class.String_1 == "")
                    {
                        MessageBox.Show("there's no installed drivers");
                    }
                    if (@class.String_1 == "USBAAPL64.CAT" || @class.String_1 == "usbaapl64.cat")
                    {
                        string_12 = @class.String_0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public void method_12(string path)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                FileInfo[] files = directoryInfo.GetFiles();
                for (int i = 0; i < files.Length; i++)
                {
                    files[i].Delete();
                }
                DirectoryInfo[] directories = directoryInfo.GetDirectories();
                for (int j = 0; j < directories.Length; j++)
                {
                    directories[j].Delete(recursive: true);
                }
            }
            catch (Exception)
            {
            }
        }
        private static void smethod_0(string sourcePath, string targetPath)
        {
            try
            {
                string[] files = Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly);
                foreach (string obj in files)
                {
                    File.Copy(obj, obj.Replace(sourcePath, targetPath), overwrite: true);
                }
            }
            catch (Exception)
            {
            }
        }

        public void method_11()
        {
             
        }

        private void portBtn_Click(object sender, EventArgs e)
        {

            portBtn.Text = "Repairing port drivers";
            ipwndfu repair = new ipwndfu();

            repair.UninstallPortDriver();
            DSCD();


        }





        private void RepairDFU_Click(object sender, EventArgs e)
        {

            RepairDFU.Enabled = false;
            portBtn.Enabled = false;
            MainCFG.USB(false);
            RepairDFU.Text = "Repairing DFU drivers";
            ipwndfu repair = new ipwndfu();

            repair.UninstallPortDriver();
            repair.uninstall_dfu_driver();

            Thread.Sleep(2000);

            repair.install_libusbk();

            repair.uninstall_dfu_driver();

            repair.FullKm(true, true, true, false, true);

            RepairDFU.Text = "Repair DFU Driver";

            MainCFG.USB(true);

            MessageBox.Show(@"Drivers Has been Successfully Repaired", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RepairDFU.Enabled = true;
            portBtn.Enabled = true;

        }
    }
}
