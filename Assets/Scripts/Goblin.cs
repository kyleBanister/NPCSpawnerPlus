using UnityEngine;

public class Goblin: NPCInterface {
    public int stolenGold = 0;
    public void Speak(Client client) {
        if(client.goblinFriend) {
            client.ChangeGold(stolenGold*stolenGold);
            stolenGold = 0;
        } else {
            if(client.gold >= 10) {
                Debug.Log("Your gold is mine!");
                client.ChangeGold(-10);
                stolenGold += 10;
            } else {
                Debug.Log("You are not worth stealing from.");
            }
        }
    }
}
