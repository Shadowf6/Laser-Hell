using UnityEngine;
using Settings;

public class LoadPlayerSkin : MonoBehaviour
{
    public GameObject player;
    SpriteRenderer sprite;
    string skin;

    void Start()
    {
        sprite = player.GetComponent<SpriteRenderer>();
        AssignSkin();
    }

    void AssignSkin()
    {
        int skin = LoadOptions.GetSetting("skin");
        Sprite skinSprite = Resources.Load<Sprite>("Sprites/" + skin.ToString());
        sprite.sprite = skinSprite;

        switch (skin)
        {
            case 0:
                player.transform.localScale = new Vector3(1f, 1f, 1f); break;
            case 1:
                player.transform.localScale = new Vector3(2f, 2f, 2f); break;
        }
    }
}
