/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Vehicle
{
	/// <summary>
	/// Description of clsVehicle.
	/// </summary>
	public class clsVehicle
	{
		protected string icolor, imarker; 
		protected int iyear, iprice;
		public string Color
		{
			get
			{
				return icolor;
			}
			set
			{
				icolor = value;
			}
		}
		public string Maker
		{
			get
			{
				return imarker;
			}
			set
			{
				imarker = value;
			}
		}
		public int Price
		{
			get
			{
				return iprice;
			}
			set
			{
				iprice = value;
			}
		}
		public int Year
		{
			get
			{
				return iyear;
			}
			set
			{
				iyear = value;
			}
		}
		public clsVehicle()
		{
		}
	}
}
