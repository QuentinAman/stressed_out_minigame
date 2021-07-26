using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Quests
{
  public class Interaction : MonoBehaviour
  {

    private Script script;

    void Start()
    {
      script = GetComponent<Script>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
      script.OpenQuest();
    }
  }
}
