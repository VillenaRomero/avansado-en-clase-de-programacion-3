using UnityEngine;

public class estadisticas : jugador
{
    public int estadistic;
    public estadisticas(string _name, string _life, int _estadistic) : base(_name, _life)
    {
        estadistic = _estadistic;
    }
}