using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Utils;
public static class FileHelper
{
    public static List<string> ReadCommandsFromFile(string filePath)
    {
        List<string> commands = new List<string>();
        if (File.Exists(filePath))
        {
            commands.AddRange(File.ReadAllLines(filePath));
        }
        else
        {
            Console.WriteLine("Command file not found!");
        }
        return commands;
    }
}
