using System.Collections.Generic;
using Godot;
using System;

public partial class EnemyListDemo : Node
{
	private List<Enemy> enemies = new();
	Godot.Collections.Array bullets = new();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		bullets.Add(1);
		bullets.Add("abraca");
		GD.Print(bullets.Count);
		bullets.RemoveAt(bullets.Count - 1);

		enemies.Add(new Enemy());
		enemies.Add(new Enemy());
		enemies.Add(new Enemy());
		enemies.RemoveAt(1);
		foreach (Enemy enemy in enemies)
		{
			GD.Print(enemy.Name);
		}
		List<Enemy> toRemove = new();
		foreach (Enemy enemy in enemies)
		{
			if (enemy == enemies[0]) toRemove.Add(enemy);
		}
		foreach (Enemy enemy in toRemove)
		{
			enemies.Remove(enemy);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
