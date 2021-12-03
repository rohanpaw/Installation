﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace InstallationExe
{
    public partial class Recording1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Verify_Window()
        {
        	 var repo = InstallationExeRepository.Instance;
            var instalation_Text = repo.FormMe.Instalation_Text;
			if (instalation_Text == null)
				return ;
			var installation_Combobox = repo.FormMe.Installation_Combobox;
			if (installation_Combobox == null)
				return ;
			var installation_Lang = repo.FormMe.Installation_Lang;
				installation_Lang.TextValue="English";
				var buttonOK = repo.FormMe.ButtonOK;
				if (buttonOK == null)
					return ;
				buttonOK.Click();

            // TODO: Replace the following line with your code implementation.
            throw new NotImplementedException();
        }

    }
}