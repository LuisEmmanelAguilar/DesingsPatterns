using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.memento
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState pop()
        {
            var lastState = states.Last();
            states.Remove(lastState);

            return lastState;
        }
    }
}
