using Microsoft.AspNetCore.Mvc;

namespace SHURALE.Controllers
{
    public class WeatherDara
    {
        public int id { get; set; }
        public string Date { get; set; }
        public int Degree { get; set; }
        public string Location { get; set; }

    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new()
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static List<WeatherDara> weatherDatas = new()
        {
            new WeatherDara() {id = 2, Date=  "21.01.2022", Degree = 10, Location = "��������"},
            new WeatherDara() {id = 23, Date=  "10.08.2019", Degree = -20, Location = "���������������"},
            new WeatherDara() {id = 51, Date=  "05.11.2020", Degree = 15, Location = "����"},
            new WeatherDara() {id = 59, Date=  "07.02.2021", Degree = 0, Location = "�����"},
            new WeatherDara() {id = 1, Date=  "30.05.2022", Degree = 3, Location = "����������"},
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<WeatherDara> GetAll()
        {
            return weatherDatas;
        }

        [HttpGet("{id}")]
        public IActionResult GetByIndex(int id)
        {
            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].id == id)
                {
                    return Ok(weatherDatas[i]);
                }
            }
            return BadRequest("����� ������ �� �������");
        }

        [HttpGet("find-by-city")]
        public IActionResult GetCountByCityName(string cityName)
        {
            if (string.IsNullOrWhiteSpace(cityName))
            {
                return BadRequest("��� ������ �� ������ ���� ������");
            }

            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].Location.Equals(cityName, StringComparison.OrdinalIgnoreCase))
                {
                    return Ok("������ � ��������� ������� ������� � ������");
                }
            }
            return BadRequest("������ � ��������� ������� �� ����������");
        }

        [HttpPost]
        public IActionResult Add(WeatherDara data)
        {
            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].id == data.id)
                {
                    return BadRequest("������ � ����� ID ��� ����������");
                }
            }
            weatherDatas.Add(data);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(WeatherDara data)
        {
            // �������� �������� ���� Id
            if (data.id < 0)
            {
                return BadRequest("Id �� ����� ���� ������ 0");
            }

            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].id == data.id)
                {
                    weatherDatas[i] = data;
                    return Ok();
                }
            }
            return BadRequest("����� ������ �� ����������");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            // �������� �������� ���� Id
            if (id < 0)
            {
                return BadRequest("Id �� ����� ���� ������ 0");
            }

            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].id == id)
                {
                    weatherDatas.RemoveAt(i);
                    return Ok();
                }
            }
            return BadRequest("����� ������ �� ����������");
        }
    }
}

