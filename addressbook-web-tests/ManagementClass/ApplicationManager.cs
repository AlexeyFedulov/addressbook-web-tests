﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NovigationHelper novigator;
        protected GroupHelper groupHelper;
    
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/";

            loginHelper = new LoginHelper(this);
            novigator = new NovigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
        }
        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static ApplicationManager GetInstance()

        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigator.GoToHomePage();
                app.Value = newInstance;
                
            }
            return app.Value;
        }


        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NovigationHelper Navigator
        {
            get
            {
                return novigator;
            } 
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }
    }
}