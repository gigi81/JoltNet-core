using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//sign
#if NET35 || NET40
[assembly:AssemblyKeyFileAttribute("../../Jolt.snk")]

// Friend assemblies.
[assembly: InternalsVisibleTo("Jolt.Tests,PublicKey=00240000048000009400000006020000002400005253413100040000010001001d177bb42749a6788ec732bff549851e2ce91f27bcfa0142fa5d094ece409c43486345f9cfb563c2efbeb684a1d27a677f5264d8060ccdc06fd4291f524bc402a7d31d3862a2a0ca1d3592e950b8ddd749e4eff943ba62a1f3c24ee70019c78107904a48f1a2ac1cf5b5a7717d82f451872dba59ad44fe836cbd6171b1e85dc9")]
#else
[assembly: InternalsVisibleTo("Jolt.Tests")]
#endif
