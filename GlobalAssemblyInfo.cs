﻿using System.Reflection;

[assembly: AssemblyProduct("Beds Protector")]
[assembly: AssemblyCompany("Bed")]
[assembly: AssemblyCopyright("Copyright (C) K019")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else

[assembly: AssemblyConfiguration("Release")]
#endif


[assembly: AssemblyVersion("1.4")]
[assembly: AssemblyFileVersion("1.4")]
[assembly: AssemblyInformationalVersion("v1.4 | Public Version @Github")]
