using System.Collections.Generic;
using UnityEngine;

namespace SoldierCubeGame
{
    public class SwappableCharacterManager : MonoBehaviour, ISwap
    {
        [SerializeField] GameObject[] characterPrefabs;

        List<GameObject> spawnedCharacters = new List<GameObject>();

        int currentPrefabCount = 0;

        private void OnEnable()
        {
            RayCastTargetSpawner.ScreenTouched += PopulateCharacterArray;
        }
        private void OnDisable()
        {
            RayCastTargetSpawner.ScreenTouched -= PopulateCharacterArray;
        }

        void PopulateCharacterArray()
        {
            GetSpawnedCharacters<RedSoldier>();
            GetSpawnedCharacters<BlueSoldier>();
            GetSpawnedCharacters<GreenSoldier>();
        }
        
        void GetSpawnedCharacters<T>() where T : SoldierBase
        {
            T[] characters = FindObjectsOfType<T>();
            foreach (T npc in characters)
            {
                spawnedCharacters.Add(npc.gameObject);
            }
        }
        
        public void SwapCharacters()
        {
            if (characterPrefabs != null)
            {

                for (int i = 0; i < spawnedCharacters.Count; i++)
                {
                    Transform transform = spawnedCharacters[i].transform;

                    spawnedCharacters[i] = Instantiate(characterPrefabs[Random.Range(0, 
                        currentPrefabCount)], transform.position, Quaternion.identity);

                    Destroy(transform.gameObject);

                }
                    if (currentPrefabCount == spawnedCharacters.Count - 1)
                        currentPrefabCount = 0;
                    else
                        currentPrefabCount++;
            }
        }
    }
}