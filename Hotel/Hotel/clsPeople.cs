/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/3/2019
 * Time: 8:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hotel
{
	/// <summary>
	/// Description of clsPeople.
	/// </summary>
	public class clsPeople:clsHotel
	{
		private string iname; 
		private int iage, idate, iid;
		public string Name
		{
			get
			{
				return iname;
			}
			set
			{
				iname = value;
			}
		}
		public int ID
		{
			get
			{
				return iid;
			}
			set
			{
				iid = value;
			}
		}
		public int Age 
		{
			get
			{
				return (2018 - idate);
			}
			set
			{
				iage = value;
			}
		}
		public int Date
		{
			get
			{
				return idate;
			}
			set
			{
				idate = value;
			}
		}
		public clsPeople()
		{
		}
	}
}
