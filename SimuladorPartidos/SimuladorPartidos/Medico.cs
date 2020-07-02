using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Medico : IntegrantesEquipo
    {

        private int exp;
        private bool treatingPlayer;
        public Medico(Jugador jugador)
        {
            jugador.InjuryNotified += OnInjuryNotified;
        }

        
        public void OnInjuryNotified(object sender, EventArgs e)
        {
            Console.WriteLine("Player Injured...");
            treatingPlayer = true;

        }
        public void Cure()
        {
            if (treatingPlayer == true)
            {
                Console.WriteLine("Player Cured...");
                treatingPlayer = false;
            }
        }
        public void Treat()
        {
            if (treatingPlayer == true)
            {
                Console.WriteLine("Treating Player...");
            }
        }

        public override string GetInfo()
        {
            return "Name: " + name;
        }
    }
}
