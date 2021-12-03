/*
 * Created by Ranorex
 * User: jpawarro
 * Date: 11/26/2021
 * Time: 4:40 PM
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

namespace MyTest
{
    /// <summary>
    /// Description of Installation.
    /// </summary>
    [TestModule("C69C3F7D-3E6D-432C-9E13-00C71402AC84", ModuleType.UserCode, 1)]
    public class Installation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Installation()
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
            
            // Start Here
            
            var repo = MyTestRepository.Instance;
            var installation_Text = repo.FormMe.Installation_Text;
            var installation_Language = repo.FormMe.Installation_Language;
            var button = repo.FormMe.Button;
            repo.FormMe.Button.Click();
			
      

        }
    }
}
