﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Installation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the InstallationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("123954e7-5002-42ad-9c03-0f45341fcc09")]
    public partial class InstallationRepository : RepoGenBaseFolder
    {
        static InstallationRepository instance = new InstallationRepository();

        /// <summary>
        /// Gets the singleton class instance representing the InstallationRepository element repository.
        /// </summary>
        [RepositoryFolder("123954e7-5002-42ad-9c03-0f45341fcc09")]
        public static InstallationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public InstallationRepository() 
            : base("InstallationRepository", "/", null, 0, false, "123954e7-5002-42ad-9c03-0f45341fcc09", ".\\RepositoryImages\\InstallationRepository123954e7.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("123954e7-5002-42ad-9c03-0f45341fcc09")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class InstallationRepositoryFolders
    {
    }
#pragma warning restore 0436
}