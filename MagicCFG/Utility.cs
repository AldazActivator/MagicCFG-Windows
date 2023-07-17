//using System;
/*
 * 
 * Developed By Gerson Aldaz [ AldazActivator ]
 * if you wanna source full dm telegram @gerson_5
 * 
 */
using System.Collections.Generic;

namespace MagicCFG
{
    public static class iOSDevice
    {
        public static bool debugMode = false;

      
        public static string SerialNumber = "N/A";
        public static string ProductType = "";
        public static string Model = "";
        public static string MEID = "";
        public static string ECID = "";
        public static string HWM = "";
        public static string CPID = "";
        public static string Mode = ""; 
        public static string ipwndfu = "";

        public static void setProductType(string AproductType)
        {
            ProductType = AproductType;

            try
            {
                Model = DetermineModel(AproductType);

            }
            catch (System.Exception)
            {
               
            }
        }

  

        //In Authorization stage we determine if it a Warranty or Primary activation by server "I-KING-WARRANTY" header reply
        public static bool isWarranty = false;

        internal static uint CalculateModelNumber(string productType)
        {
            uint num = 0;
            if (productType != null)
            {
                num = 2166136261U;
                for (int i = 0; i < productType.Length; i++)
                {
                    num = ((uint)productType[i] ^ num) * 16777619U;
                }
            }
            return num;
        }

        public static string DetermineModel(string productType)
        {
            Dictionary<string, string> models = new Dictionary<string, string>
            {
                { "iPhone1,1", "iPhone 1" },
                { "iPhone1,2", "iPhone 3G" },
                { "iPhone2,1", "iPhone 3GS" },
                { "iPhone3,1", "iPhone 4" },
                { "iPhone3,2", "iPhone 4 (GSM)" },
                { "iPhone3,3", "iPhone 4 (CDMA)" },
                { "iPhone4,1", "iPhone 4s" },
                { "iPhone5,1", "iPhone 5 (GSM+CDMA)" },
                { "iPhone5,2", "iPhone 5 (GSM+CDMA)" },
                { "iPhone5,3", "iPhone 5c (GSM+CDMA)" },
                { "iPhone5,4", "iPhone 5c (GSM+CDMA)" },
                { "iPhone6,1", "iPhone 5s CDMA)" },
                { "iPhone6,2", "iPhone 5s (GSM+CDMA)" },
                { "iPhone8,1", "iPhone 6s" },
                { "iPhone8,2", "iPhone 6s Plus" },
                { "iPhone8,4", "iPhone SE (1st generation)" },
                { "iPhone9,1", "iPhone 7 (CDMA)" },
                { "iPhone9,2", "iPhone 7 Plus (CDMA)" },
                { "iPhone9,3", "iPhone 7 (GSM)" },
                { "iPhone9,4", "iPhone 7 Plus (GSM)" },
                { "iPhone10,1", "iPhone 8 (CDMA)" },
                { "iPhone10,3", "iPhone X (CDMA)" },
                { "iPhone10,4", "iPhone 8 (GSM)" },
                { "iPhone10,2", "iPhone 8 Plus" },
                { "iPhone10,5", "iPhone 8 Plus (GSM)" },
                { "iPhone10,6", "iPhone X (GSM)" },
                { "iPhone11,8", "iPhone XR" },
                { "iPhone11,2", "iPhone XS" },
                { "iPhone11,4", "iPhone XS Max" },
                { "iPhone11,6", "iPhone XS Max" },
                { "iPhone12,1", "iPhone 11" },
                { "iPhone12,3", "iPhone 11 Pro" },
                { "iPhone12,5", "iPhone 11 Pro Max" },
                { "iPhone13,1", "iPhone 12 mini" },
                { "iPhone13,2", "iPhone 12" },
                { "iPhone13,3", "iPhone 12 Pro" },
                { "iPhone13,4", "iPhone 12 Pro Max" },
                { "iPhone14,4", "iPhone 13 mini" },
                { "iPhone14,5", "iPhone 13" },
                { "iPhone14,2", "iPhone 13 Pro" },
                { "iPhone14,3", "iPhone 13 Pro Max" },
                { "iPhone14,6", "iPhone SE (3rd generation)" },
                { "iPhone14,7", "iPhone 14" },
                { "iPhone14,8", "iPhone 14 Plus" },
                { "iPhone15,2", "iPhone 14 Pro" },
                { "iPhone15,3", "iPhone 14 Pro Max" },
                { "iPad1,1", "iPad" },
                { "iPad2,1", "iPad 2" },
                { "iPad2,2", "iPad 2" },
                { "iPad2,3", "iPad 2" },
                { "iPad2,4", "iPad 2" },
                { "iPad3,1", "iPad (3rd generation)" },
                { "iPad3,2", "iPad (3rd generation)" },
                { "iPad3,3", "iPad (3rd generation)" },
                { "iPad3,4", "iPad (4th generation)" },
                { "iPad3,5", "iPad (4th generation)" },
                { "iPad3,6", "iPad (4th generation)" },
                { "iPad6,11", "iPad (5th generation)" },
                { "iPad6,12", "iPad (5th generation)" },
                { "iPad7,5", "iPad (6th generation)" },
                { "iPad7,6", "iPad (6th generation)" },
                { "iPad7,11", "iPad (7th generation)" },
                { "iPad7,12", "iPad (7th generation)" },
                { "iPad11,6", "iPad (8th generation)" },
                { "iPad11,7", "iPad (8th generation)" },
                { "iPad12,1", "iPad (9th generation)" },
                { "iPad12,2", "iPad (9th generation)" },
                { "iPad4,1", "iPad Air" },
                { "iPad4,2", "iPad Air" },
                { "iPad4,3", "iPad Air" },
                { "iPad5,3", "iPad Air 2" },
                { "iPad5,4", "iPad Air 2" },
                { "iPad11,3", "iPad Air (3rd generation)" },
                { "iPad11,4", "iPad Air (3rd generation)" },
                { "iPad13,1", "iPad Air (4th generation)" },
                { "iPad13,2", "iPad Air (4th generation)" },
                { "iPad2,5", "iPad mini" },
                { "iPad2,6", "iPad mini" },
                { "iPad2,7", "iPad mini" },
                { "iPad4,4", "iPad mini 2" },
                { "iPad4,5", "iPad mini 2" },
                { "iPad4,6", "iPad mini 2" },
                { "iPad4,7", "iPad mini 3" },
                { "iPad4,8", "iPad mini 3" },
                { "iPad4,9", "iPad mini 3" },
                { "iPad5,1", "iPad mini 4" },
                { "iPad5,2", "iPad mini 4" },
                { "iPad11,1", "iPad mini (5th generation)" },
                { "iPad11,2", "iPad mini (5th generation)" },
                { "iPod1,1", "iPod touch" },
                { "iPod2,1", "iPod touch (2nd generation)" },
                { "iPod3,1", "iPod touch (3rd generation)" },
                { "iPod4,1", "iPod touch (4th generation)" },
                { "iPod5,1", "iPod touch (5th generation)" },
                { "iPod7,1", "iPod touch (6th generation)" },
                { "iPod9,1", "iPod touch (7th generation)" },
                { "Watch1,1", "Apple Watch (1st generation) 38mm" },
                { "Watch1,2", "Apple Watch (1st generation) 42mm" },
                { "Watch2,6", "Apple Watch Series 1 38mm" },
                { "Watch2,7", "Apple Watch Series 1 42mm" },
                { "Watch2,3", "Apple Watch Series 2 38mm" },
                { "Watch2,4", "Apple Watch Series 2 42mm" },
                { "Watch3,1", "Apple Watch Series 3 (GPS) 38mm" },
                { "Watch3,2", "Apple Watch Series 3 (GPS) 42mm" },
                { "Watch3,3", "Apple Watch Series 3 (GPS + Cellular) 38mm" },
                { "Watch3,4", "Apple Watch Series 3 (GPS + Cellular) 42mm" },
                { "Watch4,1", "Apple Watch Series 4 (GPS) 40mm" },
                { "Watch4,2", "Apple Watch Series 4 (GPS) 44mm" },
                { "Watch4,3", "Apple Watch Series 4 (GPS + Cellular) 40mm" },
                { "Watch4,4", "Apple Watch Series 4 (GPS + Cellular) 44mm" },
                { "Watch5,1", "Apple Watch Series 5 (GPS) 40mm" },
                { "Watch5,2", "Apple Watch Series 5 (GPS) 44mm" },
                { "Watch5,3", "Apple Watch Series 5 (GPS + Cellular) 40mm" },
                { "Watch5,4", "Apple Watch Series 5 (GPS + Cellular) 44mm" },
                { "Watch6,1", "Apple Watch Series 6 (GPS) 40mm" },
                { "Watch6,2", "Apple Watch Series 6 (GPS) 44mm" },
                { "Watch6,3", "Apple Watch Series 6 (GPS + Cellular) 40mm" },
                { "Watch6,4", "Apple Watch Series 6 (GPS + Cellular) 44mm" },
                { "Watch7,1", "Apple Watch Series 7 (GPS) 41mm" },
                { "Watch7,2", "Apple Watch Series 7 (GPS) 45mm" },
                { "Watch7,3", "Apple Watch Series 7 (GPS + Cellular) 41mm" },
                { "Watch7,4", "Apple Watch Series 7 (GPS + Cellular) 45mm" }
            };

            if (models.ContainsKey(productType))
            {
                return models[productType];
            }
            else
            {
                return "Unknown Model";
            }
        }
    }

}