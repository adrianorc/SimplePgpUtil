using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Security;
using System;
using System.IO;

namespace App
{
    class PGPHelper
    {
        public static void EncryptStream(string inputFile, Stream streamPublicKey, Stream outputFile)
        {
            PgpPublicKey encKey = ReadPublicKey(streamPublicKey);

            try
            {
                byte[] bytes = CompressFile(inputFile, CompressionAlgorithmTag.Zip);

                PgpEncryptedDataGenerator encGen = new PgpEncryptedDataGenerator(
                    SymmetricKeyAlgorithmTag.Aes256, true /*integrity check*/, new SecureRandom());
                encGen.AddMethod(encKey);

                Stream cOut = encGen.Open(outputFile, bytes.Length);
                cOut.Write(bytes, 0, bytes.Length);
                cOut.Close();
            }
            catch (PgpException e)
            {
                Console.Error.WriteLine(e);

                Exception underlyingException = e.InnerException;
                if (underlyingException != null)
                {
                    Console.Error.WriteLine(underlyingException.Message);
                    Console.Error.WriteLine(underlyingException.StackTrace);
                }

                throw e;
            }

        }

        private static byte[] CompressFile(string inputFile, CompressionAlgorithmTag algorithm)
        {
            MemoryStream bOut = new MemoryStream();
            PgpCompressedDataGenerator comData = new PgpCompressedDataGenerator(algorithm);
            PgpUtilities.WriteFileToLiteralData(comData.Open(bOut), PgpLiteralData.Binary,
                new FileInfo(inputFile));
            comData.Close();
            return bOut.ToArray();
        }

        private static PgpPublicKey ReadPublicKey(Stream inputStream)
        {
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            PgpPublicKeyRingBundle pgpPub = new PgpPublicKeyRingBundle(inputStream);

            // finds the first key suitable for encryption
            foreach (PgpPublicKeyRing kRing in pgpPub.GetKeyRings())
            {
                foreach (PgpPublicKey k in kRing.GetPublicKeys())
                {
                    if (k.IsEncryptionKey)
                    {
                        return k;
                    }
                }
            }

            throw new ArgumentException("Can't find encryption key in key ring.");
        }
    }
}
