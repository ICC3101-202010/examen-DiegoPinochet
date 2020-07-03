using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("D", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j2 = new Jugador("M", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j3 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j4 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j5 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j6 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j7 = new Jugador("D", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j8 = new Jugador("M", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j9 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j10 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j11 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j12 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j13 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j14 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");
            Jugador j15 = new Jugador("J", 21, "Chilena", 30, 10, 10, 4, "Defensa");

            List<Jugador> nomina = new List<Jugador>();
            nomina.Add(j1);
            nomina.Add(j2);
            nomina.Add(j3);
            nomina.Add(j4);
            nomina.Add(j5);
            nomina.Add(j6);
            nomina.Add(j7);
            nomina.Add(j8);
            nomina.Add(j9);
            nomina.Add(j10);
            nomina.Add(j11);
            nomina.Add(j12);
            nomina.Add(j13);
            nomina.Add(j14);
            nomina.Add(j15);

            Entrenador e1 = new Entrenador("Y", 21, "Chilena", 30, 10);
            Medico m1 = new Medico("P", 21, "Chilena", 30, 10);

            Equipo equipo1 = new Equipo("DOBS", false, e1, m1);
            Equipo nacional = new Equipo("Chile", true, e1, m1);

            equipo1.Players = nomina;
            equipo1.Trainer = e1;
            equipo1.Medic = m1;

            nacional.Players = nomina;
            nacional.Trainer = e1;
            nacional.Medic = m1;
            nacional.NationOrLeague = "Chilena";

            Console.WriteLine(nacional.CheckNationality());
            Console.WriteLine("\nTEAM INFO:\n");
            Console.WriteLine(nacional.TeamInfo());

        }
    }
}
