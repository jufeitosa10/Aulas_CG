using UnityEngine;

public class SimpleRotateToggle: MonoBehaviour
{

    public float Degrees = 100f;
    private bool mRotationState = true; // Esta variável mantém o controle do estado da rotação (se ele está desligada ou ligada); 


    void Update()
    {

   
        if (mRotationState) {
        // se o estado é 1, gire
        transform.Rotate (0f, Degrees * Time.deltaTime, 0f);
        }


    }
    
    void OnMouseDown () {
        mRotationState = !mRotationState;
        print("State = " + mRotationState);
    }


}
