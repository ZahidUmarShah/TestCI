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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace GovPilot.GovPilotRecordings.SmokeRecordings.DataViewer
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidateRestoredRecord recording.
    /// </summary>
    [TestModule("96ad80e4-6f30-4e8f-9387-360df00004e8", ModuleType.Recording, 1)]
    public partial class ValidateRestoredRecord : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static ValidateRestoredRecord instance = new ValidateRestoredRecord();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateRestoredRecord()
        {
            RefNumRestored = "";
            RefrenceRestored = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateRestoredRecord Instance
        {
            get { return instance; }
        }

#region Variables

        string _RefNumRestored;

        /// <summary>
        /// Gets or sets the value of variable RefNumRestored.
        /// </summary>
        [TestVariable("7763f223-ebda-4b82-9f41-079a9dd65c88")]
        public string RefNumRestored
        {
            get { return _RefNumRestored; }
            set { _RefNumRestored = value; }
        }

        string _RefrenceRestored;

        /// <summary>
        /// Gets or sets the value of variable RefrenceRestored.
        /// </summary>
        [TestVariable("bc0f2635-193f-4470-b5a1-f372970a679e")]
        public string RefrenceRestored
        {
            get { return _RefrenceRestored; }
            set { _RefrenceRestored = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DateEnteredView.
        /// </summary>
        [TestVariable("03d8d640-dfb0-4121-8c34-f290b498ff34")]
        public string DateEnteredView
        {
            get { return repo.DateEnteredView; }
            set { repo.DateEnteredView = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.IconModules' at Center.", repo.ApplicationUnderTest.HomePage.IconModulesInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.IconModules.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.LinkViewNameCreated' at Center.", repo.ApplicationUnderTest.HomePage.LinkViewNameCreatedInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.LinkViewNameCreated.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.SaveMyView' at Center.", repo.ApplicationUnderTest.DataViewerGrid.SaveMyViewInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.DataViewerGrid.SaveMyView.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.HomePage.LinkViewNameCreated'.", repo.ApplicationUnderTest.HomePage.LinkViewNameCreatedInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.HomePage.LinkViewNameCreated.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.HomePage.LinkViewNameCreated'.", repo.ApplicationUnderTest.HomePage.LinkViewNameCreatedInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.HomePage.LinkViewNameCreated.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.DataViewerGrid.RefNumOnTheRecord' and assigning its value to variable 'RefNumRestored'.", repo.ApplicationUnderTest.DataViewerGrid.RefNumOnTheRecordInfo, new RecordItemIndex(8));
            RefNumRestored = repo.ApplicationUnderTest.DataViewerGrid.RefNumOnTheRecord.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", RefNumRestored, new RecordItemIndex(9));
            
            // Validating that Reference Number cached in the ealier step before delete, matches with the restored record
            Report.Log(ReportLevel.Info, "Validation", "Validating that Reference Number cached in the ealier step before delete, matches with the restored record\r\nValidating AttributeEqual (InnerText=$RefrenceRestored) on item 'ApplicationUnderTest.DataViewerGrid.RefNumOnTheRecord'.", repo.ApplicationUnderTest.DataViewerGrid.RefNumOnTheRecordInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.DataViewerGrid.RefNumOnTheRecordInfo, "InnerText", RefrenceRestored);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
