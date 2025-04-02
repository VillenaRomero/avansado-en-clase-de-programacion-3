using UnityEngine;

public class jugador : MonoBehaviour
{
    #region Private
    private string name;
    private string life;
    #endregion

    public string Name => name;
    public string Life => life;
    #region Constructors

    public jugador(){
        name = "null";
        life = "null";
    }
    #endregion
    public jugador(string _name, string _life) {
      name= _name;
      name= _life;
    } 
}
