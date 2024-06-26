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
    ///The EditForm recording.
    /// </summary>
    [TestModule("cf397534-b059-4c2a-bdca-d9072a29c7c1", ModuleType.Recording, 1)]
    public partial class EditForm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static EditForm instance = new EditForm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditForm()
        {
            ModuleName = "yourtext";
            PropAddress = "yourtext";
            CapturedRecordIDonGrid = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditForm Instance
        {
            get { return instance; }
        }

#region Variables

        string _ModuleName;

        /// <summary>
        /// Gets or sets the value of variable ModuleName.
        /// </summary>
        [TestVariable("8f0de332-eab6-4830-b30e-970500425bc4")]
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }

        string _PropAddress;

        /// <summary>
        /// Gets or sets the value of variable PropAddress.
        /// </summary>
        [TestVariable("68d52e6f-a9e4-40b6-b359-0c9e8fccb7c9")]
        public string PropAddress
        {
            get { return _PropAddress; }
            set { _PropAddress = value; }
        }

        string _CapturedRecordIDonGrid;

        /// <summary>
        /// Gets or sets the value of variable CapturedRecordIDonGrid.
        /// </summary>
        [TestVariable("5d2230ef-079f-42f1-8cc0-a5beca0bd1d6")]
        public string CapturedRecordIDonGrid
        {
            get { return _CapturedRecordIDonGrid; }
            set { _CapturedRecordIDonGrid = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.HomePage.TDRecordID' and assigning its value to variable 'CapturedRecordIDonGrid'.", repo.ApplicationUnderTest.HomePage.TDRecordIDInfo, new RecordItemIndex(0));
            CapturedRecordIDonGrid = repo.ApplicationUnderTest.HomePage.TDRecordID.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", CapturedRecordIDonGrid, new RecordItemIndex(1));
            
            // Launching the newly created record in edit mode
            Report.Log(ReportLevel.Info, "Mouse", "Launching the newly created record in edit mode\r\nMouse Left Click item 'ApplicationUnderTest.HomePage.IconViewForm' at Center.", repo.ApplicationUnderTest.HomePage.IconViewFormInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.IconViewForm.Click();
            Delay.Milliseconds(0);
            
            // Verifying that Form does not go into Save mode
            Report.Log(ReportLevel.Info, "Validation", "Verifying that Form does not go into Save mode\r\nValidating AttributeEqual (Visible='False') on item 'ApplicationUnderTest.CreateNewScreen.BtnSaveNew'.", repo.ApplicationUnderTest.CreateNewScreen.BtnSaveNewInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CreateNewScreen.BtnSaveNewInfo, "Visible", "False");
            Delay.Milliseconds(0);
            
            // Verifying Button Edit displays
            Report.Log(ReportLevel.Info, "Validation", "Verifying Button Edit displays\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.ViewFormPage.BtnEdit'.", repo.ApplicationUnderTest.ViewFormPage.BtnEditInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ViewFormPage.BtnEditInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ViewFormPage.BtnEdit' at Center.", repo.ApplicationUnderTest.ViewFormPage.BtnEditInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.ViewFormPage.BtnEdit.Click();
            Delay.Milliseconds(0);
            
            // Verifying after button edit is clicked Save button displays
            Report.Log(ReportLevel.Info, "Validation", "Verifying after button edit is clicked Save button displays\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.CreateNewScreen.BtnSaveNew'.", repo.ApplicationUnderTest.CreateNewScreen.BtnSaveNewInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.CreateNewScreen.BtnSaveNewInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
