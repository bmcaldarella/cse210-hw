// Fraction.cs

public class Fraction
{
    // Atributos privados para los números superior e inferior
    private int _top;
    private int _bottom;

    // Constructor que inicializa el número a 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor que tiene un parámetro para la parte superior y que inicializa el denominador a 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Constructor que tiene dos parámetros, uno para la parte superior y otro para la parte inferior
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Métodos getters y setters para los atributos privados
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
}
