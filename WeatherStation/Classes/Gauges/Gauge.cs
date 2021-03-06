﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WeatherStation
{
    public abstract class Gauge
    {
        protected string name;//Naam van de gauge
        protected string unit;//Eenheid van de gauge
        protected SolidColorBrush foreGround; //Kleur van de voorgrond van de gauge
        protected SolidColorBrush backGround; //Kleur van de achtergrond
        protected SolidColorBrush gridColor; //Kleur van de grid
        protected SolidColorBrush fontColor; //Kleur van de tekst
        protected int fontSize; //Grootte van de tekst
        protected FontFamily fontFamilyGauge; //Font van de tekst

        //Getters en Setters
        public string Name { get { return name; } }
        public string Unit { get { return unit; } }
        public SolidColorBrush ForeGround { get { return foreGround; } }
        public SolidColorBrush BackGround { get { return backGround; } }
        public SolidColorBrush GridColor { get { return gridColor; } }
        public SolidColorBrush FontColor { get { return fontColor; } }
        public int FontSize { get { return fontSize; } }
        public FontFamily FontFamilyGauge { get { return fontFamilyGauge; } }

        //Constructor
        public Gauge(string name, string unit, SolidColorBrush foreGround, SolidColorBrush backGround, SolidColorBrush gridColor, SolidColorBrush fontColor, int fontSize, FontFamily fontFamily)
        {
            this.name = name;
            this.unit = unit;
            this.foreGround = foreGround;
            this.backGround = backGround;
            this.gridColor = gridColor;
            this.fontColor = fontColor;
            this.fontSize = fontSize;
            this.fontFamilyGauge = fontFamily;
        }

        //Functies die de gauges moeten hebben
        abstract public void Draw();
        abstract public void Update();
    }
}
