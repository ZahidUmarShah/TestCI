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

namespace GovPilot.GovPilotRecordings.SmokeRecordings.Homescreen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseTileFunctionality recording.
    /// </summary>
    [TestModule("14e34b03-8b89-4eb0-84db-bfc56b28c9c3", ModuleType.Recording, 1)]
    public partial class CloseTileFunctionality : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CloseTileFunctionality instance = new CloseTileFunctionality();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseTileFunctionality()
        {
            ViewName1 = "BreedMix";
            TxtOnTile = "Add a tile";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseTileFunctionality Instance
        {
            get { return instance; }
        }

#region Variables

        string _ViewName1;

        /// <summary>
        /// Gets or sets the value of variable ViewName1.
        /// </summary>
        [TestVariable("c2be371d-999f-4250-aa86-75bc081ed96a")]
        public string ViewName1
        {
            get { return _ViewName1; }
            set { _ViewName1 = value; }
        }

        string _TxtOnTile;

        /// <summary>
        /// Gets or sets the value of variable TxtOnTile.
        /// </summary>
        [TestVariable("bd9c267f-be31-48e7-a9e0-986c082640d4")]
        public string TxtOnTile
        {
            get { return _TxtOnTile; }
            set { _TxtOnTile = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Link_AddTile'", repo.ApplicationUnderTest.HomePage.Link_AddTileInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.Link_AddTileInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Link_AddTile' at Center.", repo.ApplicationUnderTest.HomePage.Link_AddTileInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.Link_AddTile.Click();
            Delay.Milliseconds(0);
            
            // To perform close tile funtionality
            Report.Log(ReportLevel.Info, "Section", "To perform close tile funtionality", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "User", "To Close a Tile upon selection", new RecordItemIndex(4));
            
            HelperClass.CloseTile(ViewName1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            // Verify the View Is not added to the Tile on which the Close Tile Operation was perfomed
            Report.Log(ReportLevel.Info, "Section", "Verify the View Is not added to the Tile on which the Close Tile Operation was perfomed", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$TxtOnTile) on item 'ApplicationUnderTest.HomePage.TxtTile_Name'.", repo.ApplicationUnderTest.HomePage.TxtTile_NameInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.HomePage.TxtTile_NameInfo, "InnerText", TxtOnTile);
            Delay.Milliseconds(0);
            
            // Refresh to Remove the Check Mark on View Name on Add Tile Window
            Report.Log(ReportLevel.Info, "Section", "Refresh to Remove the Check Mark on View Name on Add Tile Window", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Link_AddTile'", repo.ApplicationUnderTest.HomePage.Link_AddTileInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.HomePage.Link_AddTileInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Link_AddTile' at Center.", repo.ApplicationUnderTest.HomePage.Link_AddTileInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.HomePage.Link_AddTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Removing the check mark of Selected View for close tile funtionality", new RecordItemIndex(14));
            
            HelperClass.SelectViewName(ViewName1);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_CloseTile'", repo.ApplicationUnderTest.HomePage.Btn_CloseTileInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.HomePage.Btn_CloseTileInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Btn_CloseTile' at Center.", repo.ApplicationUnderTest.HomePage.Btn_CloseTileInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.HomePage.Btn_CloseTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
