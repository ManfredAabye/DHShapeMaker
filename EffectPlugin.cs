using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using PaintDotNet;
using PaintDotNet.Direct2D1;
using PaintDotNet.Effects;
using PaintDotNet.Imaging;
using PaintDotNet.IndirectUI;
using PaintDotNet.PropertySystem;
using PaintDotNet.Rendering;
using System.Windows.Forms;

namespace ShapeMaker
{
    [PluginSupportInfo<PluginSupportInfo>()]
    public class EffectPlugin : Effect
    {
        public static string StaticName
        {
            get
            {
                return "DH ShapeMaker";
            }
        }

        
        public static Bitmap? StaticImage
        {
            get { return ShapeMaker.Properties.Resources.pdndwarvesicon2; }
        }

        public static string StaticSubMenuName
        {
            get
            {
                return "Advanced"; 
            }
        }

        public EffectPlugin()
            : base(EffectPlugin.StaticName, EffectPlugin.StaticImage, EffectPlugin.StaticSubMenuName, new EffectOptions() { Flags = EffectFlags.Configurable })
        {

        }

        public override EffectConfigDialog CreateConfigDialog()
        {
            return new EffectPluginConfigDialog();
        }
        protected override void OnSetRenderInfo(EffectConfigToken parameters, RenderArgs dstArgs, RenderArgs srcArgs)
        {
            EffectPluginConfigToken token = (EffectPluginConfigToken)parameters;
            PGP = token.GP;
            Draw = token.Draw;
            if (PGP != null) MyRender(dstArgs.Surface, srcArgs.Surface);
            base.OnSetRenderInfo(parameters, dstArgs, srcArgs);
        }

        GraphicsPath[] PGP = new GraphicsPath[0];
        bool Draw = false;

        private void MyRender(Surface dst, Surface src)
        {
            RectInt32 selectionBounds = src.Bounds;
            ColorBgra PrimaryColor = EnvironmentParameters.PrimaryColor;
            ColorBgra SecondaryColor = EnvironmentParameters.SecondaryColor;
            int BrushWidth = (int)EnvironmentParameters.BrushWidth;
            if (PGP.Length > 0 && Draw)
            {
                using (Graphics g = new RenderArgs(dst).Graphics)
                {
                    using (Region reg = new Region(new Rectangle(selectionBounds.X, selectionBounds.Y, selectionBounds.Width, selectionBounds.Height)))
                    {
                        g.SetClip(reg, CombineMode.Replace);
                    }
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    Pen p = new Pen(Color.FromArgb(PrimaryColor.A, PrimaryColor.R, PrimaryColor.G, PrimaryColor.B));
                    p.Width = BrushWidth;
                    for (int i = 0; i < PGP.Length; i++)
                    {
                        if (PGP[i].PointCount > 0)
                        {
                            
                            g.DrawPath(p, PGP[i]);
                        }
                    }
                    p.Dispose();
                }
            }
        }

        public override void Render(EffectConfigToken parameters, RenderArgs dstArgs, RenderArgs srcArgs, Rectangle[] rois, int startIndex, int length)
        {
        }
    }
}