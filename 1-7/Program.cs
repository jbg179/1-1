using System;
class EventApp
{
    public event EventHandler MyEvent; // 2. 이벤트 선언
    void MyEventHandler(object sender, EventArgs e)
    { // 3. 이벤트 처리기 작성
        Console.WriteLine("Hello world");
    }
    public EventApp()
    { // 생성자
        this.MyEvent += new EventHandler(MyEventHandler); // 4. 이벤트 처리기 등록
    }
    public void InvokeEvent()
    {
        if (MyEvent != null)
            MyEvent(this, null); // 5. 이벤트 발생
    }
    public static void Main()
    {
        new EventApp().InvokeEvent();
    }
}