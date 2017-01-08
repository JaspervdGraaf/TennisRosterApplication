using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisSchemaApplicatie
{
	public static class Design
	{
		public static Color COLORBASE = Color.FromArgb(138, 184, 207);
		public static Color COLORDARKER = Color.FromArgb(93, 148, 174);
		public static Color COLORDARKEST = Color.FromArgb(59, 117, 145);
		public static Color COLORLIGHTER = Color.FromArgb(187, 218, 233);
		public static Color COLORLIGHTEST= Color.FromArgb(232, 244, 250);

		public static Font FONTNORMAL = new Font("Segoe UI", 14);
		public static Font FONTSMALL = new Font("Segoe UI", 10);
		public static Font FONTBIGBOLD = new Font("Segoe UI", 18, FontStyle.Bold);
		public static Font FONTTITLE = new Font("Segoe UI", 30, FontStyle.Bold);

	}
}
