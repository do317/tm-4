using Godot;
using System;
using System.Collections.Generic;

public partial class Inventory : Node
{
	private Dictionary<string, int> inventory = new();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		inventory["Health Potion"] = 5;
		inventory["Mana Potion"] = 3;
		inventory["Ammo Pack"] = 20;
		GD.Print("Health Potion: ", inventory["Health Potion"]);
		foreach (var pair in inventory)
		{
			GD.Print(pair.Key, " -> ", pair.Value);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
