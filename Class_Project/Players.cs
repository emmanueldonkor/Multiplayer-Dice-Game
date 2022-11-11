using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Project
{
    class Players
    {
        public static int player1;
        public static int players2;
        public static int players3;
        public static int players4;
        public static int diceNumber = 1;
        public static int _scorePlayer1 = 0;
        public static int _scorePlayer2 = 0;
        public static int _scorePlayer3 = 0;
        public static int _scorePlayer4 = 0;
        public static int _bankPlayer1 = 0;
        public static int _bankPlayer2 = 0;
        public static int _bankPlayer3 = 0;
        public static int _bankPlayer4 = 0;
        public static int playerTurnNumber = 1;
    }

    class GamePlayers
    {
        public string name = "";
        public int points = 0;
        public int bank = 0;
    }
}
