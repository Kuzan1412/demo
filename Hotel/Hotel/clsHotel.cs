/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/3/2019
 * Time: 8:24 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hotel
{
	/// <summary>
	/// Description of clsHotel.
	/// </summary>
	public class clsHotel
	{
		private int istayday, icost;
		private string itype;
		public int Stay
		{
			get
			{
				return istayday;
			}
			set
			{
				istayday = value;
			}
		}
		public int Cost
		{
			get
			{
				return icost;
			}
			set 
			{
				icost = value;
			}
		}
		public string Type
		{
			get 
			{
			 	return itype;
			}
			set
			{
				itype = value;
			}
		}
		public clsHotel()
		{
		}
	}
}
