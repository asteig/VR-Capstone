using UnityEngine;
using UnityEngine.Networking;


public class CustomDiscovery : NetworkDiscovery
{

    void Start()
    {
        Initialize();
        if (!NetworkServer.active)
            StartAsClient();
    }

    public override void OnReceivedBroadcast(string fromAddress, string data)
    {
        Debug.Log("Received Broadcast Message with Data " + fromAddress);
        NetworkManager.singleton.networkAddress = fromAddress;
        if (!NetworkClient.active)
            NetworkManager.singleton.StartClient();
    }
}