using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CST247CLC.Models;
using CST247CLC.Services.Data;

namespace CST247CLC.Services.Business
{
    public class MineSweeperService
    {
        MineSweeperDataService mineSweeperDataService = new MineSweeperDataService();

        //load all record method
        public List<GameStorageModel> loadAllRecord()
        {
            return mineSweeperDataService.GetGames();
        }

        //delete method
        public bool removeGameRecord(int recordId)
        {
            return mineSweeperDataService.DeleteById(recordId);
        }
        //search a GameRecord by ID
        public GameStorageModel GetGameById(int recordId)
        {
            return mineSweeperDataService.GetGameById(recordId);
        }

        public int insertGameRecord(GameStorageModel gameStorageModel)
        {
            return mineSweeperDataService.Insert(gameStorageModel);
        }
    }
}
