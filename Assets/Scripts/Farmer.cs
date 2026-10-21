using UnityEngine;

public class Farmer: NPCInterface {
    public void Speak(Client client) {
        Debug.Log("You reap what you sow!");
        client.ChangeGold(10);
    }
}
