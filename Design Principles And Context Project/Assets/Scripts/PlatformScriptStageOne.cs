using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PlatformScriptStageOne : MonoBehaviour
{
    public GameObject Prefab;
    public Transform SpawnPosition;
    public ItemCountScript itemCountScript;

    private void Update()
    {
        if (itemCountScript.itemCount == 1f)
        {
            SpawnPlatform();
        }
    }

    public void SpawnPlatform()
    {
        Instantiate(Prefab, SpawnPosition.position, SpawnPosition.rotation);
        Destroy(gameObject);
    }
        
}
