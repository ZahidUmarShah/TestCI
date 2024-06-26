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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.PublicForms
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyDogLicenseOnAdminApplication recording.
    /// </summary>
    [TestModule("559c8731-40ea-4b87-af94-8427ffcad4b0", ModuleType.Recording, 1)]
    public partial class VerifyDogLicenseOnAdminApplication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static VerifyDogLicenseOnAdminApplication instance = new VerifyDogLicenseOnAdminApplication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyDogLicenseOnAdminApplication()
        {
            ModuleName = "yourtext";
            GetReferenceNo = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyDogLicenseOnAdminApplication Instance
        {
            get { return instance; }
        }

#region Variables

        string _ModuleName;

        /// <summary>
        /// Gets or sets the value of variable ModuleName.
        /// </summary>
        [TestVariable("6f2476dd-816a-410c-a169-0a4812da722d")]
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }

        string _GetReferenceNo;

        /// <summary>
        /// Gets or sets the value of variable GetReferenceNo.
        /// </summary>
        [TestVariable("d84579f9-5d27-4d5f-9971-81979efc8891")]
        public string GetReferenceNo
        {
            get { return _GetReferenceNo; }
            set { _GetReferenceNo = value; }
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

            // Waiting for Dashboard is showing or not
            Report.Log(ReportLevel.Info, "Wait", "Waiting for Dashboard is showing or not\r\nWaiting 40s for the attribute 'Visible' to equal the specified value ' True'. Associated repository item: 'ApplicationUnderTest.PublicForms.Link_Modules'", repo.ApplicationUnderTest.PublicForms.Link_ModulesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.PublicForms.Link_ModulesInfo.WaitForAttributeEqual(40000, "Visible", " True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Link_Modules' at Center.", repo.ApplicationUnderTest.PublicForms.Link_ModulesInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.PublicForms.Link_Modules.Click();
            Delay.Milliseconds(0);
            
            // Validating the Select a modules page is opened or not
            Report.Log(ReportLevel.Info, "Validation", "Validating the Select a modules page is opened or not\r\nValidating AttributeEqual (InnerText='Select a Module') on item 'ApplicationUnderTest.PublicForms.Validate_SelectModules'.", repo.ApplicationUnderTest.PublicForms.Validate_SelectModulesInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PublicForms.Validate_SelectModulesInfo, "InnerText", "Select a Module");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Input_SearchModule' at Center.", repo.ApplicationUnderTest.PublicForms.Input_SearchModuleInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.PublicForms.Input_SearchModule.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ModuleName' with focus on 'ApplicationUnderTest.PublicForms.Input_SearchModule'.", repo.ApplicationUnderTest.PublicForms.Input_SearchModuleInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.PublicForms.Input_SearchModule.PressKeys(ModuleName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Enter}'.", new RecordItemIndex(5));
            Keyboard.Press("{Tab}{Tab}{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(6));
            Delay.Duration(4000, false);
            
            // Validating Dog License page is opened or not
            Report.Log(ReportLevel.Info, "Validation", "Validating Dog License page is opened or not\r\nValidating Exists on item 'ApplicationUnderTest.PublicForms.Validate_DogModule'.", repo.ApplicationUnderTest.PublicForms.Validate_DogModuleInfo, new RecordItemIndex(7));
            Validate.Exists(repo.ApplicationUnderTest.PublicForms.Validate_DogModuleInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Input_RefNo' at Center.", repo.ApplicationUnderTest.PublicForms.Input_RefNoInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.PublicForms.Input_RefNo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GetReferenceNo' with focus on 'ApplicationUnderTest.PublicForms.Input_RefNo'.", repo.ApplicationUnderTest.PublicForms.Input_RefNoInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.PublicForms.Input_RefNo.PressKeys(GetReferenceNo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}'.", new RecordItemIndex(10));
            Keyboard.Press("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
            // Validating only one row should show with the refernece number which is submitted from public form
            Report.Log(ReportLevel.Info, "Validation", "Validating only one row should show with the refernece number which is submitted from public form\r\nValidating Exists on item 'ApplicationUnderTest.PublicForms.Vlidate_RowOfRefeNo'.", repo.ApplicationUnderTest.PublicForms.Vlidate_RowOfRefeNoInfo, new RecordItemIndex(12));
            Validate.Exists(repo.ApplicationUnderTest.PublicForms.Vlidate_RowOfRefeNoInfo);
            Delay.Milliseconds(0);
            
            // Validating the refenece number which is submitted from Public Form is available or not
            Report.Log(ReportLevel.Info, "Validation", "Validating the refenece number which is submitted from Public Form is available or not\r\nValidating AttributeEqual (InnerText=$GetReferenceNo) on item 'ApplicationUnderTest.PublicForms.Validate_RefNotitle'.", repo.ApplicationUnderTest.PublicForms.Validate_RefNotitleInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PublicForms.Validate_RefNotitleInfo, "InnerText", GetReferenceNo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
