using System;
using System.Linq;
using System.Management.Automation.Runspaces;

namespace PowershellHidden
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
            var args2 = args.Select(a => a.Contains(' ') ? ('"' + a + '"') : a);
            string arg = "& {" + String.Join(" ", args2) + "}";
            System.IO.File.WriteAllText(@"c:\bin\var\arg.txt", arg);

            Runspace rs = RunspaceFactory.CreateRunspace();
			rs.Open();

            Pipeline pipe = rs.CreatePipeline();
            pipe.Commands.AddScript(arg);
            pipe.Invoke();
		}
	}
}