using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitBeforeTitle : MonoBehaviour
{
    // Start is called before the first frame update
    public string sceneToChangeTo = "titleScene";
    public float delay = 3;
    public void Start()
    {

        ChangeToScene(sceneToChangeTo);

        void ChangeToScene(string sceneToChangeTo)
        {
            StartCoroutine(DoChangeScene(sceneToChangeTo, 4f));
        }
        IEnumerator DoChangeScene(string sceneToChangeTo, float delay)
        {
            yield return new WaitForSeconds(delay);
           // Application.LoadLevel(sceneToChangeTo);
            SceneManager.LoadScene(sceneToChangeTo);
        }

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void ChangeToScene(string sceneToChangeTo)
    {
    }
}
