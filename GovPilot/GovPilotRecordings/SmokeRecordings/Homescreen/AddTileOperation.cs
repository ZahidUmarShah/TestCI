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
    ///The AddTileOperation recording.
    /// </summary>
    [TestModule("8262c856-0b32-488b-bb1d-85376897008b", ModuleType.Recording, 1)]
    public partial class AddTileOperation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static AddTileOperation instance = new AddTileOperation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddTileOperation()
        {
            ViewName1 = "";
            ViewName2 = "";
            ViewName3 = "";
            ViewName5 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddTileOperation Instance
        {
            get { return instance; }
        }

#region Variables

        string _ViewName1;

        /// <summary>
        /// Gets or sets the value of variable ViewName1.
        /// </summary>
        [TestVariable("eebb097e-ab35-473a-a0a9-c33a7e873fa2")]
        public string ViewName1
        {
            get { return _ViewName1; }
            set { _ViewName1 = value; }
        }

        string _ViewName2;

        /// <summary>
        /// Gets or sets the value of variable ViewName2.
        /// </summary>
        [TestVariable("b61b6c72-a61b-45f4-885f-20d078ec2293")]
        public string ViewName2
        {
            get { return _ViewName2; }
            set { _ViewName2 = value; }
        }

        string _ViewName3;

        /// <summary>
        /// Gets or sets the value of variable ViewName3.
        /// </summary>
        [TestVariable("05e251be-8a01-4a44-9b83-ed2bd8d8d22c")]
        public string ViewName3
        {
            get { return _ViewName3; }
            set { _ViewName3 = value; }
        }

        string _ViewName5;

        /// <summary>
        /// Gets or sets the value of variable ViewName5.
        /// </summary>
        [TestVariable("fa093d1c-1f04-4c23-a04d-8d8b872a6b1b")]
        public string ViewName5
        {
            get { return _ViewName5; }
            set { _ViewName5 = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Link_AddTile'", repo.ApplicationUnderTest.HomePage.Link_AddTileInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePage.Link_AddTileInfo.WaitForAttributeEqual(30000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Link_AddTile' at Center.", repo.ApplicationUnderTest.HomePage.Link_AddTileInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.Link_AddTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Window_AddTile'", repo.ApplicationUnderTest.HomePage.Window_AddTileInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.HomePage.Window_AddTileInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            // Add The Views to the New Tile
            Report.Log(ReportLevel.Info, "Section", "Add The Views to the New Tile", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "User", "Adding the Maximum Four Created Views to the Tile", new RecordItemIndex(5));
            
            HelperClass.SelectViewName(ViewName1);
            Delay.Milliseconds(0);
            
            HelperClass.SelectViewName(ViewName2);
            Delay.Milliseconds(0);
            
            HelperClass.SelectViewName(ViewName3);
            Delay.Milliseconds(0);
            
            HelperClass.SelectViewName(ViewName5);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Four Views Selected to be added", new RecordItemIndex(10));
            
            // Add Tile of the Above Selected Views
            Report.Log(ReportLevel.Info, "Section", "Add Tile of the Above Selected Views", new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_AddTile'", repo.ApplicationUnderTest.HomePage.Btn_AddTileInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.HomePage.Btn_AddTileInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Btn_AddTile' at Center.", repo.ApplicationUnderTest.HomePage.Btn_AddTileInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.HomePage.Btn_AddTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Add Tile Button Clicked", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
