using Godot;
using System;

// Author: Kovaleva E.

/// <summary>
/// Класс LabelHP создает и выводит надпись над игроком, постоянно ее обновляя при
/// изменении количества HP.
/// </summary>
public partial class LabelHP : Godot.Label

{
	[Export] Player _player;
	public override void _Ready()
	{
		_player = (Player)GetParent();
		
	}
	public override void _Process(double delta)
	{
		Text = $"HP: {_player.Health}";
		
	}
}
