using System;

public class Toothpick
{
    public Point start, end;
    public Boolean newPick = true;
    public bool horizontal;

        
	public Toothpick(int startX, int startY, int endX, int endY, bool horizontal)
	{
        this.startX = startX;
        this.startY = startY;
        this.endX = endX;
        this.endY = endY;
        this.horizontal = horizontal;
	}

}
