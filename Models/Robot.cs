using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Models;
public class Robot
{
    private int x, y;
    private string facing;
    private readonly Tabletop tabletop;
    private static readonly string[] directions = { "NORTH", "EAST", "SOUTH", "WEST" };

    public Robot(Tabletop tabletop)
    {
        this.tabletop = tabletop;
        x = -1;
        y = -1;
        facing = string.Empty;
    }

    public void Place(int x, int y, string facing)
    {
        if (tabletop.IsValidPosition(x, y) && Array.Exists(directions, dir => dir == facing))
        {
            this.x = x;
            this.y = y;
            this.facing = facing;
        }
    }

    public void Move()
    {
        if (!IsPlaced()) return;

        int newX = x, newY = y;
        switch (facing)
        {
            case "NORTH": newY++; break;
            case "EAST": newX++; break;
            case "SOUTH": newY--; break;
            case "WEST": newX--; break;
        }

        if (tabletop.IsValidPosition(newX, newY))
        {
            x = newX;
            y = newY;
        }
    }

    public void TurnLeft()
    {
        if (!IsPlaced()) return;
        int index = Array.IndexOf(directions, facing);
        facing = directions[(index + 3) % 4]; // Rotate 90° counter-clockwise
    }

    public void TurnRight()
    {
        if (!IsPlaced()) return;
        int index = Array.IndexOf(directions, facing);
        facing = directions[(index + 1) % 4]; // Rotate 90° clockwise
    }

    public void Report()
    {
        if (IsPlaced())
            Console.WriteLine($"{x},{y},{facing}");
    }

    private bool IsPlaced() => !string.IsNullOrEmpty(facing);
}
