﻿// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalAssemblyInfo.cs" company="VirtoCommerce">
//   Copyright © VirtoCommerce. All rights reserved.
// </copyright>
// <summary>
//   Virto Commerce
// </summary>
// ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("VirtoCommerce")]
[assembly: AssemblyProduct("Virto Commerce 2.12")]
[assembly: AssemblyCopyright("Copyright © VirtoCommerce 2011-2016")]

[assembly: AssemblyFileVersion("2.13.11.0")]
[assembly: AssemblyVersion("2.13.11.0")]
[assembly: AssemblyInformationalVersion("2.13")]


#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
