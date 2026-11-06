using System.Runtime.InteropServices;

namespace Reloaded.Hooks.Internal;

[StructLayout(LayoutKind.Sequential)]
internal struct SystemInfo
{
    internal ushort ProcessorArchitecture;
    internal ushort Reserved;
    internal uint PageSize;
    internal nuint MinimumApplicationAddress;
    internal nuint MaximumApplicationAddress;
    internal nuint ActiveProcessorMask;
    internal uint NumberOfProcessors;
    internal uint ProcessorType;
    internal uint AllocationGranularity;
    internal ushort ProcessorLevel;
    internal ushort ProcessorRevision;

    [DllImport("kernel32.dll", ExactSpelling = true)]
    internal static extern void GetSystemInfo(out SystemInfo systemInfo);
}
