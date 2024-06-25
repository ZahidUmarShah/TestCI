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
    ///The CancelInShareTile recording.
    /// </summary>
    [TestModule("ac2e2787-e1d0-4697-85cc-6c7397cf0554", ModuleType.Recording, 1)]
    public partial class CancelInShareTile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CancelInShareTile instance = new CancelInShareTile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CancelInShareTile()
        {
            EmailId = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CancelInShareTile Instance
        {
            get { return instance; }
        }

#region Variables

        string _EmailId;

        /// <summary>
        /// Gets or sets the value of variable EmailId.
        /// </summary>
        [TestVariable("13c1ca10-89a7-44e2-a002-1e22c53be0e0")]
        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.LnkModules'", repo.ApplicationUnderTest.HomePage.LnkModulesInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.LnkModulesInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(1));
            Delay.Duration(300, false);
            
            // ToVerify if the Added Tile Exists in the Home page
            Report.Log(ReportLevel.Info, "Section", "ToVerify if the Added Tile Exists in the Home page", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "User", "ToVerify if the Added Tile Exists in the Home page", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.InnerText_FirstViewOnTile'", repo.ApplicationUnderTest.HomePage.InnerText_FirstViewOnTileInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.HomePage.InnerText_FirstViewOnTileInfo.WaitForAttributeEqual(60000, "Visible", "True");
            
            // To Verify if the First View Exists on the Tile
            Report.Log(ReportLevel.Info, "Validation", "To Verify if the First View Exists on the Tile\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.InnerText_FirstViewOnTile'.", repo.ApplicationUnderTest.HomePage.InnerText_FirstViewOnTileInfo, new RecordItemIndex(5));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.InnerText_FirstViewOnTileInfo);
            Delay.Milliseconds(0);
            
            // To Verify if the Second View Exists on the Tile
            Report.Log(ReportLevel.Info, "Validation", "To Verify if the Second View Exists on the Tile\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.InnerText_SecondViewOnTile'.", repo.ApplicationUnderTest.HomePage.InnerText_SecondViewOnTileInfo, new RecordItemIndex(6));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.InnerText_SecondViewOnTileInfo);
            Delay.Milliseconds(0);
            
            // To Verify if the Third View Exists on the Tile
            Report.Log(ReportLevel.Info, "Validation", "To Verify if the Third View Exists on the Tile\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTile'.", repo.ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTileInfo, new RecordItemIndex(7));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.InnerText_ThirdViewOnTileInfo);
            Delay.Milliseconds(0);
            
            // To Verify if the Fourth View Exists on the Tile
            Report.Log(ReportLevel.Info, "Validation", "To Verify if the Fourth View Exists on the Tile\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.InnerText_FourthViewOnTile'.", repo.ApplicationUnderTest.HomePage.InnerText_FourthViewOnTileInfo, new RecordItemIndex(8));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.InnerText_FourthViewOnTileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 200ms.", new RecordItemIndex(9));
            Delay.Duration(200, false);
            
            // To Click on Share Tile from the Context Menu
            Report.Log(ReportLevel.Info, "Section", "To Click on Share Tile from the Context Menu", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "User", "To Perform Share Tile Operation", new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "User", "The Context Menu of the Tile in the Home page is to be clicked", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_ContextMenu'", repo.ApplicationUnderTest.HomePage.Btn_ContextMenuInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.HomePage.Btn_ContextMenuInfo.WaitForAttributeEqual(20000, "Visible", "True");
            
            // Verifying if the Context Menu of Three Dots exists for the operation to choose from
            Report.Log(ReportLevel.Info, "Validation", "Verifying if the Context Menu of Three Dots exists for the operation to choose from\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.Btn_ContextMenu'.", repo.ApplicationUnderTest.HomePage.Btn_ContextMenuInfo, new RecordItemIndex(14));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.Btn_ContextMenuInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Btn_ContextMenu' at Center.", repo.ApplicationUnderTest.HomePage.Btn_ContextMenuInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.HomePage.Btn_ContextMenu.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(16));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "User", "The option of Share Tile is selected from the Context Menu", new RecordItemIndex(17));
            
            // Verifying if the Share Tile option is Present after clicking on the context menu of the Tile
            Report.Log(ReportLevel.Info, "Wait", "Verifying if the Share Tile option is Present after clicking on the context menu of the Tile\r\nWaiting 20s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_ShareTile'", repo.ApplicationUnderTest.HomePage.Btn_ShareTileInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.HomePage.Btn_ShareTileInfo.WaitForAttributeEqual(20000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.HomePage.Btn_ShareTile'.", repo.ApplicationUnderTest.HomePage.Btn_ShareTileInfo, new RecordItemIndex(19));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.Btn_ShareTileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Btn_ShareTile' at Center.", repo.ApplicationUnderTest.HomePage.Btn_ShareTileInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.HomePage.Btn_ShareTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(1000, false);
            
            // Cancel Button Click On Share Tile Window
            Report.Log(ReportLevel.Info, "Section", "Cancel Button Click On Share Tile Window", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.PopupWindow_ShareTile'", repo.ApplicationUnderTest.HomePage.PopupWindow_ShareTileInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.HomePage.PopupWindow_ShareTileInfo.WaitForAttributeEqual(20000, "Visible", "True");
            
            // Validating if the Share Tile Pop window Appears
            Report.Log(ReportLevel.Info, "Validation", "Validating if the Share Tile Pop window Appears\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.PopupWindow_ShareTile'.", repo.ApplicationUnderTest.HomePage.PopupWindow_ShareTileInfo, new RecordItemIndex(24));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.PopupWindow_ShareTileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_ConfirmSelection_ShareTile'", repo.ApplicationUnderTest.HomePage.Btn_ConfirmSelection_ShareTileInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.HomePage.Btn_ConfirmSelection_ShareTileInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            // Validating if the Button Confirm Selection appeared on the Share Tile Pop Window
            Report.Log(ReportLevel.Info, "Validation", "Validating if the Button Confirm Selection appeared on the Share Tile Pop Window\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.Btn_ConfirmSelection_ShareTile'.", repo.ApplicationUnderTest.HomePage.Btn_ConfirmSelection_ShareTileInfo, new RecordItemIndex(26));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.Btn_ConfirmSelection_ShareTileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_Cancel_ShareTile'", repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo.WaitForAttributeEqual(15000, "Visible", "True");
            
            // Validating if the Button Cancel appeared on the Share Tile Pop Window
            Report.Log(ReportLevel.Info, "Validation", "Validating if the Button Cancel appeared on the Share Tile Pop Window\r\nValidating Exists on item 'ApplicationUnderTest.HomePage.Btn_Cancel_ShareTile'.", repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo, new RecordItemIndex(28));
            Validate.Exists(repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.TxtBox_Search_ShareTile'", repo.ApplicationUnderTest.HomePage.TxtBox_Search_ShareTileInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.HomePage.TxtBox_Search_ShareTileInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EmailId' with focus on 'ApplicationUnderTest.HomePage.TxtBox_Search_ShareTile'.", repo.ApplicationUnderTest.HomePage.TxtBox_Search_ShareTileInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.HomePage.TxtBox_Search_ShareTile.PressKeys(EmailId);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(31));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.FirstCheckbox_ShareTile'", repo.ApplicationUnderTest.HomePage.FirstCheckbox_ShareTileInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.HomePage.FirstCheckbox_ShareTileInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.FirstCheckbox_ShareTile' at Center.", repo.ApplicationUnderTest.HomePage.FirstCheckbox_ShareTileInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.HomePage.FirstCheckbox_ShareTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Btn_Cancel_ShareTile'", repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.Btn_Cancel_ShareTile' at Center.", repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTileInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.HomePage.Btn_Cancel_ShareTile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(36));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Window_HomePage'", repo.ApplicationUnderTest.HomePage.Window_HomePageInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.HomePage.Window_HomePageInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to not exist. Associated repository item: 'ApplicationUnderTest.HomePage.PopWindowTitle_SharedSuccess'", repo.ApplicationUnderTest.HomePage.PopWindowTitle_SharedSuccessInfo, new ActionTimeout(5000), new RecordItemIndex(38));
            repo.ApplicationUnderTest.HomePage.PopWindowTitle_SharedSuccessInfo.WaitForNotExists(5000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.HomePage.Window_HomePage'", repo.ApplicationUnderTest.HomePage.Window_HomePageInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.HomePage.Window_HomePageInfo.WaitForAttributeEqual(5000, "Visible", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
