using System.Threading.Tasks;
using AgileTest.AcceptanceTests.Pages;
using Autofac;
using Microsoft.Playwright;
using Reqnroll.Autofac;

namespace AgileTest.AcceptanceTests.StepDefinitions;

public static class Startup
{
    [ScenarioDependencies]
    public static void Scenario(ContainerBuilder builder)
    {
        builder.RegisterType<StepDefinitions>().InstancePerDependency();
        builder.RegisterType<GeneralEnquiriesPage>().AsSelf().InstancePerDependency();
        builder.RegisterInstance(Init()).SingleInstance();
    }

    private static IPage Init()
    {
        var playwright = Playwright.CreateAsync().Result;
        var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        }).Result;
        var context = browser.NewContextAsync(new BrowserNewContextOptions
        {
            BaseURL = "https://www.ieg4.com"
        }).Result;
        return context.NewPageAsync().Result;
    }
}