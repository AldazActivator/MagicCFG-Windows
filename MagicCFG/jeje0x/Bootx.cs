/*
 * 
 * Developed By Gerson Aldaz [ AldazActivator ]
 * if you wanna source full dm telegram @gerson_5
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicCFG
{
    internal class Bootx
    {

        public string Temp = "";
        public string TempZip = "";
        public string folderPathW = "";
        public bool boot() 
        {
            

            string output, error;

            iRecovery.Logs("Starting Process");

            EliminacionTemporal();


            if (!CrearFolderTemporal()) 
            {

                MessageBox.Show(@"No fixed disk found, please disconnect portable disks or usb and leave only the iphone connected", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            iRecovery.Logs("Obtaining Bootchains");

            desencriptar_cfg();

            if (!Unpack()) 
            {
                MessageBox.Show(@"Error extracting ZIP file", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EliminacionTemporal();
                return false;


            }

            iRecovery.Logs("Booting IBSS");

            string BootDir = $"{Temp}{iOSDevice.ProductType}";

            iRecovery.IRecovery("-f", $"{BootDir}/ibss.img4", out output, out error);

            iRecovery.IRecovery("-f", $"{BootDir}/ibss.img4", out output, out error);

            iRecovery.IRecovery("-f", $"{BootDir}/ibss.img4", out output, out error);

            if (error.Contains("unable to connect to device") || error.Contains(@"unable to upload data to device") || error.Contains(@"file not found"))

            {

            }

            iRecovery.Logs("Booting IBEC");

            iRecovery.IRecovery("-f", $"{BootDir}/ibec.img4", out output, out error);

            if (error.Contains("unable to connect to device") || error.Contains(@"unable to upload data to device") || error.Contains(@"file not found"))

            {

            }

            iRecovery.Logs("Opening Access to the Port Route A10/A11");

            iRecovery.IRecovery("-c", "setenv boot-args usbserial=enabled",out output, out error);

            iRecovery.IRecovery("-c", "saveenv", out output, out error);

            iRecovery.Logs("Booting Diag");

            iRecovery.IRecovery("-f", $"{BootDir}/diag.img4", out output, out error);

            if (error.Contains("unable to connect to device") || error.Contains(@"unable to upload data to device") || error.Contains(@"file not found"))

            {

            }

            iRecovery.IRecovery("-c", "go", out output, out error);

             ReCreacionTemporal();

            iRecovery.Logs("Done DiagMode");

            ipwndfu repair = new ipwndfu();

            repair.UninstallPortDriver();

            DriverRepair repairPair = new DriverRepair();

            repairPair.RepairOtherCleass();


            MessageBox.Show(@"Purple Mode Successfully", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            return true;
        }





        public bool Unpack() 
        {
            // Ruta del archivo ZIP a extraer
            string zipFilePath = TempZip;

            // Directorio de destino para extraer los archivos
            string extractPath = Temp;

            try
            {
                // Extraer el archivo ZIP
                ZipFile.ExtractToDirectory(zipFilePath, extractPath);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al extraer el archivo ZIP: " + ex.Message);

                return false;
            }

            return true;

        }

        public void desencriptar_cfg()
        {

            TempZip = $"{folderPathW}/{iOSDevice.ProductType}.zip";

            Temp = $"{folderPathW}/";

            Encriptador.FileDecryptAndSave($"{iOSDevice.ProductType}.CFG", $"{folderPathW}/{iOSDevice.ProductType}.zip");

        }


        public void EliminacionTemporal()
        {

            if (Directory.Exists(folderPathW))
            {
                // Eliminar el directorio y su contenido
                Directory.Delete(folderPathW, true);


                Console.WriteLine("Directorio eliminado correctamente.");
            }
            else
            {
            }

        }


        public void ReCreacionTemporal()
        {

            if (Directory.Exists(folderPathW))
            {
                try
                {
                    // Eliminar el directorio y su contenido
                    Directory.Delete(folderPathW, true);

                    CrearFolderTemporal();

                    Console.WriteLine("Directorio eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el directorio: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe.");

                CrearFolderTemporal();
            }

        }



        public bool CrearFolderTemporal()
        {
            
            // Obtener la unidad por defecto de Windows
            string defaultDrive = Path.GetPathRoot(Environment.SystemDirectory);

            // Verificar si la unidad por defecto es un disco fijo
            DriveInfo selectedDrive = new DriveInfo(defaultDrive);
            if (selectedDrive.DriveType != DriveType.Fixed)
            {
                // Buscar un disco fijo disponible
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (drive.DriveType == DriveType.Fixed)
                    {
                        selectedDrive = drive;
                        break;
                    }
                }

                // Si no se encuentra ningún disco fijo, buscar la carpeta "Program Files" o "Archivos de programa"
                if (selectedDrive.DriveType != DriveType.Fixed)
                {
                    string programFilesFolder = Path.Combine(defaultDrive, "Program Files");
                    if (!Directory.Exists(programFilesFolder))
                    {
                        programFilesFolder = Path.Combine(defaultDrive, "Archivos de programa");
                    }

                    if (Directory.Exists(programFilesFolder))
                    {
                        selectedDrive = new DriveInfo(defaultDrive);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un disco fijo ni las carpetas 'Program Files' o 'Archivos de programa'.");
                        
                        return false;
                    }
                }
            }

            // Crear la carpeta "LogsDiags" en la unidad seleccionada
            string folderPath = Path.Combine(selectedDrive.RootDirectory.FullName, "LogsDiags");
            Directory.CreateDirectory(folderPath);
            Console.WriteLine("Carpeta creada exitosamente en " + folderPath);

            folderPathW = folderPath;

            return true;
        }




    }
}
