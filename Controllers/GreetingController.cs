public class GreetingController {
    public string GetGreeting() {
        int hour = DateTime.Now.Hour;
        return hour < 12 ? "Good Morning" : "Good Afternoon";
    }
    public string GetTime() => DateTime.Now.ToString("T");
}
