using APIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace APIDemo.DAL
{
    public class User_DALBase : DAL_Helpers
    {
        #region Select_All_User
        public List<UserModel> API_SELECT_ALL_USER()
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("API_SELECT_ALL_USER");
                List<UserModel> userModels = new List<UserModel>();
                using (IDataReader dr = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dr.Read())
                    {
                        UserModel userModel = new UserModel();
                        userModel.UserID = Convert.ToInt32(dr["UserID"].ToString());
                        userModel.Name = dr["Name"].ToString();
                        userModel.Contact = dr["Contact"].ToString();
                        userModel.Email = dr["Email"].ToString();
                        userModels.Add(userModel);

                    }
                }
                return userModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region SELECT_USER_BY_ID

        public UserModel API_SELECT_BY_PK_USER(int UserID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("API_SELECT_BY_PK_USER");
                sqlDatabase.AddInParameter(dbCommand, "@UserID", SqlDbType.Int, UserID);
                UserModel userModel = new UserModel();
                using (IDataReader dr = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dr.Read())
                    {
                        userModel.UserID = Convert.ToInt32(dr["UserID"].ToString());
                        userModel.Name = dr["Name"].ToString();
                        userModel.Contact = dr["Contact"].ToString();
                        userModel.Email = dr["Email"].ToString();
                    }
                    return userModel;
                }

            }
            catch (Exception e)
            {
                return null;
            }


        }

        #endregion

        #region INSERT_USER


        #endregion

        #region DELETE_USER

        public int API_DELETE_USER(int UserID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("API_DELETE_USER");
                sqlDatabase.AddInParameter(dbCommand, "@UserID", SqlDbType.Int, UserID);
                var user = sqlDatabase.ExecuteNonQuery(dbCommand);
                return user;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        #endregion

        #region INSERT_USER

        public int API_INSERT_USER(string Name, string Contact, string Email)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("API_INSERT_USER");
                sqlDatabase.AddInParameter(dbCommand, "@Name", SqlDbType.VarChar, Name);
                sqlDatabase.AddInParameter(dbCommand, "@Contact", SqlDbType.VarChar, Contact);
                sqlDatabase.AddInParameter(dbCommand, "@Email", SqlDbType.VarChar, Email);
                int user = sqlDatabase.ExecuteNonQuery(dbCommand);
                return user;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        #endregion

        #region UPDATE_USER

        public int API_UPDATE_USER(int UserID,string Name, string Contact, string Email)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(ConnString);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("API_UPDATE_USER");
                sqlDatabase.AddInParameter(dbCommand, "@UserID", SqlDbType.Int, UserID);
                sqlDatabase.AddInParameter(dbCommand, "@Name", SqlDbType.VarChar, Name);
                sqlDatabase.AddInParameter(dbCommand, "@Contact", SqlDbType.VarChar, Contact);
                sqlDatabase.AddInParameter(dbCommand, "@Email", SqlDbType.VarChar, Email);
                int user = sqlDatabase.ExecuteNonQuery(dbCommand);
                return user;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        #endregion

    }
}

   
