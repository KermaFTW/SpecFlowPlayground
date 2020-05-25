using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace SpecFlowPlayground
{
	[TestClass]
	public class DemoApp
	{
		[TestMethod]
		public void CheckDemoApp()
		{
			var driver = new ChromeDriver(".\\");
			driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(text(),'Add Element')]")));
			IWebElement elem = driver.FindElement(By.XPath("//button[contains(text(),'Add Element')]"));
			Assert.IsTrue(elem.Displayed);
		}
	}
}
