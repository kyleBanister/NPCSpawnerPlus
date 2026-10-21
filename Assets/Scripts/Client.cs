using UnityEngine;

public class Client : MonoBehaviour {

    public int gold = 0;
    public int power = 0;
    public bool goblinFriend = false;
    
    public NPCFactory npcFactory;
    private NPCInterface farmer;
    private NPCInterface beggar;
    private NPCInterface shopOwner;
    private NPCInterface goblin;
    private NPCInterface dragon;

    void Start() {
        farmer = npcFactory.GetNPC(NPCType.Farmer);
        beggar = npcFactory.GetNPC(NPCType.Beggar);
        shopOwner = npcFactory.GetNPC(NPCType.ShopOwner);
        goblin = npcFactory.GetNPC(NPCType.Goblin);
        dragon = npcFactory.GetNPC(NPCType.Dragon);
    }

    public void ChangeGold(int change) {
        gold+=change;
    }
    public void ChangePower(int change) {
        power+=change;
    }

    public void BecomeGoblinFriend() {
        goblinFriend = true;
    }

    void OnGUI() {
        GUILayout.Label("Gold:" + gold);
        GUILayout.Label("Power:" + power);
        if (GUILayout.Button("Talk to farmer")) {
            farmer.Speak(this);
        }
        if (GUILayout.Button("Talk to beggar")) {
            beggar.Speak(this);
        }
        if (GUILayout.Button("Talk to shopOwner")) {
            shopOwner.Speak(this);
        }
        if (GUILayout.Button("Talk to goblin")) {
            goblin.Speak(this);
        }
        if (GUILayout.Button("Talk to dragon")) {
            dragon.Speak(this);
        }
    }
}
