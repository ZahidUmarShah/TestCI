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
    ///The CreateNewRecord recording.
    /// </summary>
    [TestModule("5195f731-da58-4404-b2d4-93143a656ac4", ModuleType.Recording, 1)]
    public partial class CreateNewRecord : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static CreateNewRecord instance = new CreateNewRecord();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateNewRecord()
        {
            PropAddress = "yourtext";
            FirstName = "yourtext";
            SecondName = "yourtext";
            OwnerPhoneNum = "yourtext";
            OwnerEmail = "yourtext";
            Address2 = "yourtext";
            DogName = "yourtext";
            Breed = "yourtext";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateNewRecord Instance
        {
            get { return instance; }
        }

#region Variables

        string _PropAddress;

        /// <summary>
        /// Gets or sets the value of variable PropAddress.
        /// </summary>
        [TestVariable("828df7ca-eec2-4f25-a041-4c89cdacb346")]
        public string PropAddress
        {
            get { return _PropAddress; }
            set { _PropAddress = value; }
        }

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("5608fb20-75aa-4fef-91d0-84e030013ffe")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _SecondName;

        /// <summary>
        /// Gets or sets the value of variable SecondName.
        /// </summary>
        [TestVariable("e4135864-a3b0-4427-b437-83a8d2a19c5f")]
        public string SecondName
        {
            get { return _SecondName; }
            set { _SecondName = value; }
        }

        string _OwnerPhoneNum;

        /// <summary>
        /// Gets or sets the value of variable OwnerPhoneNum.
        /// </summary>
        [TestVariable("b577cb20-f182-4083-b4c4-ff4c2d25d975")]
        public string OwnerPhoneNum
        {
            get { return _OwnerPhoneNum; }
            set { _OwnerPhoneNum = value; }
        }

        string _OwnerEmail;

        /// <summary>
        /// Gets or sets the value of variable OwnerEmail.
        /// </summary>
        [TestVariable("efde9a8d-735c-4ef5-b442-1998e2a8c7bd")]
        public string OwnerEmail
        {
            get { return _OwnerEmail; }
            set { _OwnerEmail = value; }
        }

        string _Address2;

        /// <summary>
        /// Gets or sets the value of variable Address2.
        /// </summary>
        [TestVariable("0796cc15-1e45-4df6-9a0e-dceec91a8f8a")]
        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }

        string _DogName;

        /// <summary>
        /// Gets or sets the value of variable DogName.
        /// </summary>
        [TestVariable("91d4c1e1-be56-42b0-8cf6-aeb57cb7e98b")]
        public string DogName
        {
            get { return _DogName; }
            set { _DogName = value; }
        }

        string _Breed;

        /// <summary>
        /// Gets or sets the value of variable Breed.
        /// </summary>
        [TestVariable("f4d0349e-9731-473a-9664-8d594e6d80dc")]
        public string Breed
        {
            get { return _Breed; }
            set { _Breed = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.BtnCreateNew' at Center.", repo.ApplicationUnderTest.HomePage.BtnCreateNewInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePage.BtnCreateNew.Click();
            Delay.Milliseconds(0);
            
            // Validating if the property finder modal displays
            Report.Log(ReportLevel.Info, "Validation", "Validating if the property finder modal displays\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.HomePage.TitlePropertyFinder'.", repo.ApplicationUnderTest.HomePage.TitlePropertyFinderInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.HomePage.TitlePropertyFinderInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePage.PropSearchVal' at Center.", repo.ApplicationUnderTest.HomePage.PropSearchValInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.HomePage.PropSearchVal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PropAddress' with focus on 'ApplicationUnderTest.HomePage.PropSearchVal'.", repo.ApplicationUnderTest.HomePage.PropSearchValInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.HomePage.PropSearchVal.PressKeys(PropAddress);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Enter}' with focus on 'ApplicationUnderTest.HomePage.PropSearchVal'.", repo.ApplicationUnderTest.HomePage.PropSearchValInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.HomePage.PropSearchVal.PressKeys("{Down}{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.CreateNewScreen.TxtFirstName'", repo.ApplicationUnderTest.CreateNewScreen.TxtFirstNameInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.CreateNewScreen.TxtFirstNameInfo.WaitForAttributeEqual(10000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.TxtFirstName' at Center.", repo.ApplicationUnderTest.CreateNewScreen.TxtFirstNameInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.CreateNewScreen.TxtFirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'ApplicationUnderTest.CreateNewScreen.TxtFirstName'.", repo.ApplicationUnderTest.CreateNewScreen.TxtFirstNameInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.CreateNewScreen.TxtFirstName.PressKeys(FirstName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.TxtSecondName' at Center.", repo.ApplicationUnderTest.CreateNewScreen.TxtSecondNameInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.CreateNewScreen.TxtSecondName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SecondName' with focus on 'ApplicationUnderTest.CreateNewScreen.TxtSecondName'.", repo.ApplicationUnderTest.CreateNewScreen.TxtSecondNameInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.CreateNewScreen.TxtSecondName.PressKeys(SecondName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.TxtOwnerPhoneNum' at Center.", repo.ApplicationUnderTest.CreateNewScreen.TxtOwnerPhoneNumInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.CreateNewScreen.TxtOwnerPhoneNum.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$OwnerPhoneNum' with focus on 'ApplicationUnderTest.CreateNewScreen.TxtOwnerPhoneNum'.", repo.ApplicationUnderTest.CreateNewScreen.TxtOwnerPhoneNumInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.CreateNewScreen.TxtOwnerPhoneNum.PressKeys(OwnerPhoneNum);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.TxtEmail' at Center.", repo.ApplicationUnderTest.CreateNewScreen.TxtEmailInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.CreateNewScreen.TxtEmail.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$OwnerEmail' with focus on 'ApplicationUnderTest.CreateNewScreen.TxtEmail'.", repo.ApplicationUnderTest.CreateNewScreen.TxtEmailInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.CreateNewScreen.TxtEmail.PressKeys(OwnerEmail);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.TxtAddress2' at Center.", repo.ApplicationUnderTest.CreateNewScreen.TxtAddress2Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.CreateNewScreen.TxtAddress2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Address2' with focus on 'ApplicationUnderTest.CreateNewScreen.TxtAddress2'.", repo.ApplicationUnderTest.CreateNewScreen.TxtAddress2Info, new RecordItemIndex(16));
            repo.ApplicationUnderTest.CreateNewScreen.TxtAddress2.PressKeys(Address2);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.Txt_DogName' at Center.", repo.ApplicationUnderTest.CreateNewScreen.Txt_DogNameInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.CreateNewScreen.Txt_DogName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DogName' with focus on 'ApplicationUnderTest.CreateNewScreen.Txt_DogName'.", repo.ApplicationUnderTest.CreateNewScreen.Txt_DogNameInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.CreateNewScreen.Txt_DogName.PressKeys(DogName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.TxtBreedInput' at Center.", repo.ApplicationUnderTest.CreateNewScreen.TxtBreedInputInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.CreateNewScreen.TxtBreedInput.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Breed' with focus on 'ApplicationUnderTest.CreateNewScreen.TxtBreedInput'.", repo.ApplicationUnderTest.CreateNewScreen.TxtBreedInputInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.CreateNewScreen.TxtBreedInput.PressKeys(Breed);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}'.", new RecordItemIndex(21));
            Keyboard.Press("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateNewScreen.BtnSaveNew' at Center.", repo.ApplicationUnderTest.CreateNewScreen.BtnSaveNewInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.CreateNewScreen.BtnSaveNew.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
