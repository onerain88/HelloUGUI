using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour {
    public ScrollRect chatScrollRect = null;
    public Transform chatContentTransform = null;
    public InputField chatInputField = null;

    public void onSendButtonClicked() {
        string chat = this.chatInputField.text;
        string chatItemRes = Random.Range(0, 2) == 0 ? "LeftChatItem" : "RightChatItem";
        GameObject chatItemGO = Instantiate(Resources.Load(chatItemRes), chatContentTransform) as GameObject;
        ChatItem chatItem = chatItemGO.GetComponent<ChatItem>();
        chatItem.setChat(chat);

        StartCoroutine(goToBottom());
    }

    IEnumerator goToBottom() {
        yield return null;
        this.chatScrollRect.normalizedPosition = Vector2.zero;
    }
}
