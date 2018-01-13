using System.Reflection;
using System.Runtime.InteropServices;

[assembly:AssemblyTitle("udp_server")]
[assembly:AssemblyProduct("udp_server")]
[assembly:AssemblyDescription("description of udp_server.")]
[assembly:AssemblyCompany("Rik Cousens")]
[assembly:AssemblyCopyright("Copyright © 2018, Rik Cousens")]
#if DEBUG
[assembly:AssemblyConfiguration("Debug version")]
#else
[assembly:AssemblyConfiguration("Release version")]
#endif
[assembly:ComVisible(false)]

[assembly:AssemblyVersion("1.0.0.0")]

