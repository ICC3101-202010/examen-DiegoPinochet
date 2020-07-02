using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Jugador:IntegrantesEquipo
    {
        public delegate void NotifyInjuryEventHanlder(object source, EventArgs args);
        public event NotifyInjuryEventHanlder InjuryNotified;

        private int ap;
        private int dp;
        private int jerseyNumber;
        public string position;
        private bool injury;

        public Jugador(string name, int edad, string nacionalidad, int sueldo, int ap, int dp, int jerseyNumber, string position)
        {
            this.name = name;
            this.age = edad;
            this.nacionality = nacionalidad;
            this.salary = sueldo;
            this.ap = ap;
            this.dp = dp;
            this.jerseyNumber = jerseyNumber;
            this.position = position;
        }

        public override string GetInfo()
        {
            return "Name: " + name + "," + "Jersey Number" + jerseyNumber; 
        }
        protected virtual void OnInjuryNotified()
        {
            if(InjuryNotified != null)
            {
                InjuryNotified(this, EventArgs.Empty);
            }
        }

    }
}
