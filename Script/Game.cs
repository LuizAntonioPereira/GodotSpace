using Godot;
using System;

public class Game : Node
{
	public RigidBody2D player;
	private int score;
	private Godot.Vector2 speed = new Godot.Vector2(0, -1000);
	private PackedScene Meteoro = ResourceLoader.Load("res://Cena/Meteoro.tscn") as PackedScene;
	Random rnd = new Random();
	public Label scoretext;
	
	public override void _Ready()
	{
		player = GetNode("Player") as RigidBody2D;
		scoretext = (Label) GetNode("Score");
		score = 0;
		scoretext.Text = score.ToString();
	}

	public override void _Process(float delta)
	{
		if(Godot.Input.IsActionJustPressed("ui_accept")){
			player.SetLinearVelocity(speed);
		}
		
		score ++;
		scoretext.Text = score.ToString();
	}
	private void _on_Spawner_timeout()
	{
		int n = rnd.Next(1,5);
		
		Godot.RigidBody2D e = Meteoro.Instance() as Godot.RigidBody2D;
		AddChild(e);
		e.SetPosition(new Vector2(800,375 + n * 140));
	}
	private void _on_Player_body_entered(object body)
	{
		GetTree().ChangeScene("res://Cena/GameOver.tscn"); 
	}
}
