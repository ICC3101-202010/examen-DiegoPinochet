using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Entrenador : IntegrantesEquipo
    {
        public delegate void ChangePlayerEventHandler(object sender, EventArgs args);
        public event ChangePlayerEventHandler PlayerChanged;
        
        private int tp;
        private bool injuredPlayer;
        public Entrenador(Jugador jugador)
        {
            jugador.InjuryNotified += OnInjuryNotified;
        }

        public void OnInjuryNotified(object sender, EventArgs e)
        {
            Console.WriteLine("Player Injured");
            injuredPlayer = true;

        }
        protected virtual void OnPlayerChanged()
        {

            if (PlayerChanged != null)
            {
                PlayerChanged(this, EventArgs.Empty);
            }

        }

        public override string GetInfo()
        {
            return "Name: " + name;
        }
    }
}
