using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using ZrTool.Model;

namespace ZrTool.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 根据用户输入的帐号去数据库中查询该帐号的所有的信息
        /// </summary>
        /// <param name="loginUserName">登录名</param>
        /// <returns>用户对象</returns>
        public UserInfo GetUserInfoByLoginUserName(string loginName)
        {
            string sql = "select * from tbuser where LoginName=@loginName";
            DataTable dt = SqliteHelper.ExecuteTable(sql, new SQLiteParameter("@loginName", loginName));
            UserInfo user = null;
            //判断是否有数据
            if (dt.Rows.Count > 0)
            {
                user = RowToUserInfo(dt.Rows[0]);
            }
            return user;
        }
        //把关系型的数据转成对象的方式---关系转对象
        private UserInfo RowToUserInfo(DataRow dr)
        {
            UserInfo user = new UserInfo();
            user.LoginName = dr["LoginName"].ToString();
            user.UserName = dr["UserName"].ToString();
            user.UserPwd = dr["UserPwd"].ToString();
            user.UserRight = dr["UserRight"].ToString();
            user.LastLoginTime = dr["LastLoginTime"].ToString();
            user.DelFlag = dr["DelFlag"].ToString();
            return user;
        }

        public UserInfo GetUserInfoByLoginName(string LoginName)
        {
            string sql = "select * from MemmberInfo where DelFlag=0 and LoginName=" + LoginName;
            DataTable dt = SqliteHelper.ExecuteTable(sql);
            UserInfo mem = null;
            if (dt.Rows.Count > 0)//有数据
            {
                mem = RowToUserInfo(dt.Rows[0]);
            }
            return mem;
        }


        /// <summary>
        /// 删除会员
        /// </summary>
        /// <param name="memmberId">会员的id</param>
        /// <returns>受影响的行数</returns>
        public int SoftDeleteUserInfoByLoginName(int LoginName)
        {
            string sql = "update tbuser set DelFlag=1 where LoginName=" + LoginName;
            return SqliteHelper.ExecuteNonQuery(sql);
        }


        /// <summary>
        /// 根据删除标识查询所有的会员信息
        /// </summary>
        /// <param name="delFlag">删除标识0---没删除,1---删除</param>
        /// <returns>会员信息集合(对象)</returns>
        public List<UserInfo> GetAllUserInfoByDelFlag(int delFlag)
        {
            string sql = "select * from tbuser where DelFlag=" + delFlag;
            DataTable dt = SqliteHelper.ExecuteTable(sql);
            //创建一个集合存所有的会员对象
            List<UserInfo> list = new List<UserInfo>();
            if (dt.Rows.Count > 0)//判断是否有行,是否有数据
            {
                //遍历所有的行
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(RowToUserInfo(dr));
                }
            }
            return list;
        }
        //关系转对象


    }
}
