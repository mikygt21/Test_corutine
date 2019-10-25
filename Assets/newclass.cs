using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NomUnityClass
{
    bool running = false;

    TextMeshProUGUI textToChange;
    public NomUnityClass(ref TextMeshProUGUI txt)
    {
        textToChange = txt;
    }

    public IEnumerator ChangeText()
    {
        if(running)
            yield break;        //parar corutina

        running = true;         

        int maxChar = textToChange.text.Length;
        textToChange.maxVisibleCharacters = 0;
        int characters = 0;

        

        while(characters<maxChar)
        {
            characters++;
            textToChange.maxVisibleCharacters = characters;
            yield return new WaitForSeconds(0.1f);
        }
        running = false;
    }

}
