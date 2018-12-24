/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/10/2018
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CANBO
{
	/// <summary>
	/// Description of clsWaiter.
	/// </summary>
	public class clsWaiter: clsCANBO
	{
		private string work;
		public string nwork
		{
			get 
			{
				return work;
			}
			set
			{
				work = value;
			}
		}
		public clsWaiter()
		{
		}
	}
}
