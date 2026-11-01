using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public static MusicController instance;
    public AudioSource audioSource;
    public AudioClip music;

    void Start()
    {
        PlayMusicForScene();
    }
    
    void PlayMusicForScene()
    {
            audioSource.clip = music;
            audioSource.Play();
    }
}