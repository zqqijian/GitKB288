using System;
namespace BCW.dzpk.Model
{
	/// <summary>
	/// ʵ����DzpkRooms ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class DzpkRooms
	{
		public DzpkRooms()
		{}
		#region Model
		private int _id;
		private string _drname;
		private int _drtype;
		private int _owers;
		private string _passwd;
		private long _gsmallb;
		private long _gbigb;
		private long _gminb;
		private long _gmaxb;
		private long _gsercharge;
		private long _gserchargeall;
		private int _gmaxuser;
		private long _gsidepot;
		private int _gsettime;
		private int _gactid;
		private string _gactbetid;
		private DateTime? _lasttime;
		private long _lastrank;
		/// <summary>
		/// ����ID���Զ�����
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// ���ƣ�Ĭ�ϣ�00��������
		/// </summary>
		public string DRName
		{
			set{ _drname=value;}
			get{return _drname;}
		}
		/// <summary>
		/// �������ͣ�1������2�м���3�߼�
		/// </summary>
		public int DRType
		{
			set{ _drtype=value;}
			get{return _drtype;}
		}
		/// <summary>
		/// ��������һ���������ң������˳�����������ң�û�������
		/// </summary>
		public int Owers
		{
			set{ _owers=value;}
			get{return _owers;}
		}
		/// <summary>
		/// �������룬�ɷ����趨��Ĭ��Ϊ�գ��κ��˶��ܽ���
		/// </summary>
		public string PassWD
		{
			set{ _passwd=value;}
			get{return _passwd;}
		}
		/// <summary>
		///  Сäע
		/// </summary>
		public long GSmallb
		{
			set{ _gsmallb=value;}
			get{return _gsmallb;}
		}
		/// <summary>
		/// ��äע
		/// </summary>
		public long GBigb
		{
			set{ _gbigb=value;}
			get{return _gbigb;}
		}
		/// <summary>
		/// ��С�ʽ�ֵ ����÷������ٵĳֱ�ֵ
		/// </summary>
		public long GMinb
		{
			set{ _gminb=value;}
			get{return _gminb;}
		}
		/// <summary>
		/// �����ֵ��ÿ���뷿�ɲ���������ֵ
		/// </summary>
		public long GMaxb
		{
			set{ _gmaxb=value;}
			get{return _gmaxb;}
		}
		/// <summary>
		/// �����ѷ���
		/// </summary>
		public long GSerCharge
		{
			set{ _gsercharge=value;}
			get{return _gsercharge;}
		}
		/// <summary>
		/// �ܹ��۳���������
		/// </summary>
		public long GSerChargeALL
		{
			set{ _gserchargeall=value;}
			get{return _gserchargeall;}
		}
		/// <summary>
		/// ��������
		/// </summary>
		public int GMaxUser
		{
			set{ _gmaxuser=value;}
			get{return _gmaxuser;}
		}
		/// <summary>
		/// �����ܽ��
		/// </summary>
		public long GSidePot
		{
			set{ _gsidepot=value;}
			get{return _gsidepot;}
		}
		/// <summary>
		/// ����ʱ�䣬Ĭ��10��15��
		/// </summary>
		public int GSetTime
		{
			set{ _gsettime=value;}
			get{return _gsettime;}
		}
		/// <summary>
		/// �����������1Ϊ���֣����2/3/4/5 ��Ӧ����ִ�ж���
		/// </summary>
		public int GActID
		{
			set{ _gactid=value;}
			get{return _gactid;}
		}
		/// <summary>
		/// ��ע��ǣ�Ĭ��Z �����ֲ���Ҫ��ע��ΪAʱ��ִ�з������̣��ȴ�������Ϻ����
		/// </summary>
		public string GActBetID
		{
			set{ _gactbetid=value;}
			get{return _gactbetid;}
		}
		/// <summary>
		/// ���һ����Ϸ����ʱ��
		/// </summary>
		public DateTime? LastTime
		{
			set{ _lasttime=value;}
			get{return _lasttime;}
		}
		/// <summary>
		/// ������ע��
		/// </summary>
		public long LastRank
		{
			set{ _lastrank=value;}
			get{return _lastrank;}
		}
		#endregion Model

	}
}
