using UnityEngine;

public class furia : guerrero
{
    public int aumentodeira;
    
    public furia(int _life, int _damage, int _aumeentodeira):base(_life, _damage)
    {
        aumentodeira=_aumeentodeira;

    }
    public void Ira() {
        print(name + " uso ira, su ataque de " + Damage + " aumento mas con "  + aumentodeira + " por el uso de ira");
    }
}
