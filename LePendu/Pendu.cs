using System;
using System.Collections.Generic;

namespace LePendu
{
    public struct Pendu
    {
        string motMystere;
        public string motTrouve;
        public int pointVie;
        List<char> propositionCorrect;
        List<char> propositionIncorrect;
        public bool Fin;

        public void Init()
        {
            string[] mots = { "elephan", "banane", "voiture", "avion" };
            motMystere = vasChercher(mots);
            foreach (char item in motMystere)
            {
                motTrouve += "_";
            }
            propositionCorrect = new List<char>();
            propositionIncorrect = new List<char>();
            pointVie = motMystere.Length;
            Fin = false;
        }
        public string fnJeu(char lettre)
        {
            string message = "";

                List<int> pos = new List<int>();
                bool trouve = false;

                for (int i = 0; i < motMystere.Length; i++)
                {
                    char lettreCourante = motMystere[i];
                    if (lettre.ToString().ToLower() == lettreCourante.ToString().ToLower())
                    {
                        trouve = true;
                        pos.Add(i);
                    }
                }
                if (trouve == true)
                {
                    propositionCorrect.Add(lettre);
                    string tempMotTrouve = "";
                    for (int i = 0; i < motMystere.Length; i++)
                    {
                        if (!pos.Contains(i)) tempMotTrouve += motTrouve[i];
                        else tempMotTrouve += lettre;
                    }
                    motTrouve = tempMotTrouve;
                    message = $"la lettre \"{lettre}\" a été rouvée";
                }
                else
                {
                    pointVie--;
                    propositionIncorrect.Add(lettre);
                    message = $"la lettre \"{lettre}\" n'a pas été rouvée";
                }

            Fin = motMystere.ToLower() == motTrouve.ToLower() || !(pointVie > 0);
            return message;
        }

        public string getStatus()
        {
            return $"==> Le mot actuel est {motTrouve} \r\n==> " +
                $"Les points de vie sont : {pointVie} \r\n================";
        }


        string vasChercher(string[] mots)
        {
            Random rnd = new Random();
            int pos = rnd.Next(0, mots.Length);
            return mots[pos];
        }
    
    }



}