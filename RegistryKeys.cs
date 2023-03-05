using System.Collections.Generic;

namespace HWIDGeneration
{
    public static class RegistryKeys
    {
        public static readonly List<(string, string)> Properties = new List<(string, string)>()
        {
            ("SOFTWARE\\Microsoft\\SQMClient", "MachineId"),
            ("SYSTEM\\ControlSet001\\Control\\SystemInformation", "ComputerHardwareId"),
            ("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", "HwProfileGuid"),
            ("SYSTEM\\HardwareConfig", "LastConfig"),
            ("SOFTWARE\\Microsoft\\Cryptography", "MachineGuid"),
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate", "SusClientId"),
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\GameInstaller", "GameInstaller"),
            ("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", "Identifier"),
            ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "InstallDate"),
            ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "InstallTime"),
            ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "RegisteredOwner"),
            ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductId"),
            ("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SoftwareProtectionPlatform", "BackupProductKeyDefault")
        };
    }
}