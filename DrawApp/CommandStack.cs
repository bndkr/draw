using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class CommandStack
    {
        private List<ICommand> m_commandStack = new List<ICommand>();
        public CommandStack() { }
        public void DoCommand(ICommand command)
        {
            m_commandStack.Add(command);
            command.Execute();
        }

        public void UndoLastCommand()
        {
            if (m_commandStack.Count != 0)
            {
                ICommand command = m_commandStack.Last();
                command.Undo();
                m_commandStack.RemoveAt(m_commandStack.Count - 1);
            }
        }
    }
}
