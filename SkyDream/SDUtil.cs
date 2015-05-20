using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyDream
{
	static class SDUtil
	{
		static public bool isNullCheck(string formContent)
		{
			if (formContent == null || formContent == "")
				return true;
			return false;
		}
	}
}
