using UnityEngine;

public class PlayerModel
{
  // string name = "Muracchi";
  string name;
  int hp;
  int at;

  // ¶¬‚³‚ê‚½‚Æ‚«‚ÉŒÄ‚Ño‚³‚ê‚é
  public PlayerModel()
  {
    name = "Murapyon";
  }

  public void SayName()
  {
    Debug.Log(name);
  }
}
