using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BohemianHarmonyHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BandMembersController : Controller
    {
        public readonly IBandMemberRepository _bandMemberRepository;
        public BandMembersController(IBandMemberRepository bandMemberRepository) 
        {
            _bandMemberRepository = bandMemberRepository;
        }

        [HttpGet]
        public ActionResult<IQueryable<BandMember>> Get()
        {
            var bandMembers = _bandMemberRepository.Get();
            if (bandMembers != null)
            {
                return Ok(bandMembers);
            }

            return NotFound();
        }

        [HttpGet("{id:int}")]
        public ActionResult<BandMember> GetById(int id)
        {
            var bandMember = _bandMemberRepository.GetById(id);
            if (bandMember != null)
            {
                return Ok(bandMember);
            }

            return NotFound();
        }

        [HttpGet("name", Name = "GetBandMember")]
        public ActionResult<BandMember> GetByName(string name)
        {
            var bandMembers = _bandMemberRepository.GetByName(name);
            if (bandMembers != null)
            {
                return Ok(bandMembers);
            }

            return NotFound();
        }
        
        [HttpPost]
        public async Task<ActionResult<BandMember>> Post(BandMember bandMember)
        {
            if(bandMember != null)
            {
                await _bandMemberRepository.Post(bandMember);
                return new CreatedAtRouteResult("GetBandMember", new { id = bandMember.BandMemberId }, bandMember);
            }

            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<BandMember>> Put(int id, BandMember bandMemberData)
        {
            if (bandMemberData.BandMemberId == id)
            {
                await _bandMemberRepository.Put(bandMemberData);
                return Ok(bandMemberData);
            }

            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<BandMember>> Delete(int id)
        {
            var bandMember = _bandMemberRepository.GetById(id);
            if (bandMember != null)
            {
                await _bandMemberRepository.Delete(bandMember);
                return Ok(bandMember);
            }

            return BadRequest();
        }
    }
}
