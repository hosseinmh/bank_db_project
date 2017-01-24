using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserL
{
	public partial class FrmUser : Form
	{
		public FrmUser()
		{
			InitializeComponent();
		}
		shard.ClassShard dt = new shard.ClassShard();

		#region  افتتاح حساب
		private void btnOkCustomer_Click(object sender, EventArgs e)
		{
			shard.Customer C = new shard.Customer();
			C.Name = txtName.Text;
			C.Family = txtFname.Text;
			C.FatherName = txtFatherN.Text;
			C.Emissionlocation = txtLocation.Text;
			C.BirthDay = Convert.ToDateTime(txtBirthDay.Text);
			C.TellHome = Convert.ToInt64(txtTellHome.Text);
			C.TellWork = Convert.ToInt64(txtTellWork.Text);
			C.MobileNumber = Convert.ToInt64(txtboxCell.Text);
			C.AddHome = txtAddHome.Text;
			C.AddWork = txtAddWork.Text;
			C.NationalCode = Convert.ToInt64(txtNationalCode.Text);
			Random IdCustomer = new Random();
            C.CustomerCode=IdCustomer.Next(999999999, 1000000000);
			//C.CustomerCode = Convert.ToInt64(IdCustomer);
			LabIDcustumer.Text = Convert.ToString(C.CustomerCode);
			dt.insertCustomer(C);

		}

		private void btnOklongtime_Click(object sender, EventArgs e)
		{
			shard.AccountLongTime b = new shard.AccountLongTime();
			b.amount = Convert.ToInt64(txtboxamountlongtime.Text);
			b.GuarantiTime = Convert.ToInt16(txtboxTimelongtime.Text);
			b.IDCustomer = Convert.ToInt64(txtboxCustomerCodelongtime.Text);
			switch (b.GuarantiTime)
			{
				case 2:
					b.Grist = 21;
					break;
				case 3:
					b.Grist = 23;
					break;
				case 4:
					b.Grist = 25;
					break;
				case 5:
					b.Grist = 27;
					break;
			}
			Random IdCustomer = new Random();
			b.LongTimeCode=IdCustomer.Next( 99999999,1000000000);
			//b.LongTimeCode = Convert.ToInt64(IdCustomer) + 10000000000;
			LabaccountNlongtime.Text = Convert.ToString(b.LongTimeCode);
			dt.insertlongtime(b);

		}

		private void btnOkshorttime_Click(object sender, EventArgs e)
		{
			shard.AccountShortTime b = new shard.AccountShortTime();
			b.amount = Convert.ToInt64(txtboxAmountshortTime.Text);
			b.GuarantiiTime = Convert.ToInt16(txtboxTimeshorttime.Text);
			b.IDcustomer = Convert.ToInt64(txtboxCustomerCodeshorttime.Text);
			switch (b.GuarantiiTime)
			{
				case 3:
					b.Grist = 10;
					break;
				case 6:
					b.Grist = 14;
					break;
				case 9:
					b.Grist = 16;
					break;
				case 12:
					b.Grist = 20;
					break;
			}
			Random IdCustomer = new Random();
			b.ShortTimeCode=IdCustomer.Next( 99999999,1000000000);
			//b.ShortTimeCode = Convert.ToInt64(IdCustomer) + 10000000000;
			LabAccountshorttime.Text = Convert.ToString(b.ShortTimeCode);
			dt.insertshorttime(b);
		}
		private void btnOKCurrent_Click(object sender, EventArgs e)
		{
			shard.AccountCurrent C = new shard.AccountCurrent();
			C.active = true;
			C.amount = Convert.ToInt64(txtboxamountCurrent.Text);
			Random IdCustomer = new Random();
			C.currentCode=IdCustomer.Next( 99999999,1000000000);
			//C.currentCode = Convert.ToInt64(IdCustomer) + 10000000000;

			C.IDcustomer = Convert.ToInt64(txtboxCustomertCurrent.Text);
			C.ReagentName = txtboxNameZCurrent.Text;
			C.ReagentFamily = txtboxFnamZCurrent.Text;
			C.ReagentIDAccount = Convert.ToInt64(txtboxaccountZCurrent.Text);
			LabAccountNCurrent.Text = Convert.ToString(C.currentCode);
			dt.insertCurrent(C);

		}

		private void btnOKSaving_Click(object sender, EventArgs e)
		{
			shard.AccountSaving C = new shard.AccountSaving();
			C.amount = Convert.ToInt64(txtboxAmountSaving.Text);
			C.active = true;
			C.IDcustomer = Convert.ToInt64(txtboxCustomerSaving.Text);
			Random IdCustomer = new Random();
			C.savingCode=IdCustomer.Next( 99999999,1000000000);
		//	C.savingCode = Convert.ToInt64(IdCustomer) + 10000000000;
			LabAccountNSaving.Text = Convert.ToString(C.savingCode);
			dt.insertSaving(C);
		}

		#endregion
		//-----------------------------------------------------------------------------------------------
		#region انتقال وجه
		private void btnShiftS2C_Click(object sender, EventArgs e)
		{
			Int64 start = Convert.ToInt64(txtboxStartShiftS2C.Text);
			Int64 goal = Convert.ToInt64(txtboxGoalShiftS2C.Text);
			Int64 amount = Convert.ToInt64(txtboxAmountShiftS2C.Text);
			string Family;
			shard.MoveSavingtoCurrent b = new shard.MoveSavingtoCurrent();
			b.IDSaving = start;
			b.IDCurrent = goal;
			b.AmountMove = amount;
			Family = dt.declarationCurrent(start);
			MessageBox.Show("فرد مورد نظر جهت انتقال:" + Family, "تایید انتقال", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			if (dt.shiftS2C(b) == true)
			{
				MessageBox.Show("انتقال با موفقیت انجام شد", "تایید انتقال", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("انتقال  انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//------------------------------------------------------------------------------------------------
		private void btnShiftC2Sh_Click(object sender, EventArgs e)
		{
			Int64 start = Convert.ToInt64(txtboxStartShiftC2Sh.Text);
			Int64 goal = Convert.ToInt64(txtboxGoalShiftC2Sh.Text);
			Int64 amount = Convert.ToInt64(txtboxAmountShiftC2Sh.Text);
			shard.MoveShortTimeToCurrent b = new shard.MoveShortTimeToCurrent();
			b.IDCurrent = start;
			b.IDShortTime = goal;
			b.AmountMove = amount;
			string Family;
			Family = dt.declarationShorttime(start);
			MessageBox.Show("فرد مورد نظر جهت انتقال:" + Family, "تایید انتقال", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			//  if(MessageBoxButtons.OKCancel.c == false)
			if (dt.shiftSh2C(b) == true)
			{
				MessageBox.Show("انتقال با موفقیت انجام شد", "تایید انتقال", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("انتقال  انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//--------------------------------------------------------------------------------------------------
		private void btnshiftC2S_Click(object sender, EventArgs e)
		{
			Int64 start = Convert.ToInt64(txtboxStartShiftC2S.Text);
			Int64 goal = Convert.ToInt64(txtboxGoalShiftC2S.Text);
			Int64 amount = Convert.ToInt64(txtboxAmountShiftC2S.Text);
			shard.MoveCurrentToSaving b = new shard.MoveCurrentToSaving();
			b.IDCurrent = start;
			b.IDSaving = goal;
			b.AmountMove = amount;
			string Family;
			Family = dt.declarationShorttime(start);
			MessageBox.Show("فرد مورد نظر جهت انتقال:" + Family, "تایید انتقال", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			if (dt.shiftC2S(b) == true)
			{
				MessageBox.Show("انتقال با موفقیت انجام شد", "تایید انتقال", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("انتقال  انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//----------------------------------------------------------------------------------------------
		private void btnshiftS2Sh_Click(object sender, EventArgs e)
		{
			Int64 start = Convert.ToInt64(txtboxStartShiftS2Sh.Text);
			Int64 goal = Convert.ToInt64(txtboxGoalShiftS2Sh.Text);
			Int64 amount = Convert.ToInt64(txtboxAmountShiftS2Sh.Text);
			shard.MoveSavingToShortTime b = new shard.MoveSavingToShortTime();
			b.IDSaving = start;
			b.IDShortTime = goal;
			b.AmountMove = amount;
			string Family;
			Family = dt.declarationShorttime(start);
			MessageBox.Show("فرد مورد نظر جهت انتقال:" + Family, "تایید انتقال", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
			if (dt.shiftS2SH(b) == true)
			{
				MessageBox.Show("انتقال با موفقیت انجام شد", "تایید انتقال", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("انتقال  انجام نشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		//------------------------------------------------------------------------------------------------
		#region چک
		private void btnOKGetCH_Click(object sender, EventArgs e)
		{
			Int64 acount = Convert.ToInt64(txtboxAccountNGetCh.Text);
			Int64 chequeN = Convert.ToInt64(txtboxChekNGetCH.Text);
			Int64 amount = Convert.ToInt64(txtboxAmountGetCH.Text);
			shard.cheque chk = new shard.cheque();
			chk.IDAccountCurrent = acount;
			chk.IDcheque = chequeN;
			chk.amount = amount;
			if (dt.getCheque(chk) == true)
				MessageBox.Show(" عملیات پرداخت چک با موفقیت انجام شد", "پرداخت چک", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			else
				MessageBox.Show(" عملیات پرداخت چک انجام نشد", "پرداخت چک", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		private void btnOkBack_Click(object sender, EventArgs e)
		{
			Int64 acount = Convert.ToInt64(txtboxAccountNBack.Text);
			Int64 chequeN = Convert.ToInt64(txtboxChekNBack.Text);
			shard.BackCheque b = new shard.BackCheque();
			b.IDcheque = chequeN;
			if (dt.backchk(b) == true)
				MessageBox.Show(" چک برگشت خورد", "برگشت چک", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			else
				MessageBox.Show(" چک برگشت نخورد", "برگشت چک", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		private void btnShowMojodiCh_Click(object sender, EventArgs e)
		{
			Int64 acount = Convert.ToInt64(txtboxAMojodiCh.Text);
			Int64 a;
			a = dt.MojodCurrent(acount);
			MessageBox.Show(" موجودی حساب :" + a, "موجودی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		#endregion
		//---------------------------------------------------------------------------------------------
		#region امورجانبی

		private void btnShowMojodi_Click(object sender, EventArgs e)
		{
			Int64 acount = Convert.ToInt64(txtboxAcountNMojodi.Text);
			Int64 a;
			if (chekboxCurrent.Checked == true)
			{
				a = dt.MojodCurrent(acount);
				MessageBox.Show(" موجودی حساب پس انداز:" + a, "موجودی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (chekboxSaving.Checked == true)
			{
				a = dt.MojodSaving(acount);
				MessageBox.Show("موجودی حساب پس انداز" + a, "موجودی", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		//------------------------------------------------------------------------------------------------
		private void btnOkClose_Click(object sender, EventArgs e)
		{
			Int64 acount = Convert.ToInt64(txtboxAcountNMojodi.Text);
			if (chekCurrentE.Checked == true)
			{
				if (dt.CloseCurrent(acount) == true)
					MessageBox.Show("انسداد موقت با موفقیت انجام شد", "تایید انسداد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			if (chekSavingE.Checked == true)
			{
				if (dt.CloseSaving(acount) == true)
					MessageBox.Show("انسداد موقت با موفقیت انجام شد", "تایید انسداد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}	

		private void btnOkcloseLong_Click(object sender, EventArgs e)
		{
			Int64 acount = Convert.ToInt64(txtboxAccountNcloseLong.Text);
			int sw = 0;
			if (chkboxcurrentCloselong.Checked == true)
			{
				sw = 1;
			}
			else if (chkboxSavingtCloselong.Checked == true)
			{
				sw = 2;
			}
			else if (chkboxshorttimeCloselong.Checked == true)
			{
				sw = 3;
			}
			else if (chkboxlongtimeCloselong.Checked == true)
			{
				sw = 4;
			}
			if (dt.Closelong(acount, sw) == true)
				MessageBox.Show("انسداد دائم با موفقیت انجام شد", "تایید انسداد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			else
				MessageBox.Show("انسداد دائم انجام نشد", "انسداد", MessageBoxButtons.OK, MessageBoxIcon.Error);

		}

		#endregion

		

	}
}
