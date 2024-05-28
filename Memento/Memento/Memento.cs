using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        private readonly string savedState;

        private Memento(string stateToSave)
        {
            savedState = stateToSave;
        }

        public class Originator
        {
            private string state;
            // The class could also contain additional data that is not part of the
            // state saved in the memento.

            public void Set(string state)
            {
                Console.WriteLine("Originator: Setting state to " + state);
                this.state = state;
            }

            public Memento SaveToMemento()
            {
                Console.WriteLine("Originator: Saving to Memento.");
                return new Memento(state);
            }

            public void RestoreFromMemento(Memento memento)
            {
                state = memento.savedState;
                Console.WriteLine("Originator: State after restoring from Memento: " + state);
            }
        }
    }    
}
