using CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderRule.CombatService
{
    public class Battle
    {
        private Player player1;
        private Player player2;

        public Battle(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public FightResults RunFight()
        {
            if(player1.Army > player2.Army)
            {
                return new FightResults
                {
                    ResultMessage = "player 1 is winnner"
                };
            }
            else if(player2.Army > player1.Army)
            {
                return new FightResults
                {
                    ResultMessage = "player 2 is winnner"
                };
            }
            else
            {
                return new FightResults
                {
                    ResultMessage = "stalemate"
                };

            }
        }
    }

    public class FightResults
    {
        public string ResultMessage;
    }
}
