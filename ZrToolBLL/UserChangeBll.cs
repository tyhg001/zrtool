using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZrTool.DAL;
using ZrTool.Model;

namespace ZrTool.BLL
{
    public class UserChangeBll
    {
        MemberInfoDal dal = new MemberInfoDal();
      
        public UserInfo GetUserInfoByloginName(string loginName)
        {
            return dal.GetUserInfoByName(loginName);
        }

        /// <summary>
        /// 删除会员
        /// </summary>
        /// <param name="memmberId">会员的id</param>
        /// <returns>受影响的行数</returns>
        public bool SoftDeleteUserInfoByloginName(string loginName)
        {
            return dal.SoftDeleteUserInfoByLoginName(loginName) > 0;
        }

        /// <summary>
        /// 根据删除标识查询所有的会员信息
        /// </summary>
        /// <param name="delFlag">删除标识0---没删除,1---删除</param>
        /// <returns>会员信息集合(对象)</returns>
        public List<UserInfo> GetAllUserInfoByDelFlag(int delFlag)
        {
            return dal.GetAllUserInfoByDelFlag(delFlag);
        }
    }
}
