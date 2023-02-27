using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    private bool _redLight = false;
    [SerializeField] private float _timeToChange;
    private float _startTimeToChange;
    [SerializeField] private Material _standardMaterial;
    [SerializeField] private ChangeColor[] _colors;
    [SerializeField]private int index = -1; 
    public bool RedLight
    {
        get
        {
            return _redLight;
        }
    }
    private void Start() {
        _startTimeToChange = _timeToChange;
    }
    
    private void Update() {
        if(_startTimeToChange >= 0){
            _startTimeToChange-= 1 * Time.deltaTime;
        }
        else{
            _startTimeToChange = _timeToChange;
            index++;
            _colors[_colors.Length-1].gameObject.GetComponent<MeshRenderer>().material = _standardMaterial;

        }
        if(index > -1){
            _colors[index].SetColor();
            _colors[index-1].gameObject.GetComponent<MeshRenderer>().material = _standardMaterial;
        }
        if(index >= _colors.Length-1){
            index = -1;
        }
        
    }
   
}
