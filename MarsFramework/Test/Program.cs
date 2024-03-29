﻿using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;

namespace MarsFramework
{
    [TestFixture]

    class Program : Base
    {
        public Program()
        {

        }

        //class User : Global.Base
        //{
        [Category("Sprint1")]
        [Test]
        public void Login()
        {
            try
            {
                Assert.IsTrue(true);
            }
            catch(Exception)
            {
                throw;
            }
           
        }
        [Category("Sprint1")]
        [Test]
        public void ShareSkillCreate()
        {
            try
            {
                ShareSkill skillCreate = new ShareSkill(GlobalDefinitions.driver);
                skillCreate.EnterShareSkill();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        [Category("Sprint1")]
        [Test]
        public void ShareSkillEdit()
        {
            try
            {
                ShareSkill skillEdit = new ShareSkill(GlobalDefinitions.driver);
                skillEdit.EditShareSkill();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void ShareSkillRemove()
        {
            try
            {
                ShareSkill skillDelete = new ShareSkill(GlobalDefinitions.driver);
                skillDelete.DeleteShareSkill();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void SkillCreate()
        {
            try
            {
                Profile skillCreate = new Profile(GlobalDefinitions.driver);
                skillCreate.AddSkill();

            }
            catch (Exception)
            {

                throw;
            }
        }
        [Category("Sprint1")]
        [Test]
        public void SkillEdit()
        {
            try
            {
                Profile skillEdit = new Profile(GlobalDefinitions.driver);
                skillEdit.EditSkill();

            }
            catch (Exception)
            {

                throw;
            }
        }
        [Category("Sprint1")]
        [Test]
        public void SkillDelete ()
        {
            try
            {
                Profile skillDelete = new Profile(GlobalDefinitions.driver);
                skillDelete.DeleteSkill();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void CertificationCreate()
        {
            try
            {
                Profile addCert = new Profile(GlobalDefinitions.driver);
                addCert.AddCertification();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void CertificationEdit()
        {
            try
            {
                Profile editCert = new Profile(GlobalDefinitions.driver);
                editCert.EditCertification();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void CertificationRemove()
        {
            try
            {
                Profile removeCert = new Profile(GlobalDefinitions.driver);
                removeCert.DeleteCertification();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void EducationCreate()
        {
            try
            {
                Profile addEdu = new Profile(GlobalDefinitions.driver);
                addEdu.AddEducation();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void EducationEdit()
        {
            try
            {
                Profile editEdu = new Profile(GlobalDefinitions.driver);
                editEdu.EditEducation();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void RemoveEducation()
        {
            try
            {
                Profile removeEdu = new Profile(GlobalDefinitions.driver);
                removeEdu.DeleteEducation();

            }
            catch (Exception)
            {

                throw;
            }
        }
        
        
        [Category("Sprint1")]
        [Test]
        public void LanguageCreate()
        {
            try
            {
                Profile addLang = new Profile(GlobalDefinitions.driver);
                addLang.AddLanguage();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void LanguageEdit()
        {
            try
            {
                Profile editLang = new Profile(GlobalDefinitions.driver);
                editLang.EditLanguage();

            }
            catch (Exception)
            {

                throw;
            }
        }

        [Category("Sprint1")]
        [Test]
        public void RemoveLanguage()
        {
            try
            {
                Profile removeLang= new Profile(GlobalDefinitions.driver);
                removeLang.DeleteLanguage();

            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    
}
