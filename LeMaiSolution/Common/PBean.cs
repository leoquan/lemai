using LeMaiDomain;
using LeMaiLogic;
using System;
using System.Collections.Generic;

namespace Common
{
	public class PBean
	{
		public static DateTime LOGIN_DATE = DateTime.Now;

		public static string CONNECTION_STRING = string.Empty;

		public static string CONNECTION_STRING_VIEW = string.Empty;

		public static string MESSAGE_TITLE = "Lê Mai Carry System";

		public static string APPLICATION_VERSION = "1.0.0.0";

		public static string LANGUAGE = "vi-VN";

		public static string SCHEMA = "dbo";

		public static AccountObject USER = null;
		
		public static LocalOptions LOCAL_OPTIONS = new LocalOptions();

		public static ServerOption SERVER_OPTION;

		public static bool MAKE_LANG = true;

		public static string COMPANY_REPORT_CODE = string.Empty;

		public static string BRANCH_ID = string.Empty;

		public static Branch BranchWorking = new Branch();

		public static BaseLogicConnectionData ConnectionBase;
        public static string PROGRAM_GROUP = "exp";
    }
}

