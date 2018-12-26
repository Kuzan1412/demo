/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Town
{
	/// <summary>
	/// Description of clsTown.
	/// </summary>
	public class clsTown
	{
		protected string ihome;
		private int imember;
		protected int count;
		public int Member
		{
			get
			{
				return imember;
			}
			set
			{
				imember = value;
			}
		}
		public string Home
		{
			get
			{
				return ihome;
			}
			set
			{
				ihome = value;
			}
		}
		public clsTown()
		{
			imember = 0;
			count = 0;
			
		}
	}
}
