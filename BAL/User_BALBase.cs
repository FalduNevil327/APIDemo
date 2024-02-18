using APIDemo.DAL;
using APIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.BAL
{
    public class User_BALBase : Controller
    {
        #region API_SELECT_ALL_USER
        public List<UserModel> API_SELECT_ALL_USER()
        {
            try
            {
                User_DALBase user_DALBase = new User_DALBase();
                List<UserModel> userModels = user_DALBase.API_SELECT_ALL_USER();
                return userModels;
            }
            catch (Exception ex) {
                return null;

            }

        }
        #endregion

        #region API_SELECT_BY_PK_USER
        public UserModel API_SELECT_BY_PK_USER(int UserID)
        {
            try
            {
                User_DALBase user_DALBase = new User_DALBase();
                UserModel userModel = user_DALBase.API_SELECT_BY_PK_USER(UserID);
                return userModel;
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        #endregion

        #region API_DELETE_USER
        public int API_DELETE_USER(int UserID)
        {
            try
            {
                User_DALBase user_DALBase = new User_DALBase();
                var user= user_DALBase.API_DELETE_USER(UserID);
                return user;
            }
            catch (Exception ex)
            {
                return 0;

            }

        }

        #endregion

        #region API_INSERT_USER
        public int API_INSERT_USER(string Name, string Contact, string Email)
        {
            try
            {
                User_DALBase user_DALBase = new User_DALBase();
                var user = user_DALBase.API_INSERT_USER(Name,Contact,Email);
                return user;
            }
            catch (Exception ex)
            {
                return 0;

            }

        }

        #endregion

        #region API_UPDATE_USER
        public int API_UPDATE_USER(int UserID,string Name, string Contact, string Email)
        {
            try
            {
                User_DALBase user_DALBase = new User_DALBase();
                var user = user_DALBase.API_UPDATE_USER(UserID,Name, Contact, Email);
                return user;
            }
            catch (Exception ex)
            {
                return 0;

            }

        }

        #endregion


    }
}
