using NUnit.Framework;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mago : personaje
{
    public int wisdom;
    public int mana;
    public List<String> speels;
    public mago(string _charName, string _description, int _wisdom , int _mana) : base(_charName, _description) {
        wisdom = _wisdom;
        mana = _mana;
    }
    public mago(mago copy) : base(copy.name, copy.Description)
    {
        wisdom = copy.wisdom;
        mana = copy.mana;
    }
}
//