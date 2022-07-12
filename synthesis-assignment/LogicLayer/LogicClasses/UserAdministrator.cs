using LogicLayer.Entities;
using LogicLayer.Exceptions;
using LogicLayer.Factories;
using LogicLayer.Interfaces;
using LogicLayer.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.LogicClasses
{
    public class UserAdministrator
    {
        List<User> users = new List<User>();

        IUserDAL iUserDAL;

        public UserAdministrator(IUserDAL iUserDAL)
        {
            try
            {
                this.iUserDAL = iUserDAL;
                UpdateUserList();
            }
            catch (Exception)
            {
                throw;
            }                   
            
        }

        /// <summary>
        /// This method gives all the registered users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            return users;
        }
        /// <summary>
        /// This method updates local user list using db 
        /// </summary>
        public void UpdateUserList()
        {
            try
            {
                users.Clear();
                users.AddRange(iUserDAL.GetAllUsersDAL());
            }
            catch (Exception)
            {
                throw;
            }            
        }
        /// <summary>
        /// This method returns true if the user id exists
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CheckIdExistence(User user)
        {
            return users.Exists(x => x.Id == user.Id);            
        }
        /// <summary>
        /// This method returns true if the username exists
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CheckUserNameExistence(User user)
        {
            return users.Exists(x => x.UserName == user.UserName);            
        }
        /// <summary>
        /// This method returns true if the email exists
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool CheckEmailExistence(User user)
        {            
            return  users.Exists(x => x.Email == user.Email);            
        }
        /// <summary>
        /// This method find an user using local list if this user doesnt exist then it throw an exception
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="UserDoesntExistException"></exception>
        public User FindUserById(string id)
        {
            if (users.Exists(x => x.Id == id))
            {
                return users.Find(x => x.Id == id);
            }
            else
            {
                throw new UserDoesntExistException();
            }                      
        }
        /// <summary>
        /// This method find an user using local list if this user doesnt exist then it throw an exception
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        /// <exception cref="UserDoesntExistException"></exception>
        public User FindUserByUserName(string userName)
        {
            if (users.Exists(x => x.UserName == userName))
            {
                return users.Find(x => x.UserName == userName);
            }
            else
            {
                throw new UserDoesntExistException();
            }                       
        }
        /// <summary>
        /// This method creates an new user and add it to the db and local list
        /// </summary>
        /// <param name="user"></param>
        public void CreateUser(User user)
        {
            users.Add(user);            
            iUserDAL.UserCreator(user);
        }
        /// <summary>
        /// This method creates an new user and delete it from the db and local list
        /// </summary>
        /// <param name="user"></param>
        public void DeleteUser(User user)
        {
            users.Remove(user);
            iUserDAL.DeleteUserDAL(user);
        }        
        /// <summary>
        /// This method edits an user
        /// </summary>
        /// <param name="user"></param>
        public void EditUser(User user)
        {
            iUserDAL.EditUserDAL(user);
        }
        /// <summary>
        /// This method checks given username and password. If this username doesnt exist or the user name and password doesnt match with an object in the local list then throw an exception
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckLogin(string username, string password)
        {
            try
            {
                var user = users.Find(x => x.UserName == username);

                var hashedPassword = PasswordHasher.sha256_hash(password + user.Salt);

                if (hashedPassword != user.HashedPassword)
                {
                    throw new AuthenticationException();
                    //return false; 
                }
            }            
            catch (System.NullReferenceException)
            {
                throw;
            }
            catch (AuthenticationException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
        /// <summary>
        /// This method adds 1 to wins of given player
        /// </summary>
        /// <param name="player"></param>
        public void AddAWinToAPlayer(Player player)
        {
            player.NrOfMatchesWin++;
            iUserDAL.EditUserDAL(player);
        }
        /// <summary>
        /// This method adds 1 to losts of given player
        /// </summary>
        /// <param name="player"></param>
        public void AddALostToAPlayer(Player player)
        {
            player.NrOfMatchesLost++;
            iUserDAL.EditUserDAL(player);
        }
        /// <summary>
        /// This method creates an list of players depend on their win rate. Only players playing 5 or more matches are counted
        /// </summary>
        /// <returns></returns>
        public List<Player> CreateHonorListByRate()
        {
            List<Player> leaderBoard = new List<Player>();
            foreach (var user in users)
            {
                if (user is Player)
                {
                    Player player = (Player)user;
                    if (player.NrOfMatchesLost+player.NrOfMatchesWin>=5)
                    {
                        leaderBoard.Add(player);
                    }                    
                }
            }
            var dic = leaderBoard.OrderByDescending(x => x.WinRate()).ToList();
            return dic;
        }
        /// <summary>
        /// This method creates an list of players depend on their total wins. Only players playing 5 or more matches are counted
        /// </summary>
        /// <returns></returns>
        public List<Player> CreateHonorListByTotalWin()
        {
            List<Player> players = new List<Player>();
            foreach (var user in users)
            {
                if (user is Player)
                {
                    Player player = (Player)user;
                    if (player.NrOfMatchesLost + player.NrOfMatchesWin >= 5)
                    {
                        players.Add(player);
                    }
                }
            }
            List<Player> lst = players.OrderByDescending(x => x.NrOfMatchesWin).ToList();
            return lst;
        }
    }    
}
