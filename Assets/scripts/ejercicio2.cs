using UnityEngine;

public class puntaje : MonoBehaviour
{
    #region Private
    private string name;
    private int life;
    private int score;

    public string Name => name;
    public int Life => life;
    public int Score => score;
    #endregion

    public puntaje() {
        name = "null";

    }

    public puntaje(string _name, int _life, int _score) { 
    name =_name;
    life=_life;
    score= _score;

    } 
}
