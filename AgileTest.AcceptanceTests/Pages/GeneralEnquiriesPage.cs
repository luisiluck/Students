using AgileTest.AcceptanceTests.Support;
using Microsoft.Playwright;

namespace AgileTest.AcceptanceTests.Pages;

[PageUri("/contact-us/general-enquiries")]
public class GeneralEnquiriesPage(IPage page) : BasePage(page)
{

    public ILocator FirstNameField => Page.Locator("[name='firstname']");
    public ILocator LastNameField => Page.Locator("[name='lastname']");
    public ILocator JobTitleField => Page.Locator("[name='jobtitle']");
    public ILocator EmailField => Page.GetByLabel("Email Address");
    public ILocator PhoneField => Page.Locator("[name='phone']");
    public ILocator CompanyField => Page.Locator("[name='company']");
    public ILocator MessageField => Page.Locator("[name='message']");
    public ILocator SendButton => Page.Locator("input[value='Send Enquiry']");
    
    
}