
using System;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using Contract;
using MaterialDesignThemes.Wpf;
using AdornerLib;

namespace TopArrow
{
    public class TopArrow : IShape
    {
        private Point2D _leftTop = new Point2D();
        private Point2D _rightBottom = new Point2D();
        private PointCollection arrow_point = new PointCollection();

        private Polygon _arrow = null;
        private Polygon _arrowFinal = new Polygon();
        private Canvas _canvas;

        public string Name => "TopArrow";
        public int IconKind => (int)PackIconKind.ArrowBottom;
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
        public Brush s_Fill
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
        public Adorner currAdnr
        {
            get; set;
        }
        public AdornerLayer adnrLayer
        {
            get; set;
        }
        public FontWeight s_FontWeight
        {
            get; set;
        }
        public FontStyle s_FontStyle
        {
            get; set;
        }
        public int s_TextDecoration
        {
            get; set;
        }

        RotateTransform rotateTransform = new RotateTransform();

        public void HandleStart(double x, double y)
        {
            arrow_point.Add(new Point(5, 9));
            arrow_point.Add(new Point(3, 5));
            arrow_point.Add(new Point(4, 5));
            arrow_point.Add(new Point(4, 1));
            arrow_point.Add(new Point(6,1));
            arrow_point.Add(new Point(6, 5));
            arrow_point.Add(new Point(7, 5));
            _leftTop = new Point2D() { X = x, Y = y };
        }

        public void HandleMove(double x, double y)
        {
            _rightBottom = new Point2D() { X = x, Y = y };
            _arrow = new Polygon();
        }

        public void HandleEnd(double x, double y)
        {
            if (_arrow != null)
            {
                _arrow.Focusable = true;
                _arrow.Focus();
                currAdnr = new RectangleAdorner(_arrow);
                adnrLayer.Add(currAdnr);
            }
        }

        public void Draw(Canvas canvas)
        {
            _canvas = canvas;
            var _width = _rightBottom.X - _leftTop.X;
            var _height = _rightBottom.Y - _leftTop.Y;
            if (_arrow != null)
            {
                rotateTransform = _arrowFinal.RenderTransform as RotateTransform;
                double angle = (rotateTransform != null) ? rotateTransform.Angle : 0;

                //_arrow = new Polygon();
                _arrow.Width = Math.Abs(_width);
                _arrow.Height = Math.Abs(_height);
                _arrow.Stroke = s_mColor;
                _arrow.StrokeThickness = s_mThickness;
                _arrow.StrokeDashArray = s_Outline;
                _arrow.Fill = s_Fill;
                _arrow.RenderTransformOrigin = new Point(0.5, 0.5);
                _arrow.RenderTransform = new RotateTransform(angle);
                _arrow.LostFocus += Arrow_LostFocus;
                _arrow.Stretch = Stretch.Fill;
                _arrow.Points = arrow_point;

                SetPosition(_arrow, _width, _height);
                canvas.Children.Add(_arrow);
                adnrLayer = AdornerLayer.GetAdornerLayer(canvas);
            }

            _arrowFinal.Fill = s_Fill;

            canvas.Children.Add(_arrowFinal);
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
            _arrow = new Polygon();
        }

        private void Arrow_LostFocus(object sender, RoutedEventArgs e)
        {
            if (_arrow != null)
            {
                _arrowFinal.Width = _arrow.Width;
                _arrowFinal.Height = _arrow.Height;
                _arrowFinal.Stroke = _arrow.Stroke;
                _arrowFinal.StrokeThickness = _arrow.StrokeThickness;
                _arrowFinal.StrokeDashArray = _arrow.StrokeDashArray;
                _arrowFinal.Fill = _arrow.Fill;
                _arrowFinal.RenderTransformOrigin = _arrow.RenderTransformOrigin;
                _arrowFinal.RenderTransform = _arrow.RenderTransform;
                _arrowFinal.Stretch = Stretch.Fill;
                _arrowFinal.Points = arrow_point;

                Canvas.SetLeft(_arrowFinal, Canvas.GetLeft(_arrow));
                Canvas.SetTop(_arrowFinal, Canvas.GetTop(_arrow));
            }

            _canvas.Children.Remove(_arrow);
            _arrow = null;
        }

        private void SetPosition(UIElement shape, double width, double height)
        {
            if (width > 0 && height > 0)
            {
                Canvas.SetLeft(shape, _leftTop.X);
                Canvas.SetTop(shape, _leftTop.Y);
            }
            else if (width > 0 && height < 0)
            {
                Canvas.SetLeft(shape, _leftTop.X);
                Canvas.SetTop(shape, _rightBottom.Y);
            }
            else if (width < 0 && height > 0)
            {
                Canvas.SetLeft(shape, _rightBottom.X);
                Canvas.SetTop(shape, _leftTop.Y);
            }
            else
            {
                Canvas.SetLeft(shape, _rightBottom.X);
                Canvas.SetTop(shape, _rightBottom.Y);
            }
        }

        public IShape Clone()
        {
            return new TopArrow();
        }
    }
}
