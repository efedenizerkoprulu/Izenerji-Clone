using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IImageItemService _imageItemService;
        ISliderService _sliderService;
        IAbilityService _abilityService;
        IArticleService _articleService;
        IChartDataService _chartDataService;
        IEmployeeService _employeeService;
        ITwitterService _twitterService;


        public HomeController(
            IImageItemService imageItemService, ISliderService sliderService, IAbilityService abilityService, IArticleService articleService, IChartDataService chartDataService, IEmployeeService employeeService,ITwitterService twitterService
            )
        {
            _imageItemService = imageItemService;
            _sliderService = sliderService;
            _abilityService = abilityService;
            _articleService = articleService;
            _chartDataService = chartDataService;
            _employeeService = employeeService;
            _twitterService = twitterService;
        }


        [HttpGet("imagelist")]
        public IActionResult GetImageList()
        {
            var getImageList = _imageItemService.GetİmageList();
            if (!getImageList.Success)
            {
                return BadRequest(getImageList);
            }
            return Ok(getImageList);
        }

        [HttpGet("slider")]
        public IActionResult GetSliderList()
        {
            var getSliderList = _sliderService.GetSliderList();
            if (!getSliderList.Success)
            {
                return BadRequest(getSliderList);
            }
            return Ok(getSliderList);
        }

        [HttpGet("ability")]
        public IActionResult GetAbilityList()
        {
            var getAbilityList = _abilityService.GetAbilityList();
            if (!getAbilityList.Success)
            {
                return BadRequest(getAbilityList);
            }
            return Ok(getAbilityList);
        }

        [HttpGet("article")]
        public IActionResult GetArticleList()
        {
            var getArticleList = _articleService.GetArticleList();
            if (!getArticleList.Success)
            {
                return BadRequest(getArticleList);
            }
            return Ok(getArticleList);
        }

        [HttpGet("chartData")]
        public IActionResult GetChartData()
        {
            var getChartData = _chartDataService.GetChartData();
            if (!getChartData.Success)
            {
                return BadRequest(getChartData);
            }
            return Ok(getChartData);
        }

        [HttpGet("employee")]
        public IActionResult GetEmployee()
        {
            var getEmployee = _employeeService.GetEmployeeList();
            if (!getEmployee.Success)
            {
                return BadRequest(getEmployee);
            }
            return Ok(getEmployee);
        }

        [HttpGet("twitter")]
        public IActionResult GetTwitter()
        {
            var getTwitter = _twitterService.GetTwitterList();
            if (!getTwitter.Success)
            {
                return BadRequest(getTwitter);
            }
            return Ok(getTwitter);
        }

    }
}
