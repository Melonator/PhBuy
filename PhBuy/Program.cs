﻿using System;
using System.Windows.Forms;

namespace PhBuy
{
	internal static class Program
	{
		/// <summary>
		///     The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			//MainForm("JD", 21629)
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DataAnalytics());
		}
	}
}