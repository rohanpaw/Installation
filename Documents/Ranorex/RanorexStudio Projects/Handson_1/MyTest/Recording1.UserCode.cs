///////////////////////////////////////////////////////////////////////////////
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

namespace MyTest
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

        public void ITestModule(Exception e)
        {
        	 var repo = MyTestRepository.Instance;
        	 var installation_Text = repo.FormMe.Installation_Text.TextValue.CheckNotContainsNull();
        	 var installation_Language = repo.FormMe.Installation_Language.SelectedItemText.CheckNotContainsNull();
            var button = repo.FormMe.Button;
            button.Click();
			
            // TODO: Replace the following line with your code implementation.
            throw new NotImplementedException(e);
        }

    }
}
