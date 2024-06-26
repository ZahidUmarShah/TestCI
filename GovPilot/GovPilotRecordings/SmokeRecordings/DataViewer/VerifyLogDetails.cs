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
    ///The VerifyLogDetails recording.
    /// </summary>
    [TestModule("26a7f9ae-bfef-4a33-852f-52a55bd0ac86", ModuleType.Recording, 1)]
    public partial class VerifyLogDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static VerifyLogDetails instance = new VerifyLogDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyLogDetails()
        {
            LogEmail1 = "";
            LogRecordID = "";
            VerifyLogID = "";
            EmailinLog = "";
            FirstNameInLogs = "yourValue";
            LastNameInLogs = "yourValue";
            PhoneInLogs = "yourValue";
            Address2InLogs = "yourValue";
            BreedInLogs = "yourValue";
            PetNameInLogs = "yourValue";
            DateOnGrid = "05/21/2024 04:20:14 AM";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyLogDetails Instance
        {
            get { return instance; }
        }

#region Variables

        string _LogEmail1;

        /// <summary>
        /// Gets or sets the value of variable LogEmail1.
        /// </summary>
        [TestVariable("e478d61e-2147-42cb-908f-07c979189c71")]
        public string LogEmail1
        {
            get { return _LogEmail1; }
            set { _LogEmail1 = value; }
        }

        string _LogRecordID;

        /// <summary>
        /// Gets or sets the value of variable LogRecordID.
        /// </summary>
        [TestVariable("6aa62025-758f-49a4-b92a-e385e9ee0319")]
        public string LogRecordID
        {
            get { return _LogRecordID; }
            set { _LogRecordID = value; }
        }

        string _VerifyLogID;

        /// <summary>
        /// Gets or sets the value of variable VerifyLogID.
        /// </summary>
        [TestVariable("67446c4b-a531-4682-acf5-213a4a4bb279")]
        public string VerifyLogID
        {
            get { return _VerifyLogID; }
            set { _VerifyLogID = value; }
        }

        string _EmailinLog;

        /// <summary>
        /// Gets or sets the value of variable EmailinLog.
        /// </summary>
        [TestVariable("b08e7c8a-682f-4dd3-8252-5760f19b7700")]
        public string EmailinLog
        {
            get { return _EmailinLog; }
            set { _EmailinLog = value; }
        }

        string _FirstNameInLogs;

        /// <summary>
        /// Gets or sets the value of variable FirstNameInLogs.
        /// </summary>
        [TestVariable("69e8459f-6350-4206-8225-de97920f7680")]
        public string FirstNameInLogs
        {
            get { return _FirstNameInLogs; }
            set { _FirstNameInLogs = value; }
        }

        string _LastNameInLogs;

        /// <summary>
        /// Gets or sets the value of variable LastNameInLogs.
        /// </summary>
        [TestVariable("8c56775b-5920-4a38-9cd7-ef0e95e2eb00")]
        public string LastNameInLogs
        {
            get { return _LastNameInLogs; }
            set { _LastNameInLogs = value; }
        }

        string _PhoneInLogs;

        /// <summary>
        /// Gets or sets the value of variable PhoneInLogs.
        /// </summary>
        [TestVariable("7b03186b-e2ed-4418-a53f-8b3f893d274d")]
        public string PhoneInLogs
        {
            get { return _PhoneInLogs; }
            set { _PhoneInLogs = value; }
        }

        string _Address2InLogs;

        /// <summary>
        /// Gets or sets the value of variable Address2InLogs.
        /// </summary>
        [TestVariable("1165afd8-e9ce-49d1-8e0a-fda51a7887de")]
        public string Address2InLogs
        {
            get { return _Address2InLogs; }
            set { _Address2InLogs = value; }
        }

        string _BreedInLogs;

        /// <summary>
        /// Gets or sets the value of variable BreedInLogs.
        /// </summary>
        [TestVariable("1d7dc83e-d8eb-4e33-9275-09d889e81bb9")]
        public string BreedInLogs
        {
            get { return _BreedInLogs; }
            set { _BreedInLogs = value; }
        }

        string _PetNameInLogs;

        /// <summary>
        /// Gets or sets the value of variable PetNameInLogs.
        /// </summary>
        [TestVariable("9b4dd023-4945-4024-9cdb-0456a99ec129")]
        public string PetNameInLogs
        {
            get { return _PetNameInLogs; }
            set { _PetNameInLogs = value; }
        }

        string _DateOnGrid;

        /// <summary>
        /// Gets or sets the value of variable DateOnGrid.
        /// </summary>
        [TestVariable("9b074e54-d2b6-4f73-983c-06c65393fc3c")]
        public string DateOnGrid
        {
            get { return _DateOnGrid; }
            set { _DateOnGrid = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.IconViewForm'", repo.ApplicationUnderTest.HomePage.IconViewFormInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.IconViewFormInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.IconViewForm' at Center.", repo.ApplicationUnderTest.HomePage.IconViewFormInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.IconViewForm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.LogsScreen.BtnLog'", repo.ApplicationUnderTest.LogsScreen.BtnLogInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.LogsScreen.BtnLogInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LogsScreen.BtnLog' at Center.", repo.ApplicationUnderTest.LogsScreen.BtnLogInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.LogsScreen.BtnLog.Click();
            Delay.Milliseconds(0);
            
            // Verifying if Log Screen Launched
            Report.Log(ReportLevel.Info, "Validation", "Verifying if Log Screen Launched\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.LogsScreen.WindowLog'.", repo.ApplicationUnderTest.LogsScreen.WindowLogInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.WindowLogInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.LogsScreen.RecordIDInLog' and assigning its value to variable 'LogRecordID'.", repo.ApplicationUnderTest.LogsScreen.RecordIDInLogInfo, new RecordItemIndex(6));
            LogRecordID = repo.ApplicationUnderTest.LogsScreen.RecordIDInLog.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", LogRecordID, new RecordItemIndex(7));
            
            // Verifying that Captured RecordID on Grid matches the RecordID edited in Logs screen
            Report.Log(ReportLevel.Info, "Validation", "Verifying that Captured RecordID on Grid matches the RecordID edited in Logs screen\r\nValidating AttributeEqual (InnerText=$VerifyLogID) on item 'ApplicationUnderTest.LogsScreen.RecordIDInLog'.", repo.ApplicationUnderTest.LogsScreen.RecordIDInLogInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.RecordIDInLogInfo, "InnerText", VerifyLogID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LogsScreen.RecordIDInLog' at Center.", repo.ApplicationUnderTest.LogsScreen.RecordIDInLogInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.LogsScreen.RecordIDInLog.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            Delay.Duration(2000, false);
            
            // Verifying that Edited On Date displayed on Log screen matches Edited On date displayed on grid
            Report.Log(ReportLevel.Info, "Validation", "Verifying that Edited On Date displayed on Log screen matches Edited On date displayed on grid\r\nValidating AttributeContains (InnerText>$DateOnGrid) on item 'ApplicationUnderTest.LogsScreen.EditedDateInLogScreen'.", repo.ApplicationUnderTest.LogsScreen.EditedDateInLogScreenInfo, new RecordItemIndex(11));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.EditedDateInLogScreenInfo, "InnerText", DateOnGrid);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.LogsScreen.LogsEmailID' and assigning its value to variable 'EmailinLog'.", repo.ApplicationUnderTest.LogsScreen.LogsEmailIDInfo, new RecordItemIndex(12));
            EmailinLog = repo.ApplicationUnderTest.LogsScreen.LogsEmailID.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", EmailinLog, new RecordItemIndex(13));
            
            // Verifying that Email on the Log page on the Changed Information section matches with Email Used while filling the details on Edit screen
            Report.Log(ReportLevel.Info, "Validation", "Verifying that Email on the Log page on the Changed Information section matches with Email Used while filling the details on Edit screen\r\nValidating AttributeContains (InnerText>$LogEmail1) on item 'ApplicationUnderTest.LogsScreen.LogsEmailID'.", repo.ApplicationUnderTest.LogsScreen.LogsEmailIDInfo, new RecordItemIndex(14));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.LogsEmailIDInfo, "InnerText", LogEmail1);
            Delay.Milliseconds(0);
            
            // Verifying that FirstName on the Log page on the Changed Information section matches with FirstName Used while filling the details on Edit screen
            Report.Log(ReportLevel.Info, "Validation", "Verifying that FirstName on the Log page on the Changed Information section matches with FirstName Used while filling the details on Edit screen\r\nValidating AttributeEqual (InnerText=$FirstNameInLogs) on item 'ApplicationUnderTest.LogsScreen.TDFirstNameInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDFirstNameInLogsInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.TDFirstNameInLogsInfo, "InnerText", FirstNameInLogs);
            Delay.Milliseconds(0);
            
            // Verifying that LastName on the Log page on the Changed Information section matches with LastName Used while filling the details on Edit screen
            Report.Log(ReportLevel.Info, "Validation", "Verifying that LastName on the Log page on the Changed Information section matches with LastName Used while filling the details on Edit screen\r\nValidating AttributeEqual (InnerText=$LastNameInLogs) on item 'ApplicationUnderTest.LogsScreen.TDLasttNameInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDLasttNameInLogsInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.TDLasttNameInLogsInfo, "InnerText", LastNameInLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>$Address2InLogs) on item 'ApplicationUnderTest.LogsScreen.TDAddress2InLogs'.", repo.ApplicationUnderTest.LogsScreen.TDAddress2InLogsInfo, new RecordItemIndex(17));
            Validate.AttributeContains(repo.ApplicationUnderTest.LogsScreen.TDAddress2InLogsInfo, "InnerText", Address2InLogs);
            Delay.Milliseconds(0);
            
            // Verifying that Phone on the Log page on the Changed Information section matches with Phone Used while filling the details on Edit screen
            //Report.Log(ReportLevel.Info, "Validation", "Verifying that Phone on the Log page on the Changed Information section matches with Phone Used while filling the details on Edit screen\r\nValidating AttributeEqual (InnerText=$PhoneInLogs) on item 'ApplicationUnderTest.LogsScreen.TDPhoneInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDPhoneInLogsInfo, new RecordItemIndex(18));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.TDPhoneInLogsInfo, "InnerText", PhoneInLogs);
            //Delay.Milliseconds(0);
            
            // Verifying that Breed on the Log page on the Changed Information section matches with Breed Used while filling the details on Edit screen
            Report.Log(ReportLevel.Info, "Validation", "Verifying that Breed on the Log page on the Changed Information section matches with Breed Used while filling the details on Edit screen\r\nValidating AttributeEqual (InnerText=$BreedInLogs) on item 'ApplicationUnderTest.LogsScreen.TDBreedInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDBreedInLogsInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.TDBreedInLogsInfo, "InnerText", BreedInLogs);
            Delay.Milliseconds(0);
            
            // Verifying that PetName on the Log page on the Changed Information section matches with Pet Name Used while filling the details on Edit screen
            Report.Log(ReportLevel.Info, "Validation", "Verifying that PetName on the Log page on the Changed Information section matches with Pet Name Used while filling the details on Edit screen\r\nValidating AttributeEqual (InnerText=$PetNameInLogs) on item 'ApplicationUnderTest.LogsScreen.TDPetNameInLogs'.", repo.ApplicationUnderTest.LogsScreen.TDPetNameInLogsInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.ApplicationUnderTest.LogsScreen.TDPetNameInLogsInfo, "InnerText", PetNameInLogs);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LogsScreen.IconCloseLog' at Center.", repo.ApplicationUnderTest.LogsScreen.IconCloseLogInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.LogsScreen.IconCloseLog.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnCLose' at Center.", repo.ApplicationUnderTest.HomePage.BtnCLoseInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.HomePage.BtnCLose.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking EnsureVisible() on item 'ApplicationUnderTest.DataViewerGrid.AllView'.", repo.ApplicationUnderTest.DataViewerGrid.AllViewInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.DataViewerGrid.AllView.EnsureVisible();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.DataViewerGrid.AllView'.", repo.ApplicationUnderTest.DataViewerGrid.AllViewInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.DataViewerGrid.AllView.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(25));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DataViewerGrid.SaveMyView' at Center.", repo.ApplicationUnderTest.DataViewerGrid.SaveMyViewInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.DataViewerGrid.SaveMyView.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(27));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
