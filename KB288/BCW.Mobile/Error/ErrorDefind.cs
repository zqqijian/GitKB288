﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BCW.Mobile.Error
{

    public enum MOBILE_ERROR_CODE
    {
        /// <summary>
        /// 没有错误信息输出
        /// </summary>
        MOBILE_MSG_NONE,

        /// <summary>
        /// 系统出现未知错误，请稍候再试...
        /// </summary>
        MOBILE_SYS_ERROR,

        /// <summary>
        /// 服务器繁忙，请稍候再试...
        /// </summary>
        MOBILE_SYS_BUSY,

        /// <summary>
        /// 参数错误
        /// </summary>
        MOBILE_PARAMS_ERROR,

        /// <summary>
        /// 手机号码不能为空 
        /// </summary>
        MOBILE_PHONE_ISNULL,

        /// <summary>
        /// 手机号码格式不正确
        /// </summary>
        MOBILE_PHONE_VERIFY,

        /// <summary>
        /// 今日获取短信太频繁，已达本日上限，请明天再试
        /// </summary>
        SMS_FREQUENTLY_TODAY,

        /// <summary>
        ///  之前存在频繁获取短信，请明天再试
        /// </summary>
        SMS_FREQUENTLY_FLAG,

        /// <summary>
        ///  同一IP由于频繁获取短信，请明天再试
        /// </summary>
        SMS_FREQUENTLY_IP,

        /// <summary>
        /// 该号码由于频繁获取短信，请明天再试
        /// </summary>
        SMS_FREQUENTLY_PHONE,

        /// <summary>
        ///  手机号码已经注册
        /// </summary>
        REGEDIT_MOBILE_EXISTS,

        /// <summary>
        /// 密码限6-20位,必须由字母或数字组成
        /// </summary>
        REGEDIT_PWD_VERIFY,

        /// <summary>
        /// 确认密码限6-20位,必须由字母或数字组成
        /// </summary>
        REGEDIT_PWDR_VERIFY,

        /// <summary>
        /// 两次密码输入不一致
        /// </summary>
        REGEDIT_PWD_DIFF,

        /// <summary>
        /// 验证码已过期
        /// </summary>
        REGEDIT_VERIFYCODE_EXPIRE,

        /// <summary>
        /// 请输入正确的验证码
        /// </summary>
        REGEDIT_VERIFYCODE_DIFF,

        /// <summary>
        /// 登录参数错误
        /// </summary>
        LOGIN_PARAMS_ERROR,

        /// <summary>
        /// 未绑定到第三方登录帐号 
        /// </summary>
        LOGIN_PLATFORM_USER_NOTFOUND,

        /// <summary>
        /// 找不到用户帐户信息
        /// </summary>
        LOGIN_ACCOUNT_NOTFOUND,

        /// <summary>
        /// 绑定第三方帐号失败
        /// </summary>
        LOGIN_BINDPLATFORM_FAILD,

        /// <summary>
        /// 用户名或密码不正确
        /// </summary>
        LOGIN_USER_PWD_ERROR,

        /// <summary>
        /// 帐号格式错误(必须是数字)
        /// </summary>
        MOBILE_USERID_VERIFY,

        /// <summary>
        /// 该帐号已被其它帐号绑定
        /// </summary>
        LOGIN_BINDPLATFORM_USE,

        //下面定义固定Id (规则：00(系统)+00（子系统）+0错误码序号)
        //1001-9999：系统预留
        //10000起：论坛
        //20000起：内线
        //30000起：游戏 
        //40000起：公告、喇叭系统        
          

        #region 系统错误码
        /// <summary>
        /// 用户未登录 
        /// </summary>
        SYS_USER_NOLOGIN = 1001,

        /// <summary>
        /// 会员自身权限不足
        /// </summary>
        SYS_USER_LIMIT_NOT_ENOUGH = 1002,

        /// <summary>
        /// 会员酷币不足
        /// </summary>
        SYS_USER_COBI_NOT_ENOUGH = 1003,

        /// <summary>
        /// 帐号ID格式不正确
        /// </summary>
        SYS_USER_ACCOUNT_VERIFY = 1004,

        /// <summary>
        /// 原密码不正确
        /// </summary>
        SYS_USER_OLDPWD_ERROR = 1005,


        #endregion

        #region 论坛错误码

        /// <summary>
        /// 找不到该论坛
        /// </summary>
        BBS_FORUM_NOT_FOUND = 10001,

        /// <summary>
        ///权限不足
        /// </summary>
        BBS_FORUM_LIMIT_NOT_ENOUGH = 10002,        

        /// <summary>
        /// 帖子类型错误
        /// </summary>
        BBS_THREAD_TYPE_ERROR = 10003,

        /// <summary>
        /// 论坛ID错误
        /// </summary>
        BBS_FORUM_ID_ERROR = 10004,

        /// <summary>
        /// 帖子标题长度不正确
        /// </summary>
        BBS_THREAD_TITLE_LENGTH_ERROR = 10005,

        /// <summary>
        /// 帖子内容长度不正确
        /// </summary>
        BBS_THREAD_CONTENT_LENGTH_ERROR = 10006,

        /// <summary>
        /// 每天发贴的数量超过系统限制
        /// </summary>
        BBS_THREAD_THREAD_NUM = 10007,

        /// <summary>
        /// 本论坛限VIP会员才可以发帖
        /// </summary>
        BBS_THREAD_ADD_VIP = 10008,

        /// <summary>
        /// 本论坛限版主和管理员才可以发帖
        /// </summary>
        BBS_THREAD_ADD_IS_ALLMODE = 10009,

        /// <summary>
        /// 本论坛限管理员才可以发帖
        /// </summary>
        BBS_THREAD_ADD_IS_ADMIN = 10010,

        /// <summary>
        /// 本论坛禁止发帖
        /// </summary>
        BBS_THREAD_ADD_STOP = 10011,

        /// <summary>
        /// 找不到对应帖子
        /// </summary>
        BBS_THREAD_NOT_FOUND = 10012,

        /// <summary>
        /// 帖子已置顶
        /// </summary>
        BBS_THREAD_IS_TOP = 10014,

        /// <summary>
        /// 帖子已加精，不能删除
        /// </summary>
        BBS_THREAD_IS_GOOD = 10015,

        /// <summary>
        /// 帖子已推荐，不能删除
        /// </summary>
        BBS_THREAD_IS_RECOM = 10016,

        /// <summary>
        /// 帖子已锁定，不能删除
        /// </summary>
        BBS_THREAD_IS_LOCK = 10017,

        /// <summary>
        /// 本版帖子不能删除
        /// </summary>
        BBS_THREAD_DEL_FORBID = 10019,

        /// <summary>
        /// 不能操作自己的帖子
        /// </summary>
        BBS_THREAD_OPER_MYSELF = 10020,

        /// <summary>
        /// 今天已经签到
        /// </summary>
        BBS_SIGNIN_HAS_TODAY = 10021,

        /// <summary>
        /// 不存在该圈子
        /// </summary>
        BBS_GROUP_NOT_EXISTS = 10022,

        /// <summary>
        /// 圈子已经过期
        /// </summary>
        BBS_GROUP_EXPIRE = 10023,

        /// <summary>
        /// 圈子论坛已关闭
        /// </summary>
        BBS_GROUP_CLOSED = 10024,

        /// <summary>
        /// 非成员不能访问该圈子
        /// </summary>
        BBS_GROUP_VISIT_NO_LIMIT = 10025,

        /// <summary>
        /// 访问等级不足
        /// </summary>
        BBS_FORUM_VISIT_LIMIT_LEVEL = 10026,
        
        /// <summary>
        /// 本论坛限VIP会员才可以浏览
        /// </summary>
        BBS_FORUM_VISIT_LIMIT_VIP = 10027,

        /// <summary>
        /// 本论坛限版主和管理员才可以浏览
        /// </summary>
        BBS_FORUM_VISIT_LIMIT_BBS_MODERATOR = 10028,

        /// <summary>
        /// 本论坛限管理员才可以浏览
        /// </summary>
        BBS_FORUM_VISIT_LIMIT_ADMIN = 10029,

        /// <summary>
        /// 本论坛限指定ID进入，您的ID不在指定ID中
        /// </summary>
        BBS_FORUM_VISIT_LIMIT_IP = 10030,

        /// <summary>
        /// 本论坛限手机才能访问
        /// </summary>
        BBS_FORUM_VISIT_LIMIT_MOBILE = 10031,

        /// <summary>
        /// 此贴已结束
        /// </summary>
        BBS_THREAD_IS_OVER = 10032,

        /// <summary>
        /// 此贴已固底
        /// </summary>
        BBS_THREAD_IS_BOTTOM = 10033,

        /// <summary>
        /// 每天回贴的数量超过系统限制
        /// </summary>
        BBS_THREAD_REPLY_NUM = 10034,

        /// <summary>
        /// 该论坛不允许删除评论
        /// </summary>
        BBS_FORUM_FORBID_DEL_REPLY = 10035,

        /// <summary>
        /// 找不到对应评论
        /// </summary>
        BBS_REPLY_NOT_FOUND = 10036,
        
        /// <summary>
        /// 不存在的收藏记录
        /// </summary>
        BBS_FAVORITES_NOT_EXISTS = 10037,

        /// <summary>
        /// 重复收藏
        /// </summary>
        BBS_FAVORITES_EXISTS = 10038,

        #endregion

        #region  公告、喇叭错误码
        /// <summary>
        /// 注册时间未达到可发布天数
        /// </summary>
        NETWORK_SUONA_REGDAY_NOT_ENOUGH = 40001,

        NETWORK_SUONA_LEVEL_NOT_ENOUGH = 40002,

        NETWORK_SUONA_CONTENT_LENGTH_ERROR = 40003,

        NETWORK_SUONA_TIME_LENGTH_ERROR = 40004,

        #endregion

        MAX
    }
}
