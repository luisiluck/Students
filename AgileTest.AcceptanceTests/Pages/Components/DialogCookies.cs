using System.Threading.Tasks;
using Microsoft.Playwright;

namespace AgileTest.AcceptanceTests.Pages.Components;

public class DialogCookies
{
    private readonly IPage _page;
    public DialogCookies(IPage page)
    {
        _page = page;
    }

    public async Task AcceptCookies()
    {
        await _page.Locator(".cky-consent-bar .cky-btn-accept").ClickAsync();
    }
}