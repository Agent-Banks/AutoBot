using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoBotAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class WebsitePickerController : ControllerBase
{
    private readonly ILogger<WebsitePickerController> _logger;

    public WebsitePickerController(ILogger<WebsitePickerController> logger)
    {
        _logger = logger;
    }


    // GET: api/<WebsitePickerController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    [HttpGet]
    public string GetTarget()
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\driver\Web");

        webDriver.Navigate().GoToUrl("https://www.target.com/");

        return "Yay";
    }

    // GET api/<WebsitePickerController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<WebsitePickerController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<WebsitePickerController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<WebsitePickerController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
