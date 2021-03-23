using CST247CLC.Models;
using CST247CLC.Services.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace CST247CLC.Controllers
{
    [ApiController]
    [Route("api")]
    public class MinesweeperAPIController : ControllerBase
    {
        MineSweeperDataService mds = new MineSweeperDataService();

        public MinesweeperAPIController()
        {
            mds = new MineSweeperDataService();
        }

        /// <summary>
        /// Show all saved games
        /// </summary>
        /// <returns></returns>
        [HttpGet("showSavedGames")]
        [ResponseType(typeof(List<GameStorageModel>))]
        public IEnumerable<GameStorageModel> showSavedGames()
        {
            IEnumerable<GameStorageModel> gameList = mds.GetGames();

            return gameList;
        }

        /// <summary>
        /// Show one game by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("showSavedGames/{Id}")]
        [ResponseType(typeof(GameStorageModel))]
        public ActionResult <GameStorageModel> showSavedGames(int Id)
        {
            GameStorageModel gsm = mds.GetGameById(Id);

            return gsm;
        }

        /// <summary>
        /// Delete game by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("deleteOneGame/{Id}")]
        [ResponseType(typeof(GameStorageModel))]
        public ActionResult<GameStorageModel> deleteOneGame(int Id)
        {
            mds.DeleteById(Id);

            return NoContent();
        }
    }
}
