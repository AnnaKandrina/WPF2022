//----------------------------------------------- 
// ShapeAnEllipse.cs (c) 2006 by Charles Petzold 
//-----------------------------------------------
using System; 
using System.Windows; 
using System.Windows.Controls; 
using System.Windows.Input; 
using System.Windows.Media; 
using System.Windows.Shapes; 
namespace Petzold.ShapeAnEllipse 
{     class ShapeAnEllipse : Window  //класс, производный от Window 
    {         
        [STAThread]  //используется однопоточная модель
        public static void Main()         
        {             
            Application app = new Application();  //создаем объект типа Application
            app.Run(new ShapeAnEllipse());  //вызов метода Run, котрый запускает цикл сообщений
        }         
        public ShapeAnEllipse()         
        {             
            Title = "Shape an Ellipse";  //определение текста заголовка окна
            Ellipse elips = new Ellipse(); //создан элемент Ellipse
            elips.Fill = Brushes.AliceBlue; //внутренная часть эллипса закрашивается бледно-голубым цветом
            elips.StrokeThickness = 24;     //граница имеет ширину 1/4  дюйма
            elips.Stroke =                 
                new LinearGradientBrush(Colors .CadetBlue, Colors.Chocolate, 
                                        new Point (1, 0), new Point(0, 1));      
            Content = elips;       
        }     
    } 
} 