//-------------------------------------------------- 
// VaryTheBackground.cs (c) 2006 by Charles Petzold 
//--------------------------------------------------
using System; 
using System.Windows; 
using System.Windows.Input; 
using System.Windows.Media; 
namespace Petzold.VaryTheBackground 
{     public class VaryTheBackground : Window    // создан класс VaryTheBackground типа Window 
    {         
        SolidColorBrush brush = new  SolidColorBrush(Colors.Black); //изменение цвета кисти после создания объекта
        [STAThread]         
        public static void Main()         
        {             
            Application app = new Application(); // создание приложения
            app.Run(new VaryTheBackground());   // открывает окно приложения      
        }         
        public VaryTheBackground()         
        {             
            Title = "Vary the Background";
            Width = 384; 
            Height = 384;    
            Background = brush;
        }         
        protected override void OnMouseMove (MouseEventArgs args)
        {             
            double width = ActualWidth
                - 2 * SystemParameters .ResizeFrameVerticalBorderWidth;   
            double height = ActualHeight      
                - 2 * SystemParameters .ResizeFrameHorizontalBorderHeight        
                - SystemParameters.CaptionHeight;    
            Point ptMouse = args.GetPosition(this);
            Point ptCenter = new Point(width / 2,  height / 2);
            Vector vectMouse = ptMouse - ptCenter;        
            double angle = Math.Atan2(vectMouse.Y,  vectMouse.X);   
            Vector vectEllipse = new Vector(width  / 2 * Math.Cos(angle),      
                height  / 2 * Math.Sin(angle));    
            Byte byLevel = (byte) (255 * (1 - Math .Min(1, vectMouse.Length /   
                vectEllipse.Length)));       
            Color clr = brush.Color;     
            clr.R = clr.G = clr.B = byLevel;       
            brush.Color = clr;        
        }
    }
}