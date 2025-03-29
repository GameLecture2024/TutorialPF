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
        // �̸�, ���, �̹���
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
        if(Input.GetMouseButtonDown(0)) // ���콺 ���� Ŭ������ �� 
        {
            currentDialogueIndex++;

            if(currentDialogueIndex >= dialogs.Length)
            {
                Debug.Log("�ִ� ��� ���̸� �ʰ��߽��ϴ�.");
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
