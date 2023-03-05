using System;
using Microsoft.Win32;

namespace HWIDGeneration
{
    public static class RegistryInteraction
    {
        public static string GetStringValue(string path, string property)
        {
            var registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
            return registryKey.OpenSubKey(path)?.GetValue(property).ToString();
        }
    }
}