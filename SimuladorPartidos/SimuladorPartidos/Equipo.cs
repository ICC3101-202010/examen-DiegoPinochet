using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorPartidos
{
    class Equipo
    {
        private List<Jugador> players = new List<Jugador>();
        private List<Jugador> titulares = new List<Jugador>();

        private Entrenador trainer;
        private Medico medic;

        private string name;
        private bool nationalTeam;
        private string nationOrLeague;
        private int matchScore;

        public Equipo(string name, bool nationalTeam)
        {
            this.name = name;
            this.nationalTeam = nationalTeam;
        }

        public List<Jugador> Players { get => players; set => players = value; }
        public Entrenador Trainer { get => trainer; set => trainer = value; }
        public Medico Medic { get => medic; set => medic = value; }
        public string NationOrLeague { get => nationOrLeague; set => nationOrLeague = value; }
        public bool NationalTeam { get => nationalTeam; set => nationalTeam = value; }

        public string AddPlayer(Jugador player)
        {
            if(nationalTeam == true)
            {
                int cont = 0;
                if (player.Nacionality == nationOrLeague)
                {
                    cont++;
                    players.Add(player);
                }
                if(cont == 1)
                {
                    return "Player added succesfully";
                }
                else
                {
                    return "The player and the team aren't from the same nationality";
                }
            }
            else
            {
                if (player.Nacionality == nationOrLeague)
                {
                    players.Add(player);
                }
                return "Player added succesfully";
            }   
        }

        public string RemovePlayer(Jugador jugador)
        {
            int index = 0;
            int initialSize = players.Count();
            foreach(Jugador player in players)
            {
                if(jugador.Name == player.Name && jugador.Nacionality == player.Nacionality && jugador.Age == player.Age)
                {
                    break;
                }
                index++;
            }
            players.RemoveAt(index);
            if(initialSize != players.Count())
            {
                return "Succesfully removed player";
            }
            else
            {
                return "Couldn't remove player";
            }
        }
        
        //Se pasa una lista de jugadores que podrian ser titulares segun el entrenador
        public string Titulares(List<Jugador> posiblesTitulares)
        {
            if (posiblesTitulares.Count == 11)
            {
                foreach (Jugador posibleTitular in posiblesTitulares)
                {
                    foreach (Jugador jugador in players)
                    {
                        if (jugador.Name == posibleTitular.Name && jugador.Nacionality == posibleTitular.Nacionality && jugador.Age == posibleTitular.Age)
                        {
                            titulares.Add(posibleTitular);
                        }
                    }
                }
                return "Players added to the initial team";
            }
            else
            {
                return "Your player length list is != 11";
            }
        }
        public string TeamInfo()
        {
            string result = "Team name: " + name + "\n" + "Team Type: " + nationOrLeague + "\n";
            string medicInfo = "Medico: " + medic.GetInfo() + "\n";
            string trainerInfo = "Entreador: " + trainer.GetInfo() + "\n";
            string playersInfo = "Jugadores: \n";

            foreach (Jugador jugador in players)
            {
                playersInfo += "\t" + jugador.GetInfo() + ".\n";
            }
            result += trainerInfo + playersInfo + medicInfo;
            return result;
        }
        public string CheckNationality()
        {
            string allchecked;

            if (nationalTeam == true)
            {
                int cont = 0;
                foreach (Jugador player in players)
                {
                    if (player.Nacionality == NationOrLeague)
                    {
                        cont++;
                    }
                }
                if(cont == 14)
                {
                    allchecked = "All players are from the team Nacionality";
                }
                else
                {
                    allchecked = "Not all players are from the team Nacionality";
                }
                return allchecked;
            }
            else
            {
                return "The team is from a league, there is no need to cheack the players nacionality";
            }
            
        }
    }
}
