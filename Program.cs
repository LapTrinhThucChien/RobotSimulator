using RobotSimulator.Models;
using RobotSimulator.Services;
using RobotSimulator.Utils;

Tabletop tabletop = new Tabletop(5, 5);
Robot robot = new Robot(tabletop);
CommandProcessor commandProcessor = new CommandProcessor(robot);

var commands = FileHelper.ReadCommandsFromFile("commands.txt");
commandProcessor.ProcessCommands(commands);

Console.ReadLine();