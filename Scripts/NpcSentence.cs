using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcSentence : MonoBehaviour
{
    public string[] sentences;
    public Transform chatTr;
    public GameObject chatBoxPrefab;
    void Start()
    {
        
    }

    void Update()
    {
        chatTr = chatTr.transform;
    }

    void TalkNpc()
    {
        GameObject go = Instantiate(chatBoxPrefab);
        go.GetComponent<ChatSystem>().Ondialogue(sentences, chatTr);
    }

    private void OnMouseDown()
    {
        TalkNpc();
    }
}
