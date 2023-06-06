using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model.Encrypt
{
    public class Encrypt
    {
        static public byte[] Encryption(byte[] data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    encryptedData = RSA.Encrypt(data, DoOAEPPadding);
                    return encryptedData;
                }
            }
            catch (CryptographicException e) {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
