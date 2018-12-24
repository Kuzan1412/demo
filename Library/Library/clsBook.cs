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
	/// Description of clsBook.
	/// </summary>
	public class clsBook: clsDocument
	{
		private string ipoet;
		private	int	ipage;
		public string Poet
		{
			get
			{
				return ipoet;
			}
			set
			{
				ipoet = value;
			}
		}
		public int Page
		{
			get
			{
				return ipage;
			}
			set
			{
				ipage = value;
			}
		}
		
		public clsBook()
		{
		}
	}
}
