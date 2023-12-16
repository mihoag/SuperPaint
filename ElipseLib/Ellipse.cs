using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Contract;
using MaterialDesignThemes.Wpf;
using AdornerLib;

namespace EllipseLib;

public class EllipseShape  : IShape
{
    private Point2D _start = new Point2D();
    private Point2D _end = new Point2D();

    private Ellipse _ellipse = null;
    private Ellipse _ellipseFinal = new Ellipse();
    private Canvas _canvas;

    public string Name =>  "Ellipse";
    //
    public int IconKind => (int)PackIconKind.EllipseOutline;
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
        if (_ellipse != null)
        {
            _ellipse.Focusable = true;
            _ellipse.Focus();
            currAdnr = new RectangleAdorner(_ellipse);
            adnrLayer.Add(currAdnr);
        }
    }

    public void HandleMove(double x, double y)
    {
        _end = new Point2D() { X = x, Y = y };
        _ellipse = new Ellipse();
    }

    public void HandleHoldShift(double x, double y)
    {
        double diff = Math.Abs(_end.X - _start.X) - Math.Abs(_end.Y - _start.Y);
        if (diff > 0)
        {
            _end = new Point2D() { X = x, Y = _start.Y };
            _ellipse = new Ellipse();
        }
        else
        {
            _end = new Point2D() { X = _start.X, Y = y };
            _ellipse = new Ellipse();
        }
    }

    public void Draw(Canvas canvas)
    {
        _canvas = canvas;

        if (_ellipse != null)
        {
            //_line = new Line();
            _ellipse.Width = Math.Abs(_start.X - _end.X);
            _ellipse.Height = Math.Abs(_start.Y -_end.Y) ;
            _ellipse.StrokeThickness = s_mThickness;
            _ellipse.Stroke = s_mColor;
            _ellipse.StrokeDashArray = s_Outline;
            _ellipse.LostFocus += Ellipse_LostFocus;

            Canvas.SetLeft(_ellipse, _start.X);
            Canvas.SetTop(_ellipse,  _start.Y);

            _canvas.Children.Add(_ellipse);
            adnrLayer = AdornerLayer.GetAdornerLayer(canvas);
        }

         canvas.Children.Add(_ellipseFinal);
    }

    private void Ellipse_LostFocus(object sender, RoutedEventArgs e)
    {
        if (_ellipse != null)
        {
            _ellipseFinal.Width = _ellipse.Width;
            _ellipseFinal.Height = _ellipse.Height;
            _ellipseFinal.Stroke = s_mColor;
            _ellipseFinal.StrokeThickness = s_mThickness;
            _ellipseFinal.StrokeDashArray = s_Outline;
            Canvas.SetLeft(_ellipseFinal, _start.X);
            Canvas.SetTop(_ellipseFinal, _start.Y);

           // _canvas.Children.Add(_rectangleFinal);
        }
        _canvas.Children.Remove(_ellipse);
        _ellipse = null;
    }

    public IShape Clone()
    {
        return new EllipseShape();
    }
}
