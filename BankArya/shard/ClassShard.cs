using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shard
{
	public class ClassShard
	{
		public static object codeKarbar;
		AryaBankDataContext dc = new AryaBankDataContext();


		public bool Income(Int64 a, Int64 b)
		{

			var v = (from c in dc.GetTable<Employ >() where (c.EmployPass == b & a == c.personalcode ) select c.IDEmploy);
			if (v != null)
				return true;
			else return false;
		}

//---------------------------------------------------------------------------------------------------
		public bool dchek(Int32 Shenase1)
		{
			Int64 a = Convert.ToInt64(codeKarbar);
			try
			{
				Access.getrequstCheque(a , Shenase1);
				return true;
			}
			catch
			{
				return false;
			}
		}
//---------------------------------------------------------------------------------------------------------
		public bool CloseCurrent(Int64 acount)
		{
			try
			{
				acount  = Convert.ToInt64(Access .getIDcurrent (acount ));
				Access.ActivCurrent(acount );
				return true;
			}
			catch
			{
				return false;
			}
		}
//---------------------------------------------------------------------------------------------------------

		public bool CloseSaving(Int64 acount)
		{
			try
			{
				acount = Convert.ToInt64(Access.getIDSaving(acount));
				Access.ActivSaving(acount );
				return true;
			}
			catch
			{
				return false;
			}
		}

		//---------------------------------------------------------------------------------------------------------
		public string declarationCurrent(Int64 a)
		{
			return (string)Access.getmove2current(a );
		}

//---------------------------------------------------------------------------------------------------------
		public string declarationSaving(Int64 a)
		{
			return (string)Access.getmove2saving (a);
		}
//-----------------------------------------------------------------------------------------------------
		public string declarationShorttime(Int64 a)
		{
			return (string)Access.getmove2shorttime(a);
		}
//-----------------------------------------------------------------------------------------------
		public Int64   MojodCurrent(Int64  acount)
		{
			try
			{
				acount = Convert .ToInt64 ( Access.getIDcurrent(acount));
				return (Int64 )Access.mojodiCurrent(acount);
			}
			catch
			{
				return 0;
			}
		}
//-------------------------------------------------------------------------------------------------
		public Int64  MojodSaving(long acount)
		{
			try
			{
				acount = Convert.ToInt64(Access.getIDSaving(acount));
				return (Int64 ) Access.mojodiSaving(acount);
			}
			catch
			{
				return 0;
			}
		}
//--------------------------------------------------------------------------------------------------------
        
//--------------------------------------------------------------------------------------------------------
        public bool  Closelong(long acount, int sw)
        {
            try
            {
				acount = Convert.ToInt64(Access.getIDcurrent(acount));
                Access .closelong (acount , sw  );
                return true;
            }
            catch
            {
                return false;
            }
        }
		//---------------------------------------------------------------------------------------------------------
        public void insertCustomer(Customer C)
        {

            dc.Customers.InsertOnSubmit(C );
            dc.SubmitChanges();
        }
		//---------------------------------------------------------------------------------------------------------
        public void insertSaving(AccountSaving b)
        {
			if (b.IDAccountSaving <= 9999999999 && b.IDAccountSaving > 1000000000 && b.amount > 100000)
			{
				b.IDcustomer = Convert.ToInt64(Access.gtIDcustomer(b.IDcustomer));
				dc.AccountSavings.InsertOnSubmit(b);
				dc.SubmitChanges();
			}
       }
		//---------------------------------------------------------------------------------------------------------
        public void insertCurrent(AccountCurrent b)
        {
			if (b.IDAccountCurrent <= 9999999999 && b.IDAccountCurrent > 1000000000 && b.amount > 100000)
			{
				b.IDcustomer = Convert.ToInt64(Access.gtIDcustomer(b.IDcustomer));
				b.ReagentIDAccount = Convert.ToInt64(Access.getIDcurrent(b.ReagentIDAccount));
				dc.AccountCurrents.InsertOnSubmit(b);
				dc.SubmitChanges();
			}
        }
		//---------------------------------------------------------------------------------------------------------
        public void insertshorttime(AccountShortTime b)
        {
			if (b.IDAccountShortTime <= 9999999999 && b.IDAccountShortTime > 1000000000 && b.amount > 100000)
			{
				b.IDcustomer = Convert.ToInt64(Access.gtIDcustomer(b.IDcustomer));
				dc.AccountShortTimes.InsertOnSubmit(b);
				dc.SubmitChanges();
			}
        }
		//---------------------------------------------------------------------------------------------------------
        public void insertlongtime(AccountLongTime b)
        {
			if (b.IDAcountLongTime <= 9999999999 && b.IDAcountLongTime > 1000000000 && b.amount > 100000)
			{
				b.IDCustomer = Convert.ToInt64(Access.gtIDcustomer(b.IDCustomer));
				dc.AccountLongTimes.InsertOnSubmit(b);
				dc.SubmitChanges();
			}
        }
//---------------------------------------------------------------------------------------------
        public bool shiftC2S(MoveCurrentToSaving b)
        {
            try
            {
				b.IDCurrent = Convert.ToInt64(Access.getIDcurrent(b.IDCurrent));
				b.IDSaving = Convert.ToInt64(Access.getIDSaving(b.IDSaving));
                dc.MoveCurrentToSavings.InsertOnSubmit(b);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
		//---------------------------------------------------------------------------------------------------------
        public bool shiftS2SH(MoveSavingToShortTime b)
        {
            try
            {
				b.IDShortTime = Convert.ToInt64(Access.getIDcurrent(b.IDShortTime));
				b.IDSaving = Convert.ToInt64(Access.getIDSaving(b.IDSaving));
                dc.MoveSavingToShortTimes .InsertOnSubmit(b);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
		//---------------------------------------------------------------------------------------------------------
        public bool shiftSh2C(MoveShortTimeToCurrent b)
        {
            try
            {
				b.IDCurrent = Convert.ToInt64(Access.getIDcurrent(b.IDCurrent));
				b.IDShortTime  = Convert.ToInt64(Access.getIDSaving(b.IDShortTime));
                dc.MoveShortTimeToCurrents.InsertOnSubmit(b);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
		//---------------------------------------------------------------------------------------------------------
        public bool shiftS2C(MoveSavingtoCurrent b)
        {
            try
            {
				b.IDCurrent =Convert .ToInt64 ( Access.getIDcurrent(b.IDCurrent));
				b.IDSaving = Convert.ToInt64(Access.getIDSaving(b.IDSaving));
                dc.MoveSavingtoCurrents .InsertOnSubmit(b);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
//-----------------------------------------------------------------------------------
        public bool backchk(BackCheque b)
        {
            try
            {
                dc.BackCheques.InsertOnSubmit(b);
                dc.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
		//---------------------------------------------------------------------------------------------------------
		public bool getCheque(cheque chk)
		{

			try
			{
				chk.IDAccountCurrent  = Convert.ToInt64(Access.getIDcurrent(chk.IDAccountCurrent ));
				Int64 a = MojodCurrent(chk.IDAccountCurrent);
				if (a >= chk.amount)
				{
					dc.cheques .InsertOnSubmit(chk);
					dc.SubmitChanges();
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
