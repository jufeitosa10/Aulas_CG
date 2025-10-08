using UnityEngine;

public class AnimationTest: MonoBehaviour
{


    [System.Serializable]
    public class ClipData
    {
        public AnimationClip Animation;
        public AudioClip Audio;
        public float AudioDelay = 0f;
    }   
    public ClipData[] Clips;
    private int m_ClipIdx = 0; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown () {
        print (name + " selecionado usando " +
        Clips[m_ClipIdx].Animation.name);
        // Toca a animação
        GetComponentInParent<Animation>()
        .Play(Clips[m_ClipIdx].Animation.name);
        // Toca o áudio
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null) {
        // Define o clipe do AudioSource
            audioSource.clip = Clips[m_ClipIdx].Audio;
            audioSource.PlayDelayed(Clips[m_ClipIdx].AudioDelay);
        }
        if(++m_ClipIdx >= Clips.Length)
            m_ClipIdx = 0;
    }


}
