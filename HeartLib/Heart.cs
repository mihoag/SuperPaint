using Contract;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;
using AdornerLib;

namespace HeartLib;

public class Heart : IShape
{
    private Point2D _leftTop = new Point2D();
    private Point2D _rightBottom = new Point2D();

    private Path _heart = null;
    private Path _heartFinal = new Path();
    private Canvas _canvas;

    public string Name => "Heart";

    public int IconKind => (int)PackIconKind.HeartOutline;
    public Brush s_mColor
    {
        get; set;
    }
    public Brush s_sColor
    {
        get; set;
    }
    public int s_mThickness
    {
        get; set;
    }
    public DoubleCollection s_Outline
    {
        get; set;
    }
    public FontFamily s_FontFamily
    {
        get; set;
    }
    public double s_FontSize
    {
        get; set;
    }
    public int s_Style
    {
        get; set;
    }
    public Brush s_Fill
    {
        get; set;
    }
    public Adorner currAdnr
    {
        get; set;
    }
    public AdornerLayer adnrLayer
    {
        get; set;
    }
    public FontWeight s_FontWeight { get; set; }
    public FontStyle s_FontStyle { get; set; }
    public int s_TextDecoration { get; set; }

    RotateTransform rotateTransform = new RotateTransform();

    public void HandleStart(double x, double y)
    {
        _leftTop = new Point2D() { X = x, Y = y };
    }

    public void HandleEnd(double x, double y)
    {
        if (_heart != null)
        {
            _heart.Focusable = true;
            _heart.Focus();
            currAdnr = new RectangleAdorner(_heart);
            adnrLayer.Add(currAdnr);
        }
    }

    public void HandleMove(double x, double y)
    {
        _rightBottom = new Point2D() { X = x, Y = y };
        _heart = new Path();
    }

    public void HandleHoldShift(double x, double y)
    {
        double _width = Math.Abs(x - _leftTop.X);
        double _height = Math.Abs(y - _leftTop.Y);
        double diff = _width < _height ? _width : _height;

        if (_rightBottom.X > _leftTop.X && _rightBottom.Y > _leftTop.Y)
        {
            if (_width > _height)
            {
                _rightBottom = new Point2D() { X = _leftTop.X + diff, Y = y };
            }
            else
            {
                _rightBottom = new Point2D() { X = x, Y = _leftTop.Y + diff };
            }
        }
        else if (_rightBottom.X > _leftTop.X && _rightBottom.Y < _leftTop.Y)
        {
            if (_width > _height)
            {
                _rightBottom = new Point2D() { X = _leftTop.X + diff, Y = y };
            }
            else
            {
                _rightBottom = new Point2D() { X = x, Y = _leftTop.Y - diff };
            }
        }
        else if (_rightBottom.X < _leftTop.X && _rightBottom.Y > _leftTop.Y)
        {
            if (_width > _height)
            {
                _rightBottom = new Point2D() { X = _leftTop.X - diff, Y = y };
            }
            else
            {
                _rightBottom = new Point2D() { X = x, Y = _leftTop.Y + diff };
            }
        }
        else
        {
            if (_width > _height)
            {
                _rightBottom = new Point2D() { X = _leftTop.X - diff, Y = y };
            }
            else
            {
                _rightBottom = new Point2D() { X = x, Y = _leftTop.Y - diff };
            }
        }
        _heart = new Path();
    }

    public void Draw(Canvas canvas)
    {
        _canvas = canvas;
        if (_heart != null)
        {
            rotateTransform = _heartFinal.RenderTransform as RotateTransform;
            double angle = (rotateTransform != null) ? rotateTransform.Angle : 0;

            var x = Math.Min(_rightBottom.X, _leftTop.X);
            var y = Math.Min(_rightBottom.Y, _leftTop.Y);

            var w = Math.Max(_rightBottom.X, _leftTop.X) - x;
            var h = Math.Max(_rightBottom.Y, _leftTop.Y) - y;

            _heart.Width = w;
            _heart.Height = h;
            _heart.Stroke = s_mColor;
            _heart.StrokeThickness = s_mThickness;
            _heart.StrokeDashArray = s_Outline;
            _heart.Data = Geometry.Parse("M 40,0 A 20,20 0 0 0 0,40 C 10,50 40,70 40,70 C 40,70 60,60 80,40 A 20,20 0 0 0 40,0 Z");
            _heart.Stretch = Stretch.Fill;
            _heart.Fill = s_Fill;
            _heart.RenderTransformOrigin = new Point(0.5, 0.5);
            _heart.RenderTransform = new RotateTransform(angle);
            _heart.LostFocus += Rectangle_LostFocus;

            Canvas.SetLeft(_heart, x);
            Canvas.SetTop(_heart, y);

            canvas.Children.Add(_heart);
            adnrLayer = AdornerLayer.GetAdornerLayer(canvas);
        }

        _heartFinal.Fill = s_Fill;

        canvas.Children.Add(_heartFinal);
    }

    private void Rectangle_LostFocus(object sender, RoutedEventArgs e)
    {
        if (_heart != null)
        {
            _heartFinal.Width = _heart.Width;
            _heartFinal.Height = _heart.Height;
            _heartFinal.Stroke = _heart.Stroke;
            _heartFinal.StrokeThickness = _heart.StrokeThickness;
            _heartFinal.StrokeDashArray = _heart.StrokeDashArray;
            _heartFinal.Data = _heart.Data;
            _heartFinal.Stretch = _heart.Stretch;
            _heartFinal.Fill = _heart.Fill;
            _heartFinal.RenderTransformOrigin = _heart.RenderTransformOrigin;
            _heartFinal.RenderTransform = _heart.RenderTransform;

            Canvas.SetLeft(_heartFinal, Canvas.GetLeft(_heart));
            Canvas.SetTop(_heartFinal, Canvas.GetTop(_heart));
        }

        _canvas.Children.Remove(_heart);
        _heart = null;
    }

    public IShape Clone()
    {
        return new Heart();
    }

}
