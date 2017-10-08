using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZrTool.Model;

namespace ZrTool.DAL
{
    public class MemberInfoDal
    {
        /// <summary>
        /// 根据会员的id查询该会员信息
        /// </summary>
        /// <param name="memmberId">会员id</param>
        /// <returns>会员对象</returns>
        public UserInfo GetUserInfoByName(string LoginName)
        {
            string sql = "select * from tbuser where DelFlag=0 and (LoginName=" + LoginName + " or UserName="+LoginName+")";
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
        public int SoftDeleteUserInfoByLoginName(string LoginName)
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
        private UserInfo RowToUserInfo(DataRow dr)
        {
            UserInfo mem = new UserInfo();
            mem.UserName = dr["UserName"].ToString();
            mem.LoginName = dr["LoginName"].ToString();
            mem.UserPwd = dr["UserPwd"].ToString();
            mem.UserRight = dr["UserRight"].ToString();
            mem.LastLoginTime = dr["LastLoginTime"].ToString();
            return mem;
        }
    }
}
