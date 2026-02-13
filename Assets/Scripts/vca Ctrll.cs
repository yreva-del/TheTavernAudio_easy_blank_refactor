using UnityEngine;
using UnityEngine.UI;
public class NewMonoBehaviourScript : MonoBehaviour
{
    private FMOD.Studio.VCA vca;
    private Slider slider;

    [Header("Ustawienia FMOD")]
    //np. vca:/Music
    [SerializeField] private string vcaPath;
    //np. MusicVolume - pod tq nazwa zostana zapisane dane ze slidera
    [SerializeField] private string saveKey;

    [Header("Poziom Glosnosci")]
    [SerializeField] private float vcaVolume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = GetComponent <Slider>();
        vca = FMODUnity.RuntimeManager.GetVCA(vcaPath);

        float savedVolume = PlayerPrefs.GetFloat(saveKey, defaultValue: 1);
        
        vca.getVolume(out vcaVolume);
        slider.value = savedVolume;
    }

  public void SetVolume(float volume)
    {
        vca.setVolume(volume);

        PlayerPrefs.SetFloat(saveKey, volume);
    }
}
