using System;
namespace BCW.dzpk.Model
{
	/// <summary>
	/// ʵ����DzpkAct ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DzpkAct
	{
		public DzpkAct()
		{}
		#region Model
		private int _id;
		private int _rmid;
		private int _usid;
		private string _actmake;
		private long _money;
		private string _maxcard;
		private DateTime _acttime;
		private string _rmmake;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ����ID
		/// </summary>
		public int RmID
		{
			set{ _rmid=value;}
			get{return _rmid;}
		}
		/// <summary>
		/// �û�ID
		/// </summary>
		public int UsID
		{
			set{ _usid=value;}
			get{return _usid;}
		}
		/// <summary>
		/// �û���������
		/// </summary>
		public string ActMake
		{
			set{ _actmake=value;}
			get{return _actmake;}
		}
		/// <summary>
		/// �ʽ�䶯
		/// </summary>
		public long Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// �������
		/// </summary>
		public string MaxCard
		{
			set{ _maxcard=value;}
			get{return _maxcard;}
		}
		/// <summary>
		/// ����ʱ��
		/// </summary>
		public DateTime ActTime
		{
			set{ _acttime=value;}
			get{return _acttime;}
		}
		/// <summary>
		/// ��Ϸ���
		/// </summary>
		public string RmMake
		{
			set{ _rmmake=value;}
			get{return _rmmake;}
		}
		#endregion Model

	}
}
