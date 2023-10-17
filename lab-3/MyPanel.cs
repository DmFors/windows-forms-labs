/// <summary>
/// Панель, использующая двойной буфер
/// </summary>
public class MyPanel : Panel
{
    public MyPanel()
    {
        this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
    }
}
