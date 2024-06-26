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
    ///The ValidationsOnRefNumAndAddress recording.
    /// </summary>
    [TestModule("2e908fe8-4424-4e4e-9081-20913fcf0653", ModuleType.Recording, 1)]
    public partial class ValidationsOnRefNumAndAddress : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static ValidationsOnRefNumAndAddress instance = new ValidationsOnRefNumAndAddress();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidationsOnRefNumAndAddress()
        {
            AddedAddrtoClone = "";
            VerifyAddedAdrrToClone = "yourtext";
            RNum = "";
            VerifyRefNum = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidationsOnRefNumAndAddress Instance
        {
            get { return instance; }
        }

#region Variables

        string _AddedAddrtoClone;

        /// <summary>
        /// Gets or sets the value of variable AddedAddrtoClone.
        /// </summary>
        [TestVariable("22ad52ca-1eee-45e3-ad42-7d26a1d71565")]
        public string AddedAddrtoClone
        {
            get { return _AddedAddrtoClone; }
            set { _AddedAddrtoClone = value; }
        }

        string _VerifyAddedAdrrToClone;

        /// <summary>
        /// Gets or sets the value of variable VerifyAddedAdrrToClone.
        /// </summary>
        [TestVariable("af00e739-1e52-489f-996e-c7dd2722cc8e")]
        public string VerifyAddedAdrrToClone
        {
            get { return _VerifyAddedAdrrToClone; }
            set { _VerifyAddedAdrrToClone = value; }
        }

        string _RNum;

        /// <summary>
        /// Gets or sets the value of variable RNum.
        /// </summary>
        [TestVariable("e4e0c70a-5485-417b-8702-0712ff2ea519")]
        public string RNum
        {
            get { return _RNum; }
            set { _RNum = value; }
        }

        string _VerifyRefNum;

        /// <summary>
        /// Gets or sets the value of variable VerifyRefNum.
        /// </summary>
        [TestVariable("cb8253e2-81b3-4265-b164-54606c07cc67")]
        public string VerifyRefNum
        {
            get { return _VerifyRefNum; }
            set { _VerifyRefNum = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'ApplicationUnderTest.CreateNewScreen.TxtAddress1' and assigning its value to variable 'AddedAddrtoClone'.", repo.ApplicationUnderTest.CreateNewScreen.TxtAddress1Info, new RecordItemIndex(0));
            AddedAddrtoClone = repo.ApplicationUnderTest.CreateNewScreen.TxtAddress1.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", AddedAddrtoClone, new RecordItemIndex(1));
            
            // Validating that Address displayed in the cloned record is same as entered previously on cloning wizard
            Report.Log(ReportLevel.Info, "Validation", "Validating that Address displayed in the cloned record is same as entered previously on cloning wizard\r\nValidating AttributeContains (Value>$VerifyAddedAdrrToClone) on item 'ApplicationUnderTest.CreateNewScreen.TxtAddress1'.", repo.ApplicationUnderTest.CreateNewScreen.TxtAddress1Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.ApplicationUnderTest.CreateNewScreen.TxtAddress1Info, "Value", VerifyAddedAdrrToClone);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'TxtAutoGenReferenceNum' and assigning its value to variable 'RNum'.", repo.TxtAutoGenReferenceNumInfo, new RecordItemIndex(3));
            RNum = repo.TxtAutoGenReferenceNum.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", RNum, new RecordItemIndex(4));
            
            // Validating that Reference Number assigned to the cloned record DOES NOT match the record on which the clone was done
            Report.Log(ReportLevel.Info, "Validation", "Validating that Reference Number assigned to the cloned record DOES NOT match the record on which the clone was done\r\nValidating AttributeNotEqual (Value!=$VerifyRefNum) on item 'TxtAutoGenReferenceNum'.", repo.TxtAutoGenReferenceNumInfo, new RecordItemIndex(5));
            Validate.AttributeNotEqual(repo.TxtAutoGenReferenceNumInfo, "Value", VerifyRefNum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
