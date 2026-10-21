using UnityEngine;

public class Beggar: NPCInterface {
    public int quota = 100;
    private static int received = 0;
    public void Speak(Client client) {
        Debug.Log("Do you have some change to spare?");
        if(client.gold >= 10) {
            client.ChangeGold(-10);
            received+=10;
            Debug.Log("Thank you kindly!");
            if(received == 100) {
                Debug.Log("Tell the goblin I said hello, by the way.");
                client.BecomeGoblinFriend();
            }
        }
    }
}
