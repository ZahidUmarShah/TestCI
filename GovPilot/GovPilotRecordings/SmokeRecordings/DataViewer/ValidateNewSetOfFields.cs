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
    ///The ValidateNewSetOfFields recording.
    /// </summary>
    [TestModule("060dff89-10c0-4f7e-8b16-9ddb6e7d0b93", ModuleType.Recording, 1)]
    public partial class ValidateNewSetOfFields : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static ValidateNewSetOfFields instance = new ValidateNewSetOfFields();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateNewSetOfFields()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateNewSetOfFields Instance
        {
            get { return instance; }
        }

#region Variables

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

            // Validating if Column Record ID exists
            Report.Log(ReportLevel.Info, "Validation", "Validating if Column Record ID exists\r\nValidating Exists on item 'ApplicationUnderTest.DataViewerGrid.ColumnRecordID'.", repo.ApplicationUnderTest.DataViewerGrid.ColumnRecordIDInfo, new RecordItemIndex(0));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.ColumnRecordIDInfo);
            Delay.Milliseconds(0);
            
            // Validating if Column Edited On exists
            Report.Log(ReportLevel.Info, "Validation", "Validating if Column Edited On exists\r\nValidating Exists on item 'ApplicationUnderTest.DataViewerGrid.ColumnEditedOn'.", repo.ApplicationUnderTest.DataViewerGrid.ColumnEditedOnInfo, new RecordItemIndex(1));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.ColumnEditedOnInfo);
            Delay.Milliseconds(0);
            
            // Validating if Column Date Entered exists
            Report.Log(ReportLevel.Info, "Validation", "Validating if Column Date Entered exists\r\nValidating Exists on item 'ApplicationUnderTest.DataViewerGrid.ColumnDateEntered'.", repo.ApplicationUnderTest.DataViewerGrid.ColumnDateEnteredInfo, new RecordItemIndex(2));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.ColumnDateEnteredInfo);
            Delay.Milliseconds(0);
            
            // Validating if Column Status exists
            Report.Log(ReportLevel.Info, "Validation", "Validating if Column Status exists\r\nValidating Exists on item 'ApplicationUnderTest.DataViewerGrid.ColumnStatus'.", repo.ApplicationUnderTest.DataViewerGrid.ColumnStatusInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.ColumnStatusInfo);
            Delay.Milliseconds(0);
            
            // Validating if Column 1 First Name exists
            Report.Log(ReportLevel.Info, "Validation", "Validating if Column 1 First Name exists\r\nValidating Exists on item 'ApplicationUnderTest.DataViewerGrid.Column1FirstName'.", repo.ApplicationUnderTest.DataViewerGrid.Column1FirstNameInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.Column1FirstNameInfo);
            Delay.Milliseconds(0);
            
            // Validating if Column 1 Last Name exists
            Report.Log(ReportLevel.Info, "Validation", "Validating if Column 1 Last Name exists\r\nValidating Exists on item 'ApplicationUnderTest.DataViewerGrid.Column1LastName'.", repo.ApplicationUnderTest.DataViewerGrid.Column1LastNameInfo, new RecordItemIndex(5));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.Column1LastNameInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.DataViewerGrid.ColumnPetName'.", repo.ApplicationUnderTest.DataViewerGrid.ColumnPetNameInfo, new RecordItemIndex(6));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.ColumnPetNameInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.DataViewerGrid.ColumnBreedName'.", repo.ApplicationUnderTest.DataViewerGrid.ColumnBreedNameInfo, new RecordItemIndex(7));
            Validate.Exists(repo.ApplicationUnderTest.DataViewerGrid.ColumnBreedNameInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
