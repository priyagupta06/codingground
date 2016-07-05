using System.IO;
using System;


// Item Class with attributes Quanity, ItemName and Cost
public class Item
{
    public int Quantity;
    public string ItemName;
    public int Cost;

    // Constructor for Item Class for setting ItemName, Quantity and Cost
    public Item(string ItemName, int Quantity)
    {
        this.ItemName = ItemName;
        
        if(ItemList.itemlist.ContainsKey(ItemName))
        {
            Cost = (int)ItemList.itemlist[ItemName];
        }
        else
        {
            Cost = 0;
        }
        
        this.Quantity = Quantity;

    }
    

  
 
}
 