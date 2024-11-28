using System;
using System.Collections.Generic;
using System.Drawing;

namespace LR7
{
    public partial class Form1 : Form
    {
        private readonly FlowerField _flowerField;
        public Form1()
        {
            InitializeComponent();
            _flowerField = new FlowerField();
            flowerPanel.Paint += new PaintEventHandler(flowerPanel_Paint);
        }

        private void flowerPanel_Paint(object sender, PaintEventArgs e)
        {
            _flowerField.DrawFlowers(e.Graphics);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, flowerPanel.Width);
            int y = random.Next(0, flowerPanel.Height);

            string[] rainbowColors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            string randomColor = rainbowColors[random.Next(rainbowColors.Length)];

            _flowerField.AddFlower(randomColor, "Smooth", 30, new Point(x, y));

            flowerPanel.Invalidate();
        }
    }
    public class FlowerColor
    {
        public string Color { get; set; }
        public string Texture { get; set; }

        public FlowerColor(string color, string texture)
        {
            Color = color;
            Texture = texture;
        }
    }

    public class FlowerFactory
    {
        private readonly Dictionary<string, FlowerColor> _flowerColors = new();

        public FlowerColor GetFlowerColor(string color, string texture)
        {
            var key = $"{color}-{texture}";
            if (!_flowerColors.ContainsKey(key))
            {
                _flowerColors[key] = new FlowerColor(color, texture);
            }
            return _flowerColors[key];
        }
    }

    public class Flower
    {
        public FlowerColor FlowerColor { get; set; }
        public int Size { get; set; }
        public Point Position { get; set; }

        public Flower(FlowerColor flowerColor, int size, Point position)
        {
            FlowerColor = flowerColor;
            Size = size;
            Position = position;
        }

        public void Draw(Graphics g)
        {
            var brush = new SolidBrush(Color.FromName(FlowerColor.Color));
            g.FillEllipse(brush, Position.X, Position.Y, Size, Size);
        }
    }

    public class FlowerField
    {
        private readonly List<Flower> _flowers = new();
        private readonly FlowerFactory _flowerFactory = new();

        public void AddFlower(string color, string texture, int size, Point position)
        {
            var flowerColor = _flowerFactory.GetFlowerColor(color, texture);
            var flower = new Flower(flowerColor, size, position);
            _flowers.Add(flower);
        }

        public void DrawFlowers(Graphics g)
        {
            foreach (var flower in _flowers)
            {
                flower.Draw(g);
            }
        }
    }
}
