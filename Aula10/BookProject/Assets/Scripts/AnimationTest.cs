using UnityEngine;
using System.Collections;

public class AnimationTest : MonoBehaviour
{


    [System.Serializable]
    public class ClipData
    {
        public AnimationClip Animation;
        public AudioClip Audio;
        public float AudioDelay = 0f;
        public bool AutoGoToNext;
    }
    public ClipData[] Clips;
    private int m_ClipIdx = 0;
    void Start()
    {

    }

    // Update is called once per frame

    IEnumerator PlayClip()
    {
        ClipData clip;
        do
        {
            clip = Clips[m_ClipIdx];
            GetComponentInParent<Animation>().Play(clip.Animation.name);
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.clip = clip.Audio;
                audioSource.PlayDelayed(clip.AudioDelay);
            }
            m_ClipIdx = (m_ClipIdx + 1) % Clips.Length;
            if (clip.AutoGoToNext)
            {
                yield return new WaitForSeconds(clip.Animation.length);
            }
        } while (clip.AutoGoToNext);
    }

    void OnMouseDown()
    {
        // print(name + " selecionado usando " +
        // Clips[m_ClipIdx].Animation.name);
        // // Toca a animação
        // GetComponentInParent<Animation>()
        // .Play(Clips[m_ClipIdx].Animation.name);
        // // Toca o áudio
        // AudioSource audioSource = GetComponent<AudioSource>();
        // if (audioSource != null)
        // {
        //     // Define o clipe do AudioSource
        //     audioSource.clip = Clips[m_ClipIdx].Audio;
        //     audioSource.PlayDelayed(Clips[m_ClipIdx].AudioDelay);
        // }
        // if (++m_ClipIdx >= Clips.Length)
        //     m_ClipIdx = 0;
        StartCoroutine(PlayClip());
    }

   


}
