using UnityEngine;

public class PlayerModel
{
  // string name = "Muracchi";
  string name;
  int hp;
  int at;

  // �������ꂽ�Ƃ��ɌĂяo�����
  public PlayerModel()
  {
    name = "Murapyon";
  }

  public void SayName()
  {
    Debug.Log(name);
  }
}
