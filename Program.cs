using System;
using System.Management.Automation.Runspaces;

namespace PowershellHidden
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Runspace rs = RunspaceFactory.CreateRunspace();
			rs.Open();
			Pipeline pipe = rs.CreatePipeline();
            pipe.Commands.AddScript(args[0]);
            pipe.Invoke();
		}
	}
}