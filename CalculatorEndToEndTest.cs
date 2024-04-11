using Microsoft.Playwright.NUnit;
using NUnit.Framework;


namespace WebCalculator;

[TestFixture]
public class CalculatorEndToEndTests : PageTest
{
    [Test]
    public async Task Calculator_Addition()
    {
        await Page.GotoAsync("http://localhost:5024/");
        
        await Page.FillAsync("#inputA", "3");
        await Page.FillAsync("#inputB", "4");
        await Page.ClickAsync("#Add");
        
        await Page.WaitForSelectorAsync("#Result");
        
        var result = await Page.EvaluateAsync<string>("() => document.querySelector('#result').innerText");

        
        Assert.That(7, Is.EqualTo(result.Trim()));
    }
    
}