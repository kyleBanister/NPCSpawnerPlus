using UnityEngine;

public class Dragon: NPCInterface {
    public void Speak(Client client) {
        Debug.Log("Fear my wrath!");
        if(client.power < 1000) {
            Debug.Log("*You die painfully and horribly in a blazing inferno.*");
        } else {
            Debug.Log("The dragon is slain!");
        }
    }
}
