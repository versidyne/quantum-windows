using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Collections;
using System.Windows.Forms;


namespace Vexis
{
	public class PluginHost : Versidyne.Plugins.Host
	{
		public void ShowFeedback(string strFeedback)
		{
			MessageBox.Show(strFeedback, Application.ProductName);
		}
	}
}
