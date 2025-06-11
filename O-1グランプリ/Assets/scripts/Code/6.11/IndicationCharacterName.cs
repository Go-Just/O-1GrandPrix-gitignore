using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndicationCharacterName : MonoBehaviour
{
    public AllCharacters allCharacters;
    public TextMeshProUGUI NameSpaceText;

    // Start is called before the first frame update
    void Start()
    {
        indicationCharacterName(allCharacters.AllCharacter[0]);
    }

    public void indicationCharacterName(Characters character)
    {
        NameSpaceText.text = character.Charactername;
    }
}
