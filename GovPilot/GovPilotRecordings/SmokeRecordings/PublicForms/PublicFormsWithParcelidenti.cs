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
    ///The PublicFormsWithParcelidenti recording.
    /// </summary>
    [TestModule("ff48552e-ccf3-4f92-ab9b-54b8806ba6fd", ModuleType.Recording, 1)]
    public partial class PublicFormsWithParcelidenti : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::GovPilot.GovPilotRepository repository.
        /// </summary>
        public static global::GovPilot.GovPilotRepository repo = global::GovPilot.GovPilotRepository.Instance;

        static PublicFormsWithParcelidenti instance = new PublicFormsWithParcelidenti();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PublicFormsWithParcelidenti()
        {
            SearchByProperty = "yourtext";
            Breed = "yourtext";
            Color = "yourtext";
            HairLength = "";
            Size = "";
            Sex = "";
            Age = "";
            Spayed = "";
            ServiceDog = "";
            RabisExp = "";
            GetReferenceNumber = "";
            InputValue = "";
            randomEmail = "";
            randomPhoneNumber = "";
            date = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PublicFormsWithParcelidenti Instance
        {
            get { return instance; }
        }

#region Variables

        string _SearchByProperty;

        /// <summary>
        /// Gets or sets the value of variable SearchByProperty.
        /// </summary>
        [TestVariable("fab3b4ea-5a56-41c5-8bcb-80000ec09444")]
        public string SearchByProperty
        {
            get { return _SearchByProperty; }
            set { _SearchByProperty = value; }
        }

        string _Breed;

        /// <summary>
        /// Gets or sets the value of variable Breed.
        /// </summary>
        [TestVariable("35f60525-40b4-461e-af39-df8ffa6a6d1a")]
        public string Breed
        {
            get { return _Breed; }
            set { _Breed = value; }
        }

        string _Color;

        /// <summary>
        /// Gets or sets the value of variable Color.
        /// </summary>
        [TestVariable("5d14235f-0245-4d68-900e-673c8960ce99")]
        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        string _HairLength;

        /// <summary>
        /// Gets or sets the value of variable HairLength.
        /// </summary>
        [TestVariable("2e00b5e1-8f5b-4405-8da4-6c1fa867cf1d")]
        public string HairLength
        {
            get { return _HairLength; }
            set { _HairLength = value; }
        }

        string _Size;

        /// <summary>
        /// Gets or sets the value of variable Size.
        /// </summary>
        [TestVariable("b866d122-b878-4dbe-968f-c39cacd50144")]
        public string Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        string _Sex;

        /// <summary>
        /// Gets or sets the value of variable Sex.
        /// </summary>
        [TestVariable("ef465870-714b-41c7-984e-03779a3ac556")]
        public string Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        string _Age;

        /// <summary>
        /// Gets or sets the value of variable Age.
        /// </summary>
        [TestVariable("1a239f1f-e481-48f7-b405-e89415da77db")]
        public string Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        string _Spayed;

        /// <summary>
        /// Gets or sets the value of variable Spayed.
        /// </summary>
        [TestVariable("71409e97-0da4-417c-8279-4009922d5ce8")]
        public string Spayed
        {
            get { return _Spayed; }
            set { _Spayed = value; }
        }

        string _ServiceDog;

        /// <summary>
        /// Gets or sets the value of variable ServiceDog.
        /// </summary>
        [TestVariable("16733dcc-ff74-40bb-97fc-7649a89ad613")]
        public string ServiceDog
        {
            get { return _ServiceDog; }
            set { _ServiceDog = value; }
        }

        string _RabisExp;

        /// <summary>
        /// Gets or sets the value of variable RabisExp.
        /// </summary>
        [TestVariable("98275be6-9e51-462e-888b-4f0250e65871")]
        public string RabisExp
        {
            get { return _RabisExp; }
            set { _RabisExp = value; }
        }

        string _GetReferenceNumber;

        /// <summary>
        /// Gets or sets the value of variable GetReferenceNumber.
        /// </summary>
        [TestVariable("00a4c68d-6b50-47c8-a6ba-fed35ff3addb")]
        public string GetReferenceNumber
        {
            get { return _GetReferenceNumber; }
            set { _GetReferenceNumber = value; }
        }

        string _InputValue;

        /// <summary>
        /// Gets or sets the value of variable InputValue.
        /// </summary>
        [TestVariable("7d2cc799-2cd6-4c84-a0d5-cf611843abb4")]
        public string InputValue
        {
            get { return _InputValue; }
            set { _InputValue = value; }
        }

        string _randomEmail;

        /// <summary>
        /// Gets or sets the value of variable randomEmail.
        /// </summary>
        [TestVariable("c6f62777-1d5e-429c-80a3-999eb4c0252b")]
        public string randomEmail
        {
            get { return _randomEmail; }
            set { _randomEmail = value; }
        }

        string _randomPhoneNumber;

        /// <summary>
        /// Gets or sets the value of variable randomPhoneNumber.
        /// </summary>
        [TestVariable("c95fd957-b319-4593-896f-4e4178d78f64")]
        public string randomPhoneNumber
        {
            get { return _randomPhoneNumber; }
            set { _randomPhoneNumber = value; }
        }

        string _date;

        /// <summary>
        /// Gets or sets the value of variable date.
        /// </summary>
        [TestVariable("9f103aae-c12a-46d5-bcd0-194ad205d0ea")]
        public string date
        {
            get { return _date; }
            set { _date = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 12s.", new RecordItemIndex(0));
            Delay.Duration(12000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Radio_ParcelIdentifier' at Center.", repo.ApplicationUnderTest.PublicForms.Radio_ParcelIdentifierInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.PublicForms.Radio_ParcelIdentifier.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Input_text_SearchByParcelIdentifier' at Center.", repo.ApplicationUnderTest.PublicForms.Input_text_SearchByParcelIdentifierInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.PublicForms.Input_text_SearchByParcelIdentifier.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SearchByProperty' with focus on 'ApplicationUnderTest.PublicForms.Input_text_SearchByParcelIdentifier'.", repo.ApplicationUnderTest.PublicForms.Input_text_SearchByParcelIdentifierInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.PublicForms.Input_text_SearchByParcelIdentifier.PressKeys(SearchByProperty);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(5));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}'.", new RecordItemIndex(6));
            Keyboard.Press("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(7));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_FirstNameInfo, "FirstName_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(9));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_LastNameInfo, "LastName_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(11));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Set_Phonenumber(repo.ApplicationUnderTest.PublicForms.Input_text_PhoneNumberInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(13));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_email(repo.ApplicationUnderTest.PublicForms.Input_text_EmailInfo, "Email_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(15));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_DogNameInfo, "DogName_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(17));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Breed' with focus on 'ApplicationUnderTest.PublicForms.Select_Breed'.", repo.ApplicationUnderTest.PublicForms.Select_BreedInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.PublicForms.Select_Breed.PressKeys(Breed);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(19));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Color' with focus on 'ApplicationUnderTest.PublicForms.Input_text_Color'.", repo.ApplicationUnderTest.PublicForms.Input_text_ColorInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.PublicForms.Input_text_Color.PressKeys(Color);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(21));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$HairLength' with focus on 'ApplicationUnderTest.PublicForms.Select_HairLength'.", repo.ApplicationUnderTest.PublicForms.Select_HairLengthInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.PublicForms.Select_HairLength.PressKeys(HairLength);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(23));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Size' with focus on 'ApplicationUnderTest.PublicForms.Select_Size'.", repo.ApplicationUnderTest.PublicForms.Select_SizeInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.PublicForms.Select_Size.PressKeys(Size);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(25));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sex' with focus on 'ApplicationUnderTest.PublicForms.Select_Sex'.", repo.ApplicationUnderTest.PublicForms.Select_SexInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.PublicForms.Select_Sex.PressKeys(Sex);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(27));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.PublicForms.Input_text_Age'.", repo.ApplicationUnderTest.PublicForms.Input_text_AgeInfo, new RecordItemIndex(28));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.PublicForms.Input_text_Age);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Age' with focus on 'ApplicationUnderTest.PublicForms.Input_text_Age'.", repo.ApplicationUnderTest.PublicForms.Input_text_AgeInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.PublicForms.Input_text_Age.PressKeys(Age);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(30));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Spayed' with focus on 'ApplicationUnderTest.PublicForms.Select_Spayed'.", repo.ApplicationUnderTest.PublicForms.Select_SpayedInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.PublicForms.Select_Spayed.PressKeys(Spayed);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(32));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ServiceDog' with focus on 'ApplicationUnderTest.PublicForms.Select_ServiceDog'.", repo.ApplicationUnderTest.PublicForms.Select_ServiceDogInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.PublicForms.Select_ServiceDog.PressKeys(ServiceDog);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(34));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_VeterinarianNameInfo, "VetName_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(36));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_VeterinarianAddressInfo, "Address_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(38));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_Phonenumber(repo.ApplicationUnderTest.PublicForms.Input_text_VeterinarianPhoneNumberInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Btn_UploadNewFile' at Center.", repo.ApplicationUnderTest.PublicForms.Btn_UploadNewFileInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.PublicForms.Btn_UploadNewFile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.PublicForms.Title_UploadFileTitle'.", repo.ApplicationUnderTest.PublicForms.Title_UploadFileTitleInfo, new RecordItemIndex(41));
            Validate.Exists(repo.ApplicationUnderTest.PublicForms.Title_UploadFileTitleInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(42));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_FileDescriptionInfo, "FileDescription_", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Btn_SelectFile' at Center.", repo.ApplicationUnderTest.PublicForms.Btn_SelectFileInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.PublicForms.Btn_SelectFile.Click();
            Delay.Milliseconds(0);
            
            ChooseFile(repo.ChooseFiles.FileSelectInfo, "\\TestDocument.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ChooseFiles.Btn_open' at Center.", repo.ChooseFiles.Btn_openInfo, new RecordItemIndex(46));
            repo.ChooseFiles.Btn_open.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.PublicForms.Btn_Done'", repo.ApplicationUnderTest.PublicForms.Btn_DoneInfo, new RecordItemIndex(47));
            repo.ApplicationUnderTest.PublicForms.Btn_DoneInfo.WaitForAttributeEqual(40000, "Visible", "True");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(48));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PublicForms.Btn_Done' at Center.", repo.ApplicationUnderTest.PublicForms.Btn_DoneInfo, new RecordItemIndex(49));
            repo.ApplicationUnderTest.PublicForms.Btn_Done.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(50));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RabisExp' with focus on 'ApplicationUnderTest.PublicForms.Select_Rabis_VacineExp'.", repo.ApplicationUnderTest.PublicForms.Select_Rabis_VacineExpInfo, new RecordItemIndex(51));
            repo.ApplicationUnderTest.PublicForms.Select_Rabis_VacineExp.PressKeys(RabisExp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(52));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_Current_Future_Date(repo.ApplicationUnderTest.PublicForms.Input_text_VaccinationDateInfo, ValueConverter.ArgumentFromString<int>("days", "2"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(54));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_Current_Future_Date(repo.ApplicationUnderTest.PublicForms.Input_text_VaccinationExpDateInfo, ValueConverter.ArgumentFromString<int>("days", "20"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(56));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Set_value_Input(repo.ApplicationUnderTest.PublicForms.Input_text_ApplicantSignInfo, "Sign", "8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Enter}' with focus on 'ApplicationUnderTest.PublicForms.Input_text_ApplicantSign'.", repo.ApplicationUnderTest.PublicForms.Input_text_ApplicantSignInfo, new RecordItemIndex(58));
            repo.ApplicationUnderTest.PublicForms.Input_text_ApplicantSign.PressKeys("{Enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(59));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'ApplicationUnderTest.PublicForms.Btn_Submit'.", repo.ApplicationUnderTest.PublicForms.Btn_SubmitInfo, new RecordItemIndex(60));
            repo.ApplicationUnderTest.PublicForms.Btn_Submit.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'ApplicationUnderTest.PublicForms.Btn_Submit'.", repo.ApplicationUnderTest.PublicForms.Btn_SubmitInfo, new RecordItemIndex(61));
            repo.ApplicationUnderTest.PublicForms.Btn_Submit.Element.InvokeActionWithText("PerformClick");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s for the attribute 'Visible' to equal the specified value 'True'. Associated repository item: 'ApplicationUnderTest.PublicForms.Output_Text_SuccessMessage'", repo.ApplicationUnderTest.PublicForms.Output_Text_SuccessMessageInfo, new RecordItemIndex(62));
            repo.ApplicationUnderTest.PublicForms.Output_Text_SuccessMessageInfo.WaitForAttributeEqual(40000, "Visible", "True");
            
            // Validate Form successfully submitted or not
            Report.Log(ReportLevel.Info, "Validation", "Validate Form successfully submitted or not\r\nValidating AttributeEqual (Visible='True') on item 'ApplicationUnderTest.PublicForms.Output_Text_SuccessMessage'.", repo.ApplicationUnderTest.PublicForms.Output_Text_SuccessMessageInfo, new RecordItemIndex(63));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PublicForms.Output_Text_SuccessMessageInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            // Generated Refernce number is storing to Global Parameter
            Report.Log(ReportLevel.Info, "Get Value", "Generated Refernce number is storing to Global Parameter\r\nGetting attribute 'InnerText' from item 'ApplicationUnderTest.PublicForms.Output_GetText_ReferenceNumber' and assigning its value to variable 'GetReferenceNumber'.", repo.ApplicationUnderTest.PublicForms.Output_GetText_ReferenceNumberInfo, new RecordItemIndex(64));
            GetReferenceNumber = repo.ApplicationUnderTest.PublicForms.Output_GetText_ReferenceNumber.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
