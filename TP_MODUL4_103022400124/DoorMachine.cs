using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400124
{

    public class DoorMachine
    {
        enum State { Terkunci, Terbuka }
        State currentState = State.Terkunci; // State awal

        public void KunciPintu()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}
