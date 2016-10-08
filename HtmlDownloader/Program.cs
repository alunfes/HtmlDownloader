using System;
using System.Net;

namespace HtmlDownloader
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please input url");
			string url = Console.ReadLine();

			try
			{
				using (WebClient wc = new WebClient())
				{
					wc.Encoding = Encoding.UTF8;
					string html = wc.DownloadString(url);
					Console.WriteLine(html);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Unexpected error occurred!");
				Console.WriteLine(e.ToString());
			}
		}
	}
}
