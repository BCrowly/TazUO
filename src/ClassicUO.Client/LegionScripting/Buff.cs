using ClassicUO.Game.Data;

namespace ClassicUO.LegionScripting;

public struct Buff
{
    public Buff(BuffIcon icon)
    {
        Type = icon.Type;
        Graphic = icon.Graphic;
        Timer = icon.Timer;
        Text = icon.Text;
        Title = icon.Title;
    }
    
    public readonly ushort Graphic;

    public readonly string Text;

    public readonly long Timer;

    public readonly BuffIconType Type;

    public readonly string Title;
}