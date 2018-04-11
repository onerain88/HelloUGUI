using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatItem : MonoBehaviour {
    public Sprite[] avatars = null;

    public Image avatarImage = null;
    public Text chatText = null;

    public void setChat(string chat) {
        int index = Random.Range(0, avatars.Length);
        this.avatarImage.sprite = this.avatars[index];
        this.chatText.text = chat;
    }
}
