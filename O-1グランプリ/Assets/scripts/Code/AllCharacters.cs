using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.AddressableAssets;

public class AllCharacters : MonoBehaviour
{
    public List<Characters> AllCharacter;

    async void Start()
    {
        AllCharacter = new List<Characters>();
        
        await CharacterLoad();

        foreach(var Chara in AllCharacter){
            Debug.Log(Chara.Charactername);
        }
    }

    public async Task CharacterLoad(){
        var handle = Addressables.LoadAssetsAsync<Characters>("geininn", character =>
        {
            AllCharacter.Add(character);
        });
        await handle.Task;
    }
}
