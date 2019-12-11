using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class ProfilePage
    {

        private RemoteWebDriver _driver;
        public ProfilePage(RemoteWebDriver driver) => _driver = driver;
        //Availability
        //ClickAvailability
        IWebElement ClickAvailability => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i");
        //ClickAvailableField
        IWebElement ClickAvailabilityField => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select");




        //Hours
        //ClickHours
        IWebElement ClickHours => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i");
        //ClickHoursField
        IWebElement ClickHoursField => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select");



        //EarnTarget
        //ClickEarnTarget
        IWebElement ClickEarnTarget => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i");
        //ClickEarnTargetField
        IWebElement ClickEarnTargetField => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select");





        //Preema
        IWebElement ChangePassword => _driver.FindElementByXPath("//a[contains(text(),'Change Password')]");
        IWebElement OldPassword => _driver.FindElementByName("oldPassword");
        IWebElement NewPassword => _driver.FindElementByName("newPassword");
        IWebElement ConfirmPassword => _driver.FindElementByName("confirmPassword");
        IWebElement ProfileSave => _driver.FindElementByXPath("//button[@role='button']");





        //Search skills by Category and Subcategory
        IWebElement SearchSkills => _driver.FindElementByXPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[2]/input");
        //search user
        IWebElement SearchUser => _driver.FindElementByXPath("//input[@placeholder='Search user']");
        //Get the list of users
        IList<IWebElement> SearchUserList => _driver.FindElementsByXPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div");
        //Online
        IWebElement Online => _driver.FindElementByXPath("//button[contains(.,'Online')]");
        //Onsite
        IWebElement Onsite => _driver.FindElementByXPath("//button[contains(.,'Onsite')]");
        //ShowAll
        IWebElement ShowAll => _driver.FindElementByXPath("//button[contains(.,'ShowAll')]");



        public void Availability()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            ClickAvailability.WaitForElementClickable(_driver, 60);
            ClickAvailability.Click();

            ClickAvailabilityField.WaitForElementClickable(_driver, 60);
            ClickAvailabilityField.Click();
            if (GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime") == "Full time")
            {
                
                    SelectElement clickThis = new SelectElement(ClickAvailabilityField);
                clickThis.SelectByText("Full Time");
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "availibility Successful");
            }
            else if(GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime") == "Part time")
            {
                SelectElement clickThis = new SelectElement(ClickAvailabilityField);

                clickThis.SelectByText("Part Time");
            }
        }
        public void Hours()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            ClickHours.WaitForElementClickable(_driver, 60);
            ClickHours.Click();
            ClickHoursField.WaitForElementClickable(_driver, 60);
            ClickHoursField.Click();
            if (GlobalDefinitions.ExcelLib.ReadData(2, "Hours") == "Less than 30hours a week")
            {

                SelectElement clickThis = new SelectElement(ClickHoursField);
                clickThis.SelectByText("Less than 30hours a week");
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Hours Successful");
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "Hours") == "More than 30hours a week")
            {
                SelectElement clickThis = new SelectElement(ClickHoursField);
                clickThis.SelectByText("More than 30hours a week");
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "Hours") == "As needed")
            {
                SelectElement clickThis = new SelectElement(ClickHoursField);
                clickThis.SelectByText("As needed");
            }

        }
        public void EarnTarget()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            ClickEarnTarget.WaitForElementClickable(_driver, 60);
            ClickEarnTarget.Click();
            ClickEarnTargetField.WaitForElementClickable(_driver, 60);
            ClickEarnTargetField.Click();
            if (GlobalDefinitions.ExcelLib.ReadData(2, "Earn Target") == "Less than $500 per month")
            {
                SelectElement clickThis = new SelectElement(ClickEarnTargetField);
                clickThis.SelectByText("Less than $500 per month");
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "EarnTarget Successful");
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "Earn Target") == "Between $500 and $1000 per month")
            {
                SelectElement clickThis = new SelectElement(ClickEarnTargetField);
                clickThis.SelectByText("Between $500 and $1000 per month");


            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "Earn Target") == "More than $1000 per month")
            {
                SelectElement clickThis = new SelectElement(ClickEarnTargetField);
                clickThis.SelectByText("More than $1000 per month");
            }

        }
        public void EditProfilepage()
        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            //Availability
            ClickAvailability.WaitForElementClickable(_driver, 60);
            ClickAvailability.Click();

            ClickAvailabilityField.WaitForElementClickable(_driver, 60);
            ClickAvailabilityField.Click();
            SelectElement clickThis = new SelectElement(ClickAvailabilityField);
            clickThis.SelectByText("Part Time");
            Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "editavailability Successful");

            //Hours
            ClickHours.WaitForElementClickable(_driver, 60);
            ClickHours.Click();
            ClickHoursField.WaitForElementClickable(_driver, 60);
            ClickHoursField.Click();
            SelectElement clickThis1 = new SelectElement(ClickHoursField);
            clickThis1.SelectByText("More than 30hours a week");
            Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "editHours Successful");

            //EarnTarget
            ClickEarnTarget.WaitForElementClickable(_driver, 60);
            ClickEarnTarget.Click();
            ClickEarnTargetField.WaitForElementClickable(_driver, 60);
            ClickEarnTargetField.Click();
            SelectElement clickThis2 = new SelectElement(ClickEarnTargetField);
            clickThis2.SelectByText("More than $1000 per month");
            Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "EditEarnTarget Successful");



        }
        public void EditProfile()
        {
            //Availability.Click();
            //SelectElement AvailabilityDropdownlist = new SelectElement(AvailabilityDropdown);
            //AvailabilityDropdownlist.SelectByText("Part Time");
            //CloseAvailability.Click();
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ChangePassword");
            ChangePassword.Click();
            OldPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "OldPassword"));
            NewPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "NewPassword"));
            ConfirmPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ConfirmPassword"));
            ProfileSave.Click();
        }
        public void SearchByUser()
        {
            try
            {
                SearchSkills.Clear();
                // SearchUser.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SearchUser"));
                SearchUser.SendKeys("harpeet kaur");
                SearchUser.SendKeys(Keys.Enter);
                //Extension.WaitForElementDisplayed(_driver,By.XPath("//*[@id='service-search-section']/div[3]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]"),60);
                Thread.Sleep(1000);
                int m = SearchUserList.Count;
                for (int i = 1; i < SearchUserList.Count; i++)
                {
                    IWebElement userList = _driver.FindElementByXPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[" + i + "]/div/span");
                    Thread.Sleep(3000);
                    string s = userList.Text; if (GlobalDefinitions.ExcelLib.ReadData(2, "SearchUser") == userList.Text)
                    {
                        userList.Click();
                        return;
                    }
                }
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Search by user is Successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
