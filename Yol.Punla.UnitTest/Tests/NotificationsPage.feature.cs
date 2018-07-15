﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Yol.Punla.UnitTest.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class NotificationsPageFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "NotificationsPage.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NotificationsPage", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "NotificationsPage")))
            {
                global::Yol.Punla.UnitTest.Tests.NotificationsPageFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Resuming the app but the user didnt logon to the app")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("OnResume")]
        public virtual void ResumingTheAppButTheUserDidntLogonToTheApp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Resuming the app but the user didnt logon to the app", new string[] {
                        "tag",
                        "OnResume"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I am not authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
  testRunner.And("there are no username and password yet stored in the app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.Then("I should see that there are no post feeds to be pushed into the local notificatio" +
                    "ns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Resuming the app and the user logon to app previously")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("OnResumeLogon")]
        public virtual void ResumingTheAppAndTheUserLogonToAppPreviously()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Resuming the app and the user logon to app previously", new string[] {
                        "tag",
                        "OnResumeLogon"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
  testRunner.And("the username \"hynrbf@gmail.com\" and password are stored in the app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("I should see that there are post feeds that is pushed into the local notification" +
                    "s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
  testRunner.And("I am redirected to the page \"WikiPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.And("I should see that the notifications quantity is displayed at the top banner of th" +
                    "e WikiPage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Resuming the app and the user logon to app previously but the date when the notif" +
            "ications was pushed was not yet expired")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("OnResumeLogonAndPushedDateNotExpired")]
        public virtual void ResumingTheAppAndTheUserLogonToAppPreviouslyButTheDateWhenTheNotificationsWasPushedWasNotYetExpired()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Resuming the app and the user logon to app previously but the date when the notif" +
                    "ications was pushed was not yet expired", new string[] {
                        "tag",
                        "OnResumeLogonAndPushedDateNotExpired"});
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
  testRunner.And("the username \"hynrbf@gmail.com\" and password are stored in the app", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("I should see that there are no post feeds to be pushed into the local notificatio" +
                    "ns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
  testRunner.And("I should see that the notifications quantity is displayed at the top banner of th" +
                    "e WikiPage in only \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Going to the notifications page for the first time")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FacebookLogonViaNotificationsMenu")]
        public virtual void GoingToTheNotificationsPageForTheFirstTime()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Going to the notifications page for the first time", new string[] {
                        "tag",
                        "FacebookLogonViaNotificationsMenu"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
  testRunner.And("I am on the page \"NotificationsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("I should see that there are notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Going to the notifications page but the user is not connected to the internet")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FacebookLogonViaNotificationsMenu")]
        public virtual void GoingToTheNotificationsPageButTheUserIsNotConnectedToTheInternet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Going to the notifications page but the user is not connected to the internet", new string[] {
                        "tag",
                        "FacebookLogonViaNotificationsMenu"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
  testRunner.And("I am on the page \"NotificationsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.Then("I should see that there are notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.When("I tap the hamburger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("I should see the menu detail is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When("I tap the Write Down icon from the menu detail pane", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("I am redirected to the page \"PostFeedPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("I tap the hamburger icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
  testRunner.And("I tap the notifications icon but suddenly the internet went off", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("I am redirected to the page \"NotificationsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
  testRunner.And("I should see that there are no notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
  testRunner.And("I should see that the offline message is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Going to the notifications page and refreshing the notifications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FacebookLogonViaNotificationsMenu")]
        public virtual void GoingToTheNotificationsPageAndRefreshingTheNotifications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Going to the notifications page and refreshing the notifications", new string[] {
                        "tag",
                        "FacebookLogonViaNotificationsMenu"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
  testRunner.And("I am on the page \"NotificationsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("I should see that there are notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.When("I pull to refresh the notifications", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
 testRunner.Then("I should see that the notifications are refreshed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Loading comments from the notifications page")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "NotificationsPage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("tag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("FacebookLogonViaNotificationsMenu")]
        public virtual void LoadingCommentsFromTheNotificationsPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Loading comments from the notifications page", new string[] {
                        "tag",
                        "FacebookLogonViaNotificationsMenu"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I am authenticated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
  testRunner.And("I am on the page \"NotificationsPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("I should see that there are notifications displayed on the page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.When("I select a post from the notifications list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("I am redirected to the page \"PostFeedDetailPage\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
