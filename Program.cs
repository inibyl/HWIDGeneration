using System;
using System.Security.Cryptography;
using System.Text;

namespace HWIDGeneration
{
    internal static class Program
    {
        private static string _hardwareId = string.Empty;
        
        public static void Main(string[] args)
        {
            // get properties from registry
            RegistryKeys.Properties.ForEach(x =>
            {
                var property = RegistryInteraction.GetStringValue(x.Item1, x.Item2);
                if (!string.IsNullOrEmpty(property))
                    _hardwareId += property;
            });
            
            // create md5 hash
            using (var md5Hash = MD5.Create())
            {
                var sourceBytes = Encoding.ASCII.GetBytes(_hardwareId);
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                _hardwareId = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_hardwareId);
            Console.ReadLine();
        }
    }
}