using UnityEngine;

public class Random_script : MonoBehaviour
{
    [SerializeField] 
    float[] RandomNumber = new float[1];
    [SerializeField]
    float[] systemNumber = new float[5];
    [SerializeField]
    Color[] color = new Color[5];
    [SerializeField]
    Quaternion[] rotation = new Quaternion[5];

    void Start()
    {
        Random.seed = 1;
        for (int i = 0; i < systemNumber.Length; i++)
        {
            systemNumber[i] = Random.value;
        }
        

        for (int i = 0; i < RandomNumber.Length; i++)
        {
            RandomNumber[i] = Random.Range(1, 10);
        }

        
        for (int i = 0; i < color.Length; i++)
        {
            color[i] = Random.ColorHSV();
        }

        for (int i = 0; i < rotation.Length; i++)
        {
            rotation[i] = Random.rotation;
        }

    }
    void Update()
    {
        
    }
}
