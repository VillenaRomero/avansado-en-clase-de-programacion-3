using System.ComponentModel;
using UnityEngine;

public interface IDamage {
    void Ira();
}
public class guerrero : MonoBehaviour, IDamage
{
    #region Private

    private int life;
    private int damage;

    public int Life => life;
    public int Damage => damage;
    public guerrero(int _life, int _damage) { 
    life=_life;
    damage=_damage;
    }
    public void Ira() {
        print(name + " esta usando su ira preparate de puño poder ");
    }
    #endregion
}
