
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueManager", menuName = "TBKK/DialogueManager", order = 0)]
public class DialogueManager : ScriptableObject 
{
    [SerializeField] private string _name;
    public string Name{get{return _name;}}
    [SerializeField] private Sprite _avatar;
    public Sprite Avatar{
        
        get
        {
            if(_avatar == null){
                Debug.Log("Choose image");
                return null;
            }else{
                return _avatar;
            }
        }
    }
    public string[] Text;
}

   

