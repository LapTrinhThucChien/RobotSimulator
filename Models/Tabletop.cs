using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.Models;
public class Tabletop
{
    private readonly int width;
    private readonly int height;

    public Tabletop(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public bool IsValidPosition(int x, int y) => x >= 0 && x < width && y >= 0 && y < height;
}