using UnityEngine;

public enum NPCType {
    Farmer,
    Beggar,
    ShopOwner,
    Goblin,
    Dragon
}

public class NPCFactory : MonoBehaviour {
    public NPCInterface GetNPC(NPCType type) {
        switch(type) {
            case NPCType.Beggar:
            NPCInterface beggar = new Beggar();
            return beggar;
            case NPCType.Farmer:
            NPCInterface farmer = new Farmer();
            return farmer;
            case NPCType.ShopOwner:
            NPCInterface shopOwner = new ShopOwner();
            return shopOwner;
            case NPCType.Goblin:
            NPCInterface goblin = new Goblin();
            return goblin;
            case NPCType.Dragon:
            NPCInterface dragon = new Dragon();
            return dragon;
        }
        return null;
    }
}
