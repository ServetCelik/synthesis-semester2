using LogicLayer.Entities;
using LogicLayer.Enums;
using LogicLayer.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Classes
{
    public class TournamentDAL : ITournamentDAL
    {
        
        MySqlConnection con = new MySqlConnection(ConStringFactory.ConString("Mysql"));
        MySqlCommand cmd = new MySqlCommand();

        //SELECT * FROM sa_tournament as t INNER JOIN sa_user as u on t.creatorId = u.id INNER Join sa_staff as s on u.id = s.userId



        public List<Tournament> GetTournamentsFromDBDAL()
        {
            List<Tournament> tournaments = new List<Tournament>();
            try
            {
                MySqlConnection con = new MySqlConnection(ConStringFactory.ConString("Mysql"));
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT t.id as tournamentId,tournamentName,sportType,tournamentType,description,location," +
                    "startDate,endDate,minPlayers,maxPlayers,status,u.id as userId,userName,hashedPassword,salt,email,role " +
                    "FROM sa_tournament as t INNER JOIN sa_user as u on t.creatorId = u.id INNER Join sa_staff as s on u.id = s.userId";

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string id = Convert.ToString(reader["tournamentId"]);
                            string tournamentName = Convert.ToString(reader["tournamentName"]);
                            string sportType = Convert.ToString(reader["sportType"]);
                            string tournamentType = Convert.ToString(reader["tournamentType"]);
                            string description = Convert.ToString(reader["description"]);
                            string location = Convert.ToString(reader["location"]);
                            DateTime startDate = Convert.ToDateTime(reader["startDate"]);
                            DateTime endDate = Convert.ToDateTime(reader["endDate"]);
                            int minPlayers = Convert.ToInt32(reader["minPlayers"]);
                            int maxPlayers = Convert.ToInt32(reader["maxPlayers"]);                            
                            Status status = (Status)Enum.Parse(typeof(Status), Convert.ToString(reader["status"]));

                            string creatorId = Convert.ToString(reader["userId"]);
                            string username = Convert.ToString(reader["userName"]);
                            string hashedPassword = Convert.ToString(reader["hashedPassword"]);
                            string salt = Convert.ToString(reader["salt"]);
                            string email = Convert.ToString(reader["email"]);
                            string role = Convert.ToString(reader["role"]);

                            Staff whoCreated = new Staff(creatorId, username, hashedPassword, salt, email, role);

                            tournaments.Add(new Tournament(id, tournamentName, sportType, tournamentType, description, location, startDate, endDate, minPlayers, maxPlayers, whoCreated, status));
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
               con.Close();             

            }
            return tournaments;
        }

        public List<Match> FindMatchesByTournamentIdDAL(Tournament tournament)
        {
            List<Match> matchs = new List<Match>();
            try
            {
                MySqlConnection con = new MySqlConnection(ConStringFactory.ConString("Mysql"));
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM sa_match WHERE tournamentId = @tournamentId ";

                cmd.Parameters.AddWithValue("@tournamentId", tournament.Id);

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string id = Convert.ToString(reader["id"]);
                            DateTime date = Convert.ToDateTime(reader["date"]);
                            string sportType = Convert.ToString(reader["sportType"]);
                            string player1Id = Convert.ToString(reader["player1Id"]);
                            string player2Id = Convert.ToString(reader["player2Id"]);


                            int? player2Score = reader["player2Score"] as int?;
                            int? player1Score = reader["player1Score"] as int?;


                            Player player1 = (Player)FindUserByIdDAL(player1Id);
                            Player player2 = (Player)FindUserByIdDAL(player2Id);

                            Match match = new Match(id, tournament.Id, date, sportType, player1, player2);
                            match.Player1Score = player1Score;
                            match.Player2Score = player2Score;
                            matchs.Add(match);
                        }
                    }
                }
            }
            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return matchs;
        }

        public bool CheckIfUserIsAPlayerDAL(string id)
        {
            bool result = true;

            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT CASE WHEN EXISTS (SELECT playerId FROM sa_player WHERE userId = @userId) THEN true ELSE false END FROM sa_player";

                    cmd.Parameters.AddWithValue("@userId", id);

                    result = Convert.ToBoolean(cmd.ExecuteScalar());
                }
            }
            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public User FindUserByIdDAL(string id)
        {
            User? user = null;

            try
            {
                bool isItPlayer = CheckIfUserIsAPlayerDAL(id);

                con.Open();
                cmd = con.CreateCommand();
                if (isItPlayer)
                {
                    cmd.CommandText = "SELECT * FROM sa_user JOIN sa_player ON sa_user.id = sa_player.userid where id = @id";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM sa_user JOIN sa_staff ON sa_user.id = sa_staff.userId where id = @id";
                }

                cmd.Parameters.AddWithValue("@id", id);

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string username = Convert.ToString(reader["userName"]);
                            string hashedPassword = Convert.ToString(reader["hashedPassword"]);
                            string salt = Convert.ToString(reader["salt"]);
                            string email = Convert.ToString(reader["salt"]);

                            if (isItPlayer)
                            {
                                string firstName = Convert.ToString(reader["firstName"]);
                                string lastName = Convert.ToString(reader["lastName"]);
                                int nrOfMatchesWin = Convert.ToInt32(reader["nrOfMatchesWin"]);
                                int nrOfMatchesLost = Convert.ToInt32(reader["nrOfMatchesLost"]);
                                user = new Player(id, username, hashedPassword, salt, email, firstName, lastName, nrOfMatchesWin, nrOfMatchesLost);
                            }
                            else
                            {
                                string role = Convert.ToString(reader["role"]);
                                user = new Staff(id, username, hashedPassword, salt, email, role);
                            }
                        }
                    }
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return user;
        }

        public void AddGeneratedMatchesToDBDAL(Match match)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO sa_match (id,tournamentId, date, sportType, player1Id, player2Id, player1Score, player2Score ) VALUES(@id, @tournamentId, @date, @sportType, @player1Id, @player2Id, @player1Score, @player2Score)";

                    cmd.Parameters.AddWithValue("@id", match.MatchId);
                    cmd.Parameters.AddWithValue("@tournamentId", match.TournamentId);
                    cmd.Parameters.AddWithValue("@date", match.Date);
                    cmd.Parameters.AddWithValue("@sportType", match.SportType);
                    cmd.Parameters.AddWithValue("@player1Id", match.Player1.Id);
                    cmd.Parameters.AddWithValue("@player2Id", match.Player2.Id);
                    cmd.Parameters.AddWithValue("@player1Score", match.Player1Score);
                    cmd.Parameters.AddWithValue("@player2Score", match.Player1Score);

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        public void AddMatchScoreDAL(Match match)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "UPDATE sa_match SET player1Score = @player1Score, player2Score = @player2Score WHERE id = @matchId";

                    cmd.Parameters.AddWithValue("@matchId", match.MatchId);
                    cmd.Parameters.AddWithValue("@player1Score", match.Player1Score);
                    cmd.Parameters.AddWithValue("@player2Score", match.Player2Score);

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        public void UpdateTournamentStatusDAL(Tournament tournament)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();
                    
                    cmd.CommandText = "UPDATE sa_tournament SET status = @status WHERE id = @id";

                    cmd.Parameters.AddWithValue("@id", tournament.Id);
                    cmd.Parameters.AddWithValue("@status", tournament.Status + 1);

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void DeletePlayerFromTournamnetDAL(Tournament tournament, Player player)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "DELETE FROM sa_tournament_players WHERE tournamentId = @tournamentId AND userId = @userId";

                    cmd.Parameters.AddWithValue("@tournamentId", tournament.Id);
                    cmd.Parameters.AddWithValue("@userId", player.Id);

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());

            }
            finally
            {
                con.Close();
            }
        }

        public void AddPlayerToTournamentDAL(Tournament tournament, Player player)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO sa_tournament_players (tournamentId, userId) VALUES(@tournamentId, @userId)";

                    cmd.Parameters.AddWithValue("@tournamentId", tournament.Id);
                    cmd.Parameters.AddWithValue("@userId", player.Id);                    

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void NewTournamentDAL(Tournament tournament)
        {
            try
            {

                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO sa_tournament (id, tournamentName, sportType,tournamentType, description, location, startDate, endDate, minPlayers, maxPlayers, creatorId, status) VALUES(@id, @tournamentName, @sportType, @tournamentType, @description, @location, @startDate, @endDate, @minPlayers, @maxPlayers, @creatorId, @status)";

                    cmd.Parameters.AddWithValue("@id", tournament.Id);
                    cmd.Parameters.AddWithValue("@tournamentName", tournament.TournamentName);
                    cmd.Parameters.AddWithValue("@sportType", tournament.SportType);
                    cmd.Parameters.AddWithValue("@tournamentType", tournament.TournamentType);
                    cmd.Parameters.AddWithValue("@description", tournament.Description);
                    cmd.Parameters.AddWithValue("@location", tournament.Location);
                    cmd.Parameters.AddWithValue("@startDate", tournament.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", tournament.EndDate);
                    cmd.Parameters.AddWithValue("@minPlayers", tournament.MinPlayers);
                    cmd.Parameters.AddWithValue("@maxPlayers", tournament.MaxPlayers);
                    cmd.Parameters.AddWithValue("@creatorId", tournament.WhoCreated.Id);
                    cmd.Parameters.AddWithValue("@status", tournament.Status+1);

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteTournamentDAL(Tournament tournament)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "DELETE FROM sa_tournament WHERE id=@id";

                    cmd.Parameters.AddWithValue("@id", tournament.Id);                    

                    cmd.ExecuteNonQuery();
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        public List<Player> GetPlayersJoinedATournamentDAL(Tournament tournament)
        {
            List<Player> players = new List<Player>();
            try
            {
                MySqlConnection con = new MySqlConnection(ConStringFactory.ConString("Mysql"));
                MySqlCommand cmd = new MySqlCommand();
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM sa_tournament_players WHERE tournamentId = @tournamentId ";

                cmd.Parameters.AddWithValue("@tournamentId", tournament.Id);

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {

                            string userId = Convert.ToString(reader["userId"]);
                            if (true)
                            {

                            }

                            Player player = (Player)FindUserByIdDAL(userId);
                            players.Add(player);
                        }
                    }
                }
            }            
            catch (Exception ex)
            {
                throw;
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return players;
        }
























        //public List<int[]> FindScoresWithMatchIdDAL(int matchId)
        //{
        //    List<int[]> scoreList = new List<int[]>();
        //    try
        //    {
        //        con.Open();
        //        cmd = con.CreateCommand();
        //        cmd.CommandText = "SELECT * FROM sa_score WHERE matchId = @matchId ";

        //        cmd.Parameters.AddWithValue("@matchId", matchId);

        //        using (con)
        //        {
        //            MySqlDataReader reader = cmd.ExecuteReader();
        //            using (reader)
        //            {
        //                while (reader.Read())
        //                {

        //                    int player1Score = Convert.ToInt32(reader["player1Score"]);
        //                    int player2Score = Convert.ToInt32(reader["player2Score"]);

        //                    scoreList.Add(new int[] {player1Score,player2Score});
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(Convert.ToString(ex));
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return scoreList;
        //}
    }
}
