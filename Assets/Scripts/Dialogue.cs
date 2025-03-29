using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    // Speaker

    [System.Serializable]
    public class Speaker
    {
        // 이름, 대사, 이미지
        public TextMeshProUGUI name;
        public TextMeshProUGUI dialougeText;
        public Image portraitImage;
    }

    [System.Serializable]
    public class DialogueData
    {
        public Sprite image;
        public string name;
        public string dialouge;
    }

    public Speaker speaker;
    public DialogueData[] dialogs;
    public int currentDialogueIndex = 0;

    void Setup(int index)
    {
        speaker.dialougeText.text = dialogs[index].dialouge;
        speaker.name.text = dialogs[index].name;
        speaker.portraitImage.sprite = dialogs[index].image;
    }

    public void UpdateDialouge()
    {
        if(Input.GetMouseButtonDown(0)) // 마우스 왼쪽 클릭했을 때 
        {
            currentDialogueIndex++;

            if(currentDialogueIndex >= dialogs.Length)
            {
                Debug.Log("최대 대사 길이를 초과했습니다.");
                currentDialogueIndex = -1;
                return;
            }

            Setup(currentDialogueIndex);
        }
    }

    private void Start()
    {
        Setup(currentDialogueIndex);
    }

    private void Update()
    {
        UpdateDialouge();
    }

}
