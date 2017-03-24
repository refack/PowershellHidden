using System;
using System.Management.Automation.Runspaces;

namespace PowershellHidden
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
            string arg = "& \"" + String.Join("\" \"", args) + "\"";
            System.IO.File.WriteAllText(@"c:\bin\var\arg.txt", arg);

            Runspace rs = RunspaceFactory.CreateRunspace();
			rs.Open();

            Pipeline pipe = rs.CreatePipeline();
            pipe.Commands.AddScript(arg);
            pipe.Invoke();
		}
	}
}