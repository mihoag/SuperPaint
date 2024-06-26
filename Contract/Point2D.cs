﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;
using MaterialDesignThemes.Wpf;

namespace Contract;
public class Point2D : IShape
{
    public double X
    {
        get; set;
    }
    public double Y
    {
        get; set;
    }

    public string Name => "Point";
    public int IconKind => (int)PackIconKind.ChartLine;
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
    public Adorner currAdnr
    {
        get; set;
    }
    public AdornerLayer adnrLayer
    {
        get; set;
    }

    public void HandleStart(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void HandleEnd(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void HandleMove(double x, double y)
    {
        HandleEnd(x, y);
    }

    public void HandleHoldShift(double x, double y)
    {
    }

    public void Draw(Canvas canvas)
    {
        Line l = new Line()
        {
            X1 = X,
            Y1 = Y,
            X2 = X,
            Y2 = Y,
            StrokeThickness = s_mThickness,
            Stroke = s_mColor,
            StrokeDashArray = s_Outline,
        };

        canvas.Children.Add(l);
    }

    public IShape Clone()
    {
        return new Point2D();
    }

}
