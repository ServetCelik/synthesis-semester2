using LogicLayer.Entities;
using LogicLayer.Interfaces;
using LogicLayer.LogicClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Classes
{
    public class UserDAL : IUserDAL
    {
        MySqlConnection con = new MySqlConnection(ConStringFactory.ConString("Mysql"));
        MySqlCommand cmd = new MySqlCommand();



        public List<User> GetAllUsersDAL()
        {
            List<User> users = new List<User>();
            users.AddRange(GetAllPlayersDAL());
            users.AddRange(GetAllStaffsDAL());
            return users;
        }

        public List<User> GetAllStaffsDAL()
        {
            List<User> users = new List<User>();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM sa_user JOIN sa_staff ON sa_user.id = sa_staff.userId";

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string idNumber = Convert.ToString(reader["id"]);
                            string username = Convert.ToString(reader["userName"]);
                            string hashedPassword = Convert.ToString(reader["hashedPassword"]);
                            string salt = Convert.ToString(reader["salt"]);
                            string email = Convert.ToString(reader["email"]);
                            string role = Convert.ToString(reader["role"]);

                            users.Add(new Staff(idNumber, username, hashedPassword, salt, email, role));                          

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
            return users;
        }
        public List<User> GetAllPlayersDAL()
        {
            List<User> users = new List<User>();
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM sa_user JOIN sa_player ON sa_user.id = sa_player.userid";

                using (con)
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            string idNumber = Convert.ToString(reader["id"]);                            
                            string username = Convert.ToString(reader["userName"]);
                            string hashedPassword = Convert.ToString(reader["hashedPassword"]);
                            string salt = Convert.ToString(reader["salt"]);
                            string email = Convert.ToString(reader["email"]);
                            string firstName = Convert.ToString(reader["firstName"]);
                            string lastName = Convert.ToString(reader["lastName"]);
                            int nrOfMatchesWin = Convert.ToInt32(reader["nrOfMatchesWin"]);
                            int nrOfMatchesLost = Convert.ToInt32(reader["nrOfMatchesLost"]);

                            users.Add(new Player(idNumber, username, hashedPassword, salt, email, firstName, lastName, nrOfMatchesWin, nrOfMatchesLost));                         

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
            return users;
        }

        public void UserCreator(User user)
        {
            CreateUserDAL(user);            

            if (user is Staff)
            {
                StaffCreator(user);
            }
            else
            {
                PlayerCreator(user);
            }
        }
        

        public void CreateUserDAL(User user)
        {
            try
            {               

                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO sa_user (id, userName, hashedPassword, salt, email) VALUES(@id, @userName, @hashedPassword, @salt, @email)";
                                        
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@hashedPassword", user.HashedPassword);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@email", user.Email);
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
        public void PlayerCreator(User user)
        {
            try
            {

                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO sa_player (userId, firstName, lastName, nrOfMatchesWin, nrOfMatchesLost) VALUES(@userId, @firstName, @lastName, @nrOfMatchesWin, @nrOfMatchesLost)";
                    Player player = (Player)user;
                    cmd.Parameters.AddWithValue("@userId", user.Id);
                    cmd.Parameters.AddWithValue("@firstName", player.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", player.LastName);
                    cmd.Parameters.AddWithValue("@nrOfMatchesWin", player.NrOfMatchesWin);
                    cmd.Parameters.AddWithValue("@nrOfMatchesLost", player.NrOfMatchesLost);

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
        public void StaffCreator(User user)
        {
            try
            {

                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();
                    Staff staff = (Staff)user;
                    cmd.CommandText = "INSERT INTO sa_staff (userId,role) VALUES(@userId,@role)";
                    cmd.Parameters.AddWithValue("@userId", user.Id);
                    cmd.Parameters.AddWithValue("@role", staff.Role);
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

        public void DeleteUserDAL(User user)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();

                    cmd.CommandText = "DELETE FROM sa_user WHERE id = @id";

                    cmd.Parameters.AddWithValue("@id", user.Id);

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

        public void EditUserDAL(User user)
        {
            try
            {
                con.Open();
                using (con)
                {
                    cmd = con.CreateCommand();


                    cmd.CommandText = "UPDATE sa_user SET userName = @userName, hashedPassword = @hashedPassword, salt = @salt, email = @email WHERE id = @id";

                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.Parameters.AddWithValue("@userName", user.UserName);
                    cmd.Parameters.AddWithValue("@hashedPassword", user.HashedPassword);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@email", user.Email);

                    cmd.ExecuteNonQuery();

                    if (user is Player)
                    {
                                cmd = con.CreateCommand();

                                cmd.CommandText = "UPDATE sa_player SET firstName = @firstName, lastName = @lastName, nrOfMatchesWin = @nrOfMatchesWin, nrOfMatchesLost = @nrOfMatchesLost WHERE userId = @userId";

                                Player player = (Player)user;
                                cmd.Parameters.AddWithValue("@userId", user.Id);
                                cmd.Parameters.AddWithValue("@firstName", player.FirstName);
                                cmd.Parameters.AddWithValue("@lastName", player.LastName);
                                cmd.Parameters.AddWithValue("@nrOfMatchesWin", player.NrOfMatchesWin);
                                cmd.Parameters.AddWithValue("@nrOfMatchesLost", player.NrOfMatchesLost);

                                cmd.ExecuteNonQuery();                     
                        
                        
                    }
                    else if (user is Staff)
                    {
                                cmd = con.CreateCommand();

                                Staff staff = (Staff)user;
                                cmd.CommandText = "UPDATE sa_player SET role = @role WHERE userId = @userId";
                                cmd.Parameters.AddWithValue("@userId", user.Id);
                                cmd.Parameters.AddWithValue("@role", staff.Role);
                                cmd.ExecuteNonQuery();
                     
                        
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
        }




        

        //public bool CheckEmailExistenceDAL(User user)
        //{
        //    bool result = true;
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();

        //            cmd.CommandText = "SELECT CASE WHEN EXISTS (SELECT id FROM sa_user WHERE email = @email) THEN true ELSE false END FROM sa_user";

        //            cmd.Parameters.AddWithValue("@email", user.Email);

        //            result = (bool)cmd.ExecuteScalar();
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
        //    return result;
        //}

        //public bool CheckIdExistenceDAL(User user)
        //{
        //    bool result = true;
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();

        //            cmd.CommandText = "SELECT CASE WHEN EXISTS (SELECT id FROM sa_user WHERE id = @id) THEN true ELSE false END FROM sa_user";

        //            cmd.Parameters.AddWithValue("@id", user.Id);

        //            result = (bool)cmd.ExecuteScalar();
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
        //    return result;
        //}

        //public bool CheckUserNameExistenceDAL(User user)
        //{
        //    bool result = true;
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();

        //            cmd.CommandText = "SELECT CASE WHEN EXISTS (SELECT id FROM sa_user WHERE username = @username) THEN true ELSE false END FROM sa_user";

        //            cmd.Parameters.AddWithValue("@username", user.UserName);

        //            result = (bool)cmd.ExecuteScalar();
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
        //    return result;
        //}

        //public int GetUserIdWithNameDAL(string userName)
        //{
        //    Int32 id = -1;
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();

        //            cmd.CommandText = "SELECT id from sa_user where userName = @userName";

        //            cmd.Parameters.AddWithValue("@userName", userName);

        //            id = (Int32)cmd.ExecuteScalar();
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
        //    return id;
        //}



        //public string GetLastRowId(/*string tableName*/)
        //{
        //    string id;
        //    try
        //    {
        //        con.Open();
        //        using (con)
        //        {
        //            cmd = con.CreateCommand();

        //            cmd.CommandText = "SELECT id FROM sa_user ORDER BY id DESC LIMIT 1";

        //            //cmd.Parameters.AddWithValue("@tableName", tableName);

        //            id = (string)cmd.ExecuteScalar();
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
        //    return id;

        //}
    }
}
