using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Adventure_Game_for_Education__SAGE__Revised
{
    public class NPC 
    {
        private string name;
        private string dialogue;

        public void setName(string npcName)
        {
            name = npcName;
        }

        public string getName()
        {
            return name; 
        }
        public void setDialogue(string dialogueMessage)
        {
            dialogue = dialogueMessage;
        }
        
        public string getDialogue()
        {
            return dialogue;    
        }
    }
}
