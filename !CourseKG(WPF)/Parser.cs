using System.Windows;

namespace _CourseKG_WPF_
{
	class Parser
	{
		public void Parse()
		{
			MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
			sc.Language = "VBScript";
			string expression = "1 + 2 * 7";
			object result = sc.Eval(expression);
			MessageBox.Show(result.ToString());
		}
	}
}