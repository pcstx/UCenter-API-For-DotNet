using DS.Web.UCenter;
using DS.Web.UCenter.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UCenter.API
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class UC : UcApiBase
    {
        public override ApiReturn DeleteUser(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }
        public override ApiReturn RenameUser(int uid, string oldUserName, string newUserName)
        {
            throw new NotImplementedException();
        }
        public override UcTagReturns GetTag(string tagName)
        {
            throw new NotImplementedException();
        }
        public override ApiReturn SynLogin(int uid)
        {
            //SiteMember loginMember = users.GetInfoByUid(uid);
            //DataTable dt = msh.GetDataTable("select uid,username,password,email,groupid from pre_common_member where uid=" + uid + " limit 0,1");
            //if (dt == null || dt.Rows.Count < 1)
            //{
            //    return ApiReturn.Failed;//无法从远端找到，则此用户不存在
            //}
            //DataRow dr = dt.Rows[0];
            //if (loginMember != null)
            //{//从本地库找到，则更新库             
            //    loginMember.ULevel = dr[4].ToString().ToNumber();
            //    users.EditInfo();
            //    //以下代码保存会话到浏览器进程
            //    TuanGouManager.userSessionManager.Login(loginMember, UserLoginExpire.NoSave);
            //    return ApiReturn.Success;
            //}

            ////本地库没有，则添加到本地库
            //loginMember = new SiteMember
            //{
            //    CreateTime = DateTime.Now,
            //    Address = "",
            //    BadAppCount = 0,
            //    CumulateMoney = "",
            //    EditTime = DateTime.Now,
            //    Email = dr[3].ToString(),
            //    GoodAppCount = 0,
            //    Intro = "",
            //    IpAddress = HttpContext.Current.Request.UserHostAddress,
            //    IsLock = 0,
            //    NickName = "",
            //    NormalAppCount = 0,
            //    PickedMoney = "",
            //    RemainMoney = "",
            //    SiteAuthoritys = "",
            //    SiteRole = "",
            //    TrueName = "",
            //    UID = uid,
            //    ULevel = dr[4].ToString().ToNumber(),
            //    UserName = dr[1].ToString(),
            //    UserPass = dr[2].ToString(),
            //    UserQQ = "",
            //    UserSex = "保密",
            //    UserTel = "",
            //    UserType = ",1,"
            //};
            //int userId = users.AddNewInfo(loginMember);
            //loginMember.ID = userId;
            ////以下代码保存会话到浏览器进程            
            //TuanGouManager.userSessionManager.Login(loginMember, UserLoginExpire.NoSave);
            return ApiReturn.Success;
        }
        public override ApiReturn SynLogout()
        {
            //TuanGouManager.userSessionManager.Logout();
            return ApiReturn.Success;
        }
        public override ApiReturn UpdatePw(string userName, string passWord)
        {
            throw new NotImplementedException();
        }
        public override ApiReturn UpdateBadWords(UcBadWords badWords) { throw new NotImplementedException(); }
        public override ApiReturn UpdateHosts(UcHosts hosts) { throw new NotImplementedException(); }
        public override ApiReturn UpdateApps(UcApps apps) { throw new NotImplementedException(); }
        public override ApiReturn UpdateClient(UcClientSetting client) { throw new NotImplementedException(); }
        public override ApiReturn UpdateCredit(int uid, int credit, int amount) { throw new NotImplementedException(); }
        public override UcCreditSettingReturns GetCreditSettings() { throw new NotImplementedException(); }
        public override ApiReturn GetCredit(int uid, int credit) { throw new NotImplementedException(); }
        public override ApiReturn UpdateCreditSettings(UcCreditSettings creditSettings) { throw new NotImplementedException(); }
    }
}