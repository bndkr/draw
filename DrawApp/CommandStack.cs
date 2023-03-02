using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
  static class CommandStack // make this a singleton? it does just fine static
  {
    private static List<ICommand> m_commandStack = new List<ICommand>();
    public static void DoCommand(ICommand command)
    {
      m_commandStack.Add(command);
      command.Execute();
    }
    public static void UndoLastCommand()
    {
      if (m_commandStack.Count != 0)
      {
        ICommand command = m_commandStack.Last();
        command.Undo();
        m_commandStack.RemoveAt(m_commandStack.Count - 1);
      }
    }

    public static int getNumCommands()
    {
      return m_commandStack.Count;
    }
  }
}
