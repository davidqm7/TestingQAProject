using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace WebCalculator;

[TestFixture]
public class CalculatorEndToEndTests : PageTest
{
    [Test]
    public async Task WebCalulatorUI_AddInputAandInputB_ReturnsResult()
    {
        await Page.GotoAsync("http://localhost:5024/");
        
        await Page.WaitForSelectorAsync("#inputA");
        await Page.WaitForSelectorAsync("#inputB");
        
        await Page.FillAsync("#inputA", "3.25");
        await Page.FillAsync("#inputB", "4.4");
        await Page.ClickAsync("#Add");
        
        await Page.WaitForSelectorAsync("#Result");
        
        var result = await Page.EvaluateAsync<string>("() => document.querySelector('#Result').innerText");

        
        Assert.That("7.65", Is.EqualTo(result.Trim()));
    }
    
    [Test]
    public async Task WebCalulatorUI_VerifyTitle_IsCaculator()
    {
        await Page.GotoAsync("http://localhost:5024/");
        
        string title = await Page.TitleAsync();
        
        Assert.That("Calculator", Is.EqualTo(title));
    }

    [Test]
    public async Task WebCaculatorUI_DivideByZero_ReturnsNaN()
    {
        
        await Page.GotoAsync("http://localhost:5024/");
        
        await Page.WaitForSelectorAsync("#inputA");
        await Page.WaitForSelectorAsync("#inputB");
        
        await Page.FillAsync("#inputA", "1");
        await Page.FillAsync("#inputB", "0");
        await Page.ClickAsync("#Divide");
        
        await Task.Delay(1000);
        await Page.WaitForSelectorAsync("#Error-message");
        
        var errorMessage = await Page.InnerTextAsync("#Error-message");
        
        Assert.That("Not a Number", Is.EqualTo(errorMessage));

        
    }

    [Test]
    public async Task WebCaculatorUI_InvalidInputValues_ReturnsInvalidInput()
    {
        await Page.GotoAsync("http://localhost:5024/");
        
        await Page.WaitForSelectorAsync("#inputA");

        await Page.FillAsync("#inputA", "fifteen");
        await Page.ClickAsync("#Add");
        
        await Task.Delay(1000);
        await Page.WaitForSelectorAsync("#Error-message");

        var errorMessage = await Page.InnerTextAsync("#Error-message");
        
        Assert.That("Invalid Input, Numbers Only", Is.EqualTo(errorMessage));
        
    }
    
    
    
    
    [Test]
    public async Task WebCaculatorUI_TestingClearButton_ReturnsDefaultState()
    {
        await Page.GotoAsync("http://localhost:5024/");
        await Page.WaitForSelectorAsync("#inputA");
        await Page.WaitForSelectorAsync("#inputB");

        await Page.FillAsync("#inputA", "5");
        await Page.FillAsync("#inputB", "5");
        await Page.ClickAsync("#Add");
        
        await Page.WaitForSelectorAsync("#Result");
        await Page.ClickAsync(".clear");
        await Task.Delay(1000);
        
        var defaultMessage = await Page.InnerTextAsync("#clear-Message");
        Assert.That("Enter value(s) below and select an operation", Is.EqualTo(defaultMessage));
        
        var inputAValue = await Page.GetAttributeAsync("#inputA", "value");
        var inputBValue = await Page.GetAttributeAsync("#inputB", "value");
       Assert.That(null,Is.EqualTo(inputAValue));
       Assert.That(null,Is.EqualTo(inputBValue));
    }
    
    
    
}