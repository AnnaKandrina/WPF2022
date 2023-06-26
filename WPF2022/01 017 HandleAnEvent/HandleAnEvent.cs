//---------------------------------------------- 
// HandleAnEvent.cs (c) 2006 by Charles Petzold
//----------------------------------------------
using System;
using System.Windows;
using System.Windows.Input;
namespace Petzold.HandleAnEvent
{
    class HandleAnEvent
    {
        [STAThread] //используется однопоточная модель
        public static void Main()
        {
            Application app = new Application(); //создаем объект типа Application
            Window win = new Window(); //создаем объект типа Window
            win.Title = "Handle An Event"; //определение текста заголовка окна
            win.MouseDown += WindowOnMouseDown; //инициируется каждый раз, когда пользователь щелкает в клиентской области окна любой кнопкой мыши
            app.Run(win); //вызов метода Run, котрый запускает цикл сообщений
        }
        static void WindowOnMouseDown(object sender, MouseButtonEventArgs args)
        {
            Window win = sender as Window;
            string strMessage =
                string.Format("Window clicked with  {0} button at point ({1})",
                args.ChangedButton, args.GetPosition(win));
            MessageBox.Show(strMessage, win.Title);
        }
    }
}