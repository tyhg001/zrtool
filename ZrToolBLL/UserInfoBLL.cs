using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZrTool.DAL;
using ZrTool.Model;


namespace ZrTool.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL dal = new UserInfoDAL();
        /// <summary>
        /// 根据用户的帐号和密码判断是否登录成功
        /// </summary>
        /// <param name="loginName">登录名</param>
        /// <param name="pwd">登录密码</param>
        /// <param name="msg">返回的信息</param>
        /// <returns>如果为true则登录成功,如果为false则登录失败</returns>
        public bool GetUserInfoByLoginUserNameAndPwd(string loginName, string pwd, out string msg)
        {
            //获取该用户的信息(对象)
            UserInfo user = dal.GetUserInfoByLoginUserName(loginName);
            if (user != null)
            {
                if (user.UserPwd == pwd)
                {
                    msg = "登录成功";
                    return true;
                }
                else
                {
                    msg = "密码错误";
                    return false;
                }
            }
            else
            {
                msg = "用户不存在";
                return false;
            }
        }
    }
}
