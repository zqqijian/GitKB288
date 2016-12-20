using System;
using System.Data;
using System.Collections.Generic;
using BCW.Common;
using BCW.Model;
namespace BCW.BLL
{
	/// <summary>
	/// ҵ���߼���tb_BasketBallWord ��ժҪ˵����
	/// </summary>
	public class tb_BasketBallWord
	{
		private readonly BCW.DAL.tb_BasketBallWord dal=new BCW.DAL.tb_BasketBallWord();
		public tb_BasketBallWord()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}
        /// <summary>
		/// �Ƿ���ڸ�name_en��¼������һ��
		/// </summary>
		public bool ExistsName_enOne(int ID)
        {
            return dal.ExistsName_enOne(ID);
        }
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsName(int name_enId)
        {
            return dal.ExistsName(name_enId);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public int  Add(BCW.Model.tb_BasketBallWord model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BCW.Model.tb_BasketBallWord model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BCW.Model.tb_BasketBallWord Gettb_BasketBallWord(int ID)
		{
			
			return dal.Gettb_BasketBallWord(ID);
		}

		/// <summary>
		/// �����ֶ�ȡ�����б�
		/// </summary>
		public DataSet GetList(string strField, string strWhere)
		{
			return dal.GetList(strField, strWhere);
		}

		/// <summary>
		/// ȡ��ÿҳ��¼
		/// </summary>
		/// <param name="p_pageIndex">��ǰҳ</param>
		/// <param name="p_pageSize">��ҳ��С</param>
		/// <param name="p_recordCount">�����ܼ�¼��</param>
		/// <param name="strWhere">��ѯ����</param>
		/// <returns>IList tb_BasketBallWord</returns>
		public IList<BCW.Model.tb_BasketBallWord> Gettb_BasketBallWords(int p_pageIndex, int p_pageSize, string strWhere, out int p_recordCount)
		{
			return dal.Gettb_BasketBallWords(p_pageIndex, p_pageSize, strWhere, out p_recordCount);
		}

		#endregion  ��Ա����
	}
}
