Button button = new Button();
button.Click += MsgBox.Show;
button.Click += PlainMsgBox.Show;
button.MakeClick("Button1 has been clicked");


public class Button
{

   public string Name { get; set; }
   public event EventHandler<string> Click;
   
    
    public void MakeClick(string msg)
    {
        Click.Invoke(this, msg);
    }

}

public static class MsgBox
{
    public static void Show(object sender, string msg)
    {
        Console.WriteLine( "MsgBox " + "called by " + sender.ToString());
    }
}


public static class PlainMsgBox
{
    public static void Show(object sender, string msg)
    {
        Console.WriteLine("PlainMsgBox " + "called by " + sender.ToString());
    }
}