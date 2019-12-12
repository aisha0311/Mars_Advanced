using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ShareSkills
    {

        private RemoteWebDriver _driver;
        public ShareSkills(RemoteWebDriver driver) => _driver = driver;

        //PageFactory.InitElements(driver, this);

        // ShareSkills button
        IWebElement ShareSkill => _driver.FindElementByCssSelector("div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button");

        // Title
        IWebElement Title => _driver.FindElementByName("title");

        // Description
        IWebElement Description => _driver.FindElementByName("description");

        // Select Category
        IWebElement Category => _driver.FindElementByName("categoryId");

        // Select Graphics & Design
        IWebElement GraphicsDesign => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)");

        //Select SubCategory - Logo Design
        IWebElement SubCategory => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown");

        //Select SubCategory - Logo Design
        IWebElement LogoDesign => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)");

        //Select Tag Names
        IWebElement Tag => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Select Service Type -Hourly Basis
        IWebElement ServiceTypeHourly => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Service Type -One-off
        IWebElement ServiceTypeOnOff => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");
        //Select Location Type - Onsite

        //Select Location Type - Onsite
        IWebElement LocationTypeOnsite => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Location Type - Onsite
        IWebElement LocationTypeOnline => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)");

       
        
        
        //Avilable Days -Start Date
        IWebElement StartDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)");

        //Avilable Days -End Date
        IWebElement EndDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)");
        //Select week day
        IWebElement SelectWeekday => _driver.FindElementByXPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input");
        //Click StartTime
        IWebElement StartTime => _driver.FindElementByName("StartTime");
        //Click EndTime
        IWebElement EndTime => _driver.FindElementByName("EndTime");
       
        
        
        
        //Skill Trade - Skill Exchange
        //IWebElement EndDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)");
        IWebElement SkillExchange => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Skill Exchange - Required Skills
        IWebElement RequiredSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Skill Trade - Credit
        IWebElement Credit => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");


        //Credit - Enter Amount
        IWebElement CreditAmount => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)");

        // Status Active 
        IWebElement StatusActive => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Status Hidden 
        IWebElement StatusHidden => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");

        // Work Sample 
        IWebElement WorkSample => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25");

        // Save Share Skills
        IWebElement SaveShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");

        // Cancel Share Skills
       
        IWebElement CancelShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");
      
        
        
        
        //Click on managelisting
        IWebElement ClickManageListing => _driver.FindElementByXPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]");
        //Click on EditManageListing
        IWebElement ClickEditButton => _driver.FindElementByXPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i");

        //EditTitle
        IWebElement EditTitle => _driver.FindElementByXPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
        //EditDesription
        IWebElement EditDesription => _driver.FindElementByXPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea");
        //ClickSave
        IWebElement ClickSaveEdit => _driver.FindElementByXPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]");
        //Validatetitle
        IWebElement Validatetitle => _driver.FindElementByXPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]");
        //DeleteShareskill
        IWebElement DeleteShareSkill => _driver.FindElementByXPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i");

        //ValidateDeleteShareSkill

        IWebElement ValidateDeleteShareSkill => _driver.FindElementByXPath("//*[@id='listing-management-section']/div[2]/h3");

        //AlertDelete
        IWebElement AlertDelete => _driver.FindElementByXPath("/html/body/div[2]/div/div[3]/button[2]");





        #region Initialize Elements - Pagefactory Implementation
        /*  [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[1]/div/a[1]")]
          public IWebElement Dashboard { get; set; }

          [FindsBy(How = How.ClassName, Using = "item active")]
          public IWebElement Skills { get; set; }*/


        //[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/section[1]/div/div[2]/a")]
        /*   [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
           public IWebElement ShareSkill { get; set; }


           // Title
           [FindsBy(How = How.Name, Using = "title")]
           public IWebElement Title { get; set; }


           // Description

           [FindsBy(How = How.Name, Using = "description")]
           public IWebElement Description { get; set; }

           // Select Category

           [FindsBy(How = How.Name, Using = "categoryId")]
           public IWebElement Category { get; set; }

           // Select Graphics & Design

           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
           public IWebElement GraphicsDesign { get; set; }


           //Select SubCategory - Logo Design
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown")]
           public IWebElement SubCategory { get; set; }

           //Select SubCategory - Logo Design
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
           public IWebElement LogoDesign { get; set; }


           //Select Tag Names
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
           public IWebElement Tag { get; set; }

           //Select Service Type -Hourly Basis
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement ServiceTypeHourly { get; set; }

           //Select Service Type -One-off
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement ServiceTypeOnOff { get; set; }

           //Select Location Type - Onsite
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement LocationTypeOnsite { get; set; }

           //Select Location Type - Onsite
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)")]
           public IWebElement LocationTypeOnline { get; set; }

           //Avilable Days -Start Date
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)")]
           public IWebElement StartDate { get; set; }

           //Avilable Days -End Date
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)")]
           public IWebElement EndDate { get; set; }

           //Skill Trade - Skill Exchange
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement SkillExchange { get; set; }

           // Skill Exchange - Required Skills
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
           public IWebElement RequiredSkills { get; set; }

           //Skill Trade - Credit
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement Credit { get; set; }


           //Credit - Enter Amount
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)")]
           public IWebElement CreditAmount { get; set; }

           // Status Active 
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement StatusActive { get; set; }

           // Status Hidden 
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement StatusHidden { get; set; }

           // Work Sample 
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25")]
           public IWebElement WorkSample { get; set; }

           // Save Share Skills
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
           public IWebElement SaveShareSkills { get; set; }

           // Cancel Share Skills
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
           public IWebElement CancelShareSkills { get; set; }*/

        #endregion

        #region Add new Skill
        public void AddNewSkill()
        {

            #region Navigate to Share Skills Page
            // Click on Share Skills Page
            ShareSkill.WaitForElementClickable(_driver, 60);
            ShareSkill.Click();
            //Populate the excel data            
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");

            #endregion


            #region Enter Title 
            Title.WaitForElementClickable(_driver, 60);
            //Enter the data in Title textbox
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "title"));
            Console.WriteLine("Title success");

            #endregion

            #region Enter Description

            //Enter the data in Description textbox
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterDescription"));
            Console.WriteLine("Descriptions success");

            #endregion

            #region Category Drop Down

            // Click on Category Dropdown
            // Category.Click();
            Category.Click();

            // Select Category from Category Drop Down
            var SelectElement = new SelectElement(Category);
            SelectElement.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "category")));
            
            Console.WriteLine("Category success");
            // Click on Sub-Category Dropdown
            SubCategory.Click();
            
            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "subcategory")));
            Console.WriteLine("SubCategory success");
            #endregion

            #region Tags
            // Eneter Tag
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TagName"));
            Console.WriteLine("Tagname success");
            Tag.SendKeys(Keys.Enter);
            Console.WriteLine("KeysEnter255line success");
            #endregion

            #region Service Type Selection

            // Service Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
                Console.WriteLine("Servicetypehourly success");
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
                Console.WriteLine("Servicetypeonoff success");
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
                Console.WriteLine("LocationTypeonsite success");
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
                Console.WriteLine("LocationTypeOnline success");
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date
            StartDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            Console.WriteLine("StartDate");
            // Select End Date
            EndDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            Console.WriteLine("EndTime");
            #endregion
            SelectWeekday.Click();
            Console.WriteLine("selectweekday");
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartTime"));
            Console.WriteLine("StartTime");
            EndTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndTime"));
            Console.WriteLine("EndTime");

            #region Select Skill Trade
            // Select Skill Trade

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {

                RequiredSkills.Click();
                RequiredSkills.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);

            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Credit")
            {

                CreditAmount.Click();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AmountInExchange"));
                CreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status

            if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion


            #region Add Work Sample

            //Work Sample upload button path
            IWebElement upload = _driver.FindElement(By.XPath("//*[@id='selectFile']"));

            // Uploading File path
            var GetCurrentDirectory = Directory.GetCurrentDirectory();
            String path = GetCurrentDirectory + @"\MarsFramework\Upload Files\Samplework.txt";
            upload.SendKeys(path);




            #endregion

            #region Save / Cancel Skill
            // Save or Cancel New Skill

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
            {
                SaveShareSkills.Click();
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Shared Skill UnSuccessful");
            }
            #endregion


            #region Check whether New  skill created sucessfully 

            string ShareSkillSucess = _driver.FindElement(By.LinkText("Manage Listings")).Text;

            if (ShareSkillSucess == "Manage Listings")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Shared Skill Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Share Skill Unsuccessful");
            }
            #endregion
        }
        #endregion
        public void EditShareSkill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills");
            ShareSkill.WaitForElementClickable(_driver, 60);
            string Expectedtitle = "Automation with selenium";

            ClickManageListing.Click();
            // ShareSkill.WaitForElementClickable(_driver, 60);
            Thread.Sleep(1000);
            ClickEditButton.Click();
            Thread.Sleep(1000);
            // ShareSkill.WaitForElementClickable(_driver, 60);
            EditTitle.Clear();
            Thread.Sleep(2000);
            EditTitle.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EditTitle"));
            Thread.Sleep(1000);
            EditDesription.Clear();
            Thread.Sleep(2000);
            EditDesription.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "EditDescription"));
            Thread.Sleep(1000);
            ClickSaveEdit.Click();
            Thread.Sleep(2000);
            // ShareSkill.WaitForElementClickable(_driver, 60);
            if (Expectedtitle == Validatetitle.Text)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "EditTitle Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Edit Share Skill Unsuccessful");
            }

        }
        public void DeleteShareskill()
        {
            ClickManageListing.WaitForElementClickable(_driver, 60);
            string Expectedtitle = "Automation with selenium";
            string ExpectedAfterdeletion = "You do not have any service listings!";
            Thread.Sleep(1000);
            ClickManageListing.Click();
            Thread.Sleep(1000);
            if (Expectedtitle == Validatetitle.Text)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "EditTitle Successful");
            }

            // ShareSkill.WaitForElementClickable(_driver, 60);

            Thread.Sleep(1000);
            DeleteShareSkill.Click();
            Thread.Sleep(1000);
            AlertDelete.Click();
            Thread.Sleep(2000);
            if (ExpectedAfterdeletion == ValidateDeleteShareSkill.Text)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Delete UnSuccessful");
            }
        }
    }
}
    
    
