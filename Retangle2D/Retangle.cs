using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Contract;
using MaterialDesignThemes.Wpf;
using System.Numerics;
using PaintWindow;
using System.Xml.Linq;

namespace Retangle2D
{
    public class RectangleShape  : IShape
    {
        private Point2D _start = new Point2D();
        private Point2D _end = new Point2D();

        private Rectangle _rectangle = null;
        private Rectangle _rectangleFinal = new Rectangle();
        private Canvas _canvas;

        public string Name => "Rectangle";
        public int IconKind => (int)PackIconKind.ShapeRectanglePlus;
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
            if (_rectangle != null)
            {
                _rectangle.Focusable = true;
                _rectangle.Focus();
                currAdnr = new RectangleAdorner(_rectangle);
                adnrLayer.Add(currAdnr);
            }
        }

        public void HandleMove(double x, double y)
        {
            _end = new Point2D() { X = x, Y = y };
            _rectangle = new Rectangle();
        }

        public void HandleHoldShift(double x, double y)
        {
            double diff = Math.Abs(_end.X - _start.X) - Math.Abs(_end.Y - _start.Y);
            if (diff > 0)
            {
                _end = new Point2D() { X = x, Y = _start.Y };
                _rectangle = new Rectangle();
            }
            else
            {
                _end = new Point2D() { X = _start.X, Y = y };
                _rectangle = new Rectangle();
            }
        }

        public void Draw(Canvas canvas)
        {
            _canvas = canvas;

            if (_rectangle != null)
            {
                //_line = new Line();
                _rectangle.Width = Math.Abs(_start.X - _end.X);
                _rectangle.Height = Math.Abs(_start.Y -_end.Y) ;
                _rectangle.StrokeThickness = s_mThickness;
                _rectangle.Stroke = s_mColor;
                _rectangle.StrokeDashArray = s_Outline;
                _rectangle.LostFocus += Rectangle_LostFocus;

                Canvas.SetLeft(_rectangle, _start.X);
                Canvas.SetTop(_rectangle,  _start.Y);

                _canvas.Children.Add(_rectangle);
                adnrLayer = AdornerLayer.GetAdornerLayer(canvas);
            }

             canvas.Children.Add(_rectangleFinal);
        }

        private void Rectangle_LostFocus(object sender, RoutedEventArgs e)
        {
            if (_rectangle != null)
            {
                _rectangleFinal.Width = _rectangle.Width;
                _rectangleFinal.Height = _rectangle.Height;
                _rectangleFinal.Stroke = s_mColor;
                _rectangleFinal.StrokeThickness = s_mThickness;
                _rectangleFinal.StrokeDashArray = s_Outline;
                Canvas.SetLeft( _rectangleFinal, _start.X);
                Canvas.SetTop(_rectangleFinal, _start.Y);

               // _canvas.Children.Add(_rectangleFinal);
            }
            _canvas.Children.Remove(_rectangle);
            _rectangle = null;
        }

        public IShape Clone()
        {
            return new RectangleShape();
        }
    }
}
