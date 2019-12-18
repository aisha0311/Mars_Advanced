using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Linq;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class Profile
    {

        private readonly IWebDriver _driver;

        public Profile(IWebDriver driver)
        {
            _driver = driver;
        }

        #region SkillWebElements
        IWebElement skillsButton => _driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Skills')]"));

        IWebElement ShareSkillBtn => _driver.FindElement(By.XPath("//div[@class='ui teal button'][contains(.,'Add New')]"));

        //  Thread.Sleep(1500);
        //Click on Add New button

        //Add skill
        IWebElement nameField => _driver.FindElement(By.XPath("//input[@name='name']"));
        IWebElement levelField => _driver.FindElement(By.Name("level"));
        IWebElement valueField => _driver.FindElement(By.XPath("//option[@value='Intermediate']"));

        IWebElement addButton => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        IWebElement updateBtn => _driver.FindElement(By.XPath("//input[@value='Update']"));
        #endregion

        #region EducationWebElements

        IWebElement eduTab => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        //click on add new
        IWebElement addEdu => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));

        IWebElement editEdu => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i"));

        IWebElement deleteEdu => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[5]/tr/td[6]/span[2]/i"));

        IWebElement dropDownListuni => _driver.FindElement(By.XPath("//input[@name='instituteName']"));

        IWebElement bachelor => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));

        IWebElement dropDowntitle3 => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));

        IWebElement dropDownListBox => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));

        IWebElement dropDowntitle => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));

        #endregion

        #region CertificationWebElements
        //clicking on profile tab
        IWebElement profileTab => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
        //clicking on Cerification tab
        IWebElement certTab => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));

        //click on add new
        IWebElement addNew => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        // add certificate or award
        IWebElement cert => _driver.FindElement(By.XPath("//input[@class='certification-award capitalize']"));
        // add certified from
        IWebElement certFrom => _driver.FindElement(By.XPath("//input[@class='received-from capitalize']"));

        IWebElement certText => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));


        #endregion

        #region LanguageWebElements
   // Click on Profile tab
        IWebElement profTab => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
        //Click on Add New button
        IWebElement profAddNew => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));

        //Add Language
        IWebElement addLang => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));

        //Click on Language Level
        IWebElement langLevel => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));

        IWebElement addBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));

        IWebElement editLang => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));

        IWebElement languageModify => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));

        IWebElement levelModify => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select"));

        private IWebElement updateLink => _driver.FindElement(By.XPath("//input[@value='Update']"));
            
        #endregion

        #region SkillMethods
        internal void AddSkill()
        {
            skillsButton.Click();
            GlobalDefinitions.Wait(1000);

            ShareSkillBtn.Click();

            nameField.SendKeys("selenium c#");

            levelField.Click();

            valueField.Click();

            addButton.Click();


            // CommonMethods.ExtentReports();
            // GlobalDefinitions.Wait(1000);
            //    CommonMethods.test = CommonMethods.extent.StartTest("Add a skill");


            GlobalDefinitions.Wait(2000);


            var table = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));

            var skillsList = table.FindElements(By.TagName("tbody")).ToList();

            for (int i = 1; i <= skillsList.Count; i++)
            {

                var skill = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));

                //create test cases
                if (skill.Text == "selenium c#")
                {

                    //    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a skill Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "SkillAdded");
                    break;
                }
                else
                {
                    //  CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Skill is not added");
                    //Assert.Fail("failed");
                }



            }

        }
        internal void EditSkill()
        {
            skillsButton.Click();
            //Start the Reports
            // CommonMethods.ExtentReports();
            GlobalDefinitions.Wait(1000);
            //  CommonMethods.test = CommonMethods.extent.StartTest("Edit a skill");
            try
            {
                //  GlobalDefinitions.Wait(1000);


                var table = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table")); //table

                var skillsList = table.FindElements(By.TagName("tbody")).ToList();   //all rows picked

                var isFound = false;

                for (int i = 1; i <= skillsList.Count; i++)
                {

                    var oldskill = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));  //each row and coloum

                    //click on edit button with specific row and column

                    if (oldskill.Text == "selenium c#")
                    {
                        isFound = true;

                        _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]")).Click();   //edit button



                        break;
                    }
                }

                if (isFound)
                {

                    //  edit value update from (selenium C#)
                    nameField.Clear();
                    nameField.SendKeys("Manual Testing");

                    //Click on skill Level
                    levelField.Click();

                    //Choose the skill level (Expert) {edit value update}
                    _driver.FindElement(By.XPath("//option[@value='Expert']")).Click();
                    //Wait
                    GlobalDefinitions.Wait(1500);

                    //click on update button

                    updateBtn.Click();
                }
                else
                {
                    //  CommonMethods.test.Log(LogStatus.Fail, "Test Failed, skill not found");
                }

                GlobalDefinitions.Wait(1000);

                //validate
                var table1 = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));

                var skillsList1 = table1.FindElements(By.TagName("tbody")).ToList();

                for (int i = 1; i <= skillsList1.Count; i++)
                {

                    var skill = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));

                    //create test cases
                    if (skill.Text == "Manual Testing")
                    {

                        //  CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a skill Successfully");
                        GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "SkillEdited");
                        break;
                    }
                    else
                    {
                        // CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Code not edited");
                        //Assert.Fail("failed-code not edited");
                    }

                }
            }
            catch (Exception ex)
            {
                //Log
            }
        }
        internal void DeleteSkill()
        {
            skillsButton.Click();
            //Start the Reports
            // CommonMethods.ExtentReports();
            GlobalDefinitions.Wait(2000);
            //   CommonMethods.test = CommonMethods.extent.StartTest("Edit a skill");

            try
            {
                GlobalDefinitions.Wait(1000);


                var table = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table")); //table

                var skillsList = table.FindElements(By.TagName("tbody")).ToList();   //all rows picked



                for (int i = 1; i <= skillsList.Count; i++)
                {

                    var skillname = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));  //each row and coloum

                    //click on delete button on specific row 

                    if (skillname.Text == "selenium java")
                    {


                        _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]")).Click();   //delete button

                        break;
                    }
                }

                GlobalDefinitions.Wait(1000);


                var table1 = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));   //table

                var skillsList1 = table1.FindElements(By.TagName("tbody")).ToList();

                for (int i = 1; i <= skillsList1.Count; i++)
                {

                    var skill = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));  //each row with coloum

                    //create test cases
                    if (skill.Text == "selenium java")
                    {

                        // CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a skill Successfully");
                        GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "SkillDeleted");
                        break;
                    }
                    else
                    {
                        // CommonMethods.test.Log(LogStatus.Fail, "Test Failed, Code not deleted");
                        //Assert.Fail("failed");
                    }

                }

            }
            catch (Exception ex)
            {
                // CommonMethods.test.Log(LogStatus.Fail, $"Test Failed due to exception. {ex.Message}");
                //  Assert.Fail(ex.Message);

            }
        }
        #endregion

        #region EducationMethods
        internal void AddEducation()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");


            GlobalDefinitions.Wait(3000);
            //clicking on profile tab
            //Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
            //clicking on Education Tab 
            eduTab.Click();
            //click on add new
            addEdu.Click();
            GlobalDefinitions.Wait(1000);
            dropDownListuni.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "dropDownListuni"));
            //Console.WriteLine(dropDownListuni.Text);

            GlobalDefinitions.Wait(1000);
            SelectElement clickThis = new SelectElement(dropDownListBox);
            clickThis.SelectByText("Brazil");
            //Console.WriteLine(dropDownListBox.Text);

            GlobalDefinitions.Wait(1000);
            SelectElement click = new SelectElement(dropDowntitle);
            click.SelectByText("B.A");
            //Console.WriteLine(dropDowntitle.Text);

            GlobalDefinitions.Wait(1000);
            bachelor.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "bachelor"));
            //Console.WriteLine(bachelor.Text);

            GlobalDefinitions.Wait(1000);
            SelectElement click2 = new SelectElement(dropDowntitle3);
            click2.SelectByText("2016");
            //Console.WriteLine(dropDowntitle3.Text);
            //clicking add 
            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

            //Start the Reports
            //  CommonMethods.ExtentReports();
            GlobalDefinitions.Wait(1000);
            // CommonMethods.test = CommonMethods.extent.StartTest("Add a Education Details");
            int count;
            GlobalDefinitions.Wait(1000);
            {
                count = 1;
                count++;
                int i;
                for (i = 1; i <= count++; i++)
                {
                    //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                    GlobalDefinitions.Wait(1000);
                    Console.WriteLine(ActualValue.Text);
                    //string ExpectedValue = "Spanish";
                    if (ActualValue.Text == "Brazil")

                    {
                        //   CommonMethods.test.Log(LogStatus.Pass, "Test Passed, added Successfully");
                        GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "added");
                        Console.WriteLine("Passed");
                        return;
                    }

                    else

                        Console.WriteLine("Failed");
                }

            }

        }
        internal void EditEducation()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Education");
            GlobalDefinitions.Wait(2000);
            //clicking on Education Tab 
            eduTab.Click();
            GlobalDefinitions.Wait(2000);
            //click on modify button
            editEdu.Click();
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i
            //*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[1]/i

            IWebElement modify2 = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[1]/div[2]/select"));
       
            //modify2.Clear();
            //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[5]/tr/td/div[1]/div[2]/select
            SelectElement clickThis2 = new SelectElement(modify2);
            clickThis2.SelectByText("India");

            //   _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[5]/tr/td/div[3]/input[1]")).Click();
            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]")).Click();
            //Start the Reports
            //CommonMethods.ExtentReports();
            GlobalDefinitions.Wait(1000);
            // CommonMethods.test = CommonMethods.extent.StartTest("modify a education Details");

            int count;
            GlobalDefinitions.Wait(1000);

            count = 1;
            count++;
            int i;
            for (i = 1; i <= count++; i++)
            {
                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                GlobalDefinitions.Wait(1000);
                Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "sitar";
                if (ActualValue.Text == "India")

                {
                    //  CommonMethods.test.Log(LogStatus.Pass, "Test Passed, modified Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "modified");
                    Console.WriteLine("Success");
                    break;
                }


                else

                    Console.WriteLine("Failed");

            }

        }
        internal void DeleteEducation()
        {

            GlobalDefinitions.Wait(2000);

            eduTab.Click();

          
            GlobalDefinitions.Wait(1000);
            var table = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table")); 

            var eduList = table.FindElements(By.TagName("tbody")).ToList();
            
            for (int i = 1; i <= eduList.Count; i++)
            {
                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                GlobalDefinitions.Wait(1000);
                Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "Spanish";
                if (ActualValue.Text == "India")

                {
                    _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[6]/span[2]")).Click();
                    //   CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "deleted");
                    // Console.WriteLine("Success");
                    break;
                   // return;
                }

                
            }

        }
        #endregion

        #region LanguageMethods

        internal void AddLanguage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            GlobalDefinitions.Wait(1500);
            // Click on Profile tab
            profTab.Click();
            //Click on Add New button
            profAddNew.Click();
            //Add Language
            addLang.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "addLang"));
            //Click on Language Level
            langLevel.Click();

            //Choose the language level
            IWebElement Lang = _driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();

            //Click on Add button
            addBtn.Click();
            int count;
            count = 1;
            count++;
            int i;
            for (i = 1; i <= count++; i++)
            {

                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                Thread.Sleep(1000);
                //string actualvalue = "ActualValue.Text";
                //Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "Spanish";
                if (ActualValue.Text == "Spanish")
                //Assert.AreEqual(actualvalue, "Spanish");
                {
                    // CommonMethods.test.Log(LogStatus.Pass, "Test Passed, added Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "added");
                    Console.WriteLine("Passed");
                    return;
                }

                else

                    Console.WriteLine("Failed");


            }
        }
        internal void EditLanguage()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Language");
            //click on profile tab
            profTab.Click();
            //click on Language tab
            _driver.FindElement(By.XPath("//a[@class='item active']")).Click();
            //click on modify symbol
            editLang.Click();

            //clear value in langauge field and enter new language
            languageModify.Click();
            languageModify.Clear();
            languageModify.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "languageModify"));
            //clear level and give new level
            SelectElement selectlevel = new SelectElement(levelModify);
            selectlevel.SelectByText("Fluent");

            updateLink.Click();

            //Start the Reports
            //  CommonMethods.ExtentReports();
            //Thread.Sleep(1000);
            //  CommonMethods.test = CommonMethods.extent.StartTest("modify a language Details");

            int count;
            count = 1;
            count++;
            int i;
            for (i = 1; i <= count++; i++)
            {
                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath(
                    "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" +
                    i + "]/tr/td[1]"));
                // Thread.Sleep(1000);
                Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "Spanish";
                if (ActualValue.Text == "Telugu")
                {
                    //  CommonMethods.test.Log(LogStatus.Pass, "Test Passed, modified Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "modified");
                    Console.WriteLine("Success");
                    return;
                }

                else

                    Console.WriteLine("Failed");

            }
        }
        internal void DeleteLanguage()
        {
 //click on profile tab
            profTab.Click();
            //click on Language tab
           _driver.FindElement(By.XPath("//a[@class='item active']")).Click();

            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i")).Click();

            //Start the Reports
           // CommonMethods.ExtentReports();
           GlobalDefinitions.Wait(1000);
           // CommonMethods.test = CommonMethods.extent.StartTest("delete a language Details");
            int count;
           // GlobalDefinitions.Wait(1000);
           
                count = 1;
                // count++;
                int i;
                for (i = 1; i <= count++; i++)
                {
                    //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                   GlobalDefinitions.Wait(1000);
                    Console.WriteLine(ActualValue.Text);
                    //string ExpectedValue = "Spanish";
                    if (ActualValue.Text == "Telugu")
                    {
                        //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, not deleted Successfully");
                      GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "notdeleted");
                        Console.WriteLine("Fail");
                        Assert.Fail("failed");
                        // return;
                    }


                    else
                      //  CommonMethods.test.Log(LogStatus.Pass, "Test Passed");

                 GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "deleted");
                    // Console.WriteLine("Success");

                }
        }
        #endregion

        #region CertificationMethods

        internal void AddCertification()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certificate");
            int count;
            //clicking on profile tab
            profileTab.Click();
            //clicking on Cerification tab
            certTab.Click();
            //click on add new
            addNew.Click();
            // add certificate or award
            cert.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "cert")); 
            // add certified from
            certFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "certFrom"));
            // add or select year
            IWebElement addCerification = _driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            SelectElement addcerificationyear = new SelectElement(addCerification);
            addcerificationyear.SelectByText("2018");
            //Console.WriteLine(addCerification.Text);
            certText.Click();
            //Start the Reports
            // CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            // CommonMethods.test = CommonMethods.extent.StartTest("Add a certification Details");

            Thread.Sleep(1000);
            count = 1;
            count++;
            int i;
            for (i = 1; i <= count++; i++)
            {
                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                Thread.Sleep(1000);
                Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "Spanish";
                if (ActualValue.Text == "ISTQB")

                {
                    // CommonMethods.test.Log(LogStatus.Pass, "Test Passed, added Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "added");
                    Console.WriteLine("Passed");
                    return;
                }

                else

                    Console.WriteLine("Failed");
            }




        }
        internal void EditCertification()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Certificate");
            certTab.Click();
            //click on modify button
            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[3]/tr/td[4]/span[1]/i")).Click();

            //clear and enter new data
            IWebElement certificationmodify = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[3]/tr/td/div/div/div[1]/input"));
            certificationmodify.Clear();
            certificationmodify.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "certificationmodify"));

            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[3]/tr/td/div/span/input[1]")).Click();

            int count;

            //Start the Reports
            //  CommonMethods.ExtentReports();
            GlobalDefinitions.Wait(1000);
            // CommonMethods.test = CommonMethods.extent.StartTest("modify a certification Details");

            GlobalDefinitions.Wait(1000);

            count = 1;
            count++;
            int i;
            for (i = 1; i <= count++; i++)
            {
                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                GlobalDefinitions.Wait(1000);
                Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "sitar";
                if (ActualValue.Text == "QTP")
                {
                    // CommonMethods.test.Log(LogStatus.Pass, "Test Passed, modified Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "modified");
                    Console.WriteLine("Success");
                    return;
                }


                else

                    Console.WriteLine("Failed");

            }

        }
        internal void DeleteCertification()
        {
            certTab.Click();

            _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[3]/tr/td[4]/span[2]/i")).Click();

            // CommonMethods.ExtentReports();
            GlobalDefinitions.Wait(1000);
            // CommonMethods.test = CommonMethods.extent.StartTest("delete a certification Details");

            int count;
            GlobalDefinitions.Wait(1000);
            count = 1;
            // count++;
            int i;
            for (i = 1; i <= count++; i++)
            {
                //string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                IWebElement ActualValue = _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]"));
                GlobalDefinitions.Wait(1000);
                Console.WriteLine(ActualValue.Text);
                //string ExpectedValue = "Spanish";
                if (ActualValue.Text == "QTP")
                {
                    //CommonMethods.test.Log(LogStatus.Fail, "Test Failed, not deleted Successfully");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "notdeleted");
                    Console.WriteLine("Fail");
                    Assert.Fail("failed");
                    // return;
                }


                else
                    // CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
                    GlobalDefinitions.SaveScreenShotClass.SaveScreenshot(_driver, "deleted");
                // Console.WriteLine("Success");

            }


        }
        #endregion


    }
}
