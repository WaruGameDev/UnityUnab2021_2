using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassCat : MonoBehaviour
{
    public List<Sprite> catsSprites;
    public SpriteRenderer theSprite;
    public enum CLASS_CAT
    {
        NORMAL,
        SAMURAI,
        VAQUERO,
        IDOL

    }
    public CLASS_CAT classCat;
    
    public void ChangeClassCat(CLASS_CAT newClass)
    {
        classCat = newClass;
        theSprite.sprite = catsSprites[(int)classCat];

        //switch(classCat)
        //{
        //    case CLASS_CAT.NORMAL:
        //        theSprite.sprite = catsSprites[0];
        //        break;
        //    case CLASS_CAT.SAMURAI:
        //        theSprite.sprite = catsSprites[1];
        //        break;
        //    case CLASS_CAT.VAQUERO:
        //        theSprite.sprite = catsSprites[2];
        //        break;
        //}
    }
}
