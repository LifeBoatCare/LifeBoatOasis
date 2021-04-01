using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableValuesScript : MonoBehaviour
{
    public Text logText;
    private InteractableScript interactableScript;
    private void Start() {
        interactableScript = GetComponent<InteractableScript>();
    }
    // Start is called before the first frame update
    void Update()
    {
        logText.text = "Total Used by : "+interactableScript.usedBy;
        foreach(Interaction interaction in interactableScript.interactions)
            if(interaction.interactableType != InteractableType.Close)
                logText.text += "\n Interaction Used by : "+interaction.usedBy;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        logText.transform.LookAt(Camera.main.transform.position);
        logText.transform.position = transform.position + new Vector3(0,1,0);
    }
}
