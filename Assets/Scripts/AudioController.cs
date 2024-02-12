using System.Collections;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _clips;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AudioControllerSettings());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator AudioControllerSettings()
    {
        foreach (var clip in _clips)
        {
            _audioSource.clip = clip;
            _audioSource.Play();
            yield return new WaitForSeconds(clip.length);
        }
    }
}
