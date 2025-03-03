using RobotSimulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Services;
public class CommandProcessor
{
    private readonly Robot robot;

    public CommandProcessor(Robot robot)
    {
        this.robot = robot;
    }

    public void ProcessCommands(List<string> commands)
    {
        foreach (var command in commands)
        {
            var parts = command.Split(' ');
            switch (parts[0])
            {
                case "PLACE":
                    HandlePlace(parts);
                    break;
                case "MOVE":
                    robot.Move();
                    break;
                case "LEFT":
                    robot.TurnLeft();
                    break;
                case "RIGHT":
                    robot.TurnRight();
                    break;
                case "REPORT":
                    robot.Report();
                    break;
            }
        }
    }

    private void HandlePlace(string[] parts)
    {
        if (parts.Length < 2) return;

        var args = parts[1].Split(',');
        if (args.Length < 3) return;

        if (int.TryParse(args[0], out int x) &&
            int.TryParse(args[1], out int y) &&
            !string.IsNullOrEmpty(args[2]))
        {
            robot.Place(x, y, args[2]);
        }
    }
}
