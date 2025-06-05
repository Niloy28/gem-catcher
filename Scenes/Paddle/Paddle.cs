using GemCatcher.Utility;
using Godot;

namespace GemCatcher;

public partial class Paddle : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed(InputActionNames.MoveLeft))
		{
			Position -= new Vector2(100.0f * (float)delta, 0f);
		}

		if (Input.IsActionPressed(InputActionNames.MoveRight))
		{
			Position += new Vector2(100.0f * (float)delta, 0f);
		}
	}
}
