using System;

interface IWindow
{
    void Close();
}
interface IFileHandler
{
    void Close();
}
class FileViewer : IWindow, IFileHandler
{
    void IWindow.Close() {
        Console.WriteLine("Window Closed");
    }
    void IFileHandler.Close() {
        Console.WriteLine("File Closed");
    }
    public void Test() {
        ((IWindow)this).Close();
    }
}

class InterfaceExplicitImpl
{
	static void Main()
	{
		FileViewer f = new FileViewer();
		f.Test();
		( (IWindow) f ).Close();
		
		IWindow w = new FileViewer();
		w.Close();
	}
}
