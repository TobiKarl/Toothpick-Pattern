using System;
using System.Collections.Generic;
using System.Drawing;

public class Toothpick
{
    public Point PtA { get; }
    public Point PtB { get; }
    public Point Center { get; }
    private readonly Point[] Points;
    public bool Horizontal { get; }
    public bool IsNew { get; set; } = true;
    private readonly int length;
        
	public Toothpick(int startX, int startY, int length, bool horizontal)
	{
        int ax, ay, bx, by;
        this.Horizontal = horizontal;
        this.length = length;
        if (horizontal)
        {
            ay = by = startY;
            ax = startX - (length / 2);
            bx = ax + length;
        }
        else
        {
            ax = bx = startX;
            ay = startY - (length / 2);
            by = ay + length;
        }

        PtA = new Point(ax, ay);
        PtB = new Point(bx, by);
        int cenX = (PtA.X + PtB.X) / 2;
        int cenY = (PtA.Y + PtB.Y) / 2;
        Center = new Point(cenX, cenY);
        Points = new Point[] { PtA, PtB, Center };
	}

    public void addToOpenEnds(List<Toothpick> toothpicks, List<Toothpick> newToothpicks)
    {
        var aIsOpen = true;
        var bIsOpen = true;

        foreach(Toothpick tpick in toothpicks)
        {
            if (tpick==this||
                Math.Abs(tpick.Center.X - this.Center.X) >= 30 ||
                Math.Abs(tpick.Center.Y - this.Center.Y) >= 30)
                continue;

            if (aIsOpen && Array.IndexOf(tpick.Points, this.PtA) > -1)
            {
                aIsOpen = false;
                if (!bIsOpen) break;
            }

            if (bIsOpen && Array.IndexOf(tpick.Points, this.PtB) > -1)
            {
                bIsOpen = false;
                if (!aIsOpen) break;
            }
        }

        if (aIsOpen)
            newToothpicks.Add(new Toothpick(this.PtA.X, this.PtA.Y, this.length, !this.Horizontal));
        if (bIsOpen)
            newToothpicks.Add(new Toothpick(this.PtB.X, this.PtB.Y, this.length, !this.Horizontal));
    }

}
