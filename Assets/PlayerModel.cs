using UnityEngine;

public class PlayerModel
{
  // string name = "Muracchi";
  string name;
  int hp;
  int at;

  // 生成されたときに呼び出される
  public PlayerModel()
  {
    name = "Murapyon";
  }

  public void SayName()
  {
    Debug.Log(name);
  }
}
