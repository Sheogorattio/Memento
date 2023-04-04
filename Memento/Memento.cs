using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        public string String { get; set; }

        public Memento(string String)
        {
            this.String = String;
        }

        public override string ToString()
        {
            return String;
        }
    }

    public class Caretaker
    {
        List<Memento> savedStates = new List<Memento>(256);
        int latestVersion = -1;
        public int currentVersion = -1;
        public string this[int index]
        {
            get 
            {
                if (index >= 0)
                {

                    return savedStates[index].ToString();
                }
                throw new IndexOutOfRangeException();
            }
        }
        public void Add(Memento state)
        {
            latestVersion++;
            currentVersion = latestVersion;
            savedStates.Add(state);
        }
    }
}
