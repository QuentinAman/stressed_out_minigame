using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Quests
{
  public class MiniGame : MonoBehaviour
  {

    public delegate void OnClose();
    public delegate void OnFinished();

    public event OnClose close;
    public event OnFinished finished;

    public Button closeButton;

    protected AudioSource gameAudio;

    virtual protected void Awake()
    {
      closeButton.onClick.AddListener(Close);
      gameAudio = GetComponent<AudioSource>();
    }

    public void Open()
    {
      gameObject.SetActive(true);
      PlayerController.player.Disable();
    }

    public void Close()
    {
      close?.Invoke();
      gameObject.SetActive(false);
      PlayerController.player.Enable();
    }

    public void Finish()
    {
      PlayerController.player.Enable();
      finished?.Invoke();
      gameObject.SetActive(false);
    }
  }
}
