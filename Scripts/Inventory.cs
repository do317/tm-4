using Godot;
using System;
using System.Collections.Generic;

public partial class Inventory : Node
{
	private Dictionary<string, int> inventory = new();
	Godot.Collections.Dictionary saveData = new();



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		saveData["player_name"] = "Anna"; 
		saveData["level"] = 5;
		if (saveData.ContainsKey("player_name"))
		{
			GD.Print("Spēlētājs: ", saveData["player_name"], ", līmenis: ", saveData["level"]);
		}
		inventory["Health Potion"] = 5;
		inventory["Mana Potion"] = 3;
		inventory["Ammo Pack"] = 20;
		if(inventory.TryGetValue("Health Potion", out int amount)) { GD.Print("Atrasts: ", amount)}

 		GD.Print("Health Potion: ", GetAmount("Health Potion"));
 		GD.Print("Shield: ", GetAmount("Shield"));
 		GD.Print("inv.count: ", inventory.Count);
 		GD.Print("Mana Potion: ", GetAmount("Mana Potion"));
 		GD.Print("Ammo Pack: ", GetAmount("Ammo Pack"));

		foreach (var pair in inventory)
		{
			GD.Print(pair.Key, " -> ", pair.Value);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public int GetAmount(string name)
	{
		if (inventory.TryGetValue(name, out int amount))
			return amount;
		return 0;
	}
}
