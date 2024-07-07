using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reinicio : MonoBehaviour
{ public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            {
                StartCoroutine(SceneLoad(1));
            }
        }
    }
            public IEnumerator SceneLoad(int sceneindex)

            {
                transition.SetTrigger("START");
                yield return new WaitForSeconds(1f);
                SceneManager.LoadScene(sceneindex);
            }
    
}
