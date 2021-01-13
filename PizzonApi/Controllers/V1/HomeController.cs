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

        [Route("isBanner")]
        [HttpGet]
        public async Task<IActionResult> GetIsBannerAsync()
        {
            var isBanners = await _unitOfWork.Banner.GetIsBannerAsync();
            var isBannerResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(isBanners);
            return Ok(isBannerResources);
        }
        [Route("isService")]
        [HttpGet]
        public async Task<IActionResult> GetIsServiceAsync()
        {
            var isService = await _unitOfWork.Banner.GetIsServiceAsync();
            var isServiceResources = _mapper.Map<IEnumerable<Banner>, IEnumerable<BannerResource>>(isService);
            return Ok(isServiceResources);
        }
    }
}
