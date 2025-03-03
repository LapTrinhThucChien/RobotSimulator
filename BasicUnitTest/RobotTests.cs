using NUnit.Framework;
using RobotSimulator.Models;
using RobotSimulator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator.BasicUnitTest;
[TestFixture]
public class RobotTests
{
    private Tabletop _tabletop;
    private Robot _robot;

    [SetUp] 
    public void Setup()
    {
        _tabletop = new Tabletop(5, 5);
        _robot = new Robot(_tabletop);
    }

    [Test]
    public void Robot_Should_Move_Correctly()
    {
        _robot.Place(0, 0, "NORTH");
        _robot.Move();
        Assert.That(GetReport(), Is.EqualTo("0,1,NORTH"));
    }

    [Test]
    public void Robot_Should_Not_Move_Out_Of_Bounds()
    {
        _robot.Place(0, 0, "SOUTH");
        _robot.Move();
        Assert.That(GetReport(), Is.EqualTo("0,0,SOUTH"));
    }

    [Test]
    public void Robot_Should_Turn_Left_Correctly()
    {
        _robot.Place(0, 0, "NORTH");
        _robot.TurnLeft();
        Assert.That(GetReport(), Is.EqualTo("0,0,WEST"));
    }

    [Test]
    public void Robot_Should_Turn_Right_Correctly()
    {
        _robot.Place(0, 0, "NORTH");
        _robot.TurnRight();
        Assert.That(GetReport(), Is.EqualTo("0,0,EAST"));
    }

    [Test]
    public void Robot_Should_Ignore_Invalid_Place_Commands()
    {
        _robot.Place(-1, -1, "NORTH");
        Assert.That(GetReport(), Is.EqualTo(""));
    }

    private string GetReport()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            _robot.Report();
            return sw.ToString().Trim();
        }
    }
}
