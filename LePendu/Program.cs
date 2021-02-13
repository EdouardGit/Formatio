using System;
using System.Collections.Generic;

namespace LePendu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region version object

            GameInstances game = new GameInstances();

            #endregion
            
            #region version procedural with struct

            // Pendu pendu = new Pendu();
            // pendu.Init();
            //
            // while (!pendu.Fin)
            // {
            //     //demander les info => prg
            //     Console.WriteLine("Entrez une lettre");
            //     char lettre = char.Parse(Console.ReadLine());
            //     //vérifier la lettre => struct
            //     string message = pendu.fnJeu(lettre);
            //
            //     //Afficher les info
            //     Console.WriteLine(message);
            //     Console.WriteLine(pendu.getStatus());
            // }
            // if (pendu.pointVie == 0) Console.WriteLine("Désolé perdu");
            // else Console.WriteLine("Bravo !");

            #endregion
        }
    }
}
