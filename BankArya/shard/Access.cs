using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shard
{
	class Access
	{
		#region StoredProcedures
		public static object ActivCurrent(Int64 a)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_active_saving(a);
		}

		public static object ActivSaving(Int64 a)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_active_saving(a);
		}
		
		public static object getrequstCheque(long i, long f)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_Request_cheque(i, f);
		}
		public static object getmove2current(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_move2Current(i);
		}
		public static object getmove2saving(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_move2Saving(i);
		}

		public static object getmove2shorttime(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_move2ShortTime(i);
		}
		public static object mojodiCurrent(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_mojodi_current (i);
		}
		public static object mojodiSaving(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.p_mojodi_Saving (i);
		}
		public static object closelong(long acount, int sw)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.P_close(sw, acount);

		}
            
		public static object getIDshorttime(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.getIdshorttime (i);
		}
		public static object getIDcurrent(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.getIdcurrent (i);
		}
		public static object getIDSaving (long  i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.getIdsaving (i);
		}
		public static object getIDlongtime(long i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.getIdlongtime(i);
		}
		public static object gtIDcustomer(long? i)
		{
			AryaBankDataContext dc = new AryaBankDataContext();
			return dc.GTIdCustomer(i);
			}

		#endregion





	}
}
