using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyDescription("Contains unit tests for the data structures and algorithms in Jolt.dll.")]
[assembly: AssemblyCopyright("Copyright © Steve Guidi 2008")]

//sign
#if NET35 || NET40
[assembly: AssemblyKeyFileAttribute("../../Jolt.snk")]
#endif
