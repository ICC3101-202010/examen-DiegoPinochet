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
        public Entrenador(string name, int edad, string nacionalidad, int sueldo, int tp)
        {
            this.name = name;
            this.age = edad;
            this.nacionality = nacionalidad;
            this.salary = sueldo;
            this.tp = tp;
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
