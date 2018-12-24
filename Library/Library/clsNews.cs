/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/24/2018
 * Time: 9:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Library
{
	/// <summary>
	/// Description of clsNews.
	/// </summary>
	public class clsNews:clsDocument
	{
		private int idate;
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
		
		public clsNews()
		{
		}
	}
}
