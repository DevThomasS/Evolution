﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {
    private string name;                // The name of the node
    private int[] herbivoreFoodSource;  // i == 0 berries, i == 1 nuts, i == 2 grass, i == 3 leaves, 0 (default) means speceis cannot eat food type at given index
    private int carnivoreFoodSource;    // integer between 1 and 500 that limits what size prey you can eat, -1 (default) means species cannot eat meat
    private int amntCalories;           // amount of food to survive
    private int creatureSize;           // 1 is tiny, 2 - 100 is small, 101 - 200 is medium, 201 - 300 is large, 301 - 400 is humongous
    private int maxPerTile;             // max number of individuals of a species in a given tile, -1 is unlimited
    private int litterSize;             // population growth per reproduction
    private int matingFrequency;        // reproduction speed
    private int mateAttachment;         // mutation chance v offspring survivability
    private int peckingOrder;           // determines when the species eats in the eating algorithm

    public Node(string name)
    {
        this.name = name;
        this.herbivoreFoodSource = new int[4];
        this.carnivoreFoodSource = 0;
        this.amntCalories = 0;
        this.creatureSize = 0;
        this.maxPerTile = 0;
        this.litterSize = 0;
        this.matingFrequency = 0;
        this.mateAttachment = 0;
        this.peckingOrder = 0;
    }

    public Node(string name, int[] herbivoreFoodSource, int carnivoreFoodSource, int amntCalories, int creatureSize, int maxPerTile, int litterSize, int matingFrequency, int mateAttachment, int peckingOrder)
    {
        this.name = name;
        this.herbivoreFoodSource = herbivoreFoodSource;
        this.carnivoreFoodSource = carnivoreFoodSource;
        this.amntCalories = amntCalories;
        this.creatureSize = creatureSize;
        this.maxPerTile = maxPerTile;
        this.litterSize = litterSize;
        this.matingFrequency = matingFrequency;
        this.mateAttachment = mateAttachment;
        this.peckingOrder = peckingOrder;
    }

    public string getName()
    {
        return name;
    }
    public int[] getHerbivoreFoodSource()
    {
        return herbivoreFoodSource;
    }
    public int getCarnivoreFoodSource()
    {
        return carnivoreFoodSource;
    }
    public int getAmntCalories()
    {
        return amntCalories;
    }
    public int getCreatureSize()
    {
        return creatureSize;
    }
    public int getMaxPerTile()
    {
        return maxPerTile;
    }
    public int getLitterSize()
    {
        return litterSize;
    }
    public int getMatingFrequency()
    {
        return matingFrequency;
    }
    public int getMateAttachment()
    {
        return mateAttachment;
    }
    public int getPeckingOrder()
    {
        return peckingOrder;
    }
}
