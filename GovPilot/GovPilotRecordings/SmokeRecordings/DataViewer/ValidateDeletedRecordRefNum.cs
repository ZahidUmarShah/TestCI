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
    ///The ValidateDeletedRecordRefNum recording.
    /// </summary>
    [TestModule("7e463756-f8cf-429c-bc7a-90e7b57b55c7", ModuleType.Recording, 1)]
    public partial class ValidateDeletedRecordRefNum : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static ValidateDeletedRecordRefNum instance = new ValidateDeletedRecordRefNum();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateDeletedRecordRefNum()
        {
            RefNumInRecycleBin = "";
            VerifyRefNuminRecycle = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateDeletedRecordRefNum Instance
        {
            get { return instance; }
        }

#region Variables

        string _RefNumInRecycleBin;

        /// <summary>
        /// Gets or sets the value of variable RefNumInRecycleBin.
        /// </summary>
        [TestVariable("333d494a-2beb-4b08-8ff5-15dedb74462a")]
        public string RefNumInRecycleBin
        {
            get { return _RefNumInRecycleBin; }
            set { _RefNumInRecycleBin = value; }
        }

        string _VerifyRefNuminRecycle;

        /// <summary>
        /// Gets or sets the value of variable VerifyRefNuminRecycle.
        /// </summary>
        [TestVariable("b8a709f9-8e5f-4651-9781-30a094c8e621")]
        public string VerifyRefNuminRecycle
        {
            get { return _VerifyRefNuminRecycle; }
            set { _VerifyRefNuminRecycle = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.RecycleBin.RefNumInRecycleBin' and assigning its value to variable 'RefNumInRecycleBin'.", repo.ApplicationUnderTest.RecycleBin.RefNumInRecycleBinInfo, new RecordItemIndex(0));
            RefNumInRecycleBin = repo.ApplicationUnderTest.RecycleBin.RefNumInRecycleBin.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", RefNumInRecycleBin, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$VerifyRefNuminRecycle) on item 'ApplicationUnderTest.RecycleBin.RefNumInRecycleBin'.", repo.ApplicationUnderTest.RecycleBin.RefNumInRecycleBinInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.RecycleBin.RefNumInRecycleBinInfo, "InnerText", VerifyRefNuminRecycle);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
