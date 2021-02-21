using System;
using Model;

namespace MyEditor
{
	public static class SvnHelper
	{
		private static string RunCmd(string exe, string args)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = exe;
			process.StartInfo.Arguments = args;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.WorkingDirectory = @".\";
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();
			string info = process.StandardOutput.ReadToEnd();
			return info;
		}

		public static string GetSvnRevision()
		{
			// 获取svn版本号
			string content = RunCmd("svn.exe", "info");
			Log.Debug(content);
			string line = content.Split(new string[]{Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)[6].Trim();
			string revision = line.Split()[1];
			Log.Debug($"svn revision: {revision}");
			return revision;
		}
	}
}
