/*
 * Created by Ranorex
 * User: jpawarro
 * Date: 11/26/2021
 * Time: 5:39 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace InstallationExe
{
    /// <summary>
    /// Description of FirstPage.
    /// </summary>
    [TestModule("7AE879B5-6042-43B5-9FC2-BEC281443E63", ModuleType.UserCode, 1)]
    public class FirstPage : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FirstPage()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
           
        }
    }
}
