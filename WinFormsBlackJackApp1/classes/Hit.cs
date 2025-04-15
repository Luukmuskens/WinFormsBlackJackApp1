using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlackJackApp1.classes
{
    internal class Hit
    {
        /// <summary>
        /// Represents the 'Hit' action in the BlackJack game.
        /// A player chooses 'Hit' to receive an additional card.
        /// </summary>
        public class Hitt
        {
            // Version of the action
            public string Version { get; } = "1.0";

            // Actor performing the hit (always the player)
            public string Actor { get; } = "Player";

        }


    }
}
