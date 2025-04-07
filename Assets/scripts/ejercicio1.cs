using UnityEngine;

public class jugador : MonoBehaviour
{
    private string nombre;
    private int fuerza;
    private int defensa;

    public string Nombre => nombre;
    public int Fuerza => fuerza;
    public int Defensa => defensa;

    public jugador(string _nombre, int _fuerza, int _defensa)
    {
        nombre = _nombre;
        fuerza = _fuerza;
        defensa = _defensa;
    }
}