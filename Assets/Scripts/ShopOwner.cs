using UnityEngine;

public class ShopOwner: NPCInterface {
    public void Speak(Client client) {
        Debug.Log("Do you wish to purchase something?");
        if(client.gold >= 10) {
            client.ChangeGold(-10);
            client.ChangePower(10);
            Debug.Log("Here you go!");
        } else {
            Debug.Log("Come back when you are a little bit richer.");
        }
    }
}
