using UnityEngine;

public interface IMision {
    public void OnAccept();
    public void OnComplete();
    public void OnFailure();
}

public enum MissionState { 
    Unvalible,
    Avalibre,
    OnProgress,
    Compleated
}
public class misionMnager : MonoBehaviour
{
    private string missionName;
    private string missionDescription;

    private MissionState missionState = MissionState.Avalibre;
}
