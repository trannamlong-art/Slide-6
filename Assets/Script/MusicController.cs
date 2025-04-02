using UnityEngine;
using UnityEngine.UI;

public class MusicController : MonoBehaviour
{
    public Slider musicSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("volBucket"))
        {
            LoadVolume();
        }
        else
        {
            PlayerPrefs.SetFloat("volBucket", 0.5f);
            LoadVolume();
        }
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volBucket", musicSlider.value);
        PlayerPrefs.Save();
    }
    public void LoadVolume()
    {
        PlayerPrefs.SetFloat("volBucket", musicSlider.value );
        SetVolume();
    }
    public void SetVolume()
    {
        AudioListener.volume = musicSlider.value;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
