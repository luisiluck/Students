using System;
using System.Linq;
using System.Threading.Tasks;
using AgileTest.AcceptanceTests.Support;
using Reqnroll;
using Microsoft.Playwright;
using Xunit;

namespace AgileTest.AcceptanceTests.StepDefinitions;

[Binding]
public sealed class StepDefinitions : IDisposable
{
    private readonly IReqnrollOutputHelper _output;
    private readonly IPage _page;

    public StepDefinitions(IReqnrollOutputHelper output, IPage page)
    {
        _output = output;
        _page = page;
    }

    [Given("the user is in {string}")]
    public async Task TheUserIsIn(string page)
    {
        await BasePage.GetPage(_page, page).Init();
    }

    [When("the {string} field is set with {string}")]
    public async Task SetField(string field, string value)
    {
        await BasePage.CurrentPage.SetField($"{field}Field", value);
    }
    
    [When("the {string} is clicked")]
    public async Task ClickOn(string element)
    {
        await BasePage.CurrentPage.ClickOn(element);
    }

    [When("the {string} form is filled out with...")]
    public async Task FillForm(string formName, Table table)
    {
        foreach (var kv in table.Rows[0].ToDictionary())
        {
            await SetField(kv.Key, kv.Value);
        }
    }

    [Then("a {string} text should be displayed")]
    public void ThenTheResultShouldBe(string text)
    {
        try
        {
            _page.Locator($"text={text}");
        }
        catch (Exception e)
        {
            Assert.Fail($"'{text}' is not displayed.");
        }
        
    }

    public void Dispose()
    { 
        _page.Context.Browser?.CloseAsync();
    }
}