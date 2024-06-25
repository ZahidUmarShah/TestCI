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
    ///The VerrifyLogDetailsUpdated recording.
    /// </summary>
    [TestModule("89020329-5bea-438c-a725-51834cbf0b61", ModuleType.Recording, 1)]
    public partial class VerrifyLogDetailsUpdated : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static VerrifyLogDetailsUpdated instance = new VerrifyLogDetailsUpdated();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerrifyLogDetailsUpdated()
        {
            EmailEntered = "";
            EmailUsed = "";
            EmailUsedOnNew = "yourtext";
            FirstNameInLogs = "yourValue";
            LastNameInLogs = "yourValue";
            PhoneInLogs = "yourValue";
            Address2InLogs = "yourValue";
            BreedInLogs = "yourValue";
            PetNameInLogs = "yourValue";
            RefNoInLogs = "yourValue";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerrifyLogDetailsUpdated Instance
        {
            get { return instance; }
        }

#region Variables

        string _EmailEntered;

        /// <summary>
        /// Gets or sets the value of variable EmailEntered.
        /// </summary>
        [TestVariable("0e2f3ecc-ee10-4f6d-871d-77b5738c7c21")]
        public string EmailEntered
        {
            get { return _EmailEntered; }
            set { _EmailEntered = value; }
        }

        string _EmailUsed;

        /// <summary>
        /// Gets or sets the value of variable EmailUsed.
        /// </summary>
        [TestVariable("4ad6a2c2-223e-4d57-b1f6-25e9fbee454d")]
        public string EmailUsed
        {
            get { return _EmailUsed; }
            set { _EmailUsed = value; }
        }

        string _EmailUsedOnNew;

        /// <summary>
        /// Gets or sets the value of variable EmailUsedOnNew.
        /// </summary>
        [TestVariable("9227f73f-16b0-4f59-a3fe-b9db04f6deaf")]
        public string EmailUsedOnNew
        {
            get { return _EmailUsedOnNew; }
            set { _EmailUsedOnNew = value; }
        }

        string _FirstNameInLogs;

        /// <summary>
        /// Gets or sets the value of variable FirstNameInLogs.
        /// </summary>
        [TestVariable("a85a67a6-7810-4f61-8f30-41b01146695a")]
        public string FirstNameInLogs
        {
            get { return _FirstNameInLogs; }
            set { _FirstNameInLogs = value; }
        }

        string _LastNameInLogs;

        /// <summary>
        /// Gets or sets the value of variable LastNameInLogs.
        /// </summary>
        [TestVariable("73a98906-bfe3-4c47-a6b2-e533e5c4b40d")]
        public string LastNameInLogs
        {
            get { return _LastNameInLogs; }
            set { _LastNameInLogs = value; }
        }

        string _PhoneInLogs;

        /// <summary>
        /// Gets or sets the value of variable PhoneInLogs.
        /// </summary>
        [TestVariable("ae49f5f8-a60d-4f9c-bdd4-e5bcfe7c2c68")]
        public string PhoneInLogs
        {
            get { return _PhoneInLogs; }
            set { _PhoneInLogs = value; }
        }

        string _Address2InLogs;

        /// <summary>
        /// Gets or sets the value of variable Address2InLogs.
        /// </summary>
        [TestVariable("a5bae196-0086-4208-8884-0b722017e00c")]
        public string Address2InLogs
        {
            get { return _Address2InLogs; }
            set { _Address2InLogs = value; }
        }

        string _BreedInLogs;

        /// <summary>
        /// Gets or sets the value of variable BreedInLogs.
        /// </summary>
        [TestVariable("925ea86b-1b33-44f2-a062-c68aee96571d")]
        public string BreedInLogs
        {
            get { return _BreedInLogs; }
            set { _BreedInLogs = value; }
        }

        string _PetNameInLogs;

        /// <summary>
        /// Gets or sets the value of variable PetNameInLogs.
        /// </summary>
        [TestVariable("082f8f01-7bb4-43be-81e0-d9ac3d52cc2b")]
        public string PetNameInLogs
        {
            get { return _PetNameInLogs; }
            set { _PetNameInLogs = value; }
        }

        string _RefNoInLogs;

        /// <summary>
        /// Gets or sets the value of variable RefNoInLogs.
        /// </summary>
        [TestVariable("9f864c37-4a69-4302-881f-031778371bb7")]
        public string RefNoInLogs
        {
            get { return _RefNoInLogs; }
            set { _RefNoInLogs = value; }
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

            // Fetching the email ID logged in Logs screen
            Report.Log(ReportLevel.Info, "Get Value", "Fetching the email ID logged in Logs screen\r\nGetting attribute 'InnerText' from item 'ApplicationUnderTest.LogsScreen.LogsEmailID' and assigning its value to variable 'EmailUsed'.", repo.ApplicationUnderTest.LogsScreen.LogsEmailIDInfo, new RecordItemIndex(0));
            EmailUsed = repo.ApplicationUnderTest.LogsScreen.LogsEmailID.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", EmailUsed, new RecordItemIndex(1));
            
            // Comparing the Logs screen email with email entered on New screen
            Report.Log(ReportLevel.Info, "Validation", "Comparing the Logs screen email with email entered on New screen\r\nValidating AttributeContains (InnerText>$EmailUsedOnNew) on item 'ApplicationUnderTest.LogsScreen.LogsEmailID'.", repo.ApplicationUnderTest.LogsScreen.LogsEmailIDInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.LogsEmailIDInfo, "InnerText", EmailUsedOnNew);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", EmailUsedOnNew, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$FirstNameInLogs) on item 'ApplicationUnderTest.LogsScreen.TDFirstNameInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDFirstNameInLogsInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDFirstNameInLogsInfo, "InnerText", FirstNameInLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$LastNameInLogs) on item 'ApplicationUnderTest.LogsScreen.TDLasttNameInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDLasttNameInLogsInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDLasttNameInLogsInfo, "InnerText", LastNameInLogs);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$PhoneInLogs) on item 'ApplicationUnderTest.LogsScreen.TDPhoneInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDPhoneInLogsInfo, new RecordItemIndex(6));
            //Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDPhoneInLogsInfo, "InnerText", PhoneInLogs);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$Address2InLogs) on item 'ApplicationUnderTest.LogsScreen.TDAddress2InLogs'.", repo.ApplicationUnderTest.LogsScreen.TDAddress2InLogsInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDAddress2InLogsInfo, "InnerText", Address2InLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$BreedInLogs) on item 'ApplicationUnderTest.LogsScreen.TDBreedInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDBreedInLogsInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDBreedInLogsInfo, "InnerText", BreedInLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$PetNameInLogs) on item 'ApplicationUnderTest.LogsScreen.TDPetNameInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDPetNameInLogsInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDPetNameInLogsInfo, "InnerText", PetNameInLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$RefNoInLogs) on item 'ApplicationUnderTest.LogsScreen.TDRefNoInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDRefNoInLogsInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.TDRefNoInLogsInfo, "InnerText", RefNoInLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LogsScreen.IconCloseLog' at Center.", repo.ApplicationUnderTest.LogsScreen.IconCloseLogInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.LogsScreen.IconCloseLog.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Property.CloseXCloseTab' at Center.", repo.ApplicationUnderTest.Property.CloseXCloseTabInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.Property.CloseXCloseTab.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
