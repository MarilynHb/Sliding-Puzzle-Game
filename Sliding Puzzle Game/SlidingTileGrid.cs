namespace Sliding_Puzzle_Game;
public class SlidingTileGrid : GraphicsView, IDrawable
{
    private Microsoft.Maui.Graphics.IImage? image;
    private float imageHeight;
    private float imageWidth;
    private int horizontalTileCount;
    private int verticalTileCount;
    private float tileHeight;
    private float tileWidth;

    private readonly IList<Tile> tiles = new List<Tile>();
    private EmptyTile? emptyTile;

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        foreach (var tile in this.tiles)
        {
            // Save and then reset the state of the canvas ahead of allowing a tile to draw.
            canvas.SaveState();
            canvas.ResetState();

            tile.Draw(canvas);

            // Restore back to the original saved state to avoid any left over state from the last tiles drawing.
            canvas.RestoreState();
        }
    }


}
