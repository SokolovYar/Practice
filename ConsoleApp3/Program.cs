Button button = new Button("MyButton");
button.Click += MsgBox.Show;
button.Click += PlainMsgBox.Show;
button.MakeClick(button.Name);


public class Button
{
    public Button (string name)
    {
        Name = name;
    }

    public string Name { get; set; }
   public event EventHandler<string> Click;
   
    
    public void MakeClick(string msg)
    {
        Click?.Invoke(this, msg);
    }

}

public static class MsgBox
{
    public static void Show(object sender, string msg)
    {
        Console.WriteLine( "MsgBox " + "called by " + msg);
    }
}


public static class PlainMsgBox
{
    public static void Show(object sender, string msg)
    {
        Console.WriteLine("PlainMsgBox " + "called by " + msg);
    }
}