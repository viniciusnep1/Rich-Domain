using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost("UploadTemplat")]
        public async Task<IActionResult> Import(IFormFile file)
        {
            try
            {
                if (file == null)
                {
                    return BadRequest("File is null");
                }

                if (file.ContentType.Contains("xml"))
                {
                    using (var fileStream = new StreamReader(file.OpenReadStream()))
                    {
                        XmlReaderSettings settings = new XmlReaderSettings();
                        settings.IgnoreWhitespace = true;
                        using (XmlReader reader = XmlReader.Create(fileStream, settings))
                        {
                            while (reader.Read())
                            {
                                if (reader.Name == "infNFe")
                                {
                                    if (reader.HasAttributes)
                                    {
                                        var Id = reader.GetAttribute("Id");
                                        var versao = reader.GetAttribute("versao");
                                    }
                                }
                            }
                        }

                    }



                }

                return Ok(file);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            };
        }

    }
}
