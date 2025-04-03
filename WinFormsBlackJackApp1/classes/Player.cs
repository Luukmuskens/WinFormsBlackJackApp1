using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static WinFormsBlackJackApp1.classes.Deck;

namespace WinFormsBlackJackApp1.classes
{
    private List<Hand> hands;

    // Win streak counter
    private int winstreak;

    // Flag to check if the player's turn is done
    public bool done = false;

    
    public Player()
    {
        
    }
}
