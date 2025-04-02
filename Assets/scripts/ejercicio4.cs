using UnityEngine;

public class personaje : MonoBehaviour
{
    #region Private 

    private string charName;
    private string description;
    #endregion
    #region Getters

    public string CharName=> charName;
    public string Description=>description;
    #endregion

    #region Constructors
    public personaje() {
        charName = "null";
        description = "null";
    }
 
    public personaje(string _charName, string _description) {
        charName = _charName;
        charName = _description;
    }

    
    public void OnDestroy()
    {
        print("Me han destruido zhasbot!") ;
    }
    #endregion
    #region Methods
    #endregion

}