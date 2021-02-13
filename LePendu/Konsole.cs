using System;
using System.Runtime.InteropServices;

namespace LePendu
{

    public class Konsole
    {
        // Les différentes couleurs possibles.
        public enum CharacterAttributes
        {
            FOREGROUND_BLUE = 0x0001,
            FOREGROUND_GREEN = 0x0002,
            FOREGROUND_RED = 0x0004,
            FOREGROUND_INTENSITY = 0x0008,
            BACKGROUND_BLUE = 0x0010,
            BACKGROUND_GREEN = 0x0020,
            BACKGROUND_RED = 0x0040,
            BACKGROUND_INTENSITY = 0x0080,
            COMMON_LVB_LEADING_BYTE = 0x0100,
            COMMON_LVB_TRAILING_BYTE = 0x0200,
            COMMON_LVB_GRID_HORIZONTAL = 0x0400,
            COMMON_LVB_GRID_LVERTICAL = 0x0800,
            COMMON_LVB_GRID_RVERTICAL = 0x1000,
            COMMON_LVB_REVERSE_VIDEO = 0x4000,
            COMMON_LVB_UNDERSCORE = 0x8000
        }

        // Importation des fonctions de l'API de windows qui nous seront nécesaires
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, CharacterAttributes wAttributes);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        public Konsole()
        {
        }

        // Fonction permettant de changer les attributs de la console
        public static void SetConsoleTextAttribute(CharacterAttributes wAttributes)
        {
            // "GetStdHandle(-11)" retourne la console output... me demandez pas pourquoi le -11.
            SetConsoleTextAttribute(GetStdHandle(-11), wAttributes);
        }

        // Permet d'écrire une ligne de texte avec les attributs en cours.
        public static void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        // Permet d'écrire une ligne de texte en changeant les attributs de couleur.
        public static void WriteLine(string str, CharacterAttributes wAttributes)
        {
            SetConsoleTextAttribute(wAttributes);
            Console.WriteLine(str);
        }

        // Permet d'écrire du texte avec les attributs en cours.
        public static void Write(string str)
        {
            Console.Write(str);
        }

        // Permet d'écrire du texte en changeant les attributs de couleur.
        public static void Write(string str, CharacterAttributes wAttributes)
        {
            SetConsoleTextAttribute(wAttributes);
            Console.Write(str);
        }
    }
}  