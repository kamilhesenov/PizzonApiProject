using AutoMapper;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzonApi.Resources.HomePage;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzonApi.Controllers.V1
{
    [Route("V1/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public HomeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("banner")]
        [HttpGet]
        public async Task<IActionResult> GetBannerAsync()
        {
            var banners = await _unitOfWork.Banner.GetAllAsync();
            var bannersResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(banners);
            return Ok(bannersResources);
        }
    }
}
