
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnpoint;
    public GameObject obstacle;
    void Start()
    {
        int randomindex = Random.Range(0,spawnpoint.Length);
        for(int i = 0 ; i<spawnpoint.Length; i++){
            if(randomindex!=i ){
                Instantiate(obstacle,spawnpoint[i].position, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
