using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueUI : MonoBehaviour
{
    [SerializeField] private DialogueManager _dialogueManager;
    [SerializeField] private Image _imageAvatar;
    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _text;

    private int _index = 0;
    private void Start() {
        _imageAvatar.sprite = _dialogueManager.Avatar;
        _name.text = _dialogueManager.Name;
        _text.text = _dialogueManager.Text[0];

    }
    public void ChangeText()
    {
        _index++;
        if(_index >= _dialogueManager.Text.Length){
            _index = 1;
        }
        _text.text = _dialogueManager.Text[_index];
    }
}

