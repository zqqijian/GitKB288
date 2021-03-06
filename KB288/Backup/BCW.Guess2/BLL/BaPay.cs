using System;
using System.Data;
using System.Collections.Generic;
using TPR2.Common;
using TPR2.Model.guess;
/// <summary>
/// 更新人工确认标识
/// 
/// 黄国军 20160324
/// </summary>
namespace TPR2.BLL.guess
{
    /// <summary>
    /// 业务逻辑类BaPay 的摘要说明。
    /// </summary>
    public class BaPay
    {
        private readonly TPR2.DAL.guess.BaPay dal = new TPR2.DAL.guess.BaPay();
        public BaPay()
        { }
        #region  成员方法

        /// <summary>
        /// 得到某一赛事下注结果得币
        /// </summary>
        public decimal GetBaPayMoney(int id, int payusid)
        {
            return dal.GetBaPayMoney(id, payusid);
        }

        /// <summary>
        /// 得到某赛事各项目的记录数
        /// </summary>
        public int GetCount(int ibcid, int iptype, int ipaytype)
        {
            return dal.GetCount(ibcid, iptype, ipaytype);
        }
        /// <summary>
        /// 得到某ID在某赛事各项目的记录数
        /// </summary>
        public int GetCount(int ibcid, int iptype, int ipaytype, int iusid)
        {
            return dal.GetCount(ibcid, iptype, ipaytype, iusid);
        }
        /// <summary>
        /// 得到某一赛事下注总注数
        /// </summary>
        public int GetBaPayNum(int ibcid, int iptype)
        {
            return dal.GetBaPayNum(ibcid, iptype);
        }

        /// <summary>
        /// 得到某一赛事下注总注数——机器人 20160817 邵广林
        /// </summary>
        public int GetBaPayNum_robot(int ibcid, int iptype)
        {
            return dal.GetBaPayNum_robot(ibcid, iptype);
        }

        /// <summary>
        /// 得到某一赛事下注总金额
        /// </summary>
        public long GetBaPayCent(int ibcid, int iptype)
        {
            return dal.GetBaPayCent(ibcid, iptype);
        }

        /// <summary>
        /// 得到某一赛事下注总金额——机器人 20160817 邵广林
        /// </summary>
        public long GetBaPayCent_robot(int ibcid, int iptype)
        {
            return dal.GetBaPayCent_robot(ibcid, iptype);
        }

        /// <summary>
        /// 得到某一赛事走地下注总金额
        /// </summary>
        public long GetBaPayCent(int ibcid, int iptype, DateTime dt)
        {
            return dal.GetBaPayCent(ibcid, iptype, dt);
        }

        /// <summary>
        /// 得到某一赛事某ID下注总金额
        /// </summary>
        public long GetBaPayCent(int ibcid, int iptype, int payusid)
        {
            return dal.GetBaPayCent(ibcid, iptype, payusid);
        }

        /// <summary>
        /// 得到某一赛事某项下注总金额
        /// </summary>
        public long GetBaPayCent2(int ibcid, int iptype, int ipaytype)
        {
            return dal.GetBaPayCent2(ibcid, iptype, ipaytype);
        }

        /// <summary>
        /// 得到某一赛事某项下注总金额
        /// </summary>
        public long GetBaPayCent2(int ibcid, int iptype, int ipaytype, DateTime dt)
        {
            return dal.GetBaPayCent2(ibcid, iptype, ipaytype, dt);
        }

        /// <summary>
        /// 根据条件得到赛事下注数
        /// </summary>
        public int GetBaPayCount(string strWhere)
        {
            return dal.GetBaPayCount(strWhere);
        }
        /// <summary>
        /// 根据条件得到赛事下注总金额
        /// </summary>
        public long GetBaPaypayCent(string strWhere)
        {
            return dal.GetBaPaypayCent(strWhere);
        }
        /// <summary>
        /// 根据条件得到赛事下注盈利额
        /// </summary>
        public long GetBaPaygetMoney(string strWhere)
        {
            return dal.GetBaPaygetMoney(strWhere);
        }

        /// <summary>
        /// 是否存在兑奖记录
        /// </summary>
        public bool ExistsIsCase(int ID, int payusid)
        {
            return dal.ExistsIsCase(ID, payusid);
        }

        /// <summary>
        /// 更新用户兑奖
        /// </summary>
        public void UpdateIsCase(int ID)
        {
            dal.UpdateIsCase(ID);
        }

        /// <summary>
        /// 更新滚球下注为正常
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Updatestate(int ID)
        {
            dal.Updatestate(ID);
        }

        /// <summary>
        /// 更新人工下注确认标识
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void UpdateSure(int ID)
        {
            dal.UpdateSure(ID);
        }

        /// <summary>
        /// 更新平盘业务
        /// </summary>
        public void UpdatePPCase(TPR2.Model.guess.BaPay model)
        {
            dal.UpdatePPCase(model);
        }

        /// <summary>
        /// 更新开奖业务
        /// </summary>
        public void UpdateCase(TPR2.Model.guess.BaPay model, string p_strVal, out decimal p_intDuVal, out int p_intWin)
        {
            dal.UpdateCase(model, p_strVal, out p_intDuVal, out p_intWin);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(TPR2.Model.guess.BaPay model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            dal.Delete(ID);
        }

        /// <summary>
        /// 删除一组数据
        /// </summary>
        public void DeleteStr(string strWhere)
        {
            dal.DeleteStr(strWhere);
        }

        /// <summary>
        /// 删除一条数据,根据赛事ID
        /// </summary>
        public void Deletebcid(int gid)
        {
            dal.Deletebcid(gid);
        }

        /// <summary>
        /// 得到一个getMoney
        /// </summary>
        public decimal Getp_getMoney(int ID)
        {
            return dal.Getp_getMoney(ID);
        }

        /// <summary>
        /// 得到一个Types
        /// </summary>
        public int GetTypes(int ID)
        {
            return dal.GetTypes(ID);
        }

        /// <summary>
        /// 得到一个bcid
        /// </summary>
        public int Getbcid(int ID)
        {
            return dal.Getbcid(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public TPR2.Model.guess.BaPay GetModelIsCase(int ID)
        {
            return dal.GetModelIsCase(ID);
        }

        /// <summary>
        /// 根据字段取数据列表
        /// </summary>
        public DataSet GetBaPayList(string strField, string strWhere)
        {
            return dal.GetBaPayList(strField, strWhere);
        }

        /// <summary>
        /// 根据字段取数据列表
        /// </summary>
        public DataSet GetBaPayList(string strField, string strWhere, string filedOrder)
        {
            return dal.GetBaPayList(strField, strWhere, filedOrder);
        }

        /// <summary>
        /// 取得每页记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList</returns>
        public IList<TPR2.Model.guess.BaPay> GetBaPays(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
        {
            return dal.GetBaPays(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
        }

        /// <summary>
        /// 取得每页记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList</returns>
        public IList<TPR2.Model.guess.BaPay> GetBaPayViews(int p_pageIndex, int p_pageSize, string strWhere, int itype, out int p_recordCount)
        {
            return dal.GetBaPayViews(p_pageIndex, p_pageSize, strWhere, itype, out p_recordCount);
        }

        /// <summary>
        /// 取得详细排行榜记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList BaPayTop</returns>
        public IList<TPR2.Model.guess.BaPay> GetBaPayTop(int p_pageIndex, int p_pageSize, string strWhere, int itype, out int p_recordCount)
        {
            return dal.GetBaPayTop(p_pageIndex, p_pageSize, strWhere, itype, out p_recordCount);
        }

        /// <summary>
        /// 取得详细排行榜记录
        /// </summary>
        /// <param name="p_pageIndex">当前页</param>
        /// <param name="p_pageSize">分页大小</param>
        /// <param name="p_recordCount">返回总记录数</param>
        /// <returns>IList BaPayTop</returns>
        public IList<TPR2.Model.guess.BaPay> GetBaPayTop2(int p_pageIndex, int p_pageSize, string strWhere, int itype, out int p_recordCount)
        {
            return dal.GetBaPayTop2(p_pageIndex, p_pageSize, strWhere, itype, out p_recordCount);
        }

        #endregion  成员方法
    }
}
