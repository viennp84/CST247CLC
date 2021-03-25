using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CST247CLC.Models
{
    public class GameStorageModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string dateTime { get; set; }
        public string gameBoard { get; set; }

        public GameStorageModel()
        {
            gameBoard = "";
        }
        public GameStorageModel(int userId, string dateTime, string gameBoard)
        {
            this.userId = userId;
            this.dateTime = dateTime;
            this.gameBoard = gameBoard;
        }

        public GameStorageModel(int id, int userId, string dateTime, string gameBoard)
        {
            this.id = id;
            this.userId = userId;
            this.dateTime = dateTime;
            this.gameBoard = gameBoard;
        }
    }
}
