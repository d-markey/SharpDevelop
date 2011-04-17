﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using NuGet;

namespace ICSharpCode.PackageManagement
{
	public interface IPackageViewModelFactory
	{
		PackageViewModel CreatePackageViewModel(IPackageFromRepository package);
		
		IPackageManagementSolution Solution { get; }
		IPackageManagementEvents PackageManagementEvents { get; }
	}
}
