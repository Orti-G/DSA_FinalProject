using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class PlayerCard
    {
        private string PlayerName;
        private string PlayerCharacter;
        private string PlayerCategory;
        private string PlayerMoneyTree;
        private string PlayerWinnings;

        public static LinkedList<string> PlayerDescription = new LinkedList<string>();
        public static Stack<PlayerCard> GameHistory = new Stack<PlayerCard>();
        public static Stack<PlayerCard> GameHistoryTemporary = new Stack<PlayerCard>();
        public PlayerCard(string pName, string pCharacter, string pCategory, string pMoneyTree, string pWinnings)
        {
            PlayerName = pName;
            PlayerCharacter = pCharacter;
            PlayerCategory = pCategory;
            PlayerMoneyTree = pMoneyTree;
            PlayerWinnings = pWinnings;
        }

        public string GetPlayerName() 
        {
            return PlayerName;
        }
        public string GetPlayerCharacter()
        {
            return PlayerCharacter;
        }
        public string GetPlayerCategory()
        {
            return PlayerCategory;
        }
        public string GetPlayerMoneyTree()
        {
            return PlayerMoneyTree;
        }
        public string GetPlayerWinnings()
        {
            return PlayerWinnings;
        }

        public static void UnloadPlayerDescription() 
        {
           
            List<string> st = new List<string>();

            foreach (string s in PlayerDescription) 
            {
                st.Add(s);
            }

            GameHistory.Push(new PlayerCard(st[0], st[1], st[2], st[3], st[4]));
            st.Clear();
            PlayerDescription.Clear();


        }

        public static void ReturnToSender() 
        {
            for (int i = 0; i < GameHistoryTemporary.Count; i++) 
            {
                GameHistory.Push(GameHistoryTemporary.Pop());
            }
        }

    }
}
