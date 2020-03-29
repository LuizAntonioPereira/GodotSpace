using Godot;
using System;

public class GameOver : Node
{
	public override void _Ready()
	{
		
	}
	private void _on_BtnReiniciar_pressed()
	{
		GetTree().ChangeScene("res://Cena/Game.tscn");
	}
	private void _on_BtnMenu_pressed()
	{
		GetTree().ChangeScene("res://Cena/Menu.tscn");
	}
}
