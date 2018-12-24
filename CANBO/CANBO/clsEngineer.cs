/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/10/2018
 * Time: 11:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CANBO
{
	/// <summary>
	/// Description of clsEngineer.
	/// </summary>
	public class clsEngineer: clsCANBO
	{
		private string major;
		public string nmajor 
		{
			get 
			{
				return major;
			}
			set
			{
				major = value;
			}
		}
		public clsEngineer()
		{
		}
	}
}
