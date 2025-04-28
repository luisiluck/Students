using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace AgileTest.AcceptanceTests.Support;

public abstract class BasePage(IPage page)
{
    public static BasePage CurrentPage {get; private set;}
    
    protected IPage Page { get; } = page;
    
    public async Task Init()
    {
        var uri = GetType().GetCustomAttribute<PageUri>()?.Uri;
        if (uri == null) throw new CustomAttributeFormatException($"Page URI does not set for {GetType().Name}");
        await Page.GotoAsync(uri);
    }

    private ILocator GetLocator(string propertyName)
    {
        var property =  GetType().GetProperty(propertyName)
               ?? throw new MemberAccessException($"Property {propertyName} does not exist on {GetType().Name}");
        return property.GetValue(this) as ILocator;
    }

    public async Task SetField(string field, string value)
        => await GetLocator(field).FillAsync(value);

    public async Task ClickOn(string element) 
        => await GetLocator(element).ClickAsync();
    
    public static BasePage GetPage(IPage page, string className)
    {
        const string namespaceName = "AgileTest.AcceptanceTests.Pages";
        var assembly = Assembly.GetExecutingAssembly();
        var type = assembly.GetTypes()
            .FirstOrDefault(t => t.IsClass && t.Namespace == namespaceName && t.Name == className);
        if (type == null)
            throw new TypeAccessException($"{className} class not found in {namespaceName}.");
        
        CurrentPage = Activator.CreateInstance(type, page) as BasePage;
        return CurrentPage;
    }
}