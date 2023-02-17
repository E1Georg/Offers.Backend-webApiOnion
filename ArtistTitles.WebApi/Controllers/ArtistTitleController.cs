using Microsoft.AspNetCore.Mvc;
using ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleDetails;
using ArtistTitles.Application.ArtistTitles.Commands.CreateArtistTitle;
using ArtistTitles.WebApi.Models;
using ArtistTitles.Application.ArtistTitles.Queries.GetArtistTitleList;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace ArtistTitles.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ArtistTitleController : BaseController
    {
        private readonly IMapper _mapper;
        public ArtistTitleController(IMapper mapper) => _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<ArtistTitleListVm>> GetAll()
        {
            var query = new GetArtistTitleListQuery { };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<ArtistTitleDetailsVm>> Get(int id)
        {
            var query = new GetArtistTitleDetailsQuery { offerId = id };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateArtistTitleDto createArtistTitleDto)
        {
            var command = _mapper.Map<CreateArtistTitleCommand>(createArtistTitleDto);
            command.Id = Id;
            var ArtistTitleId = await Mediator.Send(command); 
            return Ok(ArtistTitleId); 
        }
    }
}
