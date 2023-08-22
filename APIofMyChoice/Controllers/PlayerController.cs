using APIofMyChoice.DataContext;
using APIofMyChoice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIofMyChoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly  PlayerContext _playerContext;
        public PlayerController(PlayerContext context)
        {
            _playerContext = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerModel>>> GetPlayers()
        {
            return await _playerContext.Players.ToListAsync();
        }
        [HttpGet("{id}")]
        public PlayerModel GetPlayerModel(int id)
        {
            PlayerModel player = _playerContext.Players.Where(p => p.Id == id).FirstOrDefault();
            return player;
        }
        [HttpDelete("{id}")]
        public void DeletePlayerModel(int id)
        {
            PlayerModel player = _playerContext.Players.Find(id);
            _playerContext.Players.Remove(player);
            _playerContext.SaveChanges();

        }









    }
}
