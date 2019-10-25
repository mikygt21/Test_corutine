using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_behaviour : MonoBehaviour
{
    [SerializeField]        //permet visualitzar variables privades a l'inspector
    private TextMeshProUGUI text;
    int a = 10;
    float b = 5f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("vida", -1); //si no troba vida, retorna -1
        PlayerPrefs.SetInt("vida", 10); //guarda les variables fora de unity
        PlayerPrefs.DeleteKey("vida");

        NomUnityClass hey = new NomUnityClass(ref text);
        StartCoroutine(hey.ChangeText());
        
    }

  
    /*
    IEnumerator WriteText()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(text.text);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(1f);
    }                                           //posar operacions complicades en coroutines pot reduir els FPS
    */


}
