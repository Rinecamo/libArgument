﻿using System;

namespace Codeaddicts.libArgument.Attributes
{
	[AttributeUsage (AttributeTargets.Field, AllowMultiple = true)]
	public class Argument : Attribute
	{
		readonly string shortname;
		readonly string fullname;

		public string FriendlyShort { get { return string.Format ("{0}{1}", string.IsNullOrEmpty (shortname) ? "" : "-", shortname); } }
		public string FriendlyFull { get { return string.Format ("{0}{1}", string.IsNullOrEmpty (fullname) ? "" : "--", fullname); } }

		public Argument (string shortname, string fullname) {
			this.shortname = shortname;
			this.fullname = fullname;
		}
	}
}

