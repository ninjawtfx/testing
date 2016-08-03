﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using OpenQA.Selenium;

namespace TestBotForTwitch
{
    public static class Extens
    {
        		/// <summary>
		/// Вводим текст, предварительно отчистив поле web-элемента
		/// </summary>
		/// <param name="webElement">элемент</param>
		/// <param name="text">текст</param>
		/// <param name="expectedText">текст,который ожидается увидеть в поле после окончания ввода</param>
		public static void SetText(IWebElement webElement, string text, string expectedText = null)
		{
			var i = 0;
			do
			{
				//CustomTestContext.WriteLine("Попытка ввода текста №{0}", i);
				i++;
				webElement.Clear();

				Thread.Sleep(100); // Возникают проблемы в редакторе, если быстро перезаписывать
				// таргет сегмента. Думаю из-за того, что там много фоновых обработок типа
				// проверки репетишенов, ошибок и ревизий.

				webElement.SendKeys(text);



				expectedText = expectedText ?? text;
			} // TrimEnd(' ') используется в связи с тем, что иногда редактор добавляет в конце слова пробел
			// webElement.Text нужен, потому что value есть не у всех элементов
			while (i < 3 && webElement.GetAttribute("value") != expectedText && webElement.Text.TrimEnd(' ') != expectedText);

			if (webElement.GetAttribute("value") != expectedText && webElement.Text.TrimEnd(' ') != expectedText)
			{
				throw new Exception("Произошла ошибка:\nНеверный текст в элементе");
			}
		}

	    public static bool CheckProxy(string proxyLine)
	    {
		  //  proxyLine = proxyLine.Remove(proxyLine.IndexOf('/'), 2);
		    
		    string[] proxyies = proxyLine.Trim('/').Split(':');
		    string url = proxyies[1];
		    string port = proxyies[2];
			
			WebRequest wReq = WebRequest.Create(Settings.StreamerUrl);
			//wReq.Proxy = new WebProxy(url, Int32.Parse(port));

			try
			{
				WebResponse wRes = wReq.GetResponse();
			}
			catch (Exception e)
			{
				Console.WriteLine("Proxy not enabled");
			}

		    return true;
	    }
    }
}
