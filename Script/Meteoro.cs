using Godot;
using System;

public class Meteoro : RigidBody2D
{
	public override void _Ready()
	{
		
	}

  public override void _Process(float delta)
  {
	MoveLocalX(-2);
  }
}
