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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.DataViewer
{
    public partial class ChangeStatusForEmailSending
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_BtnSave(RepoItemInfo atagInfo)
        {
        	if (atagInfo.FindAdapter<ATag>().Visible) //Checking if the Button Save got enabled/visible because of status change on the record
        	{
        	
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'atagInfo' at Center.", atagInfo); //Clciking Save first
            atagInfo.FindAdapter<ATag>().Click();
            Delay.Duration(3000, false);
            repo.ApplicationUnderTest.LogsScreen.BtnLog.Click(); // And Then clicking Log Button
        	}
        	else //If the status did not change then click on Log button instead
        	{
        		repo.ApplicationUnderTest.LogsScreen.BtnLog.Click();
        	}
        }

    }
}
