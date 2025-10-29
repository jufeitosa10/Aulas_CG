using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown() {
        GetComponent<Animator>().SetTrigger("selectedTrigger");
    }

    void PlaySound(UnityEngine.Object clip) {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = (AudioClip)clip;
        AnimatorStateInfo state = GetComponent<Animator>()
        .GetCurrentAnimatorStateInfo(0);
        audioSource.pitch = state.speed * state.speedMultiplier;
        if (audioSource.pitch < 0) {
            audioSource.time = audioSource.clip.length - 0.01f;
        }
        audioSource.Play();
    }

    void Die()
    {
        GameObject.Destroy(gameObject);
    }


}
