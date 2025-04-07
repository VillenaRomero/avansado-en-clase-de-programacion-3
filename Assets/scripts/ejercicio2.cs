using UnityEngine;

public class enemigo : MonoBehaviour
{
    private string nombre;
    private int vida;
    private int score;

    public enemigo(string _nombre, int _vida, int _score)
    {
        nombre = _nombre;
        vida = _vida;
        score = _score;
    }

    ~enemigo()
    {
        score += 10;
        Debug.Log(nombre + " ha muerto. Score aumentado a: " + score);
    }
}