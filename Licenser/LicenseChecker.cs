using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Licenser
{
    class LicenseChecker
    {
        public static string LoadLicenseFromFile(string filename)
        {
            try
            {
                return System.IO.File.ReadAllText(@filename);
            }
            catch (Exception er)
            {
                return "";
            }
        }

        public static string GenerateLicense(string privKey)
        {
            RSACryptoServiceProvider csp;

            csp = new RSACryptoServiceProvider();
            csp.FromXmlString(privKey);

            //get unique mac address of computer
            var plainTextData = macId();

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.SignData(bytesPlainTextData, new SHA1CryptoServiceProvider());

            //we might want a string representation of our cypher text... base64 will do
            return Convert.ToBase64String(bytesCypherText);
        }
        public static bool VerifyLicense(string publicKey, string license)
        {
            byte[] bytesCypherText = Convert.FromBase64String(license);

            RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
            csp.FromXmlString(publicKey);

            var plainTextData = macId();

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

            //decrypt and verify data
            return csp.VerifyData(bytesPlainTextData, new SHA1CryptoServiceProvider(), bytesCypherText);
        }

        private static string macId()
        {
            return identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
        }

        private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (mo[wmiMustBeTrue].ToString() == "True")
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
            }
            return result;
        }
    }
}
