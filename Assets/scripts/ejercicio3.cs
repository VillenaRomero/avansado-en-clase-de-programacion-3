using UnityEngine;

public class guerrero : jugador
{
    private int ira;

    public int Ira => ira;

    public guerrero(string _nombre, int _fuerza, int _defensa, int _ira) : base(_nombre, _fuerza, _defensa)
    {
        ira = _ira;
    }

    public void UsarIra()
    {
        Debug.Log(Nombre + " está usando su ira con poder de: " + ira);
    }
}