using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CST247CLC.Models;


namespace CST247CLC.Services.Data
{
    public class MineSweeperDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CST247CLC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        /// <summary>
        /// Insert game using gameStorageModel
        /// </summary>
        /// <param name="gameStorage"></param>
        public int Insert(GameStorageModel gameStorage)
        {
            int newIdNumber = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string quey = "INSERT INTO GameStorage(UserId, DateTime, GameBoard) VALUES(@userId, @dateTime, @gameBoard)";
                SqlCommand myCommand = new SqlCommand(quey, connection);
                myCommand.Parameters.AddWithValue("@userId", gameStorage.userId);
                myCommand.Parameters.AddWithValue("@dateTime", gameStorage.dateTime);
                myCommand.Parameters.AddWithValue("@gameBoard", gameStorage.gameBoard);
                try
                {
                    connection.Open();

                    //check if there was a row affected
                    if (myCommand.ExecuteNonQuery() > 0)
                        newIdNumber = 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return newIdNumber;
            }
        }
        /// <summary>
        /// Delete game by id
        /// </summary>
        /// <param name="id"></param>
        public bool DeleteById(int id)
        {
            int isDeleted = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string quey = "DELETE GameStorage WHERE Id = @Id";
                SqlCommand command = new SqlCommand(quey, connection);
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    connection.Open();
                    isDeleted = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return isDeleted > 0;
        }
        /// <summary>
        /// Select gamestorage by id
        /// </summary>
        /// <param name="id"></param>
        public GameStorageModel GetGameById(int id)
        {
            GameStorageModel gameStorageModel = null;
            string sqlStatement = "SELECT * FROM GameStorage WHERE Id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        gameStorageModel = new GameStorageModel((int)reader[0], (int)reader[1], (string)reader[2], (string)reader[3]);
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                };
            }
            return gameStorageModel;
        }

        /// <summary>
        /// Select gamestorage by id
        /// </summary>
        /// <param name="id"></param>
        public List<GameStorageModel> GetGames()
        {
            List<GameStorageModel> gameStorageList = new List<GameStorageModel>();
            string sqlStatement = "SELECT * FROM GameStorage";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        gameStorageList.Add(new GameStorageModel((int)reader[0], (int)reader[1], (string)reader[2], (string)reader[3]));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                };
            }
            return gameStorageList;
        }
    }
}
