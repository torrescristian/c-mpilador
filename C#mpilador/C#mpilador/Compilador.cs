using System;
using System.Diagnostics;
using System.Threading;

namespace C_mpilador
{

	public static class Compilador
	{
		public static string compilar(string name_out, string files_cs, int cases, string csc_dir, bool mostrar_start_info) {
			try
			{
				Process compiler = new Process();
				compiler.StartInfo.FileName = "cmd";
				compiler.StartInfo.UseShellExecute = false;
				compiler.StartInfo.CreateNoWindow = true;
				compiler.StartInfo.RedirectStandardOutput = true;
				switch(cases) {
					// .exe sin librerías
					case 0: compiler.StartInfo.Arguments = "/c \"path %path%;"+csc_dir+"; & csc.exe /out:\""+name_out+"\" \""+files_cs+"\"\"";
					break;
					// .exe con librerías
					case 1: compiler.StartInfo.Arguments = "/c \"path %path%;"+csc_dir+"; & csc.exe /out:\""+name_out+"\" /reference:\""+files_cs+"\"\"";
					break;
					// librería
					case 2: compiler.StartInfo.Arguments = "/c \"path %path%;"+csc_dir+"; & csc.exe /target:library /out:\""+name_out+"\" \""+files_cs+"\"\"";
					break;
				}
				compiler.Start();
				string txt_debug = "";
				if(mostrar_start_info)
					txt_debug += compiler.StartInfo.Arguments + "\n";
				txt_debug += compiler.StandardOutput.ReadToEnd();
				return txt_debug;
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}
	}
}
