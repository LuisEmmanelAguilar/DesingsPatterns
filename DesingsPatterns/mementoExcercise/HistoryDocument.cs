using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.mementoExcercise
{
    public class HistoryDocument
    {
        private Queue<DocumentState> mementos = new Queue<DocumentState>();
        
        public void push(DocumentState memento)
        {
            mementos.Enqueue(memento);
        }

        public DocumentState pop()
        {
            return mementos.Dequeue();
        }

    }
}
