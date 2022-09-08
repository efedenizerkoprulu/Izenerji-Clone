using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SliderDetailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderDetailController : ControllerBase
    {
        ISliderService _sliderService;

        public SliderDetailController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet("GetSliderById")]
        public IActionResult GetSliderById(int id)
        {
            var getSlider = _sliderService.GetSliderById(id);
            if (!getSlider.Success)
            {
                return BadRequest(getSlider);
            }
            return Ok(getSlider);
        }


    }
}
