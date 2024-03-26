using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExCharcterManager : MonoBehaviour
{
    public List<ExCharacter> characterList = new List<ExCharacter>();

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i = 0; i < characterList.Count; i++)
            {
                characterList[i].OnDestroyCharacter();
            }
        }
    }
}
