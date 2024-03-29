﻿using ChromeTests.Supports.Hooks;
using FirefoxTesting.Support.Locators;

namespace ChromeTests.Supports.PageObjects.Actions
{
    public static class RegistrationPageMeth
    {
        internal static bool IsRegistrationPage()
        {
            if (ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PageTitle).Displayed)
                return true;
            return false;
        }

        internal static bool IsURLCorrected() => RegistrationLoc.CorrectURL.Equals(ChromeBrowser.GetDriver().Url);
        internal static void ClickOnUpperSingInButton() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.UpperSingInButton).Click();
        internal static void FIrstNameInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.FirstnameField).SendKeys("");
        internal static void LastNameInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.LastnameField).SendKeys("");
        internal static void EmailInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.EmailField).SendKeys("");
        internal static void PasswordInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PasswordField).SendKeys("");
        internal static void ConfirmPasswordInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PasswordConfirmField).SendKeys("");
        internal static void PhoneInput() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.PhoneNumberField).SendKeys("");
        internal static void GoToNextStepRegist() => ChromeBrowser.GetDriver().FindElement(RegistrationLoc.NextButton).SendKeys("");
    }
}
