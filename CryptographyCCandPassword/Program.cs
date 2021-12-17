using System;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
//
using System.Collections.Generic;
using System.IO;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;
using static System.Convert;
using System.Linq;


/*

//Install - Package System.Security.Cryptography.Xml - Version 5.0.0
//RefURL: - https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.xml.encryptedxml?view=net-5.0

*/

namespace CryptographyCCandPassword
{//Start Namespace
    class Program
    {//Start Program
        static void Main(string[] args)
        {//Start Main
         // Create an XmlDocument object.
            XmlDocument xmlDoc = new XmlDocument();

            //This is the only place path is set
            //Defaults to: CryptographyCCandPassword\bin\Debug\net5.0\user.xml
            //There is also a back-up of teh xml file incase you want to run multiple times or in case of an error.

            string path = "user.xml";

            // Load an XML file into the XmlDocument object.
            try
            {
                xmlDoc.PreserveWhitespace = false;
                xmlDoc.Load(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

        // Create a new TripleDES key.
        TripleDESCryptoServiceProvider tDESkey = new TripleDESCryptoServiceProvider();

            try
            {
                // Encrypt the "creditcard" element.
                Encrypt(xmlDoc, "creditcard", tDESkey, "tDESKey");
                // Display the encrypted XML to the console.
                Console.WriteLine("Encrypted XML:");
                Console.WriteLine();
                Console.WriteLine(xmlDoc.OuterXml);
                xmlDoc.Save(path);
                //--------------------------------------------------------------------

                //Here is where we need to hash and salt the password
                string valueToReplace = "Pa$$w0rd";
                string newPassword = EncryptHash(valueToReplace, "NeverGiveUp");

                XDocument doc = XDocument.Load(path);
                var elements = doc.Descendants("password").ToList();
                foreach (var element in elements)
                {
                    element.ReplaceAll(newPassword);
                }

                doc.Save(path);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hashed & Salted Password:");
                Console.WriteLine();

                Console.WriteLine(doc);

                Console.WriteLine();
                Console.WriteLine();

                //End Hash and Salt password
                //--------------------------------------------------------------------

                // Decrypt the "creditcard" element.
                //Having to reopen th efile after a save.

                // Load an XML file into the XmlDocument object.
                try
                {
                    xmlDoc.PreserveWhitespace = false;
                    xmlDoc.Load(path);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

                Decrypt(xmlDoc, tDESkey, "tDESKey");

                // Display the dencrypted XML to the console.
                Console.WriteLine();
                Console.WriteLine("Decrypted XML:");
                Console.WriteLine();
                Console.WriteLine(xmlDoc.OuterXml);
                xmlDoc.Save(path);

                //Here is where we need to undo the hash and salted password
                XDocument root = XDocument.Load(path); 
                string HashedandSaltedPassword = (string)
                    (from el in root.Descendants("password")
                     select el).First();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("password to unhash...");
                Console.WriteLine(HashedandSaltedPassword);
                //Here is where we need to unhash and unsalt the password
                string unHashedPassword = DecryptHash(HashedandSaltedPassword, "NeverGiveUp");

                XDocument doc2 = XDocument.Load(path);
                var elements2 = doc2.Descendants("password").ToList();
                foreach (var element in elements)
                {
                    element.ReplaceAll(unHashedPassword);
                }
                doc2.Save(path);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("unHashed & unSalted Password:");
                Console.WriteLine();
                Console.WriteLine(doc);
                Console.WriteLine();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Clear the TripleDES key.
                tDESkey.Clear();
            }
        }

        public static void Encrypt(XmlDocument Doc, string ElementToEncrypt, SymmetricAlgorithm Alg, string KeyName)
        {
            // Check the arguments.
            if (Doc == null)
                throw new ArgumentNullException("Doc");
            if (ElementToEncrypt == null)
                throw new ArgumentNullException("ElementToEncrypt");
            if (Alg == null)
                throw new ArgumentNullException("Alg");

            ////////////////////////////////////////////////
            // Find the specified element in the XmlDocument
            // object and create a new XmlElemnt object.
            ////////////////////////////////////////////////

            XmlElement elementToEncrypt = Doc.GetElementsByTagName(ElementToEncrypt)[0] as XmlElement;

            // Throw an XmlException if the element was not found.
            if (elementToEncrypt == null)
            {
                throw new XmlException("The specified element was not found");
            }

            //////////////////////////////////////////////////
            // Create a new instance of the EncryptedXml class
            // and use it to encrypt the XmlElement with the
            // symmetric key.
            //////////////////////////////////////////////////

            EncryptedXml eXml = new EncryptedXml();

            byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, Alg, false);

            ////////////////////////////////////////////////
            // Construct an EncryptedData object and populate
            // it with the desired encryption information.
            ////////////////////////////////////////////////

            EncryptedData edElement = new EncryptedData();
            edElement.Type = EncryptedXml.XmlEncElementUrl;

            // Create an EncryptionMethod element so that the
            // receiver knows which algorithm to use for decryption.
            // Determine what kind of algorithm is being used and
            // supply the appropriate URL to the EncryptionMethod element.

            string encryptionMethod = null;

            if (Alg is TripleDES)
            {
                encryptionMethod = EncryptedXml.XmlEncTripleDESUrl;
            }
            else if (Alg is DES)
            {
                encryptionMethod = EncryptedXml.XmlEncDESUrl;
            }
            else if (Alg is Aes)
            {
                switch (Alg.KeySize)
                {
                    case 128:
                        encryptionMethod = EncryptedXml.XmlEncAES128Url;
                        break;
                    case 192:
                        encryptionMethod = EncryptedXml.XmlEncAES192Url;
                        break;
                    case 256:
                        encryptionMethod = EncryptedXml.XmlEncAES256Url;
                        break;
                }
            }
            else
            {
                // Throw an exception if the transform is not in the previous categories
                throw new CryptographicException("The specified algorithm is not supported for XML Encryption.");
            }

            edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);

            // Set the KeyInfo element to specify the
            // name of a key.

            // Create a new KeyInfo element.
            edElement.KeyInfo = new KeyInfo();

            // Create a new KeyInfoName element.
            KeyInfoName kin = new KeyInfoName();

            // Specify a name for the key.
            kin.Value = KeyName;

            // Add the KeyInfoName element.
            edElement.KeyInfo.AddClause(kin);

            // Add the encrypted element data to the
            // EncryptedData object.
            edElement.CipherData.CipherValue = encryptedElement;

            ////////////////////////////////////////////////////
            // Replace the element from the original XmlDocument
            // object with the EncryptedData element.
            ////////////////////////////////////////////////////

            EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
        }

        public static void Decrypt(XmlDocument Doc, SymmetricAlgorithm Alg, string KeyName)
        {
            // Check the arguments.
            if (Doc == null)
                throw new ArgumentNullException("Doc");
            if (Alg == null)
                throw new ArgumentNullException("Alg");
            if (KeyName == null)
                throw new ArgumentNullException("KeyName");

            // Create a new EncryptedXml object.
            EncryptedXml exml = new EncryptedXml(Doc);

            // Add a key-name mapping.
            // This method can only decrypt documents
            // that present the specified key name.
            exml.AddKeyNameMapping(KeyName, Alg);

            // Decrypt the element.
            exml.DecryptDocument();
        }

        //=========================================================================================================

        //START HASH AND SALT OF PASSWORD
        // public static class Protector
        // {

        //====================================================

        public static string EncryptHash(string plainText, string password)
        {

            //This is used by the hash salt method
            // salt size must be at least 8 bytes, we will use 16 bytes    
            byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");
            // iterations must be at least 1000, we will use 2000     
            int iterations = 2000;

            byte[] encryptedBytes;
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = pbkdf2.GetBytes(32);
            // set a 256-bit key       
            aes.IV = pbkdf2.GetBytes(16);
            // set a 128-bit IV       
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(plainBytes, 0, plainBytes.Length);
                }
                encryptedBytes = ms.ToArray();
            }
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string DecryptHash(string cryptoText, string password)
        {

            //This is used by the hash salt method
            // salt size must be at least 8 bytes, we will use 16 bytes    
            byte[] salt = Encoding.Unicode.GetBytes("7BANANAS");
            // iterations must be at least 1000, we will use 2000     
            int iterations = 2000;

            byte[] plainBytes;
            byte[] cryptoBytes = Convert.FromBase64String(cryptoText);
            var aes = Aes.Create();
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = pbkdf2.GetBytes(32);
            aes.IV = pbkdf2.GetBytes(16);
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cryptoBytes, 0, cryptoBytes.Length);
                }
                plainBytes = ms.ToArray();
            }
            return Encoding.Unicode.GetString(plainBytes);
        }
        //}
        //END HASH AND SALT OF PASSWORD
        //=========================================================================================================
    }//End Program
}//End NameSpace
