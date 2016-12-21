using System;
namespace BCW.dzpk.Model
{
	/// <summary>
	/// ʵ����DzpkPlayRanks ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DzpkPlayRanks
	{
		public DzpkPlayRanks()
		{}
		#region Model
		private int _id;
		private int _rmid;
		private int _usid;
		private int _rankchk;
		private string _rankbanker;
		private string _rankmake;
		private string _rankchips;
		private string _pokercards;
		private string _pokerchips;
		private DateTime _timeout;
		private string _rmmake;
		private long _uspot;
        private int _TimeOutCount;
		/// <summary>
		/// ����ID���Զ�����
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ����ID ��Ӧ����ID
		/// </summary>
		public int RmID
		{
			set{ _rmid=value;}
			get{return _rmid;}
		}
		/// <summary>
		/// ��ԱID
		/// </summary>
		public int UsID
		{
			set{ _usid=value;}
			get{return _usid;}
		}
		/// <summary>
		/// ��ע���̱��0Ϊׯ�ң�1ΪСä��2Ϊ��ä��˳��ݼӣ���������������
		/// </summary>
		public int RankChk
		{
			set{ _rankchk=value;}
			get{return _rankchk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RankBanker
		{
			set{ _rankbanker=value;}
			get{return _rankbanker;}
		}
		/// <summary>
		/// ��ǰ��ע���ǣ��Ե�ǰ���ʱ��Ϊ׼ AΪ��ǰ�����ߣ��հײ�����
		/// </summary>
		public string RankMake
		{
			set{ _rankmake=value;}
			get{return _rankmake;}
		}
		/// <summary>
		/// ��Ҽ�ע��ʶ
		/// </summary>
		public string RankChips
		{
			set{ _rankchips=value;}
			get{return _rankchips;}
		}
		/// <summary>
		/// ���鷽ʽ��¼ÿһ�ַ��Ƶ���ϸ��Ϣ�ö��ŷָ���P��������
		/// </summary>
		public string PokerCards
		{
			set{ _pokercards=value;}
			get{return _pokercards;}
		}
		/// <summary>
		/// ÿ����ע�ĳ����������ִ�����ע����0��������P��������
		/// </summary>
		public string PokerChips
		{
			set{ _pokerchips=value;}
			get{return _pokerchips;}
		}
		/// <summary>
		/// ������עʱ�䣬�����Ϸ���Ĳ���ʱ�䣬��������Ϊ�޲������޳�������
		/// </summary>
		public DateTime TimeOut
		{
			set{ _timeout=value;}
			get{return _timeout;}
		}
		/// <summary>
		/// �����ǣ���ʷ����ͳ����
		/// </summary>
		public string RmMake
		{
			set{ _rmmake=value;}
			get{return _rmmake;}
		}
		/// <summary>
		/// ��ҳֱ��������ؼ�������
		/// </summary>
		public long UsPot
		{
			set{ _uspot=value;}
			get{return _uspot;}
		}

        /// <summary>
        /// ��ʱ����,�����ʱ��������3��,���Զ��޳�������
        /// </summary>
        public int TimeOutCount
        {
            set { _TimeOutCount = value; }
            get { return _TimeOutCount; }
        }
        #endregion Model

    }
}
