using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Contract;
using MaterialDesignThemes.Wpf;
using AdornerLib;

namespace Paint;

public class Line2D : IShape
{
    private Point2D _start = new Point2D();
    private Point2D _end = new Point2D();

    private Line _line = null;
    private Line _lineFinal = new Line();
    private Canvas _canvas;

    public string Name => "Line";
    public int IconKind => (int)PackIconKind.VectorLine;
    public Brush s_mColor { get; set; }
    public Brush s_sColor { get; set; }
    public int s_mThickness { get; set; }
    public DoubleCollection s_Outline { get; set; }
    public Brush s_Fill { get; set; }
    public FontFamily s_FontFamily { get; set; }
    public double s_FontSize { get; set; }
    public FontWeight s_FontWeight { get; set; }
    public FontStyle s_FontStyle { get; set; }
    public int s_TextDecoration { get; set; }
    public Adorner currAdnr { get; set; }
    public AdornerLayer adnrLayer { get; set; }

    RotateTransform rotateTransform = new RotateTransform();

    public void HandleStart(double x, double y)
    {
        _start = new Point2D() { X = x, Y = y };
    }

    public void HandleEnd(double x, double y)
    {
        _end = new Point2D() { X = x, Y = y };
        if (_line != null)
        {
            _line.Focusable = true;
            _line.Focus();
            currAdnr = new LineAdorner(_line);
            adnrLayer.Add(currAdnr);
        }
    }

    public void HandleMove(double x, double y)
    {
        _end = new Point2D() { X = x, Y = y };
        _line = new Line();
    }

    public void HandleHoldShift(double x, double y)
    {
        double diff = Math.Abs(_end.X - _start.X) - Math.Abs(_end.Y - _start.Y);
        if (diff > 0)
        {
            _end = new Point2D() { X = x, Y = _start.Y };
            _line = new Line();
        }
        else
        {
            _end = new Point2D() { X = _start.X, Y = y };
            _line = new Line();
        }
    }

    public void Draw(Canvas canvas)
    {
        _canvas = canvas;

        if (_line != null)
        {
            //_line = new Line();
            _line.X1 = _start.X;
            _line.Y1 = _start.Y;
            _line.X2 = _end.X;
            _line.Y2 = _end.Y;
            _line.StrokeThickness = s_mThickness;
            _line.Stroke = s_mColor;
            _line.StrokeDashArray = s_Outline;
            _line.LostFocus += Line_LostFocus;

            canvas.Children.Add(_line);
            adnrLayer = AdornerLayer.GetAdornerLayer(canvas);
        }

        canvas.Children.Add(_lineFinal);
    }

    private void Line_LostFocus(object sender, RoutedEventArgs e)
    {
        if (_line != null)
        {
            _lineFinal.X1 = _line.X1;
            _lineFinal.X2 = _line.X2;
            _lineFinal.Y1 = _line.Y1;
            _lineFinal.Y2 = _line.Y2;
            _lineFinal.Stroke = s_mColor;
            _lineFinal.StrokeThickness = s_mThickness;
            _lineFinal.StrokeDashArray = s_Outline;
        }
        _canvas.Children.Remove(_line);
        _line = null;
    }

    public IShape Clone()
    {
        return new Line2D();
    }
}
