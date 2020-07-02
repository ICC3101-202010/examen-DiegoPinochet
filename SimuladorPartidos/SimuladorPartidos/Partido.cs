using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Partido
    {
        private Equipo equipo1;
        private Equipo equipo2;
        private double time;
        private List<int> score;

        public Partido(Entrenador entrenador)
        {
            entrenador.PlayerChanged += OnPlayerChanged;
        }

        public Equipo Equipo1 { get => equipo1; set => equipo1 = value; }
        public Equipo Equipo2 { get => equipo2; set => equipo2 = value; }
        public double Time { get => time; set => time = value; }
        public List<int> Score { get => score; set => score = value; }

        public void OnPlayerChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Player Changed...");
        }
        public bool CheckTeams()
        {
            if(equipo1.NationalTeam == true && equipo2.NationalTeam == true)
            {
                Console.WriteLine("Play");
                return true;
            }
            else if(equipo1.NationalTeam == false && equipo2.NationalTeam == false)
            {
                Console.WriteLine("Play");
                    return true;
            }
            else
            {
                return false;
            }
        }
    }
}
