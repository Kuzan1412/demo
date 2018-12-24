/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/10/2018
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CANBO
{
	/// <summary>
	/// Description of clsWoker.
	/// </summary>
	public class clsWoker: clsCANBO
	{
		private string lv;
		public string nlv
		{
			get
			{
				return lv;
			}
			set
			{
				lv = value;
			}
		}
		public clsWoker()
		{
		}
	}
}
